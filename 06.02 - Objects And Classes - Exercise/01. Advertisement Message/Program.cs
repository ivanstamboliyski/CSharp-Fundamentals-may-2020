using System;

namespace _06._2.CSharpFundamentals_ObjectsAndClasses_Exercise
{
    class Program
    {
        static void Main()
        {
            int messagesNumber = int.Parse(Console.ReadLine());

            string[] phrases = 
            {   
                "Excellent product.", 
                "Such a great product.", 
                "I always use that product.", 
                "Best product of its category.", 
                "Exceptional product.", 
                "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" 
            };

            string[] authors = 
            {  
                "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie", 
                "Eva" 
            };

            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse" 
            };

            Random randomIndex = new Random();

            for (int i = 0; i < messagesNumber; i++)
            {
                Message message = new Message(phrases, events, authors, cities);

                string currPhrase = phrases[randomIndex.Next(phrases.Length)];
                string currEvent = events[randomIndex.Next(events.Length)];
                string currAuthor = authors[randomIndex.Next(authors.Length)];
                string currCity = cities[randomIndex.Next(cities.Length)];

                Console.WriteLine($"{currPhrase} {currEvent} {currAuthor} – {currCity}.");
            }
        }
    }
    class Message 
    {
        public string[] Phrase { get; set; }
        public string[] Event { get; set; }
        public string[] Author { get; set; }
        public string[] City { get; set; }

        public Message(string[] phrases, string[] events, string[] authors, string[] cities)
        {
            Phrase = phrases;
            Event = events;
            Author = authors;
            City = cities;
        }
    }
}
