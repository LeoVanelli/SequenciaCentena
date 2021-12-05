using System;

namespace SequenciaCentena
{
    class Program
    {
        static void Main(string[] args)
        {
            int _numeroNatural = default;
            string _cadeiaNumeros = default;

            Console.WriteLine("------ Sequência Centena ------\n");

            while(_numeroNatural != 100)
            {
                _numeroNatural ++;
                _cadeiaNumeros += $" {_numeroNatural}";
            }

            Console.WriteLine("{0}",_cadeiaNumeros);
        }
    }
}
