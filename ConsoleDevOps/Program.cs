using Hjalmer;

namespace ConsoleDevOps;

public class Program
{
    static void Main(string[] args)
    {
        bool goon = true;
        Console.WriteLine("Hello, World!");
        while (goon)
        {
            Console.WriteLine("Letter counter:");
            string? usrInput = Console.ReadLine();
            if (usrInput != null)
            {
                Console.WriteLine(usrInput.Length);
            }
            usrInput = Console.ReadLine();
            if (usrInput != null && usrInput.ToLower().Equals("y") || usrInput != null && usrInput.ToLower().Equals("yes"))
            {
                goon = false;
                if(goon == false)
                {
                    goon = true;
                }
                //Vigtig kommentar
                //Vigtig kommentar 2
            }
        }
    }
    public static int PlusNumbers()
    {
        Numbers nums = new Numbers();
        return nums.GetNine() + nums.GetTen();
    }
}
