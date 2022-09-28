using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class ShoeForm : Form
    {

        //Shoe newShoe = new Shoe();

        //string test = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"\ShoeStore\ShoeStore\ShoeCollection.txt");

        public ShoeForm()
        {
            InitializeComponent();
        }

        private void ShoeForm_Load(object sender, EventArgs e)
        {

        }

        

        private void cmbImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStoreShoeData_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == String.Empty || txtDescription.Text == String.Empty || txtManufacturer.Text == String.Empty)
            {
                MessageBox.Show("Please Fillout all data fields!");
            }
            else
            {
                int imageIndex = cmbImage.SelectedIndex;
                
                string category = cmbShoeCategory.SelectedItem.ToString();
                string gender = cmbGender.SelectedItem.ToString();
                int price = Convert.ToInt32(txtPrice.Text);
                string description = txtDescription.Text;
                string manufacturer = txtManufacturer.Text;
                int imagePathway = imageIndex;
                Shoe newShoe = new Shoe(category, gender, price, description, manufacturer, imagePathway);

                //TextWriter txt = new StreamWriter("C:\\Users\\Breez\\source\\repos\\ShoeStore\\ShoeStore\\ShoeCollection.txt");
                //txt.WriteLine(newShoe.ToString());
                //txt.Close();

                //if text file doesnt exist create new textfile TODO:
                using (StreamWriter outputFile = new StreamWriter("../ShoeCollection.txt", true))
                {
                    outputFile.WriteLine(newShoe.ToString());
                }

                cmbShoeCategory.SelectedIndex = -1;
                cmbGender.SelectedIndex = -1;
                txtPrice.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtManufacturer.Text = string.Empty;
                cmbImage.SelectedIndex = -1;
            }
        }

        
        private void btnInventory_Click(object sender, EventArgs e)
        {

            List<Shoe> list = new List<Shoe>();
            List<string> categoryList = new List<string>();
            List<string> genderList = new List<string>();
            List<string> priceList = new List<string>();
            List<string> descriptionList = new List<string>();
            List<string> manufacturerList = new List<string>();
            List<string> imagePathwayList = new List<string>();
            using (var reader = new StreamReader("../ShoeCollection.txt"))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var temp = line.Split(',');
                    list.Add(new Shoe
                    {
                        ShoeCategory = temp[0],
                        ShoeGender = temp[1],
                        ShoePrice = temp[2],
                        ShoeDescription = temp[3],
                        ShoeManufacturer = temp[4],
                        ShoeImagePathway = temp[5]
                    });
                    categoryList.Add(temp[0]);
                    genderList.Add(temp[1]);
                    priceList.Add(temp[2]);
                    descriptionList.Add(temp[3]);
                    manufacturerList.Add(temp[4]);
                    imagePathwayList.Add(temp[5]);
                }
            }


            //Console.WriteLine(categoryList);


            //Reads all the lines from the text file.
            string[] lines = System.IO.File.ReadAllLines("../ShoeCollection.txt");

            //converts to single string seperate by new line (FOR DISPLAY PURPOSES ONLY).
                //string toDisplay = string.Join(Environment.NewLine, lines);
                //MessageBox.Show(toDisplay);


            List<string> passInfoList = new List<string>();
            
            //pass these string over to new form, then deconstruct strings there.
            for (int i = 0; i < lines.Length; i++)
            {
                passInfoList.Add(lines[i]);
            }


            Form invDisplay = new InventoryDisplay(passInfoList, categoryList, genderList, priceList, descriptionList, manufacturerList, imagePathwayList);
            this.Hide();
            invDisplay.ShowDialog();
        }
    }
}
