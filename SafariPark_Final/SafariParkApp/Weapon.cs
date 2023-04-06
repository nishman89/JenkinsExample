using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Weapon : IShootable
    {
        private string _brand;
        public Weapon(string brand)
        {
            _brand = brand;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {_brand}";
        }


    }

    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand) { }


    }

    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand) { }


    }
}
