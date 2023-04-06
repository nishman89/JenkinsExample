using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public  class ShoppingBasket
    {
        private int _bread;
        public int Bread 
        {   get => _bread; 
            set => _bread = value < 0 ? 0 : value; 
        }
        public int Milk { get; set; }
        public int Soap { get; set; }
        public int Potato { get; set; }
        public int Lemon { get; set; }



    }
}
