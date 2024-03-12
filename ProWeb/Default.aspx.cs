using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace ProWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateButton_Click(object sender, EventArgs e)
        { 
            try
            {
                CADProduct product = new CADProduct();
                product.Create(new ENProduct(CodeTextBox.Text, NameTextBox.Text, int.Parse(AmountTextBox.Text), float.Parse(PriceTextBox.Text), DateTime.Parse(DateTextBox.Text)));
                Console.WriteLine("Product created!!");
                MsgLabel.Text = "Product created!!";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. ERROR: " + ex.Message);
                MsgLabel.Text = "Something went wrong";
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        protected void ReadButton_Click(object sender, EventArgs e)
        {

        }

        protected void ReadFirstButton_Click(object sender, EventArgs e)
        {

        }

        protected void ReadPrevButton_Click(object sender, EventArgs e)
        {

        }

        protected void ReadNextButton_Click(object sender, EventArgs e)
        {

        }
    }
}