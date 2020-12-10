using OpenCvSharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace IPTP
{
    public partial class Form1 : Form
    {
        private Mat src = null;
        private Mat dst = null;
        private Stack<Mat> history = new Stack<Mat>();

        private Form pixelProcForm = null;
        private Form histogramForm = null;
        private Form blurNSharpeningForm = null;
        private Form colorForm = null;
        private Form segmentationForm = null;

        private List<Form> openForms = new List<Form>();

        private const int PPForm = 0;
        private const int HForm = 1;
        private const int BNSForm = 2;
        private const int CForm = 3;
        private const int SForm = 4;

        private int pX = 0;
        private int pY = 0;

        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            pX = this.Location.X;
            pY = this.Location.Y;
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
            history.Push(src.Clone());
            src = dst.Clone();
            updateSrc();
            if (history.Count > 0) btn_reset.Enabled = true;
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
            pixelProcForm = BtnAction(pixelProcForm, PPForm);
        }

        private void but_Histogram_Click(object sender, EventArgs e)
        {
            histogramForm = BtnAction(histogramForm, HForm);
        }

        private void btn_blurNsharpe_Click(object sender, EventArgs e)
        {
            blurNSharpeningForm = BtnAction(blurNSharpeningForm, BNSForm);
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            colorForm = BtnAction(colorForm, CForm);
        }

        private Form BtnAction(Form form, int formType)
        {
            if (src == null) return null;
            if (form == null || form.IsDisposed)
            {
                switch (formType)
                {
                    case PPForm:
                        form = new PixelProcForm(this);
                        break;

                    case HForm:
                        form = new HistogramForm(this);
                        break;

                    case BNSForm:
                        form = new BlurNSharpeningForm(this);
                        break;

                    case CForm:
                        form = new ColorForm(this);
                        break;

                    case SForm:
                        form = new SegmentationForm(this);
                        break;

                    default:
                        return null;
                }
                form.Show();
                openForms.Add(form);
                form.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y);
            }
            else if (!form.Visible)
            {
                form.Show();
                openForms.Add(form);
                form.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y);
            }
            else
            {
                openForms.Remove(form);
                form.Hide();
            }
            return form;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (history.Count == 0)
            {
                btn_reset.Enabled = false;
                return;
            }
            Mat pop = history.Pop();
            dst = src.Clone();
            src = pop;
            updateSrc();
            updateDst();
            if (history.Count == 0) btn_reset.Enabled = false;
        }

        private void btn_Segmentation_Click(object sender, EventArgs e)
        {
            segmentationForm = BtnAction(segmentationForm, SForm);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            foreach (Form form in this.openForms)
            {
                if (form.Visible)
                {
                    int dx = pX - this.Location.X;
                    int dy = pY - this.Location.Y;
                    form.SetDesktopLocation(form.Location.X - dx, form.Location.Y - dy);
                }
            }
            pX = this.Location.X;
            pY = this.Location.Y;
        }
    }
}