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
            string usrInput = Console.ReadLine();
            Console.WriteLine(usrInput.Length);
            Console.WriteLine("Quit?");
            usrInput = Console.ReadLine();
            if (usrInput.ToLower().Equals("y") || usrInput.ToLower().Equals("yes") && usrInput != null)
            {
                goon = false;
                if(goon = false)
                {
                    goon = true;
                }
            }

        }
    }
}
