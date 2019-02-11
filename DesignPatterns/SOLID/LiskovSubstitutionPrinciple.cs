using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    class LiskovSubstitutionPrinciple
    {
    }
    /*
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(this.Width)}: {this.Width}, {nameof(this.Height)}: {this.Height}";
        }
    }

    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }

    public class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Height;

        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            //Zapis Square sq = new Square() przy zapisie w klasie Square (publin new int Width..) zadziala,
            //ale jesli damy Rectangle sq = new Square() to juz nie i to jest przeciwienstwem
            //zasady podstawienia liskova ponieważ (w mysl polimorfizmu) kazdy kwadrat jest prostokatem ale nie kazdy prostokat jest kwadratem
            //Obiekt typu Square oraz obiekt typu Rectangle przy podaniu identycznych zmiennych powinny dzialac i dac taki sam wynik - tu tak nie jest. Podajemy tylko Width bez Height.
            //Dopiero sposob z override to rozwiaze

            //TOK POSTEPOWANIA
            //Program widzi przypisanie 4 do width, leci do klasy rectangle, ale tam widzi virtual, wiec zmyka do klasy Square
            //i korzysta z tamtej logiki przypisujac 4 jednoczesnie do Width i Height

            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");
        }
    }
    */
}
