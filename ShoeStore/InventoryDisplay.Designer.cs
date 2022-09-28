
namespace ShoeStore
{
    partial class InventoryDisplay
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblCategoryType = new System.Windows.Forms.Label();
            this.lblGenderType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(689, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 41);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Submit Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(145, 47);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 1;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(501, 47);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 2;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Maroon;
            this.lblWarning.Location = new System.Drawing.Point(12, 12);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(160, 13);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "SELECT 1 OPTION AT A TIME!\r\n";
            // 
            // lblCategoryType
            // 
            this.lblCategoryType.AutoSize = true;
            this.lblCategoryType.Location = new System.Drawing.Point(12, 50);
            this.lblCategoryType.Name = "lblCategoryType";
            this.lblCategoryType.Size = new System.Drawing.Size(113, 13);
            this.lblCategoryType.TabIndex = 4;
            this.lblCategoryType.Text = "Select Shoe Category:";
            // 
            // lblGenderType
            // 
            this.lblGenderType.AutoSize = true;
            this.lblGenderType.Location = new System.Drawing.Point(330, 50);
            this.lblGenderType.Name = "lblGenderType";
            this.lblGenderType.Size = new System.Drawing.Size(133, 13);
            this.lblGenderType.TabIndex = 5;
            this.lblGenderType.Text = "Select Shoe Gender Type:";
            // 
            // InventoryDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 886);
            this.Controls.Add(this.lblGenderType);
            this.Controls.Add(this.lblCategoryType);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnSearch);
            this.Name = "InventoryDisplay";
            this.Text = "InventoryDisplay";
            this.Load += new System.EventHandler(this.InventoryDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblCategoryType;
        private System.Windows.Forms.Label lblGenderType;
    }
}