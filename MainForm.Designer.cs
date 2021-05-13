
namespace PicViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stretchCB = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.openB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.editB = new System.Windows.Forms.Button();
            this.closeB = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.stretchCB, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(609, 336);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 296);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // stretchCB
            // 
            this.stretchCB.AutoSize = true;
            this.stretchCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stretchCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stretchCB.Location = new System.Drawing.Point(3, 305);
            this.stretchCB.Name = "stretchCB";
            this.stretchCB.Size = new System.Drawing.Size(85, 28);
            this.stretchCB.TabIndex = 1;
            this.stretchCB.Text = "Stretch";
            this.stretchCB.UseVisualStyleBackColor = false;
            this.stretchCB.CheckedChanged += new System.EventHandler(this.stretchCB_CheckedChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.openB);
            this.flowLayoutPanel.Controls.Add(this.clearB);
            this.flowLayoutPanel.Controls.Add(this.editB);
            this.flowLayoutPanel.Controls.Add(this.closeB);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(94, 305);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(512, 28);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // openB
            // 
            this.openB.AutoSize = true;
            this.openB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openB.Location = new System.Drawing.Point(409, 3);
            this.openB.Name = "openB";
            this.openB.Size = new System.Drawing.Size(100, 25);
            this.openB.TabIndex = 0;
            this.openB.Text = "Open a picture";
            this.openB.UseVisualStyleBackColor = false;
            this.openB.Click += new System.EventHandler(this.openB_Click);
            // 
            // clearB
            // 
            this.clearB.AutoSize = true;
            this.clearB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clearB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearB.Location = new System.Drawing.Point(303, 3);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(100, 25);
            this.clearB.TabIndex = 1;
            this.clearB.Text = "Clear the picture";
            this.clearB.UseVisualStyleBackColor = false;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // editB
            // 
            this.editB.AutoSize = true;
            this.editB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editB.Location = new System.Drawing.Point(197, 3);
            this.editB.Name = "editB";
            this.editB.Size = new System.Drawing.Size(100, 25);
            this.editB.TabIndex = 2;
            this.editB.Text = "Edit Image";
            this.editB.UseVisualStyleBackColor = false;
            this.editB.Click += new System.EventHandler(this.editB_Click);
            // 
            // closeB
            // 
            this.closeB.AutoSize = true;
            this.closeB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeB.Location = new System.Drawing.Point(91, 3);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(100, 25);
            this.closeB.TabIndex = 3;
            this.closeB.Text = "Close";
            this.closeB.UseVisualStyleBackColor = false;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpg)|*.jpg|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog.Title = "Select a picture file";
            // 
            // MainForm
            // 
            this.AcceptButton = this.openB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearB;
            this.ClientSize = new System.Drawing.Size(609, 336);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Picture Viewer";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void MainForm_Activated(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox stretchCB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button openB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button editB;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}