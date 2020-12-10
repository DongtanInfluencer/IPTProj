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
    public partial class SegmentationForm : Form
    {
        private Form1 form = null;
        private AdaptiveThresholdTypes mode;
        private ThresholdTypes thMode;

        public SegmentationForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            tb_value.Text = (TrB_value.Value * 2 + 1).ToString();
            mode = AdaptiveThresholdTypes.MeanC;
            thMode = ThresholdTypes.Binary;
        } // 

        private void SegmentationForm_Load(object sender, EventArgs e)
        {

        }

        private void SegmentationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Btn_AdaptiveMean_Click(object sender, EventArgs e)
        {
            mode = AdaptiveThresholdTypes.MeanC;
            update();
        }
        private void Btn_AdaptiveGau_Click(object sender, EventArgs e)
        {
            mode = AdaptiveThresholdTypes.GaussianC;
            update();
        }

        private void TrB_value_Scroll(object sender, EventArgs e)
        {
            int value = (TrB_value.Value * 2) + 1;
            tb_value.Text = value.ToString();
            update();
            
        }

        private void update()
        {
            Mat src = form.getSrc();
            Mat[] rgb = src.Split();
            
            foreach (Mat m in rgb)
            {
                Cv2.AdaptiveThreshold(m, m, 255, mode, thMode, Int32.Parse(tb_value.Text), 3);
            }

            Mat dst = form.getDst();
            Cv2.Merge(rgb, dst);
            form.updateDst();


            foreach (Mat m in rgb)
            {
                m.Dispose();
            }

        }

        private void Btn_Binary_Click(object sender, EventArgs e)
        {
            thMode = ThresholdTypes.Binary;
            update();
        }

        private void Btn_BiInv_Click(object sender, EventArgs e)
        {
            thMode = ThresholdTypes.BinaryInv;
            update();

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            form.setDst(form.getSrc().Clone());
            form.updateDst();
        }
    }
}
