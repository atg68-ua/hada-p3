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
        private const string errMsg = "User operation has failed. Error: ";
        private void showProduct(ENProduct pr)
        {
            CodeTextBox.Text = pr.Code;
            NameTextBox.Text = pr.Name;
            AmountTextBox.Text = pr.Amount.ToString();
            PriceTextBox.Text = pr.Price.ToString();
            CategoryList.SelectedIndex = pr.Category-1;
            DateTextBox.Text = pr.CreationDate.ToString();
        }
        private ENProduct correctData(string code, string name, int amount, float price, string creationDate)
        {
            if (code.Length < 1 || code.Length > MAX_CODE) throw new ArgumentException("incorrect code format");
            if (name.Length >= MAX_NAME) throw new ArgumentException("incorrect name format");
            if (amount < 0 || amount >= MAX_AMOUNT) throw new ArgumentException("incorrect amount format");
            if (price < 0 || price >= MAX_PRICE) throw new ArgumentException("incorrect price format");
            if (!DateTime.TryParseExact(creationDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt)) throw new ArgumentException("incorrect date format");

            return new ENProduct(code, name,  amount, price, int.Parse(CategoryList.SelectedValue), dt);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
            }
        }
        private void LoadCategories()
        {
            CADCategory cad = new CADCategory();
            List<ENCategory> categorias = cad.readAll();

            CategoryList.DataSource = categorias;
            CategoryList.DataTextField = "name";
            CategoryList.DataValueField = "id";
            CategoryList.DataBind();
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
                Console.WriteLine(errMsg + ex.Message);
                MsgLabel.Text = errMsg + ex.Message;
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct pr = correctData(CodeTextBox.Text, NameTextBox.Text, int.Parse(AmountTextBox.Text), float.Parse(PriceTextBox.Text), DateTextBox.Text);
                CADProduct product = new CADProduct();
                product.Update(pr);
                Console.WriteLine("Product updated!!");
                MsgLabel.Text = "Product updated!!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(errMsg + ex.Message);
                MsgLabel.Text = errMsg + ex.Message;
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CodeTextBox.Text.Length < 1 || CodeTextBox.Text.Length > MAX_CODE) throw new ArgumentException("incorrect code format");
                ENProduct pr = new ENProduct();
                pr.Code = CodeTextBox.Text;
                CADProduct product = new CADProduct();
                product.Delete(pr);
                Console.WriteLine("Product deleted!!");
                MsgLabel.Text = "Product deleted!!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(errMsg + ex.Message);
                MsgLabel.Text = errMsg + ex.Message;
            }
        }

        protected void ReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CodeTextBox.Text.Length < 1 || CodeTextBox.Text.Length > MAX_CODE) throw new ArgumentException("incorrect code format");
                ENProduct pr = new ENProduct();
                pr.Code = CodeTextBox.Text;
                CADProduct product = new CADProduct();
                product.Read(pr);
                showProduct(pr);
                Console.WriteLine("Done!!");
                MsgLabel.Text = "Done!!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(errMsg + ex.Message);
                MsgLabel.Text = errMsg + ex.Message;
            }
        }

        protected void ReadFirstButton_Click(object sender, EventArgs e)
        {
            try
            {
                ENProduct pr = new ENProduct();
                CADProduct product = new CADProduct();
                product.ReadFirst(pr);
                showProduct(pr);
                Console.WriteLine("Done!!");
                MsgLabel.Text = "Done!!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(errMsg + ex.Message);
                MsgLabel.Text = errMsg + ex.Message;
            }
        }

        protected void ReadPrevButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CodeTextBox.Text.Length < 1 || CodeTextBox.Text.Length > MAX_CODE) throw new ArgumentException("incorrect code format");
                ENProduct pr = new ENProduct();
                pr.Code = CodeTextBox.Text;
                CADProduct product = new CADProduct();
                product.ReadPrev(pr);
                showProduct(pr);
                Console.WriteLine("Done!!");
                MsgLabel.Text = "Done!!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(errMsg + ex.Message);
                MsgLabel.Text = errMsg + ex.Message;
            }
        }

        protected void ReadNextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CodeTextBox.Text.Length < 1 || CodeTextBox.Text.Length > MAX_CODE) throw new ArgumentException("incorrect code format");
                ENProduct pr = new ENProduct();
                pr.Code = CodeTextBox.Text;
                CADProduct product = new CADProduct();
                product.ReadNext(pr);
                showProduct(pr);
                Console.WriteLine("Done!!");
                MsgLabel.Text = "Done!!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(errMsg + ex.Message);
                MsgLabel.Text = errMsg + ex.Message;
            }
        }
    }
}