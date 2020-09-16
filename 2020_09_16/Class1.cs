using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_16
{
    class Class1
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            man.FName = "류";
            man.Lname = "현진";
            man.VirtualPrint();

            Employee emp1 = new Employee(2020155);
            emp1.FName = "아";
            emp1.Lname = "이유";
            emp1.VirtualPrint();


            Rpyee rpyee = new Rpyee(123456);
            rpyee.FName = "로";
            rpyee.Lname = "미아";
            rpyee.VirtualPrint();
            

        }
    }
}
