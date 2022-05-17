using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab8._1
{
    public class Alc_drinks : Liquid
    {
        private int strength;
        public Alc_drinks()
        {
            this.SetDensity(0);
            this.strength = 0;
        }
        public Alc_drinks(int density, int strength)
        {
            this.SetDensity(density);
            this.strength = strength;
        }

        public Alc_drinks(int strength)
        {
            this.SetDensity(0);
            this.strength = strength;
        }
        
        public Alc_drinks(Alc_drinks c_d)
        {
            this.SetDensity(c_d.GetDensity());
            this.strength = c_d.strength;
        }
        public int GetStrength()
        {
            return this.strength;
        }
        public void SetTup(int value)
        {
            this.strength = value;
        }
        ~Alc_drinks()
        {
            Console.WriteLine("Destructor Was Called");
        }
        public void Read()
        {
            Console.WriteLine("density: ");
            int density = Convert.ToInt32(Console.ReadLine());
            this.SetDensity(density);
            Console.WriteLine("strength: ");
            this.strength = Convert.ToInt32 (Console.ReadLine());
        }
        public override string ToString()
        {
            return "Color_Dot[" + "liquid: " + "[density: " + this.GetDensity() +
            "]" + " strength: " + this.strength + "]";
        }
    }
}

