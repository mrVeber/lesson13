using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
   sealed class MultiBuilding:Building
    {
        double numberOfStoreys;
        public double NumberOfStoreys
        {
            get
            {
                return numberOfStoreys;
            }
            set
            {
                if (value < 0)
                {
                    numberOfStoreys = 0;
                }
                else
                {
                    numberOfStoreys = value;
                }
            }
        }
        public MultiBuilding(string adress, double lenghtHouse, double widthHouse, double heightHouse, double numberOfStoreys)
            :base(adress, lenghtHouse, widthHouse, heightHouse)
        {
            this.NumberOfStoreys = numberOfStoreys;
        }

        public string GetPrint ()
        {
            return $"{base.GetPrint()} \nЭтажность здания равна: {numberOfStoreys}";
        }
    }
}
