package lab8;
import java.util.Scanner;
import java.lang.Math;

public class Cold_drinks extends Liquid 
{

	Scanner scan = new Scanner(System.in);
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
    protected void finalize()
    {
    	System.out.println("Destructor Was Called");
    }
    public void Read()
    {
    	System.out.println("density: ");
        int density = scan.nextInt();
        this.SetDensity(density);
        System.out.println("temp: ");
        this.temp = scan.nextInt();
    }
    public String ToString()
    {
        return "Cold_drinks[" + "liquid: " + "[density: " + this.GetDensity() 
            + "]" + " temp: " + this.temp + "]";
    }
}


