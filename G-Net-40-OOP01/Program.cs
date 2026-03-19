using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Xml.Linq;
using G_Net_40_OOP01.MyClasses;
using G_Net_40_OOP01.MyStructs;
using MathLip;

namespace G_Net_40_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            // Part 01 : 
            // Q1:  Explain with code example how class and struct behave differently
            // Q2 : Explain the difference between public and private access modifiers with an example.
            // Q3 : Describe the steps to create and use a class library in Visual Studio.
            // Q4 : What is a class library? Why do we use class libraries?
            //------------------------------------------------------------------------------------------


            //Answers: Q1:
            #region Code Example Of Class

            #region First Different : (Value type vs Reference Type)
            //Student student1 = new Student("Ali", 20);

            //Student student2 = student1; // This creates a reference to the same object in memory

            //Console.WriteLine(student1);
            //Console.WriteLine(student2);

            //Console.WriteLine("--------------------------------------------------");

            //student2.Name = "Mahmoud"; // Modifying student2 will affect student1
            //                           // since they reference the same object
            //                           // Because Classes are reference types,
            //                           // they are stored on the heap and variables hold references
            //                           // to the data rather than the data itself.

            //Console.WriteLine(student1);
            //Console.WriteLine(student2); 
            #endregion
            #region Second Different : (Default Constructor)
            //Student student1 = new Student("Ali", 20); 
            //// if we define custom constructor in class
            //// we must initialize all properties in the constructor


            //Student student2 = new Student(){Name = "Ali",Age = 20 }; //Invalid
            ////in class the default constructor is available even if we define custom constructor
            ////and if you define custom constructor the default constructor is not available 
            #endregion
            #endregion
            #region Code Example Of Struct 
            #region First Different : (Value type vs Reference Type)
            Employee emp01 = new Employee("Sara", 30, 5000m);

            Employee emp02 = emp01; // This creates a copy of emp01

            Console.WriteLine(emp01);
            Console.WriteLine(emp02);
            Console.WriteLine("-------------------------------------------------------");

            emp02.Salary = 6000m; // Modifying emp02 will NOT affect emp01
                                  // since they are different instances in memory
                                  //Because Structs are value types,
                                  //they are stored on the stack and each variable holds its own copy of the data.

            Console.WriteLine(emp01);
            Console.WriteLine(emp02);
            #endregion
            #region Second Different : (Default Constructor)
            //Employee emp03 = new Employee("Omar", 25, 4000m); 

            //Employee emp04 = new Employee() { Name ="mohamed", Age = 9,Salary =  1000m};

            //in struct the default constructor is  available if we define custom constructor
            #endregion


            #endregion



            //Answers: Q2:
            #region Private vs Public

            //public access modifier allows members to be accessed from anywhere in the code,
            //while private access modifier restricts access to members within the same class or struct.

            MathHelper.Multiply(10, 5); // Valid, because Multiply is public
            MathHelper.Subtract(10, 5); // Valid, because Subtract is public
                                        //MathHelper.Add(10, 5); // Invalid, because Add is private

            #endregion

            //Answers: Q3:
            #region steps to create and use a class library 
            // 1- Open Visual Studio

            // 2- Click Create New Project

            // 3- Choose Class Library(.NET)
               
            // 4- Enter project name and click Create
               
            // 5- Add your classes and methods in the project
               
            // 6- Build the project(Build → Build Solution) to generate the DLL
               
            // 7- Open another project where you want to use the library
               
            // 8- Right - click References / Dependencies → Add Reference
               
            // 9- Select the Class Library project or DLL
               
            // 10- Import the namespace using using
               
            // 11-Create objects and use the library methods if it non static, or call static methods directly
            #endregion



            #endregion
        }
    }
}
