using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab8._1
{
    public class Cold_drinks : Liquid
        {
            private int temp;
            public Cold_drinks()
            {
                this.SetDensity(0);
                this.temp = 0;
            }
            public Cold_drinks(int density, int temp)
            {
                this.SetDensity(density);
                this.temp = temp;
            }
            public Cold_drinks(int temp)
            {
                this.SetDensity(0);
                this.temp = temp;
            }
          
            public Cold_drinks(Cold_drinks c_d)
            {
                this.SetDensity(c_d.GetDensity());
                this.temp = temp;
            }
            public char GetTemp()
            {
                return (char)this.temp;
            }
            public void SetTemp(char value)
            {
                this.temp = value;
            }
            ~Cold_drinks()
            {
                Console.WriteLine("Destructor Was Called");
            }
            public void Read()
            {
                Console.WriteLine("density: ");
                int density = Convert.ToInt32(Console.ReadLine());
                this.SetDensity(density);
                Console.WriteLine("temp: ");
                this.temp = Convert.ToInt32(Console.ReadLine());
            }
            public override string ToString()
            {
                return "Cold_drinks[" + "liquid: " + "[density: " + this.GetDensity()
                    + "]" + " temp: " + this.temp + "]";
            }

    }
}



