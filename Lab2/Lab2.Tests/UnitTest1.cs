using System;
using System.Collections.Generic;
using Xunit;
using Lab2;

namespace Lab2.Tests
{
    public class UnitTest1
    {
        IPerson[] people = new Person[]
             {
                 new Person{Name = "Maksim", Age = 32, Profession= "engineer", Sex="man"},
                 new Person{Name = "Yulia", Age = 25, Profession= "fron-end developer", Sex="woman"},
                 new Person{Name = "Igor", Age = 32, Profession= "fron-end developer", Sex="man"},
                 new Person{Name = "Marina", Age = 19, Profession= "student", Sex="woman"}
             };
        [Fact]
        public void Check_EqulityOverwritten()
        {

            Assert.True(people[0].Equals(people[2]));
            Assert.False(people[0].Equals(people[1]));

        }
        [Fact]
        public void Check_JsonHandler()
        {
            string serialisedObj = (string)JsonHandler.ToJson(people[0]);
            Person testEntity = JsonHandler.FromJson(serialisedObj);
            Assert.Equal(people[0], testEntity);
        }
    }
}
