using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface ad { };
    public abstract class AbG : ad
    {
        public abstract void AbPrint();
        public virtual void x()
        {
            Console.WriteLine("내용");
        }
        public virtual void G()
        {
            Console.WriteLine("AbG고유 G출력");
        }

        public AbG()
        {
            
        }
    }

    public class AbF : AbG 
    {
        public override void AbPrint()
        {
            Console.WriteLine("abf AbPrint 출력");
        }
        public override void x()
        {
            base.x();
            Console.WriteLine("abf x 출력");
        }
        public virtual void F()
        {
            Console.WriteLine("AbF고유 F출력");
        }
        public AbF()
        {
                
        }
    }

    public class AbS : AbF, ad
    {
        public AbF AbF;
        public AbS() : base()
        {

        }

        public AbS(AbF abF) : base()
        {
            AbF = abF;
        }


        //public static explicit operator AbS(AbF b) => new AbS(b); //불가
        //public static implicit operator AbF(AbS d) => new AbF();

        public override void AbPrint()
        {
            Console.WriteLine("abs AbPrint 출력");
        }

        public override void x()
        {
            Console.WriteLine("abs x 출력");
        }

        public virtual void S()
        {
            Console.WriteLine("AbS고유 S출력");
        }
    }





}
