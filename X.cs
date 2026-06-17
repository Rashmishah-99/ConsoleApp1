using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class X
    {
        public int t;

        public virtual void Display()
        {
            Console.WriteLine(t);
        }
        public void Show()
        {
            Console.WriteLine(t);
        }
    }
    class Y : X
    {
        public int u;
        public override void Display()
        {
            base.Display();
            Console.WriteLine(u);
        }
        public new void Show()
        {
            Console.WriteLine(t);
            Console.WriteLine(u);
        }
        public void Test()
        {
        }
    }
    class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            Y obj = new Y();
            obj.Display();
            obj.Test();

            X obj2 = new Y();
            obj2.Display();
            obj2.Show();
            //obj2.Test();
        }
    }
}
