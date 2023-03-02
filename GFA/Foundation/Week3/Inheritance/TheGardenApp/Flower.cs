using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week3.Inheritance.TheGardenApp
{
    class Flower
    {

        private string _color;
        private double _waterLevel;

        public Flower()
        {
            _color = "multicolored";
        }

        public Flower(string color)
        {
            _color = color;
        }

        public void Water(int amountOfWater)
        {
            _waterLevel += amountOfWater * 0.75;
        }

        public override string ToString()
        {
            if (_waterLevel < 5)
            {
                return $"The {_color} flower needs water.";
            }
            else
            {
                return $"The {_color} flower doesn't need water.";
            }
        }
    }
}
