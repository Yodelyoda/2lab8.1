package lab8;
import java.util.Scanner;
import java.lang.Math;

public class Alc_drinks extends Liquid 
{

	Scanner scan = new Scanner(System.in);
	private int  strength;
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
        this.strength = strength;
    }
    public char GetTemp()
    {
        return (char)this.strength;
    }
    public void SetTemp(char value)
    {
        this.strength = value;
    }
    protected void finalize()
    {
    	System.out.println("Destructor Was Called");
    }
    public void Read()
    {
    	System.out.println("density: ");
        int density = scan.nextInt();
        this.SetDensity(density);
        System.out.println("strength: ");
        this.strength = scan.nextInt();
    }
    public String ToString()
    {
        return "Cold_drinks[" + "liquid: " + "[density: " + this.GetDensity() 
            + "]" + " temp: " + this.strength + "]";
    }

}