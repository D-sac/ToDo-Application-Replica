
namespace Main.StaticForm
{
    partial class ContentInsertUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentInsertUI));
            this.TakePictureBoxPanel = new System.Windows.Forms.Panel();
            this.BackGroundPictureBox = new System.Windows.Forms.PictureBox();
            this.TakePictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TakePictureBoxPanel
            // 
            this.TakePictureBoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TakePictureBoxPanel.Controls.Add(this.BackGroundPictureBox);
            this.TakePictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TakePictureBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.TakePictureBoxPanel.Name = "TakePictureBoxPanel";
            this.TakePictureBoxPanel.Size = new System.Drawing.Size(800, 350);
            this.TakePictureBoxPanel.TabIndex = 0;
            // 
            // BackGroundPictureBox
            // 
            this.BackGroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BackGroundPictureBox.Image")));
            this.BackGroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.BackGroundPictureBox.Name = "BackGroundPictureBox";
            this.BackGroundPictureBox.Size = new System.Drawing.Size(800, 350);
            this.BackGroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackGroundPictureBox.TabIndex = 0;
            this.BackGroundPictureBox.TabStop = false;
            // 
            // ContentInsertUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TakePictureBoxPanel);
            this.Name = "ContentInsertUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ContentInsertUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ContentInsertUI_Load);
            this.TakePictureBoxPanel.ResumeLayout(false);
            this.TakePictureBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TakePictureBoxPanel;
        private System.Windows.Forms.PictureBox BackGroundPictureBox;
    }
}