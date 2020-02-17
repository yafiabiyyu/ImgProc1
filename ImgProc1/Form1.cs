using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgProc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog bukaFile = new OpenFileDialog();
            bukaFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg) | *.bmp;*.jpg;*.jpeg";
            if(DialogResult.OK == bukaFile.ShowDialog())
            {
                this.pbInput.Image = new Bitmap(bukaFile.FileName);
            }
        }

        private void simpanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pbOutput.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan disimpan");
            }else
            {
                SaveFileDialog simpanFile = new SaveFileDialog();
                simpanFile.Title = "Simpan File Citra";
                simpanFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg) | *.bmp;*.jpg;*.jpeg";
                if(DialogResult.OK == simpanFile.ShowDialog())
                {
                    this.pbOutput.Image.Save(simpanFile.FileName);
                }
            }
        }
    }
}
