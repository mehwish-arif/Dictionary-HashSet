using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> dictionary = new Dictionary<string, City>()
            {
                { "Toronto", new City(59280, "ON") },
                { "Montreal", new City(400000, "QC")},
                {"Vancouver",new City(2400000, "BC")},
                { "Calgary", new City (130000, "AL")},
            };

            foreach (var data in dictionary)
            {
                Console.WriteLine($"{data.Key} is a city in {data.Value.Province}");
            }

            HashSet<string> topCities = new HashSet<string>();
            topCities.Add("Mexico");
            topCities.Add("New York");
            topCities.Add("Los Angeles");
            topCities.Add("Chicago");
            topCities.Add("Dallas");
            topCities.Add("Toronto");

            Console.WriteLine();
            Console.WriteLine("Top 10 North American cities by population");
            foreach(var city in topCities)
            {
                Console.WriteLine($"{city}");
            }

            //HashSet<string> cityNames = new HashSet<string>(dictionary.Keys);
            topCities.IntersectWith(dictionary.Keys);

            Console.WriteLine();
            foreach (var city in topCities)
            {
                Console.WriteLine($"{city} is in Canada and also in the top 10 largest cities in North America");
            }

        }

        class City
        {
            public City()
            {

            }

            public City(int population, string province)
            {
                this.Population = population;
                this.Province = province;
            }

            public int Population { get; set; }

            public string Province { get; set; }
        }
    }
}
