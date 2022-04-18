using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonPower = int.Parse(Console.ReadLine());
            int startingPokemonPower = pokemonPower;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokedTargetsCount = 0;

            while (distance <= pokemonPower)
            {
                pokemonPower -= distance;
                pokedTargetsCount++;
                if (startingPokemonPower * 0.5 == pokemonPower && exhaustionFactor > 0)
                {
                    pokemonPower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokemonPower);
            Console.WriteLine(pokedTargetsCount);
        }
    }
}
