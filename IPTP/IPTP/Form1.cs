using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace IPTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filePath = openFile();
            if(filePath != null)
            {
                Mat screen = null, find = null, res = null;
                screen = OpenCvSharp.Extensions.BitmapConverter.ToMat((Bitmap)pictureBox1.Image);
                find = OpenCvSharp.Extensions.BitmapConverter.ToMat(new Bitmap(filePath));
            }
        }

        private String openFile()
        {
            String filePath = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "이미지 파일 (*.jpg)|*.jpg|(*.png)|*.png|모든 파일 (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            return filePath;
        }
    }
}
