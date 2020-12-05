using OpenCvSharp;
using System;
using System.Windows.Forms;

namespace IPTP
{
    public partial class Histogram : Form
    {
        private Form1 form = null;
        private Mat dst = null;
        private Mat history = null;

        public Histogram(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        protected override void OnActivated(EventArgs e)
        {
            //폼이 켜질때 자동으로 히스토그램 표출 , 켜질때의 Dst를 history로 표시
            base.OnActivated(e);
            dst = form.getDst();
            updateHistogram(dst);
            history = dst.Clone();
        }

        private void updateHistogram(Mat dst)
        {
            Mat[] rgb = Cv2.Split(dst);

            pb_Histogram_Blue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[0]));
            pb_Histogram_Green.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[1]));
            pb_Histogram_Red.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[2]));

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
                new Mat[] { histogram },
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
                    new OpenCvSharp.Point((j + 1) * binW, render.Rows),color,-1);
            }

            return render;
        }

        private void Btn_HistogramEqual_Click(object sender, System.EventArgs e)
        {
            dst = form.getDst();

            Mat[] rgb = Cv2.Split(dst);
            //색깔별 평탄화
            Cv2.EqualizeHist(rgb[0], rgb[0]);
            Cv2.EqualizeHist(rgb[1], rgb[1]);
            Cv2.EqualizeHist(rgb[2], rgb[2]);
            Cv2.Merge(rgb, dst);

            form.updateDst();
            updateHistogram(form.getDst());


        }

        private void pb_Histogram_Green_Click(object sender, EventArgs e)
        {

        }
    }
}