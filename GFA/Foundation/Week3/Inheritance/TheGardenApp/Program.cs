using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week3.Inheritance.TheGardenApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Garden garden = new Garden();
            AddFlowers(garden);
            AddTrees(garden);
            WaterFlowers(garden);
            WaterTrees(garden);
        }
        public static void AddFlowers(Garden g)
        {
            g.flowers.Add(new Flower("yellow"));
            g.flowers.Add(new Flower("blue"));
        }

        public static void AddTrees(Garden g)
        {
            g.trees.Add(new Tree("purple"));
            g.trees.Add(new Tree("orange"));
        }

        public static void WaterFlowers(Garden g)
        {
            foreach (Flower flower in g.flowers)
            {
                flower.Water(40 / g.flowers.Count);
                Console.WriteLine(flower.ToString());
            }
        }

        public static void WaterTrees(Garden g)
        {
            foreach (Tree tree in g.trees)
            {
                tree.Water(40 / g.trees.Count);
                Console.WriteLine(tree.ToString());
            }
        }
    }
}
