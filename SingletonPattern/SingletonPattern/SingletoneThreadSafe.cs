using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    //Decalred as sealed for preventing inheritance Bcoz if this class inherited then multiple objects will created for this class.
    public sealed class SingletoneThreadSafe
    {

        static int counter = 0;
        static object obj = new object();
        //This single object can be used everytime.
        static SingletoneThreadSafe singletone = null;

        //Constuctor is private for avoiding multiple instaance creation.
        private SingletoneThreadSafe()
        {
            Console.WriteLine("No of Objects : [ " + (++counter).ToString() + " ]");
        }

        public static SingletoneThreadSafe GetInstance()
        {
            if (singletone == null)//Double-Lock Check
            {
                lock (obj)//Lock Check
                {
                    if (singletone == null)
                    {
                        singletone = new SingletoneThreadSafe();
                    }
                }
            }
            return singletone;
        }

        public string PrintInformation(string message)
        {
            return string.Format("'{0}' is displayed", message);
        }
    }
}
