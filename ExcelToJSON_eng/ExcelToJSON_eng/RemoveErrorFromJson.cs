using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KsaweryAPP
{
    public partial class RemoveErrorFromJson : Form
    {
        private List<string> foundValues = new List<string>();
        public RemoveErrorFromJson()
        {
            InitializeComponent();
        }

        private void BtnSelectJSON_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textJSON.Text = openFileDialog.FileName;
                //selectedFile = openFileDialog.FileName;
            }
        }

        private void BtnSelectHTML_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textHTML.Text = openFileDialog.FileName;
                string htmlContent = File.ReadAllText(textHTML.Text);

                // Użycie wyrażenia regularnego do znalezienia wszystkich wystąpień wzorca
                string pattern = "\"Line\":\"Nie znaleziono kartoteki o indeksie (\\w+)\"";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(htmlContent);

                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        foundValues.Add(match.Groups[1].Value);
                    }
                }
            }
        }


        private void BtnGenerateJSON_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy pola nie są puste
            if (string.IsNullOrWhiteSpace(textJSON.Text) || string.IsNullOrWhiteSpace(textHTML.Text))
            {
                MessageBox.Show("Proszę wybrać pliki HTML i JSON.");
                return;
            }
            for (int i = 0; i < foundValues.Count; i++)
            {
                foundValues[i] = foundValues[i].Trim(); // Usunięcie znaków białych z początku i końca
                                                        // lub
                                                        // foundValues[i] = foundValues[i].Replace(" ", ""); // Usunięcie wszystkich spacji
                                                        // Możesz użyć Replace z innymi znakami białymi, np. "\t" (tabulator) lub "\n" (znak nowej linii).
            }
            // Odczytanie zawartości pliku JSON
            string jsonContent = File.ReadAllText(textJSON.Text);

            // Usunięcie określonego indeksu z zawartości JSON
            foreach (var value in foundValues)
            {
                string pattern = $@"{{""Indeks"":""{value}""[^}}]+}}";
                jsonContent = Regex.Replace(jsonContent, pattern, "", RegexOptions.Singleline);
            }

            // Usunięcie przecinka, jeśli jest to potrzebne
            jsonContent = jsonContent.TrimEnd(',');

            // Zapisanie zmodyfikowanej zawartości do pliku JSON
            File.WriteAllText(textJSON.Text, jsonContent);

            MessageBox.Show("Zawartość pliku JSON została zaktualizowana.");
        }
    }
}
