namespace _13.SimleForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuHead = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsConnectionDB = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatabsases = new System.Windows.Forms.DataGridView();
            this.Назва = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabsases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(559, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Нажми мене";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 69);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 23);
            this.txtName.TabIndex = 1;
            // 
            // menuHead
            // 
            this.menuHead.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuHead.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuHead.Location = new System.Drawing.Point(0, 0);
            this.menuHead.Name = "menuHead";
            this.menuHead.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuHead.Size = new System.Drawing.Size(700, 24);
            this.menuHead.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.fileExit.Size = new System.Drawing.Size(144, 22);
            this.fileExit.Text = "Вихід";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsConnectionDB});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.optionsToolStripMenuItem.Text = "Налаштування";
            // 
            // optionsConnectionDB
            // 
            this.optionsConnectionDB.Name = "optionsConnectionDB";
            this.optionsConnectionDB.Size = new System.Drawing.Size(182, 22);
            this.optionsConnectionDB.Text = "Підключення до БД";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(193, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Керування Базами данних";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDatabsases
            // 
            this.dgvDatabsases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabsases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Назва});
            this.dgvDatabsases.Location = new System.Drawing.Point(0, 127);
            this.dgvDatabsases.Name = "dgvDatabsases";
            this.dgvDatabsases.RowTemplate.Height = 25;
            this.dgvDatabsases.Size = new System.Drawing.Size(700, 188);
            this.dgvDatabsases.TabIndex = 5;
            // 
            // Назва
            // 
            this.Назва.FillWeight = 1000F;
            this.Назва.HeaderText = "Назва";
            this.Назва.Name = "Назва";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.dgvDatabsases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuHead);
            this.MainMenuStrip = this.menuHead;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Магазин";
            this.menuHead.ResumeLayout(false);
            this.menuHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabsases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private TextBox txtName;
        private MenuStrip menuHead;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileExit;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem optionsConnectionDB;
        private Label label1;
        private DataGridView dgvDatabsases;
        private DataGridViewTextBoxColumn Назва;
    }
}
