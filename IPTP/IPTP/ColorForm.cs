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
            history = form.getSrc().Clone();

            Mat src = form.getSrc();

            updateImageView(src);
        }

        private void Btn_Autumn_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Autumn);
        }

        private void Btn_Bone_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Bone);
        }

        private void Btn_Cool_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Cool);
        }

        private void Btn_Hot_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Hot);
        }

        private void Btn_Hsv_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Hsv);
        }

        private void Btn_Jet_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Jet);
        }

        private void Btn_Ocean_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Ocean);
        }

        private void Btn_Pink_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Pink);
        }

        private void Btn_Rainbow_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Rainbow);
        }

        private void Btn_Spring_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Spring);
        }

        private void Btn_Summer_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Summer);
        }

        private void Btn_Winter_Click(object sender, EventArgs e)
        {
            applyColorMap(ColormapTypes.Winter);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (history == null) return;

            form.setDst(history.Clone());
            form.updateDst();
            updateImageView(history);
        }

        private void applyColorMap(ColormapTypes colormapTypes)
        {
            Mat src = form.getSrc();
            Mat dst = form.getDst();
            Cv2.ApplyColorMap(src, dst, colormapTypes);
            form.updateDst();
            updateImageView(dst);
        }

        private void updateImageView(Mat mat)
        {
            Mat hsvMat = mat.Clone();
            Cv2.CvtColor(mat, hsvMat, ColorConversionCodes.BGR2HSV);
            Mat[] rgb = Cv2.Split(mat), hsv = Cv2.Split(hsvMat);

            Mat blankMat = new Mat(mat.Size(), MatType.CV_8UC1);

            Mat[] red = new Mat[3];
            red[0] = red[1] = blankMat;
            red[2] = rgb[2];
            Cv2.Merge(red, rgb[2]);

            Mat[] green = new Mat[3];
            green[0] = green[2] = blankMat;
            green[1] = rgb[1];
            Cv2.Merge(green, rgb[1]);

            Mat[] blue = new Mat[3];
            blue[1] = blue[2] = blankMat;
            blue[0] = rgb[0];
            Cv2.Merge(blue, rgb[0]);

            pb_image_Red.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[2]);
            pb_image_Green.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[1]);
            pb_image_Blue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[0]);
            pb_image_Hue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hsv[0]);
            pb_image_Sat.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hsv[1]);
            pb_image_Value.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hsv[2]);
        }
    }
}
