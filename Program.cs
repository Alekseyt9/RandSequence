namespace RandSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var old = true;
            var max = 0;
            var oldMax = 0;
            long count = 0;

            while (true)
            {
                count++;
                var now = rand.Next(2) == 1;
                if (old == now)
                {
                    max++;
                }
                else
                {
                    if (max > oldMax)
                    {
                        oldMax = max;
                        Console.WriteLine($"max: {max} count:{count}");
                    }
                    max = 0;
                }
                old = now;
            }

        }

    }
}