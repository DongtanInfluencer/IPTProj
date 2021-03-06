﻿namespace IPTP
{
    partial class HistogramForm
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
            this.pb_Histogram_Red = new System.Windows.Forms.PictureBox();
            this.pb_Histogram_Green = new System.Windows.Forms.PictureBox();
            this.pb_Histogram_Blue = new System.Windows.Forms.PictureBox();
            this.Btn_HistogramEqual = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_HistogramBinary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histogram_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histogram_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histogram_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Histogram_Red
            // 
            this.pb_Histogram_Red.BackColor = System.Drawing.Color.White;
            this.pb_Histogram_Red.Location = new System.Drawing.Point(39, 58);
            this.pb_Histogram_Red.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pb_Histogram_Red.Name = "pb_Histogram_Red";
            this.pb_Histogram_Red.Size = new System.Drawing.Size(279, 300);
            this.pb_Histogram_Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Histogram_Red.TabIndex = 1;
            this.pb_Histogram_Red.TabStop = false;
            // 
            // pb_Histogram_Green
            // 
            this.pb_Histogram_Green.BackColor = System.Drawing.Color.White;
            this.pb_Histogram_Green.Location = new System.Drawing.Point(410, 58);
            this.pb_Histogram_Green.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pb_Histogram_Green.Name = "pb_Histogram_Green";
            this.pb_Histogram_Green.Size = new System.Drawing.Size(279, 300);
            this.pb_Histogram_Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Histogram_Green.TabIndex = 2;
            this.pb_Histogram_Green.TabStop = false;
            // 
            // pb_Histogram_Blue
            // 
            this.pb_Histogram_Blue.BackColor = System.Drawing.Color.White;
            this.pb_Histogram_Blue.Location = new System.Drawing.Point(773, 58);
            this.pb_Histogram_Blue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pb_Histogram_Blue.Name = "pb_Histogram_Blue";
            this.pb_Histogram_Blue.Size = new System.Drawing.Size(279, 300);
            this.pb_Histogram_Blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Histogram_Blue.TabIndex = 3;
            this.pb_Histogram_Blue.TabStop = false;
            // 
            // Btn_HistogramEqual
            // 
            this.Btn_HistogramEqual.Location = new System.Drawing.Point(39, 410);
            this.Btn_HistogramEqual.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Btn_HistogramEqual.Name = "Btn_HistogramEqual";
            this.Btn_HistogramEqual.Size = new System.Drawing.Size(279, 66);
            this.Btn_HistogramEqual.TabIndex = 5;
            this.Btn_HistogramEqual.Text = "히스토그램 평탄화";
            this.Btn_HistogramEqual.UseVisualStyleBackColor = true;
            this.Btn_HistogramEqual.Click += new System.EventHandler(this.Btn_HistogramEqual_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(773, 410);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(279, 66);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "되돌리기";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_HistogramBinary
            // 
            this.btn_HistogramBinary.Location = new System.Drawing.Point(410, 410);
            this.btn_HistogramBinary.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_HistogramBinary.Name = "btn_HistogramBinary";
            this.btn_HistogramBinary.Size = new System.Drawing.Size(279, 66);
            this.btn_HistogramBinary.TabIndex = 7;
            this.btn_HistogramBinary.Text = "히스토그램 이진화";
            this.btn_HistogramBinary.UseVisualStyleBackColor = true;
            this.btn_HistogramBinary.Click += new System.EventHandler(this.btn_HistogramBinary_Click);
            // 
            // HistogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 498);
            this.Controls.Add(this.btn_HistogramBinary);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.Btn_HistogramEqual);
            this.Controls.Add(this.pb_Histogram_Blue);
            this.Controls.Add(this.pb_Histogram_Green);
            this.Controls.Add(this.pb_Histogram_Red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistogramForm";
            this.ShowIcon = false;
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.Histogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histogram_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histogram_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histogram_Blue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_Histogram_Red;
        private System.Windows.Forms.PictureBox pb_Histogram_Green;
        private System.Windows.Forms.PictureBox pb_Histogram_Blue;
        private System.Windows.Forms.Button Btn_HistogramEqual;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_HistogramBinary;
    }
}