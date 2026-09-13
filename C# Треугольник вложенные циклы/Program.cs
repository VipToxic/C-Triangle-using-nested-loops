namespace C__Треугольник_вложенные_циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\t");

            for (int i = 10; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("& ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\t");


            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\t");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("% ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
