using System;
using System.IO;
using System.Runtime.Serialization; // need a reference!
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace JsonPrettyPrint
{
    public class Human
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    public class SuperHero : Human
    {
        public bool goodGuy { get; set; }
        public Ability superpower = new Ability();
    }
    public class Ability
    {
        public bool isUnique { get; set; }
        public string[] abilities { get; set; }
    }
    internal class Program
    {

        private static void Main()
        {
            SuperHero hero1 = new SuperHero
            {
                name = "Super C-Sharper",
                age = 25,
                goodGuy = true,
                superpower = new Ability
                {
                    isUnique = true,
                    abilities = new string[]
                    { "sharp eyes", "invisibility", "telekinesis",
                    "acid generation", "sonic scream", "resurrection", "time manipulation" }
                }
            };

            SuperHero hero2 = new SuperHero
            {
                name = "Super C-PlusPluser",
                age = 25,
                goodGuy = true,
                superpower = new Ability
                {
                    isUnique = true,
                    abilities = new string[]
                    { "two plus-shaped eyes (+ +)", "invisibility", "telekinesis",
                    "acid generation", "sonic scream", "resurrection", "time manipulation" }
                }
            };

            string str_json1 = JsonConvert.SerializeObject(hero1, Formatting.Indented);
            string str_json2 = JsonConvert.SerializeObject(hero2, Formatting.Indented);
            Console.WriteLine(str_json1);
            Console.WriteLine(str_json2);

            string json = @"C:\1\json.txt";
            File.WriteAllText(json, str_json1 + str_json2);
        }

    }
}