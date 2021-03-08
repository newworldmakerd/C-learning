using System;
using System.Collections.Generic;

namespace Myprop
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPropManager myPropManager = new MyPropManager();
            myPropManager.Init();
            Prop p = new Prop();
            p.id = 1005;
            p.name = "洗髓丹";
            p.isUse = false;
            myPropManager.Add(p); 
            myPropManager.Remove(1001);
            ShowTheProp(myPropManager);
        }

        private static void ShowTheProp(MyPropManager myPropManager)
        {
            List<Prop> props = myPropManager.GetAll();
            foreach (Prop p in props)
            {
                Console.WriteLine(p.id + "\n" + p.name + "\n" + p.isUse+"\n");
            }
        }
    }
}
