namespace KsaweryAPP
{
    partial class Menu
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
            this.openExcelToJSONeng = new System.Windows.Forms.Button();
            this.openExcelToJSONpl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openExcelToJSONeng
            // 
            this.openExcelToJSONeng.Location = new System.Drawing.Point(200, 50);
            this.openExcelToJSONeng.Name = "openExcelToJSONeng";
            this.openExcelToJSONeng.Size = new System.Drawing.Size(118, 43);
            this.openExcelToJSONeng.TabIndex = 0;
            this.openExcelToJSONeng.Text = "Ilość";
            this.openExcelToJSONeng.UseVisualStyleBackColor = true;
            this.openExcelToJSONeng.Click += new System.EventHandler(this.openExcelToJSONeng_Click);
            // 
            // openExcelToJSONpl
            // 
            this.openExcelToJSONpl.Location = new System.Drawing.Point(35, 50);
            this.openExcelToJSONpl.Name = "openExcelToJSONpl";
            this.openExcelToJSONpl.Size = new System.Drawing.Size(118, 43);
            this.openExcelToJSONpl.TabIndex = 1;
            this.openExcelToJSONpl.Text = "Promocje";
            this.openExcelToJSONpl.UseVisualStyleBackColor = true;
            this.openExcelToJSONpl.Click += new System.EventHandler(this.openExcelToJSONpl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Errory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.removeErrorFromJson_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openExcelToJSONpl);
            this.Controls.Add(this.openExcelToJSONeng);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button openExcelToJSONeng;
        private Button openExcelToJSONpl;
        private Button button1;
    }
}