package lab8;
import java.util.Scanner;
import java.lang.Math;

public class Program
{

	public static void main(String[] args) 
	{
		Liquid a = new Liquid();
		System.out.println("Drink a: " + a.ToString());
		System.out.println("-------------------------");
		Alc_drinks b = new Alc_drinks(3,  100);
        System.out.println("Alc_drinks b: " + b.ToString());
        System.out.println("Please enter some changes to Alc_drinks b: ");
        b.Read();
        System.out.println("Changed Alc_drinks b :" + b.ToString());
        System.out.println("-------------------------");
        Cold_drinks c = new Cold_drinks(2, 40);
        System.out.println("Cold_drinks c: " + c.toString());
        System.out.println("-------------------------");

	}

}
