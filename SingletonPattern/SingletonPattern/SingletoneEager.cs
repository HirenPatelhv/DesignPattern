using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    //Decalred as sealed for preventing inheritance Bcoz if this class inherited then multiple objects will created for this class.
    public sealed class SingletoneEager
    {

        static int counter = 0;

        //This single object can be used everytime.
        static readonly SingletoneEager singletone = new SingletoneEager();

        //Constuctor is private for avoiding multiple instaance creation.
        private SingletoneEager()
        {
            Console.WriteLine("No of Objects : [ " + (++counter).ToString() + " ]");
        }

        public static SingletoneEager GetInstance()
        {
            return singletone;
        }

        public string PrintInformation(string message)
        {
            return string.Format("'{0}' is displayed", message);
        }

    }
}
