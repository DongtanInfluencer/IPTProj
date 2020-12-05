namespace IPTP
{
    partial class BlurNSharpeningForm
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
            this.btn_averageBlur = new System.Windows.Forms.Button();
            this.TrB_value = new System.Windows.Forms.TrackBar();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.btn_GaussianBlur = new System.Windows.Forms.Button();
            this.btn_medianBlur = new System.Windows.Forms.Button();
            this.btn_Sharpening = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrB_value)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_averageBlur
            // 
            this.btn_averageBlur.Location = new System.Drawing.Point(12, 12);
            this.btn_averageBlur.Name = "btn_averageBlur";
            this.btn_averageBlur.Size = new System.Drawing.Size(135, 44);
            this.btn_averageBlur.TabIndex = 0;
            this.btn_averageBlur.Text = "평균값 필터링";
            this.btn_averageBlur.UseVisualStyleBackColor = true;
            this.btn_averageBlur.Click += new System.EventHandler(this.btn_averageBlur_Click);
            // 
            // TrB_value
            // 
            this.TrB_value.Location = new System.Drawing.Point(153, 12);
            this.TrB_value.Maximum = 25;
            this.TrB_value.Minimum = 1;
            this.TrB_value.Name = "TrB_value";
            this.TrB_value.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrB_value.Size = new System.Drawing.Size(45, 360);
            this.TrB_value.SmallChange = 2;
            this.TrB_value.TabIndex = 2;
            this.TrB_value.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrB_value.Value = 1;
            this.TrB_value.Scroll += new System.EventHandler(this.TrB_value_Scroll);
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(153, 378);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(45, 21);
            this.tb_value.TabIndex = 1;
            this.tb_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_GaussianBlur
            // 
            this.btn_GaussianBlur.Location = new System.Drawing.Point(12, 62);
            this.btn_GaussianBlur.Name = "btn_GaussianBlur";
            this.btn_GaussianBlur.Size = new System.Drawing.Size(135, 44);
            this.btn_GaussianBlur.TabIndex = 4;
            this.btn_GaussianBlur.Text = "가우시안 필터링";
            this.btn_GaussianBlur.UseVisualStyleBackColor = true;
            this.btn_GaussianBlur.Click += new System.EventHandler(this.btn_GaussianBlur_Click);
            // 
            // btn_medianBlur
            // 
            this.btn_medianBlur.Location = new System.Drawing.Point(12, 112);
            this.btn_medianBlur.Name = "btn_medianBlur";
            this.btn_medianBlur.Size = new System.Drawing.Size(135, 44);
            this.btn_medianBlur.TabIndex = 5;
            this.btn_medianBlur.Text = "중간값 필터링";
            this.btn_medianBlur.UseVisualStyleBackColor = true;
            this.btn_medianBlur.Click += new System.EventHandler(this.btn_medianBlur_Click);
            // 
            // btn_Sharpening
            // 
            this.btn_Sharpening.Location = new System.Drawing.Point(12, 162);
            this.btn_Sharpening.Name = "btn_Sharpening";
            this.btn_Sharpening.Size = new System.Drawing.Size(135, 44);
            this.btn_Sharpening.TabIndex = 6;
            this.btn_Sharpening.Text = "샤프닝";
            this.btn_Sharpening.UseVisualStyleBackColor = true;
            this.btn_Sharpening.Click += new System.EventHandler(this.btn_Sharpening_Click);
            // 
            // BlurNSharpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 411);
            this.Controls.Add(this.btn_Sharpening);
            this.Controls.Add(this.btn_medianBlur);
            this.Controls.Add(this.btn_GaussianBlur);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.TrB_value);
            this.Controls.Add(this.btn_averageBlur);
            this.Name = "BlurNSharpeningForm";
            this.Text = "BlurNSharpeningForm";
            ((System.ComponentModel.ISupportInitialize)(this.TrB_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_averageBlur;
        private System.Windows.Forms.TrackBar TrB_value;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Button btn_GaussianBlur;
        private System.Windows.Forms.Button btn_medianBlur;
        private System.Windows.Forms.Button btn_Sharpening;
    }
}