namespace ProyectoProgII;

using Library;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> a = 5.To(10).Where(i => i % 2 == 0);
        foreach (var i in a)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        a = from i in 5.To(10) where i % 2 == 0 select i;
        foreach (var i in a)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        foreach (char c in 'a'.To('d'))
        {
            Console.WriteLine(c);
        }
    }
}
