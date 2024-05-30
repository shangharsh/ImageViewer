using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class ImageViewer : Form
    {
        public ImageViewer()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string fileName = System.IO.File.ReadAllText(ofd.FileName,Encoding.UTF8);
            MessageBox.Show(fileName);

            //string fileName = ofd.FileName;
            //this.PictureBox.Image = Image.FromFile(fileName);
            //this.PictureBox.Image = Image

            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Custom Description";
            //string sSelectedPath;
            //if (fbd.ShowDialog() == DialogResult.OK)
            //{
            //    sSelectedPath = fbd.SelectedPath;
            //    MessageBox.Show(sSelectedPath);
            //}
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.PictureBox.Image = null;
        }
    }
}
