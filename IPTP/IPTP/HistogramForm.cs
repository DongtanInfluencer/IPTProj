using OpenCvSharp;
using System;
using System.Windows.Forms;

namespace IPTP
{
    public partial class HistogramForm : Form
    {
        private Form1 form = null;
        private Mat history = null;

        public HistogramForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            Mat src = form.getSrc();
            updateHistogram(src);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        private void Btn_HistogramEqual_Click(object sender, System.EventArgs e)
        {
            Mat src = form.getSrc();
            Mat dst = form.getDst();
            if (history == null && history != dst) history = src.Clone(); // 히스토리 만들기

            Mat[] rgb = Cv2.Split(src);
            //채널별 평탄화
            Cv2.EqualizeHist(rgb[0], rgb[0]);
            Cv2.EqualizeHist(rgb[1], rgb[1]);
            Cv2.EqualizeHist(rgb[2], rgb[2]);

            //병합
            Cv2.Merge(rgb, dst);

            form.updateDst();
            updateHistogram(form.getDst());
        }

        private void btn_HistogramBinary_Click(object sender, EventArgs e)
        {
            Mat src = form.getSrc();
            Mat dst = form.getDst();
            if (history == null && history != dst) history = src.Clone(); // 히스토리 만들기

            Mat[] rgb = Cv2.Split(src);
            //채널별 이진화
            Cv2.Threshold(rgb[0], rgb[0], 0, 255, ThresholdTypes.Otsu);
            Cv2.Threshold(rgb[1], rgb[1], 0, 255, ThresholdTypes.Otsu);
            Cv2.Threshold(rgb[2], rgb[2], 0, 255, ThresholdTypes.Otsu);
            //병합
            Cv2.Merge(rgb, dst);

            form.updateDst();
            updateHistogram(form.getDst());
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (history == null) return;

            form.setDst(history.Clone());
            form.updateDst();
            updateHistogram(form.getDst());
        }

        private void updateHistogram(Mat dst)
        {
            Mat[] rgb = Cv2.Split(dst);

            pb_Histogram_Blue.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[0], 0));
            pb_Histogram_Green.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[1], 1));
            pb_Histogram_Red.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[2], 2));
        }

        private Mat MatToHistogram(Mat histogram, int rgbCode)
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
            Scalar color;
            switch (rgbCode)
            {
                case 0:
                    color = Scalar.Blue;
                    break;

                case 1:
                    color = Scalar.Green;
                    break;

                case 2:
                    color = Scalar.Red;
                    break;

                default:
                    color = Scalar.All(100);
                    break;
            }

            // Scales and draws histogram
            hist = hist * (maxVal != 0 ? Height / maxVal : 0.0);

            for (int j = 0; j < hdims[0]; ++j)
            {
                int binW = (int)((double)Width / hdims[0]);
                render.Rectangle(
                    new OpenCvSharp.Point(j * binW, render.Rows - (int)(hist.Get<float>(j))),
                    new OpenCvSharp.Point((j + 1) * binW, render.Rows), color, -1);
            }

            return render;
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
        }
    }
}