using OpenCvSharp;
using System;
using System.Windows.Forms;

namespace IPTP
{
    public partial class ColorForm : Form
    {
        private Form1 form = null;

        

        public ColorForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            form.onSrcUpdate += new SrcDelegate(updateImageView);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

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
            form.setDst(form.getSrc().Clone());
            form.updateDst();
            updateImageView(form.getDst());
        }

        private void applyColorMap(ColormapTypes colormapTypes)
        {
            Mat src = form.getSrc();
            Mat dst = form.getDst();
            Cv2.ApplyColorMap(src, dst, colormapTypes);
            form.updateDst();
            updateImageView(dst);
        }

        private void updateImageView()
        {
            updateImageView(form.getSrc());
        }
        private void updateImageView(Mat mat)
        {

            if (mat.Type() != MatType.CV_8UC3)
            {
                Cv2.CvtColor(mat, mat, ColorConversionCodes.GRAY2RGB);
            }

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

            if (pb_image_Red.Image != null) pb_image_Red.Image.Dispose();
            if (pb_image_Green.Image != null) pb_image_Green.Image.Dispose();
            if (pb_image_Blue.Image != null) pb_image_Blue.Image.Dispose();
            if (pb_image_Hue.Image != null) pb_image_Hue.Image.Dispose();
            if (pb_image_Sat.Image != null) pb_image_Sat.Image.Dispose();
            if (pb_image_Value.Image != null) pb_image_Value.Image.Dispose();
            pb_image_Red.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[2]);
            pb_image_Green.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[1]);
            pb_image_Blue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[0]);
            pb_image_Hue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hsv[0]);
            pb_image_Sat.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hsv[1]);
            pb_image_Value.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(hsv[2]);

            rgb[2].Dispose();
            rgb[1].Dispose();
            rgb[0].Dispose();
            hsv[2].Dispose();
            hsv[1].Dispose();
            hsv[0].Dispose();
            hsvMat.Dispose();
            blankMat.Dispose();
        }
    }
}