namespace Multiples3sAnd5s
{
    internal class Challenge1_Multiple3sAnd5s
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; 3 * i < 1000; i++)
            {
                sum += 3 * i;

                if (5 * i < 1000 && (5 * i) % 3 != 0)
                {
                    sum += 5 * i;
                }
            }
            Console.WriteLine($"Multiples of 3 and 5 out of 1000 added together is {sum}.");
        }
    }
}