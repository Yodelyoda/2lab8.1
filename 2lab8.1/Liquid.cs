using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab8._1
{

    public class Liquid
    {
        private int density; //густинa

        public Liquid()
        {
            this.density = 0;
        }
        public Liquid(int density)
        {
            this.density = density;
        }
        public Liquid(Liquid p)
        {
            this.density = p.density;
        }
        public int GetDensity()
        {
            return this.density;
        }
        public void SetDensity(int value)
        {
            this.density = value;
        }
        ~Liquid()
        {
            Console.WriteLine("Destructor Was Called");
        }
        public void Read()
        {
            Console.WriteLine("denisty: ");
            this.density = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Liquid[" + "density: " + this.density + "]";
        }
    }
}
