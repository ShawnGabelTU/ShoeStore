
namespace ShoeStore
{
    partial class ShoeForm
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
            this.cmbShoeCategory = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.cmbImage = new System.Windows.Forms.ComboBox();
            this.lblShoeCategory = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnStoreShoeData = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbShoeCategory
            // 
            this.cmbShoeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShoeCategory.FormattingEnabled = true;
            this.cmbShoeCategory.Items.AddRange(new object[] {
            "Boots",
            "Athletic Shoes",
            "Clogs",
            "Flip Flops",
            "Loafers"});
            this.cmbShoeCategory.Location = new System.Drawing.Point(159, 49);
            this.cmbShoeCategory.Name = "cmbShoeCategory";
            this.cmbShoeCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbShoeCategory.TabIndex = 0;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unisex"});
            this.cmbGender.Location = new System.Drawing.Point(159, 99);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(159, 153);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(159, 211);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(159, 269);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(121, 20);
            this.txtManufacturer.TabIndex = 4;
            // 
            // cmbImage
            // 
            this.cmbImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImage.FormattingEnabled = true;
            this.cmbImage.Items.AddRange(new object[] {
            "Boots",
            "Athletic Shoes",
            "Clogs",
            "Flip Flops",
            "Loafers"});
            this.cmbImage.Location = new System.Drawing.Point(159, 329);
            this.cmbImage.Name = "cmbImage";
            this.cmbImage.Size = new System.Drawing.Size(121, 21);
            this.cmbImage.TabIndex = 5;
            this.cmbImage.SelectedIndexChanged += new System.EventHandler(this.cmbImage_SelectedIndexChanged);
            // 
            // lblShoeCategory
            // 
            this.lblShoeCategory.AutoSize = true;
            this.lblShoeCategory.Location = new System.Drawing.Point(28, 52);
            this.lblShoeCategory.Name = "lblShoeCategory";
            this.lblShoeCategory.Size = new System.Drawing.Size(113, 13);
            this.lblShoeCategory.TabIndex = 6;
            this.lblShoeCategory.Text = "Select Shoe Category:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(28, 102);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(78, 13);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Select Gender:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(28, 156);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Enter Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(28, 214);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Enter Description:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(28, 272);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(101, 13);
            this.lblManufacturer.TabIndex = 10;
            this.lblManufacturer.Text = "Enter Manufacturer:";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(31, 336);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(72, 13);
            this.lblImage.TabIndex = 11;
            this.lblImage.Text = "Select Image:";
            // 
            // btnStoreShoeData
            // 
            this.btnStoreShoeData.Location = new System.Drawing.Point(536, 394);
            this.btnStoreShoeData.Name = "btnStoreShoeData";
            this.btnStoreShoeData.Size = new System.Drawing.Size(121, 44);
            this.btnStoreShoeData.TabIndex = 12;
            this.btnStoreShoeData.Text = "Store Shoe Data";
            this.btnStoreShoeData.UseVisualStyleBackColor = true;
            this.btnStoreShoeData.Click += new System.EventHandler(this.btnStoreShoeData_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(676, 394);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(112, 44);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.Text = "View Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // ShoeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnStoreShoeData);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblShoeCategory);
            this.Controls.Add(this.cmbImage);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbShoeCategory);
            this.Name = "ShoeForm";
            this.Text = "Shoe Form";
            this.Load += new System.EventHandler(this.ShoeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShoeCategory;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.ComboBox cmbImage;
        private System.Windows.Forms.Label lblShoeCategory;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnStoreShoeData;
        private System.Windows.Forms.Button btnInventory;
    }
}

