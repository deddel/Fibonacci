internal class Program
{
    private static void Main(string[] args)
    {
        //Get the length of the Fibonacci sequence
        Console.Write("Enter the desired length of the Fibonacci sequence: ");
        int num = Convert.ToInt32(Console.ReadLine());

        //Loop the sequence positions and calculate the values
        for (int i = 0; i < num; i++)
        {
            Console.Write(" " + Fibonacci(i));
        }

        Console.WriteLine();

        static int Fibonacci(int n)
        {
            // A number in the sequence is the sum of the two previous numbers.
            // Sequence: 0 1 1 2 3 5 8 13 21 ..
            // Ex. 5th number n=4 F(4) = F(3)+F(2)                =
            //                           F(2)+F(1)+F(1)+F(0)      =
            //                           F(1)+F(0)+F(1)+F(1)+F(0) =
            // F(1)=1, F(0)=0            1+0+1+1+0                = 3

            if (n <= 1)
                return n; //base cases F(0)=0, F(1)=1
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

        }
    }
}