using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Building
    {
        string adress;
        double lenghtHouse;
        double widthHouse;
        double heightHouse;

        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }
        public double LenghtHouse
        {
            get
            {
                return lenghtHouse;
            }
            set
            {
                if (value < 0)
                {
                    lenghtHouse = 0;
                }
                else
                {
                    lenghtHouse = value;
                }
            }
        }
        public double WidthHouse
        {
            get
            {
                return widthHouse;
            }
            set
            {
                if (value < 0)
                {
                    widthHouse = 0;
                }
                else
                {
                    widthHouse = value;
                } 
            }
        }
        public double HeightHouse
        {
            get
            {
                return heightHouse;
            }
            set
            {
                if (value < 0)
                {
                    heightHouse = 0;
                }
                else
                {
                    heightHouse = value;
                } 
            }
        }
        public Building (string adress, double lenghtHouse, double widthHouse, double heightHouse)
        {
            this.Adress = adress;
            this.LenghtHouse = lenghtHouse;
            this.WidthHouse = widthHouse;
            this.HeightHouse = heightHouse;
        }

        public string GetPrint()
        {
            return $"Адрес здания: {adress} \nДлинна здания равна: {lenghtHouse} \nШирина здания равна: {widthHouse} \nВысота здания равна: {heightHouse}";
        }
    }
}
