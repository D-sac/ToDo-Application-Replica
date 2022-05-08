
namespace Main.StaticForm
{
    partial class ContentUI
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.ContentList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnContentAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(33, 274);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(496, 28);
            this.txtContent.TabIndex = 0;
            // 
            // ContentList
            // 
            this.ContentList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ContentList.Location = new System.Drawing.Point(33, 17);
            this.ContentList.Name = "ContentList";
            this.ContentList.Size = new System.Drawing.Size(495, 251);
            this.ContentList.TabIndex = 1;
            // 
            // btnContentAdd
            // 
            this.btnContentAdd.Location = new System.Drawing.Point(33, 308);
            this.btnContentAdd.Name = "btnContentAdd";
            this.btnContentAdd.Size = new System.Drawing.Size(495, 28);
            this.btnContentAdd.TabIndex = 2;
            this.btnContentAdd.Text = "button1";
            this.btnContentAdd.UseVisualStyleBackColor = true;
            this.btnContentAdd.Click += new System.EventHandler(this.btnContentAdd_Click);
            // 
            // ContentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1084, 704);
            this.ControlBox = false;
            this.Controls.Add(this.btnContentAdd);
            this.Controls.Add(this.ContentList);
            this.Controls.Add(this.txtContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContentUI";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ContentUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.FlowLayoutPanel ContentList;
        private System.Windows.Forms.Button btnContentAdd;
    }
}