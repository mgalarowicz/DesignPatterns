using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    //Interfaces should be segregated so nobody who implements interface has to implement functions they dont actualy need

    class InterfaceSegregationPrinciple
    {
    }

    /*
    public class Document
    {

    }

    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //
        }

        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }

    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }

    public interface IMultiFunctionDevice : IScanner, IPrinter
    {

    }

    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter _printer;
        private IScanner _scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        //DECORATOR PATTERN
        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }

        public void Print(Document d)
        {
            _printer.Print(d);
        }
    }
    */
}
