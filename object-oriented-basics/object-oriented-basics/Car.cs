using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_basics
{
    class Car
    {
        private string _make;
        private decimal _speed;

        public string Make
        {
            get
            {
                return _make;
            }
        }

        public decimal Speed
        {
            get
            {
                return _speed;
            }
        }

        public Car()
        {
            _make = "Ford";
            _speed = 80;
        }

        public Car(string make, decimal speed)
        {
            _make = make;
            _speed = speed;
        }

        public string ShowInformation()
        {
            return String.Format("\nMake: {0}\nCurrent speed: {1} km/h", _make, _speed);
        }

        public void Accelerate(decimal increase)
        {
            _speed += increase;
        }

        public void Decelerate()
        {
            _speed *= (decimal)0.9;
        }
    }
}
