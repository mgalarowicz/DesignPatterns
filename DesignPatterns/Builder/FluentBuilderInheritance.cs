using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class FluentBuilderInheritance
    {
    }
    /*
    //Builders inherit from other builder
    //Recursive Generics - approach to get fluent interfaces inherit
    public class Person
    {
        public string Name;

        public string Position;

        public class Builder : PersonJobBuilder<Builder>   //Recursive Generics Approach  - passing a Type as a Generic argument
        {

        }

        public static Builder New => new Builder();  //public property to expose Builder

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }

    public class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
    //stick it as generic argument calling itself because it's a self referential relationship effectively 
    public class PersonInfoBuilder<SELF> : PersonBuilder where SELF : PersonInfoBuilder<SELF>   //class Foo : Bar<Foo> - restricting SELF.
                                                                                                //It's allowed when SELF actually refers to object inheriting from this object
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;       //has to return this which is going through inheritance
        }
    }

    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>> where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorksAsA(string position)
        {
            person.Position = position;
            return (SELF)this;
        }
    }


    internal class Program
    {
        public static void Main(string[] args)
        {
            var me = Person.New.Called("marek").WorksAsA("develop").Build();
            Console.WriteLine(me);
        }
    }
    */
}
