using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week3.Inheritance.TheGardenApp
{
    class Tree
    {
        private string _color;
        private double _waterLevel;

        public Tree()
        {
            _color = "multicolored";
        }

        public Tree(string color)
        {
            _color = color;
        }

        public void Water(int amountOfWater)
        {
            _waterLevel += amountOfWater * 0.4;
        }

        public override string ToString()
        {
            if (_waterLevel < 10)
            {
                return $"The {_color} tree needs water.";
            }
            else
            {
                return $"The {_color} tree doesn't need water.";
            }
        }
    }
}
