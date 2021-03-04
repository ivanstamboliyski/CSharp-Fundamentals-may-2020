using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        
        {
            decimal amountMoney = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            decimal lightsabersCount = Math.Ceiling(studentsCount * 1.10m);
            decimal allLightsabersPrice = lightsabersCount * lightsaberPrice;
            decimal allRobesPrice = studentsCount * robePrice;
            decimal allBeltsPrice = studentsCount * beltPrice;

            if (studentsCount > 5)
            {
                int freeBelts = studentsCount / 6;
                allBeltsPrice -= freeBelts * beltPrice; 
            }

            decimal allCosts = allBeltsPrice + allRobesPrice + allLightsabersPrice;

            if (allCosts <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {allCosts:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {allCosts - amountMoney:F2}lv more.");
            }
        }
    }
}
