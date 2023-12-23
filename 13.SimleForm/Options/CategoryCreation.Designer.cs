

namespace _13.SimleForm.Options
{
    partial class CategoryCreation
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryDecription = new System.Windows.Forms.TextBox();
            this.txtCategoryImage = new System.Windows.Forms.TextBox();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.categoryImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblName.Location = new System.Drawing.Point(98, 55);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDescription.Location = new System.Drawing.Point(98, 176);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(122, 30);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.LblDescription_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblImage.Location = new System.Drawing.Point(98, 295);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(74, 30);
            this.lblImage.TabIndex = 2;
            this.lblImage.Text = "Image";
            this.lblImage.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(98, 88);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(205, 29);
            this.txtCategoryName.TabIndex = 3;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCategoryDecription
            // 
            this.txtCategoryDecription.Location = new System.Drawing.Point(98, 209);
            this.txtCategoryDecription.Name = "txtCategoryDecription";
            this.txtCategoryDecription.Size = new System.Drawing.Size(205, 29);
            this.txtCategoryDecription.TabIndex = 4;
            // 
            // txtCategoryImage
            // 
            this.txtCategoryImage.Location = new System.Drawing.Point(98, 328);
            this.txtCategoryImage.Name = "txtCategoryImage";
            this.txtCategoryImage.Size = new System.Drawing.Size(205, 29);
            this.txtCategoryImage.TabIndex = 5;
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateCategory.ForeColor = System.Drawing.Color.Green;
            this.btnCreateCategory.Location = new System.Drawing.Point(468, 63);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(119, 54);
            this.btnCreateCategory.TabIndex = 6;
            this.btnCreateCategory.Text = "Create";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.BtnCreateCategory_Click);
            // 
            // categoryImage
            // 
            this.categoryImage.Location = new System.Drawing.Point(360, 225);
            this.categoryImage.Name = "categoryImage";
            this.categoryImage.Size = new System.Drawing.Size(315, 300);
            this.categoryImage.TabIndex = 7;
            this.categoryImage.TabStop = false;
            this.categoryImage.Click += new System.EventHandler(this.categoryImage_Click);
            // 
            // CategoryCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.categoryImage);
            this.Controls.Add(this.btnCreateCategory);
            this.Controls.Add(this.txtCategoryImage);
            this.Controls.Add(this.txtCategoryDecription);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryCreation";
            this.Text = "CategoryCreation";
            this.Load += new System.EventHandler(this.CategoryCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblDescription;
        private Label lblImage;
        private TextBox txtCategoryName;
        private TextBox txtCategoryDecription;
        private TextBox txtCategoryImage;
        private Button btnCreateCategory;
        private PictureBox categoryImage;
    }
}