
namespace SemProject
{
    partial class ucHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panLabel = new System.Windows.Forms.Panel();
            this.labHardware = new System.Windows.Forms.Label();
            this.labThe = new System.Windows.Forms.Label();
            this.labToolBoc = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBlob = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.panLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panLabel
            // 
            this.panLabel.BackColor = System.Drawing.Color.Orange;
            this.panLabel.Controls.Add(this.labHardware);
            this.panLabel.Controls.Add(this.labThe);
            this.panLabel.Controls.Add(this.labToolBoc);
            this.panLabel.Controls.Add(this.pictureBox2);
            this.panLabel.Controls.Add(this.picBlob);
            this.panLabel.Location = new System.Drawing.Point(0, 0);
            this.panLabel.Name = "panLabel";
            this.panLabel.Size = new System.Drawing.Size(350, 550);
            this.panLabel.TabIndex = 1;
            // 
            // labHardware
            // 
            this.labHardware.AutoSize = true;
            this.labHardware.BackColor = System.Drawing.Color.Black;
            this.labHardware.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHardware.ForeColor = System.Drawing.Color.Orange;
            this.labHardware.Location = new System.Drawing.Point(135, 336);
            this.labHardware.Name = "labHardware";
            this.labHardware.Size = new System.Drawing.Size(93, 32);
            this.labHardware.TabIndex = 3;
            this.labHardware.Text = "Hardware";
            this.labHardware.Click += new System.EventHandler(this.label3_Click);
            // 
            // labThe
            // 
            this.labThe.AutoSize = true;
            this.labThe.BackColor = System.Drawing.Color.Black;
            this.labThe.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labThe.ForeColor = System.Drawing.Color.Orange;
            this.labThe.Location = new System.Drawing.Point(163, 269);
            this.labThe.Name = "labThe";
            this.labThe.Size = new System.Drawing.Size(38, 27);
            this.labThe.TabIndex = 3;
            this.labThe.Text = "The";
            this.labThe.Click += new System.EventHandler(this.label1_Click);
            // 
            // labToolBoc
            // 
            this.labToolBoc.AutoSize = true;
            this.labToolBoc.BackColor = System.Drawing.Color.Black;
            this.labToolBoc.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToolBoc.ForeColor = System.Drawing.Color.Orange;
            this.labToolBoc.Location = new System.Drawing.Point(106, 285);
            this.labToolBoc.Name = "labToolBoc";
            this.labToolBoc.Size = new System.Drawing.Size(158, 60);
            this.labToolBoc.TabIndex = 2;
            this.labToolBoc.Text = "Tool Box";
            this.labToolBoc.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::SemProject.Properties.Resources.comp1;
            this.pictureBox2.Location = new System.Drawing.Point(150, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picBlob
            // 
            this.picBlob.Image = global::SemProject.Properties.Resources.blob1;
            this.picBlob.Location = new System.Drawing.Point(25, 123);
            this.picBlob.Name = "picBlob";
            this.picBlob.Size = new System.Drawing.Size(300, 300);
            this.picBlob.TabIndex = 2;
            this.picBlob.TabStop = false;
            this.picBlob.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBackground
            // 
            this.picBackground.BackColor = System.Drawing.Color.MidnightBlue;
            this.picBackground.Image = global::SemProject.Properties.Resources.background2;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(894, 550);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            this.picBackground.Click += new System.EventHandler(this.picBackground_Click);
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panLabel);
            this.Controls.Add(this.picBackground);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(894, 550);
            this.panLabel.ResumeLayout(false);
            this.panLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Panel panLabel;
        private System.Windows.Forms.PictureBox picBlob;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labHardware;
        private System.Windows.Forms.Label labThe;
        private System.Windows.Forms.Label labToolBoc;
    }
}
