using System;

namespace SafariParkApp;

public class Program
{
    public static void Main()
    {

        #region creating objects
        //Person james = new Person("James", "Dickson", 12);
        //Console.WriteLine(james.GetFullName());
        //Person david = new Person("David", "Cull", 5);
        //Console.WriteLine(david.GetFullName());
        //Person steven = new Person("Steven");
        //try
        //{
        //    steven.Age = -1;
        //}
        //catch (Exception e)
        //{

        //    Console.WriteLine(e.Message);
        //}

        //var stevensAge = steven.Age;
        //Console.WriteLine(steven.FullName);

        //var arr = new int[] { 1, 2, 3 };

        //var marian = new Person("Marian", "Dumitriu") { Age = 90 };

        //var shoppingBasket = new ShoppingBasket() { Bread = 2, Potato = 6, Milk =2 };

        //var nish = new Person("Nish", "Mandal") { Age = 32 };


        //var nish = new Person() {FirstName = "Nish", LastName = "Mandal", Age = 32 };
        //nish.Age = 33;
        //nish.FirstName = "Nishy";

        //var spartan = new Spartan("Ned", "Nedson", "C# Dev", "Neurscience");

        //var spartan2 = new Spartan() { FirstName = "Ned", LastName = "Nedson", Stream = "C# Dev", Degree = "Neuroscience" };
        #endregion
        #region structs vs classes
        //var person = new Person() { FirstName = "Jay", LastName = "Z", Age = 50 };
        //var pt3d = new Point3D(1, 2, 3);
        //DemoMethod(person, pt3d);
        //Console.WriteLine($"Y coord: {pt3d.y}. Jay Z's age: {person.Age}");
        #endregion
        #region inheritance

        //Hunter h1 = new Hunter("Gaurav", "Dogra", "Nikon") { Age = 22 };
        //Hunter h2 = new Hunter("Goncalo", "Nunes", "Leica") { Age = 28 };
        //Console.WriteLine(h1.Age);
        //Console.WriteLine(h1.Shoot());

        //Console.WriteLine(h2.GetHashCode());
        //Console.WriteLine(h2.GetType());
        //Console.WriteLine(h2.Equals(h1));
        //Console.WriteLine(h2);

        //Object rec1 = new Rectangle(10, 10);
        //Object rec2 = new Rectangle(11, 2);
        //Object rec3 = new Rectangle(11, 2);

        //var arrRecs = new Object[] { rec1, rec2, rec3 };
        //foreach (var item in arrRecs)
        //{
        //    Console.WriteLine(item.ToString());
        //}
        #endregion

        #region polymorphism

        //List<Object> gameObjects = new List<Object>()
        //{
        //    new Person("Nish","Mandal"){ Age = 32},
        //    new Airplane(400,200, "Boeing"),
        //    new Vehicle(12,20),
        //    new Hunter("Hunter", "McHunty", "Pentax")
        //};
        //foreach (var gameObj in gameObjects)
        //{
        //    Console.WriteLine(gameObj);
        //}

        //Run time polymorphism (override). Method overloading is a type of compile rime polymorphism
        //Person yolanda = new Person("Yolanda", "Young");
        //SpartaWrite(yolanda);


        //var a = new Person("Nish", "Mandal") { Age = 32 };

        //var b = new Hunter("Hunter", "McHunty", "Pentax");
        //SpartaWrite(a);
        //var c = (Person)b;
        //SpartaWrite(c);
        //var x = "string";
        //var d = (Hunter)a;
        //SpartaWrite(d);

        //List<Person> gameObjects2 = new List<Person>()
        //{
        //    new Person("Nish","Mandal"){ Age = 32},
        //    new Hunter("Hunter", "McHunty", "Pentax")
        //};


        //var cathy = new Person("Cathy", "French");
        //var boeing = new Airplane(400, 200, "Boeing");
        //boeing.Ascend(30);
        //var vehicle = new Vehicle(12, 20);
        //var henry = new Hunter("Henry", "Hodgkins", "Pentax");

        //List<IMoveable> gameObjects3 = new List<IMoveable>()
        //         {
        //           cathy,
        //           boeing,
        //           vehicle,
        //           henry
        //         };

        //foreach (var item in gameObjects3)
        //{

        //    Console.WriteLine(item.Move());
        //}

        #endregion

        #region Polymorphic shootout
        //Console.WriteLine();
        //var theWeapons = new List<IShootable>();
        //theWeapons.Add(new WaterPistol("ToysRUs"));
        //theWeapons.Add(new LaserGun("Acme"));
        //theWeapons.Add(new Camera("Pentax"));
        //foreach (var w in theWeapons)
        //{
        //    Console.WriteLine(w.Shoot());
        //}

        //Console.WriteLine();

        //Console.WriteLine("Polymorphic shootout");
        //Camera pentax = new Camera("Pentax");
        WaterPistol pistol = new WaterPistol("Supersoaker");
        IShootable laserGun = new LaserGun("Acme");
        Hunter nish = new Hunter("Nish", "Mandal", laserGun);
        //MonsterHunter nishJr = new MonsterHunter("Nish Jr.", "Mandal", pentax);
        Console.WriteLine(laserGun.Shoot());


        //Console.WriteLine(nish.Shoot());
        //nish.Shooter = pistol;
        //Console.WriteLine(nish.Shoot());
        //nish.Shooter = laserGun;
        //Console.WriteLine(nish.Shoot());
        //nish.Shooter = pistol;
        //Console.WriteLine(nish.Shoot());
        //nish.Shooter = pentax;
        //Console.WriteLine(nish.Shoot());
        //Console.WriteLine(nishJr.Shoot());
        //nishJr.Shooter = laserGun;
        //Console.WriteLine(nishJr.Shoot());
        //nishJr.Shooter = null;
        //Console.WriteLine(nishJr.Shoot());
        #endregion



    }

    public static void SpartaWrite(Object obj)
    {
        Console.WriteLine(obj.ToString());
        if (obj is Hunter)
        {
            var hunterObj = (Hunter)obj;
            Console.WriteLine(hunterObj.Shoot());
        }
    }

    static void DemoMethod(Person p, Point3D pt)
    {
        pt.y = 1000;
        p.Age = 92;
    }
}
