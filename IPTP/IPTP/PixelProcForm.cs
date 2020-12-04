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
    public partial class PixelProcForm : Form
    {
        public PixelProcForm()
        {
            InitializeComponent();
        }

        private void onlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tr_bright_Scroll(object sender, EventArgs e)
        {
            tb_bright.Text = tr_bright.Value.ToString();
        }

        private void tr_contrast_Scroll(object sender, EventArgs e)
        {
            tb_contrast.Text = tr_contrast.Value.ToString();
        }

        private void tr_gamma_Scroll(object sender, EventArgs e)
        {
            tb_gamma.Text = tr_gamma.Value.ToString();
        }
    }
}
