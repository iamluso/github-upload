using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatedDemo
{
    class MediaInventory
    {
        public delegate bool TestMedia();

        public void TestResult(TestMedia mediaDelegate)
        {
            if (mediaDelegate() == true)
                Console.WriteLine("Work, Add to inventory");
            else
                Console.WriteLine("Media failed, Reject");
        }
    }
}
