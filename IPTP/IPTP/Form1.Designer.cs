namespace IPTP
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dst)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_src
            // 
            this.pb_src.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_src.BackColor = System.Drawing.Color.White;
            this.pb_src.Location = new System.Drawing.Point(70, 100);
            this.pb_src.Name = "pb_src";
            this.pb_src.Size = new System.Drawing.Size(512, 512);
            this.pb_src.TabIndex = 0;
            this.pb_src.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(70, 634);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(512, 78);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "불러오기";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.open_Click);
            // 
            // pb_dst
            // 
            this.pb_dst.Location = new System.Drawing.Point(670, 100);
            this.pb_dst.Name = "pb_dst";
            this.pb_dst.Size = new System.Drawing.Size(512, 512);
            this.pb_dst.TabIndex = 0;
            this.pb_dst.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(670, 634);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(512, 78);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "저장하기";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "원본 이미지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "처리된 이미지";
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(588, 301);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(76, 45);
            this.btn_convert.TabIndex = 3;
            this.btn_convert.Text = "←";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 782);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.pb_dst);
            this.Controls.Add(this.pb_src);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

