namespace IvanLesson;

internal class Program
{
    static void Main(string[] args)
    {
        // Output data

        // int number = 42;
        // Console.WriteLine("My number: " + number + ".");
        // Console.WriteLine("My number: {0}.", number);
        // Console.WriteLine($"My number: {number}.");

        // Console.WriteLine("Hello");

        // Input data

        // string name = Console.ReadLine();

        //int age = Convert.ToInt32(Console.ReadLine());

        /*int age;
        while (true)
        {
            try
            {
                age = Convert.ToInt32(Console.ReadLine());

                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/

        // int age = int.Parse(Console.ReadLine());

        int age;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out age))
            {
                break;
            }

            Console.WriteLine("ERROR");
        }

        Console.WriteLine($"My age: {age}.");
    }
}