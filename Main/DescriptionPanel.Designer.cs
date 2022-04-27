
namespace Main
{
    partial class DescriptionPanel
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
            this.RichDescription = new System.Windows.Forms.RichTextBox();
            this.DescriptionAdd = new System.Windows.Forms.Button();
            this.DescriptionDrop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichDescription
            // 
            this.RichDescription.Location = new System.Drawing.Point(12, 33);
            this.RichDescription.Name = "RichDescription";
            this.RichDescription.Size = new System.Drawing.Size(238, 121);
            this.RichDescription.TabIndex = 0;
            this.RichDescription.Text = "";
            // 
            // DescriptionAdd
            // 
            this.DescriptionAdd.Location = new System.Drawing.Point(51, 160);
            this.DescriptionAdd.Name = "DescriptionAdd";
            this.DescriptionAdd.Size = new System.Drawing.Size(158, 23);
            this.DescriptionAdd.TabIndex = 1;
            this.DescriptionAdd.Text = "Kaydet";
            this.DescriptionAdd.UseVisualStyleBackColor = true;
            // 
            // DescriptionDrop
            // 
            this.DescriptionDrop.Location = new System.Drawing.Point(51, 189);
            this.DescriptionDrop.Name = "DescriptionDrop";
            this.DescriptionDrop.Size = new System.Drawing.Size(158, 23);
            this.DescriptionDrop.TabIndex = 2;
            this.DescriptionDrop.Text = "Kaldır";
            this.DescriptionDrop.UseVisualStyleBackColor = true;
            // 
            // DescriptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 226);
            this.Controls.Add(this.DescriptionDrop);
            this.Controls.Add(this.DescriptionAdd);
            this.Controls.Add(this.RichDescription);
            this.Name = "DescriptionPanel";
            this.Text = "DescriptionPanel";
            this.Load += new System.EventHandler(this.DescriptionPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichDescription;
        private System.Windows.Forms.Button DescriptionAdd;
        private System.Windows.Forms.Button DescriptionDrop;
    }
}