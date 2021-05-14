using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PicViewer
{
    public partial class Editor : Form
    {
        public Image Image { get => editPicBox.Image; set => editPicBox.Image = value; }

        private readonly List<Point> line = new List<Point>();
        private readonly Pen pen = new Pen(Color.Black);

        public Editor(Image img)
        {
            InitializeComponent();

            SetImage(img);

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            pen.LineJoin = LineJoin.Round;

            foreach (string type in Enum.GetNames(typeof(RotateFlipType)))
            {
                rfDDB.DropDownItems.Add(type);
            }
        }

        public void SetImage(Image img)
        {
            Image = img;

            int w = img.Width + 16;
            int h = img.Height + 114;
            if (w < 216) w = 216;
            if (h < 314) h = 314;

            Size = new Size(w, h);
        }

        private void editPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            line.Add(e.Location);
            editPicBox.Invalidate();
        }

        private void editPicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                line.Add(e.Location);
                editPicBox.Invalidate();
            }
        }

        private void editPicBox_MouseUp(object sender, MouseEventArgs e)
        {
            editPicBox.Invalidate();
            line.Clear();
        }

        private void editPicBox_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(Image))
            {
                if (line.Count >= 2) g.DrawLines(pen, line.ToArray());
                else if (line.Count == 1)
                    g.FillEllipse(pen.Brush,
                        line.ToArray()[0].X - pen.Width / 2, line.ToArray()[0].Y - pen.Width / 2, pen.Width, pen.Width);
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageFormat ext = ImageFormat.Png;
                switch (System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower())
                {
                    case ".png":
                        ext = ImageFormat.Png;
                        break;
                    case ".jpg":
                        ext = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        ext = ImageFormat.Bmp;
                        break;
                }
                Image.Save(saveFileDialog.OpenFile(), ext);
            }
        }

        private void resizeB_Click(object sender, EventArgs e)
        {
            ResizePU RPU = new ResizePU(Image.Size);

            if (RPU.ShowDialog() == DialogResult.OK)
            {
                // resizing images is immoral. https://stackoverflow.com/a/24199315
                int width = RPU.ImgWidth;
                int height = RPU.ImgHeight;

                var destRect = new Rectangle(0, 0, width, height);
                var destImage = new Bitmap(width, height);

                destImage.SetResolution(Image.HorizontalResolution, Image.VerticalResolution);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(Image, destRect, 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }

                Image = destImage;
            }
            RPU.Dispose();
        }

        private void colorB_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorB.BackColor = colorDialog.Color;
                colorB.ForeColor = Color.FromArgb(colorDialog.Color.ToArgb() ^ 0xFFFFFF);
                pen.Color = colorDialog.Color;
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar.Value;
        }

        private void rfDDB_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            RotateFlipType type = RotateFlipType.RotateNoneFlipNone;
            switch (e.ClickedItem.Text)
            {
                case "Rotate180FlipNone":
                    type = RotateFlipType.Rotate180FlipNone;
                    break;
                case "Rotate180FlipX":
                    type = RotateFlipType.Rotate180FlipX;
                    break;
                case "Rotate180FlipXY":
                    type = RotateFlipType.Rotate180FlipXY;
                    break;
                case "Rotate180FlipY":
                    type = RotateFlipType.Rotate180FlipY;
                    break;
                case "Rotate270FlipNone":
                    type = RotateFlipType.Rotate270FlipNone;
                    break;
                case "Rotate270FlipX":
                    type = RotateFlipType.Rotate270FlipX;
                    break;
                case "Rotate270FlipXY":
                    type = RotateFlipType.Rotate270FlipXY;
                    break;
                case "Rotate270FlipY":
                    type = RotateFlipType.Rotate270FlipY;
                    break;
                case "Rotate90FlipNone":
                    type = RotateFlipType.Rotate90FlipNone;
                    break;
                case "Rotate90FlipX":
                    type = RotateFlipType.Rotate90FlipX;
                    break;
                case "Rotate90FlipXY":
                    type = RotateFlipType.Rotate90FlipXY;
                    break;
                case "Rotate90FlipY":
                    type = RotateFlipType.Rotate90FlipY;
                    break;
                case "RotateNoneFlipNone":
                    type = RotateFlipType.RotateNoneFlipNone;
                    break;
                case "RotateNoneFlipX":
                    type = RotateFlipType.RotateNoneFlipX;
                    break;
                case "RotateNoneFlipXY":
                    type = RotateFlipType.RotateNoneFlipXY;
                    break;
                case "RotateNoneFlipY":
                    type = RotateFlipType.RotateNoneFlipY;
                    break;
            }

            Bitmap tmpi = (Bitmap)Image.Clone();
            tmpi.RotateFlip(type);
            Image = (Image)tmpi.Clone();
            tmpi.Dispose();
            editPicBox.Refresh();
        }
    }
}
