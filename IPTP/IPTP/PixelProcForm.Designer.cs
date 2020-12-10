namespace IPTP
{
    partial class PixelProcForm
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
            this.tr_contrast = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tr_bright = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tr_gamma = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_bright = new System.Windows.Forms.TextBox();
            this.tb_contrast = new System.Windows.Forms.TextBox();
            this.tb_gamma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tr_contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_bright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_gamma)).BeginInit();
            this.SuspendLayout();
            // 
            // tr_contrast
            // 
            this.tr_contrast.Location = new System.Drawing.Point(219, 118);
            this.tr_contrast.Margin = new System.Windows.Forms.Padding(4);
            this.tr_contrast.Maximum = 200;
            this.tr_contrast.Name = "tr_contrast";
            this.tr_contrast.Size = new System.Drawing.Size(936, 90);
            this.tr_contrast.TabIndex = 0;
            this.tr_contrast.Value = 100;
            this.tr_contrast.Scroll += new System.EventHandler(this.tr_contrast_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "대비";
            // 
            // tr_bright
            // 
            this.tr_bright.Location = new System.Drawing.Point(219, 22);
            this.tr_bright.Margin = new System.Windows.Forms.Padding(4);
            this.tr_bright.Maximum = 510;
            this.tr_bright.Name = "tr_bright";
            this.tr_bright.Size = new System.Drawing.Size(936, 90);
            this.tr_bright.TabIndex = 0;
            this.tr_bright.Value = 255;
            this.tr_bright.Scroll += new System.EventHandler(this.tr_bright_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "밝기";
            // 
            // tr_gamma
            // 
            this.tr_gamma.Location = new System.Drawing.Point(219, 214);
            this.tr_gamma.Margin = new System.Windows.Forms.Padding(4);
            this.tr_gamma.Maximum = 200;
            this.tr_gamma.Name = "tr_gamma";
            this.tr_gamma.Size = new System.Drawing.Size(936, 90);
            this.tr_gamma.TabIndex = 0;
            this.tr_gamma.Value = 100;
            this.tr_gamma.Scroll += new System.EventHandler(this.tr_gamma_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "감마";
            // 
            // tb_bright
            // 
            this.tb_bright.Location = new System.Drawing.Point(108, 32);
            this.tb_bright.Margin = new System.Windows.Forms.Padding(4);
            this.tb_bright.Name = "tb_bright";
            this.tb_bright.ReadOnly = true;
            this.tb_bright.Size = new System.Drawing.Size(101, 35);
            this.tb_bright.TabIndex = 2;
            this.tb_bright.Text = "0";
            this.tb_bright.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_bright.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigit);
            // 
            // tb_contrast
            // 
            this.tb_contrast.Location = new System.Drawing.Point(108, 128);
            this.tb_contrast.Margin = new System.Windows.Forms.Padding(4);
            this.tb_contrast.Name = "tb_contrast";
            this.tb_contrast.ReadOnly = true;
            this.tb_contrast.Size = new System.Drawing.Size(101, 35);
            this.tb_contrast.TabIndex = 2;
            this.tb_contrast.Text = "0";
            this.tb_contrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_contrast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigit);
            // 
            // tb_gamma
            // 
            this.tb_gamma.Location = new System.Drawing.Point(108, 226);
            this.tb_gamma.Margin = new System.Windows.Forms.Padding(4);
            this.tb_gamma.Name = "tb_gamma";
            this.tb_gamma.ReadOnly = true;
            this.tb_gamma.Size = new System.Drawing.Size(101, 35);
            this.tb_gamma.TabIndex = 2;
            this.tb_gamma.Text = "0";
            this.tb_gamma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_gamma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigit);
            // 
            // PixelProcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 330);
            this.Controls.Add(this.tb_gamma);
            this.Controls.Add(this.tb_contrast);
            this.Controls.Add(this.tb_bright);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tr_gamma);
            this.Controls.Add(this.tr_bright);
            this.Controls.Add(this.tr_contrast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PixelProcForm";
            this.ShowIcon = false;
            this.Text = "밝기 / 대비 / 감마 조절";
            ((System.ComponentModel.ISupportInitialize)(this.tr_contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_bright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_gamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tr_contrast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tr_bright;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tr_gamma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_bright;
        private System.Windows.Forms.TextBox tb_contrast;
        private System.Windows.Forms.TextBox tb_gamma;
    }
}