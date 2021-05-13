using System;
using System.Windows.Forms;

namespace PicViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openB_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog.FileName);
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void editB_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Editor EF = new Editor(pictureBox1.Image);
                EF.ShowDialog();
                pictureBox1.Image = EF.Image;
                EF.Dispose();
            }
            else
            {
                MessageBox.Show("No image chosen to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stretchCB_CheckedChanged(object sender, EventArgs e)
        {
            if (stretchCB.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
