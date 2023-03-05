using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    public class Pirate
    {
//----------- Attributes -----------

        public string name;
        public int goldAmount;
        public int healthPoints;
        public bool hasWoodenLeg;

//----------- Constructor -----------
        public Pirate(string name)
        {
            this.name = name;
            this.goldAmount = 0;
            this.healthPoints = 20;
            this.hasWoodenLeg = false;
        }

//----------- Methods -----------
        public int getGoldAmount()
        {
            return this.goldAmount;
        }

        public string getName()
        {
            return this.name;
        }

        public bool isPoor()
        {
            return this.hasWoodenLeg && this.goldAmount < 15;
        }

        public override string ToString()
        {
            if (this.hasWoodenLeg)
            {
                return $"Hello, I'm {this.name}. I have a wooden leg and {this.goldAmount} amount of gold.";
            }
            else
            {
                return $"Hello, I'm {this.name}. I still have my real legs and {this.goldAmount} amount of gold.";
            }
        }

// Virtual Methods because will be overriden by the Captain Class
        public virtual void work()
        {
            this.goldAmount++;
            this.healthPoints--;
        }

        public virtual void party()
        {
            this.healthPoints++;
        }
    }
}













































































































































































































































































































// Created by Michalis Karatsioris