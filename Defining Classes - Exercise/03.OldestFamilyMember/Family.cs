using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {

        List<Person> persons;

        public Family()
        {
            persons = new List<Person>();
        }
        // first way
        public List<Person> Persons { get; set; }

        //second way
        //public List<Person> People
        //{
        //    get
        //    {
        //        return this.people;
        //    }
        //    set
        //    {
        //        this.people = value;
        //    }
        //}




        public void AddMember(Person member)
        {
            persons.Add(member);
        }

        public Person GerOldestMember()
        {
            return this.persons.MaxBy(x => x.Age);
        }

    }
}
