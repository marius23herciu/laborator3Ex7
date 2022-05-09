using System;

namespace laborator3Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se citesc doua numere de la tastatura. Scrieti un program care va
            //calcula cel mai mare divizor comun al numerelor

            Console.WriteLine("Introduceti 2 numere:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int divizor = MaxDivizorComun(a, b);
            Console.WriteLine("Cel mai mare divizor comun este " + divizor);
        }

        static int MaxDivizorComun(int a, int b)
        {
            int divizor;

            if (a == b)
            {
                divizor = a;
                return divizor;
            }

            divizor = Math.Min(a, b);
            for (int i = 0; i < Math.Min(a, b); i++)
            {
                if (Math.Max(a,b) % divizor == 0 && Math.Min(a,b) % divizor == 0)
                {
                    break;
                }
                divizor--;
            }

            return divizor;
        }
    }
}
