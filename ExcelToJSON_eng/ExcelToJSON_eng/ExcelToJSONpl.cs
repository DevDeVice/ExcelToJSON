using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace KsaweryAPP
{
    public partial class ExcelToJSONpl : Form
    {
        private string selectedFile;
        private const string ConfigFilePath = "config.txt";
        public ExcelToJSONpl()
        {
            InitializeComponent();
            var (textFilePath, index, ilosc, cena, wiersz) = ReadFromConfig();
            textFile.Text = textFilePath;
            indexBox.Text = index;
            iloscBox.Text = ilosc;
            cenaBox.Text = cena;
            wierszBox.Text = wiersz;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textFile.Text = openFileDialog.FileName;
                selectedFile = openFileDialog.FileName;
            }
        }

        private void BtnGenerateJSON_Click(object sender, EventArgs e)
        {
            if (!validationCreateJsonFromExcel()) return;
            string excelFilePath = textFile.Text;
            string directory = Path.GetDirectoryName(excelFilePath);
            string jsonOutputPath = Path.Combine(directory, $"{textJSON.Text}.json");

            CreateJsonFromExcel(excelFilePath, jsonOutputPath);
        }

        private void CreateJsonFromExcel(string excelFilePath, string jsonOutputPath)
        {
            using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                const string start = "{\"ZakresWylaczenGrupKontrah\":0,\"SposLaczUmowyZRabat\":0,\"ZakresKontrah\":0,\"SposLaczPromZUmonNaCene\":2,\"Typ\":0,\"ListaWylaczenKontrah\":[],\"ListaGrupKontrah\":[],\"ZakresKarotek\":1,\"ZaleznaOd\":0,\"ListaKartotek\":[";
                const string srodekTemplate = "{{\"CenaBrutto\":0,\"Waluta\":\"\",\"OdIlosci\":{0},\"Procent\":0,\"Cena\":{1},\"Indeks\":\"{2}\"}},";
                const string koniec = "],\"ListaGrupKart\":[],\"DataOd\":\"2023-10-03\",\"DataDo\":\"2023-10-31\",\"OdIlosci\":0,\"ZakresMag\":0,\"ZakresDok\":0,\"ListaMag\":[],\"ListaDok\":[],\"SposLaczPromZUmonNaBonif\":23,\"ZakresWylaczenKontrah\":0,\"ListaKontrah\":[],\"ListaCech\":[],\"ListaWylaczenGrupKontrah\":[],\"Procent\":0,\"ZakresGrupKontrah\":0,\"Uwagi\":\"\",\"Parametr\":1,\"Opis\":\"{0}\",\"ZakresGrupKart\":0,\"UmowaDla\":\"\"}}";
                string opis = textJSON.Text.ToString();
                string stringKoniec = string.Format(koniec, opis);
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                SaveToConfig(textFile.Text, indexBox.Text, iloscBox.Text, cenaBox.Text, wierszBox.Text);

                StringBuilder srodekBuilder = new StringBuilder();

                for (int row = int.Parse(wierszBox.Text); row <= rowCount; row++)
                {
                    string odIlosci = worksheet.Cells[row, int.Parse(iloscBox.Text)].Text;
                    string cena = worksheet.Cells[row, int.Parse(cenaBox.Text)].Text.Replace(",", "."); ;
                    string indeks = worksheet.Cells[row, int.Parse(indexBox.Text)].Text;

                    if (string.IsNullOrEmpty(odIlosci) || string.IsNullOrEmpty(cena) || string.IsNullOrEmpty(indeks)) continue;

                    string srodekRow = string.Format(srodekTemplate, odIlosci, cena, indeks);
                    srodekBuilder.AppendLine(srodekRow);
                }
                string srodek = srodekBuilder.ToString().TrimEnd(',');

                string finalJson = start + Environment.NewLine + srodek + Environment.NewLine + stringKoniec;
                System.IO.File.WriteAllText(jsonOutputPath, finalJson);
                MessageBox.Show("Wyeksportowano pomyślnie!", "Eksport", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveToConfig(string textFilePath, string index, string ilosc, string cena, string wiersz)
        {
            string configData = $"{textFilePath}|{index}|{ilosc}|{cena}|{wiersz}";
            SaveToLine(1, configData);
        }

        private (string textFilePath, string index, string ilosc, string cena, string wiersz) ReadFromConfig()
        {
            string readedLine = ReadFromLine(1);
            var parts = readedLine.Split('|');
            if (parts.Length == 5)
            {
                return (parts[0], parts[1], parts[2], parts[3], parts[4]);
            }
            return (string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }
        private void SaveToLine(int lineNumber, string data)
        {
            List<string> lines = new List<string>();
            if (System.IO.File.Exists(ConfigFilePath))
            {
                lines.AddRange(System.IO.File.ReadAllLines(ConfigFilePath));
            }

            while (lines.Count < lineNumber)
            {
                lines.Add(string.Empty);
            }

            lines[lineNumber - 1] = data;
            System.IO.File.WriteAllLines(ConfigFilePath, lines);
        }

        private string ReadFromLine(int lineNumber)
        {
            if (System.IO.File.Exists(ConfigFilePath))
            {
                var lines = System.IO.File.ReadAllLines(ConfigFilePath);
                if (lineNumber <= lines.Length)
                {
                    return lines[lineNumber - 1];
                }
            }
            return string.Empty;
        }
        private bool validationCreateJsonFromExcel()
        {
            if (string.IsNullOrEmpty(textFile.Text))
            {
                MessageBox.Show("Proszę wybrać plik.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textJSON.Text))
            {
                MessageBox.Show("Proszę wpisać nazwę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Sprawdzanie, czy wierszBox, indexBox, cenaBox i iloscBox są liczbami całkowitymi
            if (!int.TryParse(wierszBox.Text, out _))
            {
                MessageBox.Show("Nieprawidłowa wartość w polu Wiersz. Proszę wpisać liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(indexBox.Text, out _))
            {
                MessageBox.Show("Nieprawidłowa wartość w polu Index. Proszę wpisać liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(cenaBox.Text, out _))
            {
                MessageBox.Show("Nieprawidłowa wartość w polu Cena. Proszę wpisać liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(iloscBox.Text, out _))
            {
                MessageBox.Show("Nieprawidłowa wartość w polu Ilość. Proszę wpisać liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
