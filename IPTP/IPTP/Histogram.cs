using OpenCvSharp;
using System.Windows.Forms;

namespace IPTP
{
    public partial class Histogram : Form
    {
        private Form1 form = null;
        private Mat src = null;
        private Mat dst = null;

        public Histogram(Form1 form)
        {
            InitializeComponent();
            this.form = form;

            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            src = form.getSrc();
            dst = form.getDst();

            Mat gray = new Mat(dst.Size(), MatType.CV_8UC1);
            Cv2.CvtColor(dst, gray, ColorConversionCodes.BGR2GRAY);
            var rgb = Cv2.Split(dst);
            //Mat[] rgb = new Mat[3];
            //Cv2.Split(dst, out rgb);

            pb_Histogram_grayScale.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(gray));
            pb_Histogram_Blue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[0]));
            pb_Histogram_Green.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[1]));
            pb_Histogram_Red.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[2]));
            //pb_Histogram_grayScale.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(gray);
            //pb_Histogram_Blue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[0]);
            //pb_Histogram_Green.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[1]);
            //pb_Histogram_Red.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(rgb[2]);


        }
        private Mat MatToHistogram(Mat histogram)
        {

            const int Width = 260, Height = 200;
            Mat render = new Mat(new OpenCvSharp.Size(Width, Height), MatType.CV_8UC3, Scalar.All(255));

            // Calculate histogram
            Mat hist = new Mat();
            int[] hdims = { 256 }; // Histogram size for each dimension
            Rangef[] ranges = { new Rangef(0, 256), }; // min/max
            Cv2.CalcHist(
                new Mat[] { src },
                new int[] { 0 },
                null,
                hist,
                1,
                hdims,
                ranges);

            // Get the max value of histogram
            double minVal, maxVal;
            Cv2.MinMaxLoc(hist, out minVal, out maxVal);
            Scalar color = Scalar.All(100);
            // Scales and draws histogram
            hist = hist * (maxVal != 0 ? Height / maxVal : 0.0);

            for (int j = 0; j < hdims[0]; ++j)
            {
                int binW = (int)((double)Width / hdims[0]);
                render.Rectangle(
                    new OpenCvSharp.Point(j * binW, render.Rows - (int)(hist.Get<float>(j))),
                    new OpenCvSharp.Point((j + 1) * binW, render.Rows),
                    color,
                    -1);
            }

            return render;
        }
    }
}