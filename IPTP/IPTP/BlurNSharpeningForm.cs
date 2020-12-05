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
    public partial class BlurNSharpeningForm : Form
    {
        private Form1 form;

        public BlurNSharpeningForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }


        private void btn_averageBlur_Click(object sender, EventArgs e)
        {

        }

        private void btn_GaussianBlur_Click(object sender, EventArgs e)
        {

        }

        private void btn_medianBlur_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sharpening_Click(object sender, EventArgs e)
        {

        }

        private void TrB_value_Scroll(object sender, EventArgs e)
        {
            tb_value.Text = TrB_value.Value.ToString();
        }
    }
}
