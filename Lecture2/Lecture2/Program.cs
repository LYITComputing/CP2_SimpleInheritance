 using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BaseClass myBaseObj;
            myBaseObj = new BaseClass(1);
            myBaseObj.Print();
            myBaseObj.Print2();

            Console.WriteLine("\nCreating the derived object instance");
            //Create an instance of the derived class
            //DerivedClass myDerivedObj = new DerivedClass();*/
            DerivedClass myDerivedObj = new DerivedClass(5, 12);
            myDerivedObj.Print();
            myDerivedObj.Print2();

            BaseClass bcdc = new DerivedClass(1);
            bcdc.Print();
            bcdc.Print2();


            Console.WriteLine("\nHello World again!");
        }
    }

    public class BaseClass
    {

        //Private fields / attributes
        private int simpleNum_;

        //Public property SimpleNum
        public int SimpleNum
        {
            get { return simpleNum_; }
            set { simpleNum_ = value; }
        }

        //Default constructor
        public BaseClass()
        {
            Console.WriteLine("\nBase class constructor called ");
        }

        public BaseClass(int num)
        {
            Console.WriteLine("Base class constructor called ");
            simpleNum_ = num;
        }
        public void Print()
        {
            Console.WriteLine($"Calling print in the base ");
            Console.WriteLine($"The value of simpleNum is {simpleNum_}");
        }
        public virtual void Print2()
        {
            Console.WriteLine($"Calling print2 in the base ");
            Console.WriteLine($"The value of simpleNum is {simpleNum_}");
        }


    }

    interface ITestInterface
    {
        void PrintDetails();
    }

    //DerivedClass
    public class DerivedClass : BaseClass, ITestInterface
    {
        //Private attribute
        private int anotherSimpleNum_;

        //Public property anotherSimpleNum
        public int AnotherSimpleNum
        {
            get { return anotherSimpleNum_; }
            set { anotherSimpleNum_ = value; }
        }

        public DerivedClass()
        {
            Console.WriteLine("Derived class constructor called");
        }

        public DerivedClass(int anotherSimpleNum)
        {
            anotherSimpleNum_ = anotherSimpleNum;
            Console.WriteLine("Derived class constructor called");
        }

        public DerivedClass(int simpleNum, int anotherSimpleNum) : base(simpleNum)
        {
            Console.WriteLine("Derived class constructor called with two numbers");
            anotherSimpleNum_ = anotherSimpleNum;
        }

        public new void Print()
        {
            //The new keyword supresses the warning that we are hiding the Print method defined in the base class
            Console.WriteLine($"Calling print in the derived class ");
            Console.WriteLine($"The value of anotherSimpleNum is: {anotherSimpleNum_}");
        }

        public override void Print2()
        {
            //Note the override here extends base class virtual implementation of Print2
            // For a full explaination see: 
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
            Console.WriteLine($"Calling print2 in the derived class ");
            Console.WriteLine($"The value of anotherSimpleNum is: {anotherSimpleNum_}");
        }

        //Print details from the ITestInterface
        public void PrintDetails()
        {
            Console.WriteLine("Calling  print details");
        }


    } //End derived class 

}


