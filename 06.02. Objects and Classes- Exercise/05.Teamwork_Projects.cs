using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;


namespace SoftUni
{
    class Team
    {   
        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int CountOfTheTeams = int.Parse(Console.ReadLine());
            var teams = new List<Team>();
            for (int i = 0; i < CountOfTheTeams; i++)
            {
                string[] info = Console.ReadLine().Split("-");
                string creator = info[0];
                string teamName = info[1];
                if(teams.Any(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if(teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team();
                    {
                        team.Creator = info[0];
                        team.Name = info[1];
                        team.Members = new List<string>();
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                }
            }
            string line = Console.ReadLine();
            while (line != "end of assignment")
            {

                var user = line.Split(new string[] {"->"}, StringSplitOptions.None)[0];
                var teamToJoin = line.Split(new string[] {"->"}, StringSplitOptions.None)[1];
                if (!teams.Any(team => team.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(team => team.Members.Contains(user) || teams.Any(team => team.Creator == user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }
                else
                {
                    var currentTeam = teams.First(team => team.Name == teamToJoin);
                    currentTeam.Members.Add(user);
                }
                line = Console.ReadLine();
            }
            var finalTeams = teams.Where(team => team.Members.Count > 0);
            var disbandedTeams = teams.Where(team => team.Members.Count == 0);
            foreach (Team team in teams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine($"Teams to disband: ");
            if(disbandedTeams != null)
            {
                foreach (Team disbandedTeam in disbandedTeams.OrderBy(team => team.Name))
                {
                    Console.WriteLine($"{disbandedTeam.Name}");
                }
            }
        }
    }
}
