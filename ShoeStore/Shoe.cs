using System;

public class Shoe
{
	
	private string shoeCategory;
	private string shoeGender;
	private string shoePrice;
	private string shoeDescription;
	private string shoeManufacturer;
	private string shoeImagePathway;

    public string ShoeCategory { get => shoeCategory; set => shoeCategory = value; }
    public string ShoeGender { get => shoeGender; set => shoeGender = value; }
    public string ShoePrice { get => shoePrice; set => shoePrice = value; }
    public string ShoeDescription { get => shoeDescription; set => shoeDescription = value; }
    public string ShoeManufacturer { get => shoeManufacturer; set => shoeManufacturer = value; }
    public string ShoeImagePathway { get => shoeImagePathway; set => shoeImagePathway = value; }


    public Shoe() { }
    public static string getImagePathway(int selectedIndex)
    {
		if(selectedIndex == 0)
        {
			return "./../Images/boots.jpg";
        }else if(selectedIndex == 1)
        {
			return "./../Images/AthleticShoes.jpg";
        }else if(selectedIndex == 2)
        {
			return "./../Images/clogs.png";
        }
		else if (selectedIndex == 3)
		{
			return "./../Images/FlipFlops.jpg";
		}else if(selectedIndex == 4)
        {
			return "./../Images/Loafers.jpg";
        }
        else
        {
			return "";
        }

	}

	public Shoe(string category, string gender, int price, string description, string manufacturer, int imageIndex)
	{
		this.ShoeCategory = category;
		this.ShoeGender = gender;
		this.ShoePrice = price.ToString();
		this.ShoeDescription = description;
		this.ShoeManufacturer = manufacturer;
		this.ShoeImagePathway = getImagePathway(imageIndex);
	}

    public override string ToString()
    {
        return $"{ShoeCategory}, {ShoeGender}, {ShoePrice}, {ShoeDescription}, {ShoeManufacturer}, {ShoeImagePathway}";
    }
}
