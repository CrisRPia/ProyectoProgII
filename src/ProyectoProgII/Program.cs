namespace ProyectoProgII;

using Library;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Hice esto por testing, pueden eliminar todo lo de adentro de main.
        IEnumerable<int> a = 5.To(10).Where(i => i % 2 == 0);
        foreach (var i in a)
            Console.WriteLine(i);

        Console.WriteLine();

        a = from i in 5.To(10) where i % 2 == 0 select i;
        foreach (var i in a)
            Console.WriteLine(i);

        Console.WriteLine();

        foreach (double d in 0.1d.To(1.5, 0.1))
            Console.WriteLine(d);

        Console.WriteLine();

        foreach (char c in 'a'.To('d', (char)2))
            Console.WriteLine(c);
    }
}
