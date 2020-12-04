using OpenCvSharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IPTP
{
    public partial class Form1 : Form
    {
        private Mat src = null;
        private Mat dst = null;

        private PixelProcForm pixelProcForm = null;
        private Histogram histogram = null;

        public Form1()
        {
            InitializeComponent();
            pixelProcForm = new PixelProcForm(this);
            histogram = new Histogram(this);
        }

        public void updateSrc()
        {
            pb_src.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(src);
        }

        public Mat getSrc()
        {
            return src;
        }

        public Mat getDst()
        {
            return dst;
        }

        public void setSrc(Mat src)
        {
            this.src = src;
        }

        public void setDst(Mat dst)
        {
            this.dst = dst;
        }

        public void updateDst()
        {
            pb_dst.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);
        }

        private Mat imread(String path)
        {
            Bitmap bitmap = new Bitmap(path);
            Mat mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(bitmap);
            return mat;
        }

        private void open_Click(object sender, EventArgs e)
        {
            String filePath = openFile();
            if (filePath != null)
            {
                src = imread(filePath);
                updateSrc();
                dst = src.Clone();
                updateDst();
            }
        }

        private String openFile()
        {
            String filePath = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openFileDialog.Filter = "이미지 파일 (*.jpg)|*.jpg|이미지 파일 (*.png)|*.png|모든 파일 (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            return filePath;
        }

        private String saveFile()
        {
            String filePath = null;

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            saveFileDialog.Filter = "이미지 파일 (*.jpg)|*.jpg|이미지 파일 (*.png)|*.png|모든 파일 (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }
            return filePath;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            src = dst;
            updateSrc();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dst != null)
            {
                String filePath = saveFile();
                if (filePath != null)
                {
                    dst.SaveImage(filePath);
                    MessageBox.Show("저장되었습니다!");
                }
            }
        }

        private void btn_pixelProc_Click(object sender, EventArgs e)
        {
            if (src == null) return;

            if (!pixelProcForm.Visible)
            {
                pixelProcForm.Show();
            }
            else
            {
                pixelProcForm.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void but_Histogram_Click(object sender, EventArgs e)
        {
            if (src == null) return;

            // Histogram view
            Mat[] rgb = new Mat[3];
            Cv2.Split(src, out rgb);
            pb_dst.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(MatToHistogram(rgb[1]));




            /*
            using (new Window("Histogram", WindowMode.AutoSize | WindowMode.FreeRatio, MatToHistogram(rgb[0])))
            {
                Cv2.WaitKey();
            }
            using (new Window("Histogram", WindowMode.AutoSize | WindowMode.FreeRatio, MatToHistogram(rgb[1])))
            {
                Cv2.WaitKey();
            }*/
            using (new Window("Histogram", WindowMode.AutoSize | WindowMode.FreeRatio, MatToHistogram(rgb[2])))
            {
                Cv2.WaitKey();
            }
            /*
        if (!histogram.Visible)
        {
            histogram.Show();
        }
        else
        {
            histogram.Hide();
        }*/
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