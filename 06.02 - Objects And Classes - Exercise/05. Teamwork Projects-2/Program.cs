using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects_2
{
    class Program
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-").ToArray();
                string creator = teamInfo[0];
                string teamName = teamInfo[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(creator, teamName);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                var info = command.Split("->").ToArray();
                string user = info[0];
                string searchedTeam = info[1];

                if (!teams.Any(x => x.TeamName == searchedTeam))
                {
                    Console.WriteLine($"Team {searchedTeam} does not exist!");
                    continue;
                }
                if (teams.Any(x => x.users.Contains(user)) || teams.Any(x => x.Creator == user && x.TeamName == searchedTeam))
                {
                    Console.WriteLine($"Member {user} cannot join team {searchedTeam}!");
                    continue;
                }

                int indexSearchedTeam = teams.FindIndex(t => t.TeamName == searchedTeam);

                teams[indexSearchedTeam].users.Add(user);
            }

            var teamsToBeDisbanded = teams
            .FindAll(x => x.users.Count == 0)
            .OrderBy(x => x.TeamName)
            .ToList();

            foreach (var team in teams.Where(x => x.users.Count > 0)
            .OrderByDescending(x => x.users.Count)
            .ThenBy(x => x.TeamName))
            {
                Console.WriteLine(team.ToString());
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToBeDisbanded)
            {
                Console.WriteLine(team.TeamName);
            }
        }
        public class Team
        {
            public string Creator { get; set; }
            public string TeamName { get; set; }
            public List<string> users { get; set; }
            public Team(string creator, string teamName)
            {
                this.Creator = creator;
                this.TeamName = teamName;
                users = new List<string>();
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(TeamName);
                sb.AppendLine("- " + Creator);

                foreach (var member in users.OrderBy(x => x))
                {
                    sb.AppendLine("-- " + member);
                }

                return sb.ToString().TrimEnd();
            }
        }
    }
}
