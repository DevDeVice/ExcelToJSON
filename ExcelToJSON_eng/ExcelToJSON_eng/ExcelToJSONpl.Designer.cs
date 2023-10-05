namespace KsaweryAPP
{
    partial class ExcelToJSONpl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.wierszBox = new System.Windows.Forms.TextBox();
            this.Cena = new System.Windows.Forms.Label();
            this.Ilość = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.Label();
            this.cenaBox = new System.Windows.Forms.TextBox();
            this.iloscBox = new System.Windows.Forms.TextBox();
            this.indexBox = new System.Windows.Forms.TextBox();
            this.nazwaJSON = new System.Windows.Forms.Label();
            this.textJSON = new System.Windows.Forms.TextBox();
            this.BtnGenerateJSON = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.Label();
            this.textFile = new System.Windows.Forms.TextBox();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Wiersz";
            // 
            // wierszBox
            // 
            this.wierszBox.Location = new System.Drawing.Point(146, 63);
            this.wierszBox.Name = "wierszBox";
            this.wierszBox.Size = new System.Drawing.Size(100, 23);
            this.wierszBox.TabIndex = 26;
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.Location = new System.Drawing.Point(635, 66);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(34, 15);
            this.Cena.TabIndex = 25;
            this.Cena.Text = "Cena";
            // 
            // Ilość
            // 
            this.Ilość.AutoSize = true;
            this.Ilość.Location = new System.Drawing.Point(441, 66);
            this.Ilość.Name = "Ilość";
            this.Ilość.Size = new System.Drawing.Size(53, 15);
            this.Ilość.TabIndex = 24;
            this.Ilość.Text = "Od Ilosci";
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Location = new System.Drawing.Point(266, 66);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(41, 15);
            this.Index.TabIndex = 23;
            this.Index.Text = "Indeks";
            // 
            // cenaBox
            // 
            this.cenaBox.Location = new System.Drawing.Point(675, 63);
            this.cenaBox.Name = "cenaBox";
            this.cenaBox.Size = new System.Drawing.Size(100, 23);
            this.cenaBox.TabIndex = 22;
            // 
            // iloscBox
            // 
            this.iloscBox.Location = new System.Drawing.Point(500, 63);
            this.iloscBox.Name = "iloscBox";
            this.iloscBox.Size = new System.Drawing.Size(100, 23);
            this.iloscBox.TabIndex = 21;
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(313, 63);
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(100, 23);
            this.indexBox.TabIndex = 20;
            // 
            // nazwaJSON
            // 
            this.nazwaJSON.AutoSize = true;
            this.nazwaJSON.Location = new System.Drawing.Point(12, 101);
            this.nazwaJSON.Name = "nazwaJSON";
            this.nazwaJSON.Size = new System.Drawing.Size(73, 15);
            this.nazwaJSON.TabIndex = 19;
            this.nazwaJSON.Text = "Nazwa JSON";
            // 
            // textJSON
            // 
            this.textJSON.Location = new System.Drawing.Point(12, 119);
            this.textJSON.Name = "textJSON";
            this.textJSON.Size = new System.Drawing.Size(100, 23);
            this.textJSON.TabIndex = 18;
            // 
            // BtnGenerateJSON
            // 
            this.BtnGenerateJSON.Location = new System.Drawing.Point(12, 148);
            this.BtnGenerateJSON.Name = "BtnGenerateJSON";
            this.BtnGenerateJSON.Size = new System.Drawing.Size(95, 23);
            this.BtnGenerateJSON.TabIndex = 17;
            this.BtnGenerateJSON.Text = "Generate JSON";
            this.BtnGenerateJSON.UseVisualStyleBackColor = true;
            this.BtnGenerateJSON.Click += new System.EventHandler(this.BtnGenerateJSON_Click);
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Location = new System.Drawing.Point(12, 15);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(25, 15);
            this.File.TabIndex = 16;
            this.File.Text = "File";
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(12, 33);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(763, 23);
            this.textFile.TabIndex = 15;
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(12, 62);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFile.TabIndex = 14;
            this.BtnSelectFile.Text = "Select File";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // ExcelToJSONpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wierszBox);
            this.Controls.Add(this.Cena);
            this.Controls.Add(this.Ilość);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.cenaBox);
            this.Controls.Add(this.iloscBox);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.nazwaJSON);
            this.Controls.Add(this.textJSON);
            this.Controls.Add(this.BtnGenerateJSON);
            this.Controls.Add(this.File);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.BtnSelectFile);
            this.Name = "ExcelToJSONpl";
            this.Text = "ExcelToJSONpl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox wierszBox;
        private Label Cena;
        private Label Ilość;
        private Label Index;
        private TextBox cenaBox;
        private TextBox iloscBox;
        private TextBox indexBox;
        private Label nazwaJSON;
        private TextBox textJSON;
        private Button BtnGenerateJSON;
        private Label File;
        private TextBox textFile;
        private Button BtnSelectFile;
    }
}