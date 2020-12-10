namespace IPTP
{
    partial class SegmentationForm
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.Btn_BiInv = new System.Windows.Forms.Button();
            this.Btn_Binary = new System.Windows.Forms.Button();
            this.Btn_AdaptiveGau = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Btn_AdaptiveMean = new System.Windows.Forms.Button();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.TrB_value = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrB_value)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(22, 421);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(150, 33);
            this.btn_Reset.TabIndex = 42;
            this.btn_Reset.Text = "되돌리기";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Btn_BiInv
            // 
            this.Btn_BiInv.Location = new System.Drawing.Point(22, 218);
            this.Btn_BiInv.Name = "Btn_BiInv";
            this.Btn_BiInv.Size = new System.Drawing.Size(79, 33);
            this.Btn_BiInv.TabIndex = 36;
            this.Btn_BiInv.Text = "반전";
            this.Btn_BiInv.UseVisualStyleBackColor = true;
            this.Btn_BiInv.Click += new System.EventHandler(this.Btn_BiInv_Click);
            // 
            // Btn_Binary
            // 
            this.Btn_Binary.Location = new System.Drawing.Point(22, 179);
            this.Btn_Binary.Name = "Btn_Binary";
            this.Btn_Binary.Size = new System.Drawing.Size(79, 33);
            this.Btn_Binary.TabIndex = 34;
            this.Btn_Binary.Text = "기본";
            this.Btn_Binary.UseVisualStyleBackColor = true;
            this.Btn_Binary.Click += new System.EventHandler(this.Btn_Binary_Click);
            // 
            // Btn_AdaptiveGau
            // 
            this.Btn_AdaptiveGau.Location = new System.Drawing.Point(22, 78);
            this.Btn_AdaptiveGau.Name = "Btn_AdaptiveGau";
            this.Btn_AdaptiveGau.Size = new System.Drawing.Size(79, 33);
            this.Btn_AdaptiveGau.TabIndex = 32;
            this.Btn_AdaptiveGau.Text = "가우시안";
            this.Btn_AdaptiveGau.UseVisualStyleBackColor = true;
            this.Btn_AdaptiveGau.Click += new System.EventHandler(this.Btn_AdaptiveGau_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox7.Location = new System.Drawing.Point(12, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 30;
            this.textBox7.Text = "적응형 이진화";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_AdaptiveMean
            // 
            this.Btn_AdaptiveMean.Location = new System.Drawing.Point(22, 39);
            this.Btn_AdaptiveMean.Name = "Btn_AdaptiveMean";
            this.Btn_AdaptiveMean.Size = new System.Drawing.Size(79, 33);
            this.Btn_AdaptiveMean.TabIndex = 29;
            this.Btn_AdaptiveMean.Text = "평균";
            this.Btn_AdaptiveMean.UseVisualStyleBackColor = true;
            this.Btn_AdaptiveMean.Click += new System.EventHandler(this.Btn_AdaptiveMean_Click);
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(130, 378);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(45, 21);
            this.tb_value.TabIndex = 43;
            this.tb_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrB_value
            // 
            this.TrB_value.Location = new System.Drawing.Point(130, 12);
            this.TrB_value.Maximum = 25;
            this.TrB_value.Minimum = 1;
            this.TrB_value.Name = "TrB_value";
            this.TrB_value.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrB_value.Size = new System.Drawing.Size(45, 360);
            this.TrB_value.SmallChange = 2;
            this.TrB_value.TabIndex = 44;
            this.TrB_value.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrB_value.Value = 1;
            this.TrB_value.Scroll += new System.EventHandler(this.TrB_value_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Location = new System.Drawing.Point(12, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "이진화 방식";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SegmentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(184, 466);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.TrB_value);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.Btn_BiInv);
            this.Controls.Add(this.Btn_Binary);
            this.Controls.Add(this.Btn_AdaptiveGau);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Btn_AdaptiveMean);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SegmentationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "영상 분할";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SegmentationForm_FormClosing);
            this.Load += new System.EventHandler(this.SegmentationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrB_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button Btn_BiInv;
        private System.Windows.Forms.Button Btn_Binary;
        private System.Windows.Forms.Button Btn_AdaptiveGau;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Btn_AdaptiveMean;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.TrackBar TrB_value;
        private System.Windows.Forms.TextBox textBox1;
    }
}