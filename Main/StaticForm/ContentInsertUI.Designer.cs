
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
            this.TextEditor.Size = new System.Drawing.Size(645, 359);
            this.TextEditor.SpellingAutoCorrectionList = ((System.Collections.Hashtable)(resources.GetObject("TextEditor.SpellingAutoCorrectionList")));
            this.TextEditor.TabIndex = 0;
            this.TextEditor.ToolstripImageScalingSize = new System.Drawing.Size(16, 16);
            this.TextEditor.UseParagraphAsDefault = true;
            this.TextEditor.Load += new System.EventHandler(this.TextEditor_Load);
            // 
            // ContentInsertUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(645, 359);
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
    }
}