using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> members = new HashSet<string>();
            List<string> vipMembers = new List<string>();
            List<string> reservation = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "PARTY")
            {
                members.Add(command);

                if (char.IsDigit(command[0]))
                {
                    vipMembers.Add(command);
                }
                else
                {
                    reservation.Add(command);
                }
            }


            while ((command = Console.ReadLine()) != "END")
            {
                members.Remove(command);
                if (char.IsDigit(command[0]))
                {
                    vipMembers.Remove(command);
                }
                else
                {
                    reservation.Remove(command);
                }
            }

            Console.WriteLine(members.Count);
            foreach (var vip in vipMembers)
            {
                Console.WriteLine(vip);
            }

            foreach (var member in reservation)
            {
                Console.WriteLine(member);
            }
        }
    }

}


