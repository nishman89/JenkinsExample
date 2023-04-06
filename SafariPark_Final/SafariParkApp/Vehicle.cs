using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        public int Speed { get; init; } = 10;
        private int _numPassengers;
        public int Position { get; private set; }
        public int NumPassengers
        {
            get => _numPassengers;
            set => _numPassengers = value >= 0 && value <= _capacity ? value
                    : value > _capacity ? _capacity : _numPassengers;
        }

        public Vehicle() { }


        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }

        public virtual string Move(int times)
        {
            Position += Speed * times;
            return $"Moving along {times} times";
        }
        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public override string ToString() => base.ToString() + $" capacity: {_capacity} passengers: {_numPassengers} speed: {Speed} position: { Position}";
    }
}
