// See https://aka.ms/new-console-template for more information
class Program
{

    static void Main(string[] args)
    {

        var a = 17;
        var b = 4;

        var quotient = a / b;
        var remainder = a % b;



        Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

        AreaOfCircle();

        

    }
  public static void AreaOfCircle()
    {
        Console.WriteLine("What is the radius of your circle");


        var radius = double.Parse(Console.ReadLine());

        var pi= Math.PI;

       var AreaofCircle= pi*(radius * radius);

        Console.WriteLine($" The area of a cirlce with a radius of {radius} is {AreaofCircle}");



    }

}