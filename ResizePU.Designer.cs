
namespace PicViewer
{
    partial class ResizePU
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
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.widthTB = new System.Windows.Forms.TextBox();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.wLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(12, 96);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(75, 23);
            this.Yes.TabIndex = 0;
            this.Yes.Text = "Accept";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.No.Location = new System.Drawing.Point(97, 96);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(75, 23);
            this.No.TabIndex = 1;
            this.No.Text = "Cancel";
            this.No.UseVisualStyleBackColor = true;
            // 
            // widthTB
            // 
            this.widthTB.Location = new System.Drawing.Point(53, 12);
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(100, 20);
            this.widthTB.TabIndex = 2;
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(53, 38);
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(100, 20);
            this.heightTB.TabIndex = 3;
            // 
            // wLabel
            // 
            this.wLabel.AutoSize = true;
            this.wLabel.Location = new System.Drawing.Point(12, 15);
            this.wLabel.Name = "wLabel";
            this.wLabel.Size = new System.Drawing.Size(35, 13);
            this.wLabel.TabIndex = 4;
            this.wLabel.Text = "Width";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(12, 41);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(38, 13);
            this.hLabel.TabIndex = 5;
            this.hLabel.Text = "Height";
            // 
            // ResizePU
            // 
            this.AcceptButton = this.Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.No;
            this.ClientSize = new System.Drawing.Size(184, 136);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.wLabel);
            this.Controls.Add(this.heightTB);
            this.Controls.Add(this.widthTB);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ResizePU";
            this.Text = "Resize";
            this.Load += new System.EventHandler(this.ResizePU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.TextBox widthTB;
        private System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.Label wLabel;
        private System.Windows.Forms.Label hLabel;
    }
}