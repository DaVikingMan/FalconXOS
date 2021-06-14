using System;
using System.Threading;

namespace src
{
    class Test // This class is triggered when you run the debug command
    {
        public void TestMethod() // Put the code which you want to test here
        {
            Thread.Sleep(100);
            var m = new Menu();
            m.MenuMain();

        }
    
        
    }
}
