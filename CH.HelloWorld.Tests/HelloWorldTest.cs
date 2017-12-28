using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using System.Web;
using CH.HelloWorld.Services;
using CH.HelloWorld.Web.Controllers;

namespace CH.HelloWorld.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void TestWriteToConsole()
        {
            using (System.IO.StringWriter sw = new StringWriter())
            {
                string helloWorld = "Hello World";
                Console.SetOut(sw);
                //Arrange
                ConsoleWriter cw = new ConsoleWriter();
                //Act
                cw.WriteMessage(helloWorld);
                //Assert
                Assert.AreEqual<string>(helloWorld, sw.ToString().Replace("\r\n", ""));
            }
        }
        [TestMethod]
        public void TestWriteToWeb()
        {
            //1.
            //WebRequest request = WebRequest.Create("http://localhost:56717/");
            //request.Credentials = CredentialCache.DefaultCredentials;
            //WebResponse response = request.GetResponse();
            //Stream dataStream = response.GetResponseStream();
            //StreamReader reader = new StreamReader(dataStream);
            //string responseFromServer = reader.ReadToEnd();
            //reader.Close();
            //response.Close();

            //VS

            //2.
            string helloWorld = "Hello World";
            var controller = new HomeController();
            var result = (string)controller.Index();
            Assert.AreEqual<string>(helloWorld, result);

        }
        [TestMethod]
        public void TestWriteToDatabase()
        {
        }
    }
}
