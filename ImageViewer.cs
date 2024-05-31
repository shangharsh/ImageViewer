using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
            ofd.FileName = "";
            ofd.Filter = "Image Files (*.jpeg; *.jpg; *.gif; *.bmp; *.wmf; *.png) | *.jpeg; *.jpg; *.gif; *.bmp; *.wmf; *.png";
            ofd.ShowDialog();

            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                PictureBox.Image = Image.FromFile(@ofd.FileName);
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.PictureBox.Image = null;
        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            this.PictureBox.Image = null;

        }
    }
}
