using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    //Decalred as sealed for preventing inheritance Bcoz if this class inherited then multiple objects will created for this class.
    public sealed class SingletoneEagerLazy
    {

        static int counter = 0;

        //This single object can be used everytime.
        static Lazy< SingletoneEagerLazy> singletone = new Lazy<SingletoneEagerLazy>(()=>new SingletoneEagerLazy());

        //Constuctor is private for avoiding multiple instaance creation.
        private SingletoneEagerLazy()
        {
            Console.WriteLine("No of Objects : [ " + (++counter).ToString() + " ]");
        }

        public static SingletoneEagerLazy GetInstance()
        {
            return singletone.Value;
        }

        public string PrintInformation(string message)
        {
            return string.Format("'{0}' is displayed", message);
        }

    }
}
