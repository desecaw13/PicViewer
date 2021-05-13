
namespace PicViewer
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.saveB = new System.Windows.Forms.ToolStripButton();
            this.resizeB = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.colorB = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.editPicBox = new System.Windows.Forms.PictureBox();
            this.rfDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveB,
            this.resizeB,
            this.rfDDB});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(200, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "Menu";
            // 
            // saveB
            // 
            this.saveB.Image = ((System.Drawing.Image)(resources.GetObject("saveB.Image")));
            this.saveB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(51, 22);
            this.saveB.Text = "Save";
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // resizeB
            // 
            this.resizeB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resizeB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resizeB.Name = "resizeB";
            this.resizeB.Size = new System.Drawing.Size(43, 22);
            this.resizeB.Text = "Resize";
            this.resizeB.Click += new System.EventHandler(this.resizeB_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpg)|*.jpg|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.saveFileDialog.Title = "Save your image";
            // 
            // trackBar
            // 
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.LargeChange = 10;
            this.trackBar.Location = new System.Drawing.Point(69, 3);
            this.trackBar.Maximum = 100;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(128, 44);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel.Controls.Add(this.trackBar, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.colorB, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 175);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(200, 50);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // colorB
            // 
            this.colorB.BackColor = System.Drawing.Color.Black;
            this.colorB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorB.ForeColor = System.Drawing.Color.White;
            this.colorB.Location = new System.Drawing.Point(3, 3);
            this.colorB.Name = "colorB";
            this.colorB.Size = new System.Drawing.Size(60, 44);
            this.colorB.TabIndex = 3;
            this.colorB.Text = "Change Color";
            this.colorB.UseVisualStyleBackColor = false;
            this.colorB.Click += new System.EventHandler(this.colorB_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // editPicBox
            // 
            this.editPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPicBox.Location = new System.Drawing.Point(0, 25);
            this.editPicBox.Name = "editPicBox";
            this.editPicBox.Size = new System.Drawing.Size(200, 150);
            this.editPicBox.TabIndex = 5;
            this.editPicBox.TabStop = false;
            this.editPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.editPicBox_Paint);
            this.editPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.editPicBox_MouseDown);
            this.editPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editPicBox_MouseMove);
            this.editPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.editPicBox_MouseUp);
            // 
            // rfDDB
            // 
            this.rfDDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rfDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rfDDB.Name = "rfDDB";
            this.rfDDB.Size = new System.Drawing.Size(79, 22);
            this.rfDDB.Text = "Rotate & Flip";
            this.rfDDB.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.rfDDB_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 225);
            this.Controls.Add(this.editPicBox);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.Text = "Editor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton saveB;
        private System.Windows.Forms.ToolStripButton resizeB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button colorB;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox editPicBox;
        private System.Windows.Forms.ToolStripDropDownButton rfDDB;
    }
}