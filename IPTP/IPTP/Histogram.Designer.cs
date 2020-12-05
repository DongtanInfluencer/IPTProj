namespace IPTP
{
    partial class Histogram
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histogram_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histogram_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Histogram_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Histogram_Red
            // 
            this.pb_Histogram_Red.BackColor = System.Drawing.Color.White;
            this.pb_Histogram_Red.Location = new System.Drawing.Point(21, 29);
            this.pb_Histogram_Red.Name = "pb_Histogram_Red";
            this.pb_Histogram_Red.Size = new System.Drawing.Size(150, 150);
            this.pb_Histogram_Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Histogram_Red.TabIndex = 1;
            this.pb_Histogram_Red.TabStop = false;
            // 
            // pb_Histogram_Green
            // 
            this.pb_Histogram_Green.BackColor = System.Drawing.Color.White;
            this.pb_Histogram_Green.Location = new System.Drawing.Point(221, 29);
            this.pb_Histogram_Green.Name = "pb_Histogram_Green";
            this.pb_Histogram_Green.Size = new System.Drawing.Size(150, 150);
            this.pb_Histogram_Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Histogram_Green.TabIndex = 2;
            this.pb_Histogram_Green.TabStop = false;
            this.pb_Histogram_Green.Click += new System.EventHandler(this.pb_Histogram_Green_Click);
            // 
            // pb_Histogram_Blue
            // 
            this.pb_Histogram_Blue.BackColor = System.Drawing.Color.White;
            this.pb_Histogram_Blue.Location = new System.Drawing.Point(416, 29);
            this.pb_Histogram_Blue.Name = "pb_Histogram_Blue";
            this.pb_Histogram_Blue.Size = new System.Drawing.Size(150, 150);
            this.pb_Histogram_Blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Histogram_Blue.TabIndex = 3;
            this.pb_Histogram_Blue.TabStop = false;
            // 
            // Btn_HistogramEqual
            // 
            this.Btn_HistogramEqual.Location = new System.Drawing.Point(21, 205);
            this.Btn_HistogramEqual.Name = "Btn_HistogramEqual";
            this.Btn_HistogramEqual.Size = new System.Drawing.Size(150, 33);
            this.Btn_HistogramEqual.TabIndex = 5;
            this.Btn_HistogramEqual.Text = "히스토그램 평탄화";
            this.Btn_HistogramEqual.UseVisualStyleBackColor = true;
            this.Btn_HistogramEqual.Click += new System.EventHandler(this.Btn_HistogramEqual_Click);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 249);
            this.Controls.Add(this.Btn_HistogramEqual);
            this.Controls.Add(this.pb_Histogram_Blue);
            this.Controls.Add(this.pb_Histogram_Green);
            this.Controls.Add(this.pb_Histogram_Red);
            this.Name = "Histogram";
            this.Text = "Histogram";
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
    }
}