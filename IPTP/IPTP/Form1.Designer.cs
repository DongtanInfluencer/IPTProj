﻿namespace IPTP
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_src = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.pb_dst = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_pixelProc = new System.Windows.Forms.Button();
            this.but_Histogram = new System.Windows.Forms.Button();
            this.btn_blurNsharpe = new System.Windows.Forms.Button();
            this.btn_transform = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_Segmentation = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dst)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_src
            // 
            this.pb_src.BackColor = System.Drawing.Color.White;
            this.pb_src.Location = new System.Drawing.Point(38, 50);
            this.pb_src.Margin = new System.Windows.Forms.Padding(2);
            this.pb_src.Name = "pb_src";
            this.pb_src.Size = new System.Drawing.Size(276, 256);
            this.pb_src.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_src.TabIndex = 0;
            this.pb_src.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(38, 317);
            this.btn_open.Margin = new System.Windows.Forms.Padding(2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(276, 39);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "불러오기";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.open_Click);
            // 
            // pb_dst
            // 
            this.pb_dst.BackColor = System.Drawing.Color.White;
            this.pb_dst.Location = new System.Drawing.Point(361, 50);
            this.pb_dst.Margin = new System.Windows.Forms.Padding(2);
            this.pb_dst.Name = "pb_dst";
            this.pb_dst.Size = new System.Drawing.Size(276, 256);
            this.pb_dst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dst.TabIndex = 0;
            this.pb_dst.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(361, 317);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(276, 39);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "저장하기";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "원본 이미지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "처리된 이미지";
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(317, 150);
            this.btn_convert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(41, 22);
            this.btn_convert.TabIndex = 3;
            this.btn_convert.Text = "←";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_pixelProc
            // 
            this.btn_pixelProc.Location = new System.Drawing.Point(650, 50);
            this.btn_pixelProc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pixelProc.Name = "btn_pixelProc";
            this.btn_pixelProc.Size = new System.Drawing.Size(130, 29);
            this.btn_pixelProc.TabIndex = 4;
            this.btn_pixelProc.Text = "밝기/대비/감마";
            this.btn_pixelProc.UseVisualStyleBackColor = true;
            this.btn_pixelProc.Click += new System.EventHandler(this.btn_pixelProc_Click);
            // 
            // but_Histogram
            // 
            this.but_Histogram.Location = new System.Drawing.Point(650, 83);
            this.but_Histogram.Margin = new System.Windows.Forms.Padding(2);
            this.but_Histogram.Name = "but_Histogram";
            this.but_Histogram.Size = new System.Drawing.Size(130, 29);
            this.but_Histogram.TabIndex = 5;
            this.but_Histogram.Text = "히스토그램";
            this.but_Histogram.UseVisualStyleBackColor = true;
            this.but_Histogram.Click += new System.EventHandler(this.but_Histogram_Click);
            // 
            // btn_blurNsharpe
            // 
            this.btn_blurNsharpe.Location = new System.Drawing.Point(650, 116);
            this.btn_blurNsharpe.Margin = new System.Windows.Forms.Padding(2);
            this.btn_blurNsharpe.Name = "btn_blurNsharpe";
            this.btn_blurNsharpe.Size = new System.Drawing.Size(130, 29);
            this.btn_blurNsharpe.TabIndex = 6;
            this.btn_blurNsharpe.Text = "블러링/샤프닝";
            this.btn_blurNsharpe.UseVisualStyleBackColor = true;
            this.btn_blurNsharpe.Click += new System.EventHandler(this.btn_blurNsharpe_Click);
            // 
            // btn_transform
            // 
            this.btn_transform.Location = new System.Drawing.Point(650, 149);
            this.btn_transform.Margin = new System.Windows.Forms.Padding(2);
            this.btn_transform.Name = "btn_transform";
            this.btn_transform.Size = new System.Drawing.Size(130, 29);
            this.btn_transform.TabIndex = 7;
            this.btn_transform.Text = "기하학적 변환";
            this.btn_transform.UseVisualStyleBackColor = true;
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(650, 182);
            this.btn_color.Margin = new System.Windows.Forms.Padding(2);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(130, 29);
            this.btn_color.TabIndex = 8;
            this.btn_color.Text = "컬러영상 처리";
            this.btn_color.UseVisualStyleBackColor = true;
            // 
            // btn_Segmentation
            // 
            this.btn_Segmentation.Location = new System.Drawing.Point(650, 215);
            this.btn_Segmentation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Segmentation.Name = "btn_Segmentation";
            this.btn_Segmentation.Size = new System.Drawing.Size(130, 29);
            this.btn_Segmentation.TabIndex = 9;
            this.btn_Segmentation.Text = "영상 분할";
            this.btn_Segmentation.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(650, 327);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(130, 29);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "되돌리기";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 391);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Segmentation);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_transform);
            this.Controls.Add(this.btn_blurNsharpe);
            this.Controls.Add(this.but_Histogram);
            this.Controls.Add(this.btn_pixelProc);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.pb_dst);
            this.Controls.Add(this.pb_src);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "영상처리 기말프로젝트 1팀";
            ((System.ComponentModel.ISupportInitialize)(this.pb_src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_src;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.PictureBox pb_dst;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_pixelProc;
        private System.Windows.Forms.Button but_Histogram;
        private System.Windows.Forms.Button btn_blurNsharpe;
        private System.Windows.Forms.Button btn_transform;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_Segmentation;
        private System.Windows.Forms.Button btn_reset;
    }
}

