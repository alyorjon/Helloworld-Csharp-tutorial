
using System;
using System.Collections;
using System.Net.Mime;
using HELLOWORLD;

{
    static void Collactions()
    {
        List<string> cities = new List<string>();
        cities.Add("New York");
        cities.Add("Toshkent");
        cities.Add("Tokyo");
        cities.Add("Berlin");
        Console.WriteLine(cities[2]);
        Console.WriteLine(cities.Count);
        foreach (string name in cities)
        {
            Console.WriteLine(name);

        }

        HashSet<string> countries = new HashSet<string>();
        countries.Add("Germany");
        countries.Add("Japan");
        countries.Add("USA");
        countries.Add("Uzbekistan");
        countries.Add("Kanada");
        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }
        Dictionary<string, int> ageDict = new Dictionary<string, int>();
        string dictKey = "Alice";
        ageDict[dictKey] = 30;
        Console.WriteLine(ageDict);
        if (ageDict.ContainsKey(dictKey))
        {
            Console.WriteLine($"{dictKey}'s age is : {ageDict[dictKey]}");
        }
        Dictionary<string, string> countrycodes = new Dictionary<string, string>();
        countrycodes.Add("UZ", "Uzbekistan");
        countrycodes.Add("RU", "Russia");
        countrycodes.Add("US", "USA");

        if (countrycodes.TryGetValue("UZ", out string nomi))
        {
            Console.WriteLine($"Country name is {nomi}");
        }
        foreach (string name in countrycodes.Keys)
        {
            Console.WriteLine(name);
        }
        foreach (string name in countrycodes.Values)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine(countrycodes.Count);
        countrycodes.Remove("US");
        foreach (string name in countrycodes.Values)
        {
            Console.WriteLine(name);
        }

    }

}