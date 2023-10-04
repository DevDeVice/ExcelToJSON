namespace ExcelToJSON_eng
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            this.textFile = new System.Windows.Forms.TextBox();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cenaBox2 = new System.Windows.Forms.TextBox();
            this.iloscBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cenaBox3 = new System.Windows.Forms.TextBox();
            this.iloscBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Wiersz";
            // 
            // wierszBox
            // 
            this.wierszBox.Location = new System.Drawing.Point(146, 62);
            this.wierszBox.Name = "wierszBox";
            this.wierszBox.Size = new System.Drawing.Size(100, 23);
            this.wierszBox.TabIndex = 25;
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.Location = new System.Drawing.Point(635, 65);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(34, 15);
            this.Cena.TabIndex = 24;
            this.Cena.Text = "Cena";
            // 
            // Ilość
            // 
            this.Ilość.AutoSize = true;
            this.Ilość.Location = new System.Drawing.Point(441, 65);
            this.Ilość.Name = "Ilość";
            this.Ilość.Size = new System.Drawing.Size(53, 15);
            this.Ilość.TabIndex = 23;
            this.Ilość.Text = "Od Ilosci";
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Location = new System.Drawing.Point(266, 65);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(41, 15);
            this.Index.TabIndex = 22;
            this.Index.Text = "Indeks";
            // 
            // cenaBox
            // 
            this.cenaBox.Location = new System.Drawing.Point(675, 62);
            this.cenaBox.Name = "cenaBox";
            this.cenaBox.Size = new System.Drawing.Size(100, 23);
            this.cenaBox.TabIndex = 21;
            // 
            // iloscBox
            // 
            this.iloscBox.Location = new System.Drawing.Point(500, 62);
            this.iloscBox.Name = "iloscBox";
            this.iloscBox.Size = new System.Drawing.Size(100, 23);
            this.iloscBox.TabIndex = 20;
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(313, 62);
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(100, 23);
            this.indexBox.TabIndex = 19;
            // 
            // nazwaJSON
            // 
            this.nazwaJSON.AutoSize = true;
            this.nazwaJSON.Location = new System.Drawing.Point(12, 100);
            this.nazwaJSON.Name = "nazwaJSON";
            this.nazwaJSON.Size = new System.Drawing.Size(73, 15);
            this.nazwaJSON.TabIndex = 18;
            this.nazwaJSON.Text = "Nazwa JSON";
            // 
            // textJSON
            // 
            this.textJSON.Location = new System.Drawing.Point(12, 118);
            this.textJSON.Name = "textJSON";
            this.textJSON.Size = new System.Drawing.Size(100, 23);
            this.textJSON.TabIndex = 17;
            // 
            // BtnGenerateJSON
            // 
            this.BtnGenerateJSON.Location = new System.Drawing.Point(12, 147);
            this.BtnGenerateJSON.Name = "BtnGenerateJSON";
            this.BtnGenerateJSON.Size = new System.Drawing.Size(95, 23);
            this.BtnGenerateJSON.TabIndex = 16;
            this.BtnGenerateJSON.Text = "Generate JSON";
            this.BtnGenerateJSON.UseVisualStyleBackColor = true;
            this.BtnGenerateJSON.Click += new System.EventHandler(this.BtnGenerateJSON_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(12, 32);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(763, 23);
            this.textFile.TabIndex = 15;
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(12, 61);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFile.TabIndex = 14;
            this.BtnSelectFile.Text = "Select File";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Location = new System.Drawing.Point(12, 14);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(25, 15);
            this.File.TabIndex = 27;
            this.File.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Od Ilosci";
            // 
            // cenaBox2
            // 
            this.cenaBox2.Location = new System.Drawing.Point(675, 118);
            this.cenaBox2.Name = "cenaBox2";
            this.cenaBox2.Size = new System.Drawing.Size(100, 23);
            this.cenaBox2.TabIndex = 30;
            // 
            // iloscBox2
            // 
            this.iloscBox2.Location = new System.Drawing.Point(500, 118);
            this.iloscBox2.Name = "iloscBox2";
            this.iloscBox2.Size = new System.Drawing.Size(100, 23);
            this.iloscBox2.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Od Ilosci";
            // 
            // cenaBox3
            // 
            this.cenaBox3.Location = new System.Drawing.Point(675, 174);
            this.cenaBox3.Name = "cenaBox3";
            this.cenaBox3.Size = new System.Drawing.Size(100, 23);
            this.cenaBox3.TabIndex = 36;
            // 
            // iloscBox3
            // 
            this.iloscBox3.Location = new System.Drawing.Point(500, 174);
            this.iloscBox3.Name = "iloscBox3";
            this.iloscBox3.Size = new System.Drawing.Size(100, 23);
            this.iloscBox3.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cenaBox3);
            this.Controls.Add(this.iloscBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cenaBox2);
            this.Controls.Add(this.iloscBox2);
            this.Controls.Add(this.File);
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
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.BtnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private TextBox textFile;
        private Button BtnSelectFile;
        private Label File;
        private Label label2;
        private Label label3;
        private TextBox cenaBox2;
        private TextBox iloscBox2;
        private Label label5;
        private Label label6;
        private TextBox cenaBox3;
        private TextBox iloscBox3;
    }
}