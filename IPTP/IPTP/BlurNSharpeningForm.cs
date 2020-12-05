using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPTP
{
    public partial class BlurNSharpeningForm : Form
    {
        private Form1 form;
        private Mat history;
        private int mode;
        private float[] weigths;

        private const int NOT_USE = 0,AVRG_BLUR = 1, GAUS_BLUR = 2, MEDI_BLUR = 3,BOX_BLUR = 4, BI_BLUR = 5, SARPNING = 6;

        public BlurNSharpeningForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            mode = NOT_USE;
            history = form.getDst().Clone();
            tb_value.Text = (TrB_value.Value * 2 - 1).ToString();
            
        }


        private void btn_averageBlur_Click(object sender, EventArgs e)
        {
            mode = AVRG_BLUR;
        }

        private void btn_GaussianBlur_Click(object sender, EventArgs e)
        {
            mode = GAUS_BLUR;
        }

        private void btn_BoxBlur_Click(object sender, EventArgs e)
        {
            mode = BOX_BLUR;
        }

        private void btn_BilateralBlur_Click(object sender, EventArgs e)
        {
            mode = BI_BLUR;
        }

        private void btn_medianBlur_Click(object sender, EventArgs e)
        {
            mode = MEDI_BLUR;
        }

        private void btn_Sharpening_Click(object sender, EventArgs e)
        {
            mode = SARPNING;
        }

        private void TrB_value_Scroll(object sender, EventArgs e)
        {
            int value = (TrB_value.Value * 2) - 1; 
            tb_value.Text = value.ToString();
            update(value);
        }

        private void update(int value)
        {
            switch (mode)
            {
                case AVRG_BLUR:
                    AvrgBlur(value);
                    break;
                case GAUS_BLUR:
                    GausBlur(value);
                    break;
                case MEDI_BLUR:
                    MedianBlur(value);
                    break;
                case BOX_BLUR:
                    BoxBlur(value);
                    break;
                case BI_BLUR:
                    BilateralBlur(value);
                    break;
                case SARPNING:
                    break;
                default:
                    return;
            }
        }

        private void AvrgBlur(int value)
        {
            Mat dst = form.getDst();
            Cv2.Blur(history, dst, new OpenCvSharp.Size(value, value), new OpenCvSharp.Point(-1, -1), BorderTypes.Default);
            form.updateDst();
        }

        private void GausBlur(int value)
        {
            Mat dst = form.getDst();
            Cv2.GaussianBlur(history, dst, new OpenCvSharp.Size(value, value), 0, 0, BorderTypes.Default);
            form.updateDst();
        }
        private void BoxBlur(int value)
        {
            Mat dst = form.getDst();
            Cv2.BoxFilter(history, dst, MatType.CV_8UC3, new OpenCvSharp.Size(9, 9), new OpenCvSharp.Point(-1, -1), true, BorderTypes.Default);
            form.updateDst();
        }
        private void BilateralBlur(int value)
        {
            Mat dst = form.getDst();
            Cv2.BilateralFilter(history, dst, value, 3, 3, BorderTypes.Default);
            form.updateDst();
        }
        private void MedianBlur(int value)
        {
            Mat dst = form.getDst();
            Cv2.MedianBlur(history, dst, value*value);
            form.updateDst();
        }

    }
}
