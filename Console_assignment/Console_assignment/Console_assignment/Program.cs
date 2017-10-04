//comment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Team //parent team class
{
    public Team()
    {
    }
    public string name;
    public int wins;
    public int loss;

}

public class SoccerTeam : Team //child soccerteam class
{
    public SoccerTeam()
    {
    }
    public int draw;
    public int goalsFor;
    public int goalsAgainst;
    public int differential;
    public int points;
}

public class Game//unused game class
{
    public Game()
    {
    }

    public int home_score;
    public int opp_score;

}


namespace Console_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool baddata = false;//bool used to check for invalid input

            do//runs the program at least once
            {

                try//used to check for invalid input
                {
                    int num_teams = 0;

                    List<SoccerTeam> l_team = new List<SoccerTeam>();//creates list of object soccer team

                    Console.Write("How many teams? ");


                    num_teams = Convert.ToInt32(Console.ReadLine());//stores user input in varable 

                    Console.Write("\n\n");//spacing

                    int icount;

                    string UppercaseFirst(string s)
                    {
                        // Check for empty string.
                        if (string.IsNullOrEmpty(s))
                        {
                            return string.Empty;
                        }
                        // Return char and concat substring.
                        return char.ToUpper(s[0]) + s.Substring(1);
                    }


                    for (icount = 0; icount < num_teams; icount++)//loops through the number of teams
                    {
                        SoccerTeam soccer_team = new SoccerTeam();//creates new soccerteam object
                        l_team.Add(soccer_team);//adds the soccer team object to list

                        int icount2 = icount + 1;
                        Console.Write("Enter Team " + icount2 + "'s name: ");
                        string user_name = Console.ReadLine();//asks and stores team name
                        Console.Write("\n");
                        soccer_team.name = UppercaseFirst(user_name);//stores in the name in the object while using uppercase method
                        Console.Write("Enter " + soccer_team.name + "'s points: ");

                        soccer_team.points = Convert.ToInt32(Console.ReadLine());// converts int to string

                        Console.Write("\n\n");                    

                    }

                    List<SoccerTeam> sortedTeams = l_team.OrderByDescending(team => team.points).ToList();//creates new list for sorting

                    Console.Write("Here is the sorted list:");//prints out headings
                    Console.Write("\n\n");                
                    Console.Write(("Position").PadRight(25, ' '));
                    Console.Write(("Name").PadRight(25, ' '));
                    Console.Write(("Points").PadRight(25, ' '));
                    Console.Write("\n");
                    Console.Write(("--------").PadRight(25, ' '));
                    Console.Write(("----").PadRight(25, ' '));
                    Console.Write(("------").PadRight(25, ' '));
                    Console.Write("\n");

                    for (icount = 0; icount < num_teams; icount++)//loops through the sorted list
                    {
                        int ipos = icount + 1;
                        Console.Write(Convert.ToString(ipos).PadRight(25, ' '));//prints out position number
                        Console.Write(Convert.ToString(sortedTeams[icount].name).PadRight(25, ' '));//prints out name
                        Console.Write(Convert.ToString(sortedTeams[icount].points).PadRight(25, ' ') + "\n");//prints out points

                    }

                }
                catch//what happens when input is invalid
                {
                    Console.Write("Try Again\n\n");//message happens when input is invalid
                    baddata = true;//forces loop to continue
                }
            } while (baddata);
            Console.ReadKey(true);//pauses screen
        }
    }
}
