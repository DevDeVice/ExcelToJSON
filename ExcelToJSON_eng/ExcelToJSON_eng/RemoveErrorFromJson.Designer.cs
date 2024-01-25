namespace KsaweryAPP
{
    partial class RemoveErrorFromJson
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
            this.labelFile = new System.Windows.Forms.Label();
            this.textJSON = new System.Windows.Forms.TextBox();
            this.BtnSelectJSON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textHTML = new System.Windows.Forms.TextBox();
            this.BtnSelectHTML = new System.Windows.Forms.Button();
            this.BtnGenerateJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(12, 13);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(35, 15);
            this.labelFile.TabIndex = 19;
            this.labelFile.Text = "JSON";
            // 
            // textJSON
            // 
            this.textJSON.Location = new System.Drawing.Point(12, 31);
            this.textJSON.Name = "textJSON";
            this.textJSON.Size = new System.Drawing.Size(763, 23);
            this.textJSON.TabIndex = 18;
            // 
            // BtnSelectJSON
            // 
            this.BtnSelectJSON.Location = new System.Drawing.Point(12, 60);
            this.BtnSelectJSON.Name = "BtnSelectJSON";
            this.BtnSelectJSON.Size = new System.Drawing.Size(112, 23);
            this.BtnSelectJSON.TabIndex = 17;
            this.BtnSelectJSON.Text = "Select JSON";
            this.BtnSelectJSON.UseVisualStyleBackColor = true;
            this.BtnSelectJSON.Click += new System.EventHandler(this.BtnSelectJSON_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "HTML";
            // 
            // textHTML
            // 
            this.textHTML.Location = new System.Drawing.Point(12, 108);
            this.textHTML.Name = "textHTML";
            this.textHTML.Size = new System.Drawing.Size(763, 23);
            this.textHTML.TabIndex = 21;
            // 
            // BtnSelectHTML
            // 
            this.BtnSelectHTML.Location = new System.Drawing.Point(12, 137);
            this.BtnSelectHTML.Name = "BtnSelectHTML";
            this.BtnSelectHTML.Size = new System.Drawing.Size(112, 23);
            this.BtnSelectHTML.TabIndex = 20;
            this.BtnSelectHTML.Text = "Select HTML";
            this.BtnSelectHTML.UseVisualStyleBackColor = true;
            this.BtnSelectHTML.Click += new System.EventHandler(this.BtnSelectHTML_click);
            // 
            // BtnGenerateJSON
            // 
            this.BtnGenerateJSON.Location = new System.Drawing.Point(12, 205);
            this.BtnGenerateJSON.Name = "BtnGenerateJSON";
            this.BtnGenerateJSON.Size = new System.Drawing.Size(112, 23);
            this.BtnGenerateJSON.TabIndex = 23;
            this.BtnGenerateJSON.Text = "Generate JSON";
            this.BtnGenerateJSON.UseVisualStyleBackColor = true;
            this.BtnGenerateJSON.Click += new System.EventHandler(this.BtnGenerateJSON_Click);
            // 
            // RemoveErrorFromJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGenerateJSON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textHTML);
            this.Controls.Add(this.BtnSelectHTML);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.textJSON);
            this.Controls.Add(this.BtnSelectJSON);
            this.Name = "RemoveErrorFromJson";
            this.Text = "RemoveErrorFromJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFile;
        private TextBox textJSON;
        private Button BtnSelectJSON;
        private Label label1;
        private TextBox textHTML;
        private Button BtnSelectHTML;
        private Button BtnGenerateJSON;
    }
}