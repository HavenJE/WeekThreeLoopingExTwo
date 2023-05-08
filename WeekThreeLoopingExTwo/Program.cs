

// Exercise 2 - Write an application named SumInts that allows the user to enter any number of integers continuously until the user enters 999.
// Display the sum of the values entered not including 999.

class SumInts
{
    static void Main()
    {
        int count = 0;
        int num;
        int sum = 0;

        Console.WriteLine("Enter an integer below: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 999)
        {
            Console.WriteLine("Enter another integer below: ");
            num = Convert.ToInt32(Console.ReadLine());
            sum += num;
            count++;
            // Console.WriteLine("The sum is: {0}", sum);
        }
        Console.WriteLine("Ooh! you entered 999. The sum is: {0}", sum);
    }
}