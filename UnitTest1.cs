using Day24;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase1()
        {
            string name = "Prerana";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validname(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase2()
        {
            string lastname = "Kanekar";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validlname(lastname);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase3()
        {
            string email = "abc.xyz@bl.co.in";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validmail(email);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase4()
        {
            string mobileno = "91 7385352622";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validmobile(mobileno);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]


        public void UseCase5()
        {
            string password = "Ppfuhefup";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validpwd1(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase6()
        {

            string password = "Dwivediii";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validpwd2(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase7()
        {
            string password = "Krishna9";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validpwd3(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase8()
        {
            string password = "Krishna#2";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validpwd(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase9()
        {
            string email1 = "abc.xyz@gmail.com";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validmail(email1);
            Assert.AreEqual(expected, actual);
        }
    }
}