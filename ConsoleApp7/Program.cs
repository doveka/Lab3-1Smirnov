class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите число B: ");
        int B = int.Parse(Console.ReadLine());

        int N = 0;

        Console.WriteLine("Числа, расположенные между A и B:");

        for (int i = A; i <= B; i++)
        {
            Console.Write(i + " ");
            N++;
        }

        Console.WriteLine("\nКоличество чисел: " + N);
    }
}