using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _03
{
    class Program
    {
        static void Main()
        {
            int piecesNumber = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, string>> piecesCollections = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> composers = new Dictionary<string, string>();

            for (int piece = 0; piece < piecesNumber; piece++)
            {
                string[] currPieceInfo = Console.ReadLine().Split('|');
                string pieceName = currPieceInfo[0];
                string composer = currPieceInfo[1];
                string key = currPieceInfo[2];

                piecesCollections.Add(pieceName, new Dictionary<string, string>());
                piecesCollections[pieceName].Add(key, composer);

                composers.Add(pieceName, composer);
            }

            string commands;

            while ((commands = Console.ReadLine()) != "Stop")
            {
                string mainCommand = commands.Split("|")[0];

                switch (mainCommand)
                {
                    case "Add":
                        string pieceName = commands.Split("|")[1];
                        string composer = commands.Split("|")[2];
                        string key = commands.Split("|")[3];

                        if (piecesCollections.ContainsKey(pieceName))
                        {
                            Console.WriteLine($"{pieceName} is already in the collection!");
                        }
                        else
                        {
                            piecesCollections.Add(pieceName, new Dictionary<string, string>());
                            piecesCollections[pieceName].Add(key, composer);
                            composers.Add(pieceName, composer);
                            Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                        }
                        break;

                    case "Remove":
                        pieceName = commands.Split("|")[1];

                        if (piecesCollections.ContainsKey(pieceName))
                        {
                            piecesCollections.Remove(pieceName);
                            Console.WriteLine($"Successfully removed {pieceName}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        pieceName = commands.Split("|")[1];
                        string newKey = commands.Split("|")[2];

                        if (piecesCollections.ContainsKey(pieceName))
                        {
                            piecesCollections.Remove(pieceName);
                            piecesCollections.Add(pieceName, new Dictionary<string, string>());
                            piecesCollections[pieceName].Add(newKey, composers[pieceName]);
                            Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                        }
                        break;
                }
            }

            foreach (var piece in piecesCollections.OrderBy(x => x.Key))
            {
                foreach (var item in piece.Value.OrderBy(x => x.Value))
                {
                    Console.WriteLine($"{piece.Key} -> Composer: {item.Value}, Key: {item.Key}");
                }
            }
        }
    }
}
