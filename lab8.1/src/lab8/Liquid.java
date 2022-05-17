package lab8;
import java.util.Scanner;
import java.lang.Math;

public class Liquid 
{
	Scanner scan = new Scanner(System.in);

	private int density; 

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
        protected void finalize()
        {
        	System.out.println("Destructor Was Called");
        }

        public void Read()
        {
        	System.out.println("denisty: ");
            this.density = scan.nextInt();
        }
        public String ToString()
        {
            return "Liquid[" + "density: " + this.density + "]";
        }
}
