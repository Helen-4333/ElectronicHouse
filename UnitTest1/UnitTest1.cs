using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EH_Library;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthorizationTest()
        {
            Class1 test=new Class1();
            string auth = test.Authorization("asdf", "zxсv");
            string Login = "asdf";
            Assert.AreEqual(auth, Login);
        }

        [TestMethod]
        public void EditAccountTest()
        {
            Class1 test = new Class1();
            string editAccount = test.editAccount("fgn", "dfg", "sdf");
            string name = "fgn";
            Assert.AreEqual(editAccount, name);
        } 

        [TestMethod]
        public void CreateRequestTest()
        {
            Class1 test = new Class1();
            string createrequest = test.Create_Request("dfgh","dfg","fgh","edrwerty");
            string title = "dfgh";
            Assert.AreEqual(createrequest, title);
        }
             
     

    }
}
