using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.IO;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<dynamic> teams = new List<dynamic>();


            for (int i = 0; i < teamsCount; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-");
                string creator = teamInfo[0];
                string teamName = teamInfo[1];

                if (!teams.Exists(t => t.TeamName == teamName) &&
                    !teams.Exists(t => t.Creator == creator))
                {
                    dynamic team = new ExpandoObject();
                    team.Creator = creator;
                    team.TeamName = teamName;
                    team.User = "";
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                else if (teams.Exists(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team { teamName} was already created!");
                }
                else
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }

            string[] commands = Console.ReadLine().Split("->");


            while (commands[0] != "end of assignment")
            {
               
                string user = commands[0];
                string searchedTeam = commands[1];
                //var currTeam = teams.Exists(t => t.TeamName == searchedTeam);


                if (teams.Exists(t => t.TeamName == searchedTeam) &&
                    !teams.Exists(u => u.User == user))
                {
                    var teamToJoin = teams.Find(t => t.TeamName == searchedTeam);
                    teamToJoin.User = user;

                    DynamicObject.AddProperty(team);

                }
                else if (!teams.Exists(t => t.TeamName == searchedTeam))
                {
                    Console.WriteLine($"Team {searchedTeam} does not exist!");
                }
                else
                {
                    Console.WriteLine($"Member {user} cannot join team {searchedTeam}!");
                }

                commands = Console.ReadLine().Split("->");
            }

            //var disbandTeams = teams.FindAll();
        }
        //class Team 
        //{
        //    public string Creator { get; set; }
        //    public string TeamName { get; set; }
        //    public string User { get; set; }

        //    //public Team(string creator, string teamName)
        //    //{
        //    //    this.Creator = creator;
        //    //    this.TeamName = teamName;
        //    //}

        //    //public Team(string user)
        //    //{
        //    //    User = user;
        //    //}
        //}

        class DynamicObject 
        {
            public string Creator { get; set; }
            public string TeamName { get; set; }
            public string User { get; set; }

            public DynamicObject  (string creator, string teamName)
            {
                Creator = creator;
                TeamName = teamName;
            }

            public static void AddProperty(ExpandoObject team) 
            {
                string propertyName = "User";

                var expandoDict = team as IDictionary<string, object>;
                    expandoDict.Add(propertyName, null);
            }
        }
    }
}
