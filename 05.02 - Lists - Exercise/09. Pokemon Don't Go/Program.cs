using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main()
        {
            List<int> pokemonsDistances = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            while (pokemonsDistances.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int value = 0;

                if (index < 0)
                {
                    value = pokemonsDistances[0];
                    sum += value;
                    pokemonsDistances[0] = pokemonsDistances[pokemonsDistances.Count - 1];
                    //pokemonsDistances.RemoveAt(0);

                }
                else if (index > pokemonsDistances.Count - 1)
                {
                    value = pokemonsDistances[pokemonsDistances.Count - 1];
                    sum += value;
                    pokemonsDistances[pokemonsDistances.Count - 1] = pokemonsDistances[0];
                    //pokemonsDistances.RemoveAt(pokemonsDistances.Count - 1);

                }
                else
                {
                    value = pokemonsDistances[index];
                    pokemonsDistances.RemoveAt(index);
                    sum += value;
                }

                for (int i = 0; i < pokemonsDistances.Count; i++)
                {
                    if (pokemonsDistances[i] <= value)
                    {
                        pokemonsDistances[i] += value;
                    }
                    else
                    {
                        pokemonsDistances[i] -= value;
                    }
                }

            }

            Console.WriteLine(sum);
        }
    }
}
