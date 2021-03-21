using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MOBAChallenger
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, Dictionary<string, int>> playersPositions = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] inputData = input.Split(new[] { " -> ", " vs " }, StringSplitOptions.None);

                if (inputData.Length == 3)
                {
                    string player = inputData[0];
                    string position = inputData[1];
                    int skills = int.Parse(inputData[2]);

                    if (!playersPositions.ContainsKey(player))
                    {
                        playersPositions.Add(player, new Dictionary<string, int>());
                        playersPositions[player].Add(position, skills);
                    }
                    else
                    {
                        if (!playersPositions[player].ContainsKey(position))
                        {
                            playersPositions[player].Add(position, skills);
                        }
                        else if (playersPositions[player][position] < skills)
                        {
                            playersPositions[player][position] = skills;
                        }
                    }
                }
                else
                {
                    string playerOne = inputData[0];
                    string playerTwo = inputData[1];

                    if (playersPositions.ContainsKey(playerOne) && playersPositions.ContainsKey(playerTwo))
                    {
                        foreach (var positionOne in playersPositions[playerOne].Keys)
                        {
                            if (playersPositions[playerTwo].ContainsKey(positionOne))
                            {
                                int playerOneTotalPoints = playersPositions[playerOne].Values.Sum();
                                int playerTwoTotalPoints = playersPositions[playerTwo].Values.Sum();

                                if (playerOneTotalPoints < playerTwoTotalPoints)
                                {
                                    playersPositions.Remove(playerOne);
                                    break;
                                }
                                else
                                {
                                    playersPositions.Remove(playerTwo);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            foreach (var player in playersPositions.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
