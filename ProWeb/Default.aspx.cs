using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Globalization;

namespace ProWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const int MAX_CODE = 16;
        private const int MAX_NAME = 16;
        private const int MAX_AMOUNT = 9999;
        private const double MAX_PRICE = 9999.99;
        private ENProduct correctData(string code, string name, int amount, float price, string creationDate)
        {
            if (code.Length < 1 || code.Length > MAX_CODE) throw new ArgumentException();
            if (name.Length <= MAX_NAME) throw new ArgumentException();
            if (amount < 0 || amount >= MAX_AMOUNT) throw new ArgumentException();
            if (price < 0 || price >= MAX_PRICE) throw new ArgumentException();
            if (!DateTime.TryParseExact(creationDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt)) throw new ArgumentException();

            return new ENProduct(code, name,  amount, price, dt);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct pr = correctData(CodeTextBox.Text, NameTextBox.Text, int.Parse(AmountTextBox.Text), float.Parse(PriceTextBox.Text), DateTextBox.Text);
                CADProduct product = new CADProduct();
                product.Create(pr);
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