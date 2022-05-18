
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentInsertUI));
            this.TextEditor = new Zoople.HTMLEditControl();
            this.FinishDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextEditor
            // 
            this.TextEditor.AcceptsReturn = true;
            this.TextEditor.AllowDragInternal = true;
            this.TextEditor.AutoSize = true;
            this.TextEditor.AvailableInlineStyles = ((System.Collections.Generic.List<string>)(resources.GetObject("TextEditor.AvailableInlineStyles")));
            this.TextEditor.BaseURL = null;
            this.TextEditor.CleanMSWordHTMLOnPaste = true;
            this.TextEditor.CodeEditor.Enabled = true;
            this.TextEditor.CodeEditor.Locked = false;
            this.TextEditor.CodeEditor.TabWidth = 720;
            this.TextEditor.CodeEditor.WordWrap = false;
            this.TextEditor.CSSText = null;
            this.TextEditor.CustomColorPalette = null;
            this.TextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditor.DocumentHTML = null;
            this.TextEditor.EditingDisabled = false;
            this.TextEditor.EnableInlineSpelling = false;
            this.TextEditor.FontSizesList = null;
            this.TextEditor.FontsList = null;
            this.TextEditor.HiddenButtons = null;
            this.TextEditor.ImageStorageLocation = null;
            this.TextEditor.InCodeView = false;
            this.TextEditor.LanguageFile = null;
            this.TextEditor.LicenceActivationKey = null;
            this.TextEditor.LicenceKey = null;
            this.TextEditor.LicenceKeyInlineSpelling = null;
            this.TextEditor.Location = new System.Drawing.Point(0, 0);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(635, 348);
            this.TextEditor.SpellingAutoCorrectionList = ((System.Collections.Hashtable)(resources.GetObject("TextEditor.SpellingAutoCorrectionList")));
            this.TextEditor.TabIndex = 0;
            this.TextEditor.ToolstripImageScalingSize = new System.Drawing.Size(16, 16);
            this.TextEditor.UseParagraphAsDefault = true;
            this.TextEditor.Load += new System.EventHandler(this.TextEditor_Load);
            // 
            // FinishDate
            // 
            this.FinishDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishDate.Location = new System.Drawing.Point(463, 328);
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.Size = new System.Drawing.Size(172, 20);
            this.FinishDate.TabIndex = 1;
            // 
            // StartDate
            // 
            this.StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartDate.Location = new System.Drawing.Point(102, 328);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(171, 20);
            this.StartDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(421, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş";
            // 
            // ContentInsertUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(635, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.FinishDate);
            this.Controls.Add(this.TextEditor);
            this.Name = "ContentInsertUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ContentInsertUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zoople.HTMLEditControl TextEditor;
        private System.Windows.Forms.DateTimePicker FinishDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}