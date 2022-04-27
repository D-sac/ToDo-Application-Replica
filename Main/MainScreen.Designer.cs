
namespace Main
{
    partial class MainScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDescription = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.açıklamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.BtnDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 320);
            this.dataGridView1.TabIndex = 1;
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Categories.Location = new System.Drawing.Point(1, 1);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(186, 359);
            this.Categories.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(11, 12);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(159, 20);
            this.txtCategoryName.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(11, 43);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(95, 43);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Location = new System.Drawing.Point(1, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 90);
            this.panel1.TabIndex = 3;
            // 
            // BtnDescription
            // 
            this.BtnDescription.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açıklamaToolStripMenuItem});
            this.BtnDescription.Name = "BtnDescription";
            this.BtnDescription.Size = new System.Drawing.Size(181, 48);
            // 
            // açıklamaToolStripMenuItem
            // 
            this.açıklamaToolStripMenuItem.Name = "açıklamaToolStripMenuItem";
            this.açıklamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açıklamaToolStripMenuItem.Text = "Açıklama";
            this.açıklamaToolStripMenuItem.Click += new System.EventHandler(this.açıklamaToolStripMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BtnDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel Categories;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip BtnDescription;
        private System.Windows.Forms.ToolStripMenuItem açıklamaToolStripMenuItem;
    }
}