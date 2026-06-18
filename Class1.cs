using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        private int id;
        public int getID()
        { return id; }
        public void setID(int id)
        { this.id = id; }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        class PropertyDemo
        {
            static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.setID(10);
            Console.WriteLine(obj.getID());
        }
    }
}
