using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise._05.NetherRealms
{
    class Program
    {
        static void Main()
        {
            string[] demonsNames = Console.ReadLine().Trim().Split(",", StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, Dictionary<int, double>> demonsInfo = new SortedDictionary<string, Dictionary<int, double>>();

            for (int i = 0; i < demonsNames.Length; i++)
            {
                string currName = demonsNames[i].Trim();

                string healtPattern = @"(?<health>[^0-9+*\/.-])";
                string damagePattern = @"(?<damage>[-+]*[\d+]-*[\d+.\d+]*)";
                string basePattern = @"(?<base>[*\/])";

                MatchCollection healthMatched = Regex.Matches(currName, healtPattern);
                MatchCollection damageMatched = Regex.Matches(currName, damagePattern);
                MatchCollection baseMatched = Regex.Matches(currName, basePattern);

                string health = String.Concat(healthMatched);

                int demonHealth = health.Sum(x => x);
                double demonDamage = damageMatched.Select(x => double.Parse(x.Value)).Sum();

                string changeBaseDamage = String.Concat(baseMatched);

                foreach (var item in changeBaseDamage)
                {
                    if (item == '*')
                    {
                        demonDamage *= 2;
                    }
                    if (item == '/')
                    {
                        demonDamage /= 2;
                    }
                }

                demonsInfo.Add(currName, new Dictionary<int, double>());
                demonsInfo[currName].Add(demonHealth, demonDamage);
            }

            foreach (var demon in demonsInfo)
            {
                foreach (var demonStats in demon.Value)
                {
                    Console.WriteLine($"{demon.Key} - {demonStats.Key} health, {demonStats.Value:f2} damage");
                }
            }
        }
    }
}
