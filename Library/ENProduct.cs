using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENProduct
    {
        private string _code;
        private string _name;
        private int _amount;
        private float _price;
        private int _category;
        private DateTime _creationDate;
        public string Code
        {
            get { return _code; }
        }
        public string Name
        {
            get { return _name; }
        }
        public int Amount
        {
            get { return _amount; }
        }
        public float Price
        {
            get { return _price; }
        }
        public int Category
        {
            get { return _category; }
        }
        public DateTime CreationDate
        {
            get { return _creationDate; }
        }
        public ENProduct()
        {

        }
        public ENProduct(string code, string name, int amount, float price, int category, DateTime creationDate)
        {
            this._code = code;
            this._name = name;
            this._amount = amount;
            this._price = price;
            this._category = category;
            this._creationDate = creationDate;
        }
        public bool Create()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.Create(this);
        }
        public bool Update()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.Update(this);
        }
        public bool Delete()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.Delete(this);
        }
        public bool Read()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.Read(this);
        }
        public bool ReadFirst()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.ReadFirst(this);
        }
        public bool ReadNext()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.ReadNext(this);
        }
        public bool ReadPrev()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.ReadPrev(this);
        }
    }
}
