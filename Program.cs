//Escribir un programa que lea números enteros indefinidamente hasta que llegue el número 0
internal class Program
{
    private static void Main(string[] args)
    {
        int num = 1;

        while(num != 0)
        {
        Console.WriteLine("Digite un número");
        num = int.Parse(Console.ReadLine());
 
        }
        Console.WriteLine("Finalizado");
    }
}