using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    //Decalred as sealed for preventing inheritance Bcoz if this class inherited then multiple objects will created for this class.
    public sealed class SingletoneThread
    {

        static int counter = 0;

        //This single object can be used everytime.
        static SingletoneThread singletone = null;

        //Constuctor is private for avoiding multiple instaance creation.
        private SingletoneThread()
        {
            Console.WriteLine("No of Objects : [ " + (++counter).ToString() + " ]");
        }

        public static SingletoneThread GetInstance()
        {
            if (singletone == null)
            {
                singletone = new SingletoneThread();
            }

            return singletone;
        }

        public string PrintInformation(string message)
        {
            return string.Format("'{0}' is displayed", message);
        }
    }
}
