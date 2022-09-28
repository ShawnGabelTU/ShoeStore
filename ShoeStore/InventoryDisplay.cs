using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class InventoryDisplay : Form
    {

        int top = 100;

        public InventoryDisplay(List<string> shoeInfo, List<string> shoeCat, List<string> shoeGender, List<string> shoePrice, List<string> shoeDesc, List<string> shoeManu, List<string> shoeImg)
        {
            InitializeComponent();


            List<string> tempCat = new List<string>();
            tempCat = shoeCat;
            tempCat = tempCat.Distinct().ToList();

            for (int x = 0; x < tempCat.Count; x++)
            {
                //generates dropdown menu list items
                this.cmbCategory.Items.AddRange(new object[] {
                    tempCat[x]
                });
            }

            List<string> tempGender = new List<string>();
            tempGender = shoeGender;
            tempGender = tempGender.Distinct().ToList();

            for (int y = 0; y < tempGender.Count; y++)
            {
                //generates dropdown menu list items
                this.cmbGender.Items.AddRange(new object[] {
                    tempGender[y]
                });
            }





            for (int i = 0; i < shoeInfo.Count; i++)
            {
                //Console.WriteLine(shoeCat[i]);

                Panel panelInfo = new System.Windows.Forms.Panel();
                Label lblManufacturer = new System.Windows.Forms.Label();
                Label lblDescription = new System.Windows.Forms.Label();
                Label lblPrice = new System.Windows.Forms.Label();
                Label lblGender = new System.Windows.Forms.Label();
                Label lblShoeCategory = new System.Windows.Forms.Label();
                PictureBox imgShoe = new System.Windows.Forms.PictureBox();
                panelInfo.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(imgShoe)).BeginInit();
                SuspendLayout();
                // 
                // panelInfo
                // 
                panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panelInfo.Controls.Add(lblManufacturer);
                panelInfo.Controls.Add(lblDescription);
                panelInfo.Controls.Add(lblPrice);
                panelInfo.Controls.Add(lblGender);
                panelInfo.Controls.Add(lblShoeCategory);
                panelInfo.Controls.Add(imgShoe);
                panelInfo.Location = new System.Drawing.Point(22, top);
                panelInfo.Name = "panelInfo";
                panelInfo.Size = new System.Drawing.Size(750, 132);
                panelInfo.TabIndex = 0;
                // 
                // lblManufacturer
                // 
                lblManufacturer.AutoSize = true;
                lblManufacturer.Location = new System.Drawing.Point(151, 101);
                lblManufacturer.Name = "lblManufacturer";
                lblManufacturer.Size = new System.Drawing.Size(101, 13);
                lblManufacturer.TabIndex = 5;
                lblManufacturer.Text = "Shoe Manufacturer: " + shoeManu[i];
                // 
                // lblDescription
                // 
                lblDescription.AutoSize = true;
                lblDescription.Location = new System.Drawing.Point(151, 66);
                lblDescription.Name = "lblDescription";
                lblDescription.Size = new System.Drawing.Size(91, 13);
                lblDescription.TabIndex = 4;
                lblDescription.Text = "Shoe Description: " + shoeDesc[i];
                // 
                // lblPrice
                // 
                lblPrice.AutoSize = true;
                lblPrice.Location = new System.Drawing.Point(511, 28);
                lblPrice.Name = "lblPrice";
                lblPrice.Size = new System.Drawing.Size(62, 13);
                lblPrice.TabIndex = 3;
                lblPrice.Text = "Shoe Price: $" + shoePrice[i];
                // 
                // lblGender
                // 
                lblGender.AutoSize = true;
                lblGender.Location = new System.Drawing.Point(320, 28);
                lblGender.Name = "lblGender";
                lblGender.Size = new System.Drawing.Size(72, 13);
                lblGender.TabIndex = 2;
                lblGender.Text = "Gender Type: " + shoeGender[i];
                // 
                // lblShoeCategory
                // 
                lblShoeCategory.AutoSize = true;
                lblShoeCategory.Location = new System.Drawing.Point(151, 28);
                lblShoeCategory.Name = "lblShoeCategory";
                lblShoeCategory.Size = new System.Drawing.Size(80, 13);
                lblShoeCategory.TabIndex = 1;
                lblShoeCategory.Text = "Shoe Category: " + shoeCat[i];
                // 
                // imgShoe
                // 
                imgShoe.Location = new System.Drawing.Point(19, 18);
                imgShoe.Name = "imgShoe";
                imgShoe.Size = new System.Drawing.Size(100, 96);
                imgShoe.TabIndex = 0;
                imgShoe.TabStop = false;
                imgShoe.Image = new Bitmap(shoeImg[i]);
                imgShoe.SizeMode = PictureBoxSizeMode.StretchImage;
                // 
                // InventoryDisplay
                // 
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                ClientSize = new System.Drawing.Size(800, 450);
                Controls.Add(panelInfo);
                Name = "InventoryDisplay";
                Text = "InventoryDisplay";
                Load += new System.EventHandler(this.InventoryDisplay_Load);
                panelInfo.ResumeLayout(false);
                panelInfo.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(imgShoe)).EndInit();
                ResumeLayout(false);


                top += 150;
            }






        }

        private void InventoryDisplay_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (cmbCategory.SelectedItem != null)
            {
                if (cmbCategory.SelectedItem.ToString() == "Clogs")
                {

                    //MessageBox.Show("Success!");
                    foreach (Control control in Controls)
                    {
                        control.Visible = false;
                        foreach (Control x in control.Controls)
                        {
                            if (x.Text.Equals("Shoe Category: Clogs"))
                            {
                                control.Visible = true;

                            }
                            //Console.WriteLine(x.Name.ToString());
                        }

                        //Console.WriteLine(control.Name.ToString());
                        if (control.Name == "cmbCategory" || control.Name == "cmbGender" || control.Name == "btnSearch" || control.Name == "lblWarning" || control.Name == "lblCategoryType" || control.Name == "lblGenderType")
                        {
                            control.Visible = true;
                        }
                    }

                }
                else if (cmbCategory.SelectedItem.ToString() == "Boots")
                {
                    foreach (Control control in Controls)
                    {
                        control.Visible = false;
                        foreach (Control x in control.Controls)
                        {
                            if (x.Text == "Shoe Category: Boots")
                            {
                                control.Visible = true;

                            }
                            //Console.WriteLine(x.Name.ToString());
                        }
                        //Console.WriteLine(control.Name.ToString());
                        if (control.Name == "cmbCategory" || control.Name == "cmbGender" || control.Name == "btnSearch" || control.Name == "lblWarning" || control.Name == "lblCategoryType" || control.Name == "lblGenderType")
                        {
                            control.Visible = true;
                        }
                    }

                }
                else if (cmbCategory.SelectedItem.ToString() == "Athletic Shoes")
                {
                    foreach (Control control in Controls)
                    {
                        control.Visible = false;
                        foreach (Control x in control.Controls)
                        {
                            if (x.Text == "Shoe Category: Athletic Shoes")
                            {
                                control.Visible = true;

                            }
                            //Console.WriteLine(x.Name.ToString());
                        }
                        //Console.WriteLine(control.Name.ToString());
                        if (control.Name == "cmbCategory" || control.Name == "cmbGender" || control.Name == "btnSearch" || control.Name == "lblWarning" || control.Name == "lblCategoryType" || control.Name == "lblGenderType")
                        {
                            control.Visible = true;
                        }
                    }

                }
                else if (cmbCategory.SelectedItem.ToString() == "Flip Flops")
                {
                    foreach (Control control in Controls)
                    {
                        control.Visible = false;
                        foreach (Control x in control.Controls)
                        {
                            if (x.Text == "Shoe Category: Flip Flops")
                            {
                                control.Visible = true;

                            }
                            //Console.WriteLine(x.Name.ToString());
                        }
                        //Console.WriteLine(control.Name.ToString());
                        if (control.Name == "cmbCategory" || control.Name == "cmbGender" || control.Name == "btnSearch" || control.Name == "lblWarning" || control.Name == "lblCategoryType" || control.Name == "lblGenderType")
                        {
                            control.Visible = true;
                        }
                    }

                }
                else if (cmbCategory.SelectedItem.ToString() == "Loafers")
                {
                    foreach (Control control in Controls)
                    {
                        control.Visible = false;
                        foreach (Control x in control.Controls)
                        {
                            if (x.Text == "Shoe Category: Loafers")
                            {
                                control.Visible = true;

                            }
                            //Console.WriteLine(x.Name.ToString());
                        }
                        //Console.WriteLine(control.Name.ToString());
                        if (control.Name == "cmbCategory" || control.Name == "cmbGender" || control.Name == "btnSearch" || control.Name == "lblWarning" || control.Name == "lblCategoryType" || control.Name == "lblGenderType")
                        {
                            control.Visible = true;
                        }
                    }
                }


            }

            if (cmbGender.SelectedItem != null)
            {
                if (cmbGender.SelectedItem.ToString() == " Male")
                {

                    foreach (Control control in Controls)
                    {
                        control.Visible = false;
                        foreach (Control x in control.Controls)
                        {
                            if (x.Text.Equals("Gender Type:  Male"))
                            {
                                control.Visible = true;
                            }
                            //Console.WriteLine(x.Name.ToString());
                        }

                        //Console.WriteLine(control.Name.ToString());
                        if (control.Name == "cmbCategory" || control.Name == "cmbGender" || control.Name == "btnSearch" || control.Name == "lblWarning" || control.Name == "lblCategoryType" || control.Name == "lblGenderType")
                        {
                            control.Visible = true;
                        }
                    }

                }
                else if (cmbGender.SelectedItem.ToString() == " Female")
                {

                    foreach (Control control in Controls)
                    {
                        control.Visible = false;
                        foreach (Control x in control.Controls)
                        {
                            if (x.Text.Equals("Gender Type:  Female"))
                            {
                                control.Visible = true;

                            }
                            //Console.WriteLine(x.Name.ToString());
                        }

                        //Console.WriteLine(control.Name.ToString());
                        if (control.Name == "cmbCategory" || control.Name == "cmbGender" || control.Name == "btnSearch" || control.Name == "lblWarning" || control.Name == "lblCategoryType" || control.Name == "lblGenderType")
                        {
                            control.Visible = true;
                        }
                    }

                }
                else if (cmbGender.SelectedItem.ToString() == " Unisex")
                {

                    foreach (Control control in Controls)
                    {
                        control.Visible = false;
                        foreach (Control x in control.Controls)
                        {
                            if (x.Text.Equals("Gender Type:  Unisex"))
                            {
                                control.Visible = true;

                            }
                            //Console.WriteLine(x.Name.ToString());
                        }

                        //Console.WriteLine(control.Name.ToString());
                        if (control.Name == "cmbCategory" || control.Name == "cmbGender" || control.Name == "btnSearch" || control.Name == "lblWarning" || control.Name == "lblCategoryType" || control.Name == "lblGenderType")
                        {
                            control.Visible = true;
                        }
                    }


                }
            }

            cmbCategory.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;

        }

    }
}

