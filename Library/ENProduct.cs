﻿using System;
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
            set { _code = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        public ENProduct()
        {
            _code = "00000";
            _name = "";
            _amount = 0;
            _price = 0;
            _category = 0;
            _creationDate = new DateTime(1900,1,1,0,0,0);
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
        public bool IsEmpty()
        {
            return (_code == "00000" &&
                    _name == "" &&
                    _amount == 0 &&
                    _price == 0 &&
                    _category == 0 &&
                    _creationDate == DateTime.Parse("01/01/1900 00:00:00"));
        }
    }
}
