using System;

namespace Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double neededExp = double.Parse(Console.ReadLine());
            int countOFBattles = int.Parse(Console.ReadLine());

            double exp = 0;
            int battles = 0;
            for (int currBattle = 1; currBattle <= countOFBattles; currBattle++)
            {
                battles++;
                int currExp = int.Parse(Console.ReadLine());
                if (currBattle % 3 == 0)
                {
                    exp += currExp + currExp * 0.15;
                    if (exp >= neededExp)
                    {
                        break;
                    }
                    continue;
                }

                if(currBattle % 5 == 0)
                {
                    exp += currExp - currExp * 0.10;
                    if (currBattle % 15 == 0)
                    {
                        exp += currExp + currExp * 0.5;

                    }
                    if (exp >= neededExp)
                    {
                        break;
                    }
                    continue;
                }

                exp += currExp;
                if (exp >= neededExp)
                {
                    break;
                }
            }

            if (exp >= neededExp)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battles} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExp - exp:f2} more needed.");
            }
        }
    }
}
