﻿
namespace WindowsFormAsyncHandson
{
    partial class Form1
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
            this.btnProcessFile = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcessFile
            // 
            this.btnProcessFile.Location = new System.Drawing.Point(306, 138);
            this.btnProcessFile.Name = "btnProcessFile";
            this.btnProcessFile.Size = new System.Drawing.Size(265, 60);
            this.btnProcessFile.TabIndex = 0;
            this.btnProcessFile.Text = "Procees File";
            this.btnProcessFile.UseVisualStyleBackColor = true;
            this.btnProcessFile.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(303, 246);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 17);
            this.lblCount.TabIndex = 1;
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnProcessFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessFile;
        private System.Windows.Forms.Label lblCount;
    }
}

