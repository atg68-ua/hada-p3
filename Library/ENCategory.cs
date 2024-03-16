using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENCategory
    {
        private int _id;
        private string _name;
        public string Name
        {
            get { return _name; }
        }
        public int ID
        {
            get { return _id; }
        }
        public ENCategory(string Name, int ID)
        {
            this._name = Name;
            this._id = ID;
        }
    }
}
