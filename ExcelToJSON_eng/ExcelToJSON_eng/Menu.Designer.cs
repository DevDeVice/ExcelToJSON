﻿namespace KsaweryAPP
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
            this.SuspendLayout();
            // 
            // openExcelToJSONeng
            // 
            this.openExcelToJSONeng.Location = new System.Drawing.Point(197, 57);
            this.openExcelToJSONeng.Name = "openExcelToJSONeng";
            this.openExcelToJSONeng.Size = new System.Drawing.Size(118, 43);
            this.openExcelToJSONeng.TabIndex = 0;
            this.openExcelToJSONeng.Text = "ExcelToJSONeng";
            this.openExcelToJSONeng.UseVisualStyleBackColor = true;
            this.openExcelToJSONeng.Click += new System.EventHandler(this.openExcelToJSONeng_Click);
            // 
            // openExcelToJSONpl
            // 
            this.openExcelToJSONpl.Location = new System.Drawing.Point(35, 57);
            this.openExcelToJSONpl.Name = "openExcelToJSONpl";
            this.openExcelToJSONpl.Size = new System.Drawing.Size(118, 43);
            this.openExcelToJSONpl.TabIndex = 1;
            this.openExcelToJSONpl.Text = "ExcelToJSONpl";
            this.openExcelToJSONpl.UseVisualStyleBackColor = true;
            this.openExcelToJSONpl.Click += new System.EventHandler(this.openExcelToJSONpl_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openExcelToJSONpl);
            this.Controls.Add(this.openExcelToJSONeng);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button openExcelToJSONeng;
        private Button openExcelToJSONpl;
    }
}