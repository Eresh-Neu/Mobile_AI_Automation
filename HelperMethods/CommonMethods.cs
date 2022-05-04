using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MobileTest.HelperMethods
{
    public class CommonMethods : BaseClass
    {
        public void ResetAndWaitForReady(int sec)
        {
            driver.ResetApp();
            Thread.Sleep(sec);
        }
    }
}
