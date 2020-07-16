using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_AbstractClass
{
    //Abstract class :
    //1.)has to be Base/parent Class 
    //2.)Object can NOT be created unlike concrete classes as it is half baked class with abstract methods
    //3.) abstract classes can NOT be private, protected or internal - it has to be public
    //4.)abstract class can NOT be static / sealed

    public abstract class DB
    {
        public abstract void connect(); //abstract method //by deafault all abstract methods are virtual
        public string DBIpAddress() //non - abstract method
        {
            return "10.10.1.1";
        }
    }


    public class SQL : DB
    {
        public override void connect()
        {
            Console.WriteLine("SQL connected");

        }
    }

    public class Oracle : DB
    {
        public override void connect()
        {
            Console.WriteLine("Oracle Connected");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
