using OpenCvSharp;
using System;
using System.Windows.Forms;

namespace IPTP
{
    public partial class PixelProcForm : Form
    {
        private Form1 form = null;

        public PixelProcForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void onlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private byte[] _CalcLut()
        {
            byte[] lut = new byte[256];
            int brightness = tr_bright.Value - 255;
            double contrast = ((double)tr_contrast.Value - 100) / 100 + 1;
            double gamma = (double)tr_gamma.Value / 100;

            if (gamma <= 0)
                gamma = 0.01;

            for (int i = 0; i < 256; i++)
            {
                int v = (int)(contrast * i + brightness);
                if (v < 0)
                    v = 0;
                if (v > 255)
                    v = 255;
                lut[i] = (byte)v;
                lut[i] = (byte)(Math.Pow(v / 255.0, 1.0 / gamma) * 255.0);
            }
            return lut;
        }

        private void update()
        {
            Mat src = form.getSrc();
            Mat dst = form.getDst();
            byte[] lut = _CalcLut();
            Cv2.LUT(src, lut, dst);
            form.updateDst();
        }

        private void tr_bright_Scroll(object sender, EventArgs e)
        {
            int brightness = tr_bright.Value - 255;
            tb_bright.Text = brightness.ToString();
            update();
        }

        private void tr_contrast_Scroll(object sender, EventArgs e)
        {
            double contrast = ((double)tr_contrast.Value - 100) / 100 + 1;
            tb_contrast.Text = contrast.ToString();
            update();
        }

        private void tr_gamma_Scroll(object sender, EventArgs e)
        {
            double gamma = (double)tr_gamma.Value / 100;
            tb_gamma.Text = gamma.ToString();
            update();
        }

        private void PixelProcForm_Load(object sender, EventArgs e)
        {
        }
    }
}