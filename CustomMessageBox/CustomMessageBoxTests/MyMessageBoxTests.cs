using NUnit.Framework;
using CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMessageBox.Tests
{
    [TestFixture()]
    public class MyMessageBoxTests
    {
        [Test()]
        public void InitializeAutoCloseAsyncTest()
        {
            MyMessageBox mb = new MyMessageBox("", "", 3);
            
            
            Assert.Fail();
        }
    }
}