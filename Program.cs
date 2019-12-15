using System;

namespace OverrideMethod
{
    //example 1
    //override a parent class method under child class
    /* class Class1
     {
         public virtual void show()
         {
             Console.WriteLine("Super class show method");
         }
     }
     class Class2 : Class1
     {
         public override void show()
         {
             Console.WriteLine("Sub class override show method");
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             Class2 obj = new Class2();
             obj.show();
             Console.ReadKey();
         }
     }*/
    //example 2
    //execute the superclass method if it is overridden in sub-class
     class Class1
    {
        public virtual void show()
        {
            Console.WriteLine("Super class show method");
        }
    }
    class Class2 : Class1
    {
        public override void show()
        {
            Class1 cl1 = new Class1();
            cl1.show();
            //base.show();
            Console.WriteLine("Sub class override show method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.show();
            Console.ReadKey();
        }
    }


}
