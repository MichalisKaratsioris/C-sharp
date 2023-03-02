/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week3.ClassesObjects
{
    class Dominoes
    {
        public static void Main(string[] args)
        {
            List<Domino> dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            List<Domino> snake = OrderDominoes(dominoes);
            foreach (Domino domino in snake)
            {
                Console.Write($"[{domino.GetValues()[0]}, {domino.GetValues()[1]}]");
            }
        }

        public static List<Domino> InitializeDominoes()
        {
            List<Domino> dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }

        public static List<Domino> OrderDominoes(List<Domino> l)
        {
            List<Domino> snakeDomino = new List<Domino>();
            snakeDomino.Add(l[0]);

            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (snakeDomino[i].GetValues()[1] == l[j].GetValues()[0])
                    {
                        snakeDomino.Add(l[j]);
                    }
                }
            }
            return snakeDomino;
        }

    }
}
*/