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
                pictureBox.Load(openFileDialog.FileName);
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void editB_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Editor EF = new Editor(pictureBox.Image);
                EF.ShowDialog();
                pictureBox.Image = EF.Image;
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
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
