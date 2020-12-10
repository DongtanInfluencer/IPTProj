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

        public SegmentationForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void SegmentationForm_Load(object sender, EventArgs e)
        {

        }

        private void SegmentationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
