namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta Valik:");
            Console.WriteLine("1 CarsSwitch, 2 SportSwitch, 3 TeamSwitch");

            string meetod = Console.ReadLine();
            int number = Convert.ToInt32(meetod);

            if (number == 1)
            {
                CarsSwitch();
            }
            else if (number == 2)
            {
                SportSwitch();
            }
            else if (number == 3)
            {
                TeamSwitch();
            }
            else
            {
                Console.WriteLine("Vale Valik");
            }
        }
        static void CarsSwitch()
        {
            Console.WriteLine("Choose Your Car");
            Console.WriteLine("Dodge Hellcat, Chevrolet Corvette, Jeep Trackhawk, Dodge Durango");
            Console.WriteLine("-------------------------------------------------");

            string car = Console.ReadLine();
            switch (car)
            {
                case "hellcat":
                    Console.WriteLine("----Hellcat, 100000$----");
                    break;

                case "corvette":
                    Console.WriteLine("----Corvette, 60000$----");
                    break;

                case "trackhawk":
                    Console.WriteLine("----Trackhawk, 80000$----");
                    break;

                case "durango":
                    Console.WriteLine("----Durango, 110000$----");
                    break;

                default:
                    Console.WriteLine("----Didnt Choose Car----");
                    break;
            }
        }
        static void SportSwitch()
        {
            Console.WriteLine("Choose ur Favorite Player");
            Console.WriteLine("Lebron, Jordan, Kobe, Ben Simmons");
            Console.WriteLine("-------------------------------------------------");

            string player = Console.ReadLine();
            switch (player)
            {
                case "Lebron":
                    Console.WriteLine("----You Picked Lebron As Your Favorite Player----");
                    break;

                case "Jordan":
                    Console.WriteLine("----You Picked Jordan As Your Favorite Player----");
                    break;

                case "Kobe":
                    Console.WriteLine("----You Picked Kobe As Your Favorite Player----");
                    break;

                case "Ben Simmons":
                    Console.WriteLine("----If You Picked Ben Simmons, You Are K9----");
                    break;

                default:
                    Console.WriteLine("----Didnt Choose Player----");
                    break;
            }
        }
        static void TeamSwitch()
        {
            Console.WriteLine("Choose Your Favorite Team");
            Console.WriteLine("TimberWolves, Lakers, Heat, Clippers");
            Console.WriteLine("-------------------------------------------------");

            string team = Console.ReadLine();
            switch (team)
            {
                case "TimberWolves":
                    Console.WriteLine("-----You Picked TimberWolves As Your Favorite Team-----");
                    break;

                case "Lakers":
                    Console.WriteLine("-----You Picked Lakers As Your Favorite Team-----");
                    break;

                case "Heat":
                    Console.WriteLine("-----You Picked Heat As Your Favorite Team-----");
                    break;

                case "Clippers":
                    Console.WriteLine("-----You Picked Clippers As Your Favorite Team-----");
                    break;

                default:
                    Console.WriteLine("-----Didnt Choose Team-----");
                    break;
            }
        }
    }
}
