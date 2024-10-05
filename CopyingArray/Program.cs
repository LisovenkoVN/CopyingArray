namespace CopyingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] Array1 = new int[10], Array2 = new int[10];
            int ArrayLenght = 10;

            for (int i = 0; i < ArrayLenght; i++)
            {
                Array1[i] = rnd.Next(0, 999999);
            }

            foreach (int item in Array1)
            {
                int i = Array.IndexOf(Array1, item);
                Array2[i] = item;
            }

            Console.WriteLine("Массив 1:");
            foreach (int item in Array1)
                Console.Write(item + "  ");
            Console.WriteLine("\n");
            Console.WriteLine("Массив 2:");
            foreach (int item in Array2)
                Console.Write(item + "  ");

            Console.ReadLine();
        }
    }
}
