using System;
using System.Drawing;
using System.Windows.Forms;

namespace PicViewer
{
    public partial class ResizePU : Form
    {
        private int w, h;
        public int ImgWidth { get => w; }
        public int ImgHeight { get => h; }

        public ResizePU(Size size)
        {
            InitializeComponent();
            w = size.Width;
            h = size.Height;
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            if (int.TryParse(widthTB.Text, out w) && int.TryParse(heightTB.Text, out h)
                && 6000 >= w && w > 0 && 6000 >= h && h > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Values entered were invalid. (Valid only if a positive whole number 6000 or lower).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResizePU_Load(object sender, EventArgs e)
        {
            widthTB.Text = w.ToString();
            heightTB.Text = h.ToString();
        }
    }
}
