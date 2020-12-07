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
    public partial class ColorForm : Form
    {
        private Form1 form = null;
        private Mat history = null;
        public ColorForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Mat src = form.getSrc();
            Mat hsvSrc = src.Clone();
            Cv2.CvtColor(src, hsvSrc, ColorConversionCodes.BGR2HSV);
            Mat[] rgb = Cv2.Split(src), hsv=Cv2.Split(hsvSrc);
            
            pb_image_Red.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[2]);
            pb_image_Green.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[1]);
            pb_image_Blue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[0]);
            pb_image_Hue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hsv[0]);
            pb_image_Sat.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hsv[1]);
            pb_image_Value.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hsv[2]);

        }

        private void ColorForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
