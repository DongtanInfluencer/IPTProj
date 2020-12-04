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

        public Form1()
        {
            InitializeComponent();
        }

        private void updateSrc()
        {
            pb_src.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(src);
        }

        private void updateDst()
        {
            pb_dst.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);
        }

        private Mat imread(String path)
        {
            return OpenCvSharp.Extensions.BitmapConverter.ToMat(new Bitmap(path));
        }

        private void open_Click(object sender, EventArgs e)
        {
            String filePath = openFile();
            if (filePath != null)
            {
                src = imread(filePath);
                updateSrc();
                dst = Mat.Zeros(src.Size(), MatType.CV_8U);
                Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2GRAY);
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
            PixelProcForm pixelProcForm = new PixelProcForm();
            pixelProcForm.Show();
        }
    }
}