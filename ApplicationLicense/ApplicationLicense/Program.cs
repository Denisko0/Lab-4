namespace Program;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please, type license key to get access: ");
        var key = Console.ReadLine();

        var license = new ApplicationLicense(key);


        if (license.AccessLevel >= (int)ApplicationLicense.AccessLevels.Free)
        {
            Console.WriteLine("Free tools are available");
        }

        if (license.AccessLevel >= (int)ApplicationLicense.AccessLevels.Trial)
        {
            Console.WriteLine("Trial tools are available");
        }

        if (license.AccessLevel >= (int)ApplicationLicense.AccessLevels.Pro)
        {
            Console.WriteLine("Pro tools are available");
        }

    }
}
