using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    public class BlackPearl
    {
//----------- Attributes -----------

        private List<Pirate> crew;
        private CaptainJackSparrow? JackSparrow;

//----------- Constructor -----------

        public BlackPearl()
        {
            this.crew = new List<Pirate>();
            this.JackSparrow = null;
        }

//----------- Methods -----------
        public bool addPirate(Pirate pirate)
        {
            if (pirate is CaptainJackSparrow && this.JackSparrow != null)
            {
                return false; // Because Captain Jack Sparrow is only one!
            }
            this.crew.Add(pirate);
            if (pirate is CaptainJackSparrow)
            {
                this.JackSparrow = (CaptainJackSparrow) pirate;
            }
            return true;
        }

        public int getCrewSize()
        {
            return this.crew.Count;
        }

        public List<string> getPoorPirates()
        {
            List<string> poorPirates = new List<string>();
            foreach (Pirate pirate in this.crew)
            {
                if (pirate.isPoor())
                {
                    poorPirates.Add(pirate.getName());
                }
            }
            return poorPirates;
        }

        public int getTotalGold()
        {
            int totalGold = 0;
            foreach (Pirate pirate in this.crew)
            {
                totalGold += pirate.getGoldAmount();
            }
            return totalGold;
        }

        public void lastDayOnTheShip()
        {
            foreach (Pirate pirate in this.crew)
            {
                pirate.party();
            }
        }

        public void prepareForBattle()
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (Pirate pirate in this.crew)
                {
                    pirate.work();
                }
            }
            this.lastDayOnTheShip();
        }
    }
}

























































































































































































































































































// Created by Michalis Karatsioris