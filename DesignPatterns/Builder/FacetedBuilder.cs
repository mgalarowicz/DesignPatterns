using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class FacetedBuilder
    {
    }
    /*
    //several builders responsible for different aspects

    public class Person
    {
        //we are going to have one facet for address
        public string StreetAddress, Postcode, City;

        //and one for employment

        public string CompanyName, Position;

        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }

    public class PersonBuilder //facade - component that hides a lot of information behind it
    {
        //reference!
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        //writeline showing a person
        public static implicit operator Person(PersonBuilder pb)    //implicit conversion operator to person
        {
            return pb.person;
        }
    }

    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }


        public PersonJobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int amount)
        {
            person.AnnualIncome = amount;
            return this;
        }
    }

    public class PersonAddressBuilder : PersonBuilder
    {
        //might not work with a value type!
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilder WithPostcode(string postcode)
        {
            person.Postcode = postcode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
    }

    public class Demo
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();

            //we can use AddressBuilder and JobBuilder after each other because they both inherit from PersonBuilder
            Person person = pb
                .Lives.At("LStreet")
                      .In("London")
                      .WithPostcode("sw12ac")
                .Works.At("Fabric")
                      .AsA("Engineer")
                      .Earning(123000);

            Console.WriteLine(person);
        }
    }
    */
}
