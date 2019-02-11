using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    //High level parts of the system should not depend on low level parts of the system directly.
    //They should depend on some level of abstraction.

    public class DependencyInversionPrinciple
    {
    }
    /*
    public enum Relationship
    {
        Parent,
        Child,
        Sibling,
    }

    public class Person
    {
        public string Name;

    }

    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    //LOW-LEVEL
    public class Relationships : IRelationshipBrowser
    {
        //C#7 Tuple. Person - from which relationship stands, Relationship, Person - to which relationship applies
        private List<(Person, Relationship, Person)> relations
            = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return this.relations.Where(
                x => x.Item1.Name == name &&
                     x.Item2 == Relationship.Parent
            ).Select(r => r.Item3);
        }

        //public List<(Person, Relationship, Person)> Relations => relations;   //BAD
    }


    public class Research
    {
        //public Research(Relationships relationships)    //BAD
        //{
        //    //we are accessing very low-level part of Relationships class by public property that exposes our private property
        //    //in other words Relationships cannot change the idea of store the relationships
        //    var relations = relationships.Relations;
        //    foreach (var r in relations.Where(
        //        x => x.Item1.Name == "John" &&
        //             x.Item2 == Relationship.Parent
        //    ))
        //    {
        //        Console.WriteLine($"John has a child called {r.Item3.Name}");
        //    }
        //}

        public Research(IRelationshipBrowser browser)
        {
            foreach (var q in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {q.Name}");
            }
        }

        static void Main(string[] args)
        {
            var parent = new Person() { Name = "John" };
            var child1 = new Person() { Name = "Chris" };
            var child2 = new Person() { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Research(relationships);
        }
    }
    */
}
