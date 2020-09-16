using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_16
{
    class Button
    {        
        static int bttonCnt = 0;
        static Button btn;
        int click = 0;
        static Button()
        {
            bttonCnt = 10;
        }
        private Button()
        {
            bttonCnt++;
        }
        public void Click()
        {
            click++;
            Console.WriteLine(click);
        }
        public void BttonCnt()
        {
            Console.WriteLine(bttonCnt);
        }

        public static Button CreateInstance()
        {
            if (btn == null)
                btn = new Button();
            return btn;
        }
    }

    class ClickCount{
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                Console.WriteLine(args[0]+ "/" + args[1]);
            }
            

            Button btn1 = Button.CreateInstance();
            btn1.Click();
            btn1.Click();
            btn1.Click();

            Button btn2 = Button.CreateInstance();
            btn2.Click();
        }
    }
}
