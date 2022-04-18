using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public string TeamName { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }

        public Team(string creatorName, string teamName)
        {
            this.CreatorName = creatorName;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creatorName = line[0];
                string teamName = line[1];
                if (teams.Any(team1 => team1.CreatorName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                else if (teams.Any(team1 => team1.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    Team team = new Team(creatorName, teamName);
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.CreatorName}!");
                    teams.Add(team);
                }
            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] userWantTojoinAndTeam = input.Split("->");
                string userName = userWantTojoinAndTeam[0];
                string teamName = userWantTojoinAndTeam[1];

                if (!teams.Any(team1 => team1.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(team => team.Members.Contains(userName))
                    || teams.Any(team => team.CreatorName == userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    foreach (Team team in teams)
                    {
                        if (team.TeamName == teamName)
                        {
                            team.Members.Add(userName);
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            List<Team> teamsWithMembers = new List<Team>();
            List<Team> disbandTeams = new List<Team>();
            foreach (Team team in teams)
            {
                if (team.Members.Count == 0)
                {
                    disbandTeams.Add(team);
                }
                else
                {
                    teamsWithMembers.Add(team);
                }
            }

            teamsWithMembers = teamsWithMembers.OrderByDescending(team1 => team1.Members.Count).
                ThenBy(team1 => team1.TeamName).ToList();
            foreach (Team team in teamsWithMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");
                List<string> members = team.Members;
                foreach (string member in members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            disbandTeams = disbandTeams.OrderBy(team1 => team1.TeamName).ToList();
            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbandTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
