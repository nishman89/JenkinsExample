using System;

namespace SafariParkApp
{
    public class Hunter : Person
    {
        private IShootable _shooter;
        public IShootable Shooter
        {
            get => _shooter;
            set => _shooter = value is Person ? throw new Exception("Can't have person type as shooter") : value;
        }
        public Hunter() { }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }
        public string Shoot()
        {
            var msg = FullName;
            return Shooter == null ? " doesn't have a shooter" : msg += $": { Shooter.Shoot()}";
        }

        public sealed override string ToString()
        {
            return $"{base.ToString()} Camera: {_shooter}";
        }

    }

    public class MonsterHunter : Hunter
    {

        public MonsterHunter(string fName, string lName, IShootable shooter) : base(fName, lName, shooter) { }

        public  string Shoot()
        {
            var msg = $"{FullName}, the Monster Hunter,";
            return Shooter is null ? msg += " doesn't have a shooter" : msg += $": { Shooter.Shoot()}"; ;
        }
    }
}
