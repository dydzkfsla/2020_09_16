using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface va { };
    public class Man
    {
        protected string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        protected string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public virtual void VirtualPrint()
        {
            Console.WriteLine("============ Main =============");
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
        }
        public override string ToString()
        {
            return $"{fName}  {lname}";
        }
    }

    public class Employee : Man
    {
        int employeeID;

        public override void VirtualPrint()
        {
            Console.WriteLine("============ Employee =============");
            Console.WriteLine("employeeID : {0}", employeeID);
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lname);
            Console.WriteLine("===============================");
            base.VirtualPrint();
        }
        //public Employee()
        //{

        //}
        public Employee(int ID)
        {
            employeeID = ID;
        }

        public override string ToString()
        {
            return $"{fName}  {lname}";
        }
    }

    public class Rpyee : Employee, va
    {

        int ID;
        public Rpyee(int ID) : base(ID)
        {
            this.ID = ID;
        }

        public override void VirtualPrint()
        {
            base.VirtualPrint();
        }
    }
}
