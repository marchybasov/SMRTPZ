using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab2
{
    public interface IPerson
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public string Sex { get; set; }
        public string Profession { get; set; }
        bool Equals(object obj);


    }
    public class Person:IPerson
    {
        public string  Name { get; set; }
        public uint Age { get; set; }
        public string Sex { get; set; }
        public string Profession { get; set; }
        public override bool Equals(object obj)
        {
            if (this.Age == ((Person)obj).Age)
            {
                return true;
            }
            return false;
        }       
    }
    

    public static class JsonHandler 
    {
        public static Person FromJson(string jsonString) => JsonSerializer.Deserialize<Person>(jsonString);
        

        public static object ToJson(IPerson person) => JsonSerializer.Serialize(person);
        
    }
}
