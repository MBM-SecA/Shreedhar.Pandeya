using System;
using System.Collections.Generic;

namespace LearnCollections
{
public class Collection{

    void LearnLists()
    {
        List<byte> ages = new List<byte>();

        ages.Add(1);
        ages.Add(11);
        ages.Add(123);
        ages.Add(221);

        List<Country> countries = new List<Country>();
        Country country1 = new Country();

        countries.Add(country1);
    }

    internal void LearnDictionary()
    {
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
        countryCapitals.Add("Nepal", "Kathmandu");
        countryCapitals.Add("India", "Delhi");
        countryCapitals.Add("China", "Beijing");

        foreach (var country in countryCapitals)
        {
            Console.Write($"Country : {country.Key} Capital city : {country.Value}");

        }


    }
}

    public class Country 
    {

    }

}
