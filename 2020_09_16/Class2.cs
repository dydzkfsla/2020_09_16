using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_16
{
    class Class2
    {
        static void Main()
        {
            AbG abG;        //.G()  고유 메서드
            AbF abF;        //.F()  고유 메서드
            AbS abS;        //.S()  고유 메서드

            abG = new AbF();
            abG.x();
            abG.AbPrint();
            //abG.F();  불가능    
            abG.G();
            abG = new AbS();
            abG.x();
            abG.AbPrint();
            //abG.s();  불가능 

            //abF = new AbG(); 불가능
            abF = new AbS();
            abF.F();
            abF.G();

            //abS = new AbG(); 불가능
            //abS = new AbF(); 불가능
            abS = new AbS();
            abS.F();
            abS.G();
            abS.S();

            
        }
    }
}
