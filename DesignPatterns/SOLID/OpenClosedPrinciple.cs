using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    //OPEN CLOSED PRINCIPLE
    //Oper for extensions but closed for modification. Nobody should go back to Product filter class and editing code which
    //is already there. I can expand by adding new classes that are using ISpecfication but I cannot changing the code in existing class BetterFillter.  

    class OpenClosedPrinciple
    {
    }
    /*
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }

    public class Product
    {
        public string Name;

        public Color Color;

        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
                if (p.Size == size && p.Color == color)
                    yield return p;
        }
    }


    //SPECYFICATION PATTERN
    //allows to avoid breaking open-closed principle. Clarifies if product suits cryteria. It is some kind of prediction of future. 

    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);    //sprawadzie czy jakis przedmiot/ktos typu T odpowiada jakims kryteriom
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>    //filtrowanie przedmiotow ze wzgledu na color
    {
        private Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == _color;
        }
    }

    public class SizeScpecification : ISpecification<Product>
    {
        private Size _size;

        public SizeScpecification(Size size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == _size;
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsSatisfied(i))
                    yield return i;
            }
        }
    }

    //yield return - it will return but not take exit from loop. That means result will be returned and next iteration startet.

    public class AndSpecification<T> : ISpecification<T>       //take specifications and add(and) them in IsSatisfied
    {
        private ISpecification<T> _first, _second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            _second = second ?? throw new ArgumentNullException(paramName: nameof(first));
        }

        public bool IsSatisfied(T t)
        {
            return _first.IsSatisfied(t) && _second.IsSatisfied(t);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            Console.WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

           // SPECYFICATION PATTERN

            var bf = new BetterFilter();
            Console.WriteLine("Green producst (new):");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

           // COMPOSIT SPECIFICATION USING COMBINATOR

            Console.WriteLine("Large blue items");
            foreach (var p in bf.Filter(
                products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeScpecification(Size.Large)
                    )))
            {
                Console.WriteLine($" - {p.Name} is big and blue");
            }
        }
    }
    */
}
