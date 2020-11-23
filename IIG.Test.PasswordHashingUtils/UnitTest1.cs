using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IIG.PasswordHashingUtils;

namespace IIG.Test.PasswordHashingUtils
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string password = "password42069";
            Assert.IsNotNull(PasswordHasher.GetHash(password));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string password = "";
            Assert.IsNotNull(PasswordHasher.GetHash(password));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string password = " ";
            Assert.IsNotNull(PasswordHasher.GetHash(password));
        }

        [TestMethod]
        public void TestMethod4()
        {
            string password = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => PasswordHasher.GetHash(password));
        }





        [TestMethod]
        public void TestMethod5()
        {
            string password = "password42069";
            Assert.AreEqual(PasswordHasher.GetHash(password), PasswordHasher.GetHash(password));
        }

        [TestMethod]
        public void TestMethod6()
        {
            string password1 = "password42069";
            string password2 = "password42069";
            Assert.AreEqual(PasswordHasher.GetHash(password1), PasswordHasher.GetHash(password2));
        }

        [TestMethod]
        public void TestMethod7()
        {
            string password1 = "password4206969";
            string password2 = "password42069";
            Assert.AreNotEqual(PasswordHasher.GetHash(password1), PasswordHasher.GetHash(password2));
        }

        [TestMethod]
        public void TestMethod8()
        {
            string password1 = "password4206969";
            string password2 = "password42069";
            Assert.AreNotEqual(PasswordHasher.GetHash(password1), PasswordHasher.GetHash(password2));
        }

        [TestMethod]
        public void TestMethod9()
        {
            string password1 = "password42069";
            string password2 = "PASSWORD42069";
            Assert.AreNotEqual(PasswordHasher.GetHash(password1), PasswordHasher.GetHash(password2));
        }

        [TestMethod]
        public void TestMethod10()
        {
            string password = "password42069";
            Assert.IsNotNull(PasswordHasher.GetHash(password, null));
        }

        [TestMethod]
        public void TestMethod11()
        {
            string password = "password42069";
            Assert.IsNotNull(PasswordHasher.GetHash(password, null, 42069));
        }

        [TestMethod]
        public void TestMethod12()
        {
            string password = "password42069";
            Assert.IsNotNull(PasswordHasher.GetHash(password, "", 42069));
        }

        [TestMethod]
        public void TestMethod13()
        {
            string password = "password42069";
            Assert.AreEqual(PasswordHasher.GetHash(password, "", 42069), PasswordHasher.GetHash(password, "", 42069));
        }

        [TestMethod]
        public void TestMethod14()
        {
            string password1 = "password42069";
            string password2 = "password42069";
            Assert.AreEqual(PasswordHasher.GetHash(password1, "", 42069), PasswordHasher.GetHash(password2, "", 42069));
        }

        [TestMethod]
        public void TestMethod15()
        {
            string password1 = "password42069";
            string password2 = "password4206969";
            Assert.AreNotEqual(PasswordHasher.GetHash(password1, "", 42069), PasswordHasher.GetHash(password2, "", 42069));
        }

        [TestMethod]
        public void TestMethod16()
        {
            string password = "password42069";
            Assert.AreNotEqual(PasswordHasher.GetHash(password, "", 42069), PasswordHasher.GetHash(password, "", 69));
        }

        [TestMethod]
        public void TestMethod17()
        {
            string password1 = "password42069";
            string password2 = "password42069";
            Assert.AreNotEqual(PasswordHasher.GetHash(password1, "", 42069), PasswordHasher.GetHash(password2, "", 42069));
        }

        [TestMethod]
        public void TestMethod18()
        {
            string password = "password42069";
            Assert.IsNotNull(PasswordHasher.GetHash(password, "nice"));
        }

        [TestMethod]
        public void TestMethod19()
        {
            string password = "password42069";
            Assert.IsNotNull(PasswordHasher.GetHash(password, "nice"));
        }

        [TestMethod]
        public void TestMethod20()
        {
            string password = "password42069";
            Assert.AreEqual(PasswordHasher.GetHash(password, "nice"), PasswordHasher.GetHash(password, "nice"));
        }

        [TestMethod]
        public void TestMethod21()
        {
            string password = "password42069";
            Assert.AreNotEqual(PasswordHasher.GetHash(password, "nice"), PasswordHasher.GetHash(password, "nice69"));
        }

        [TestMethod]
        public void TestMethod22()
        {
            string password = "password42069";
            Assert.AreNotEqual(PasswordHasher.GetHash(password, "nice"), PasswordHasher.GetHash(password, "nice "));
        }

        [TestMethod]
        public void TestMethod23()
        {
            string password = "password42069";
            Assert.IsNotNull(PasswordHasher.GetHash(password, "nice", 0));
        }

        [TestMethod]
        public void TestMethod24()
        {
            string password = "password42069";
            Assert.IsNotNull(PasswordHasher.GetHash(password, " ", 69));
        }

        [TestMethod]
        public void TestMethod25()
        {
            string password = "password42069";
            Assert.AreEqual(PasswordHasher.GetHash(password, "nice", 69).Length, 64);
        }

        [TestMethod]
        public void TestMethod26()
        {
            string password1 = "password42069";
            string password2 = "password4206969";
            Assert.AreEqual(PasswordHasher.GetHash(password1, "nice", 69).Length, PasswordHasher.GetHash(password2, "nice", 69).Length);
        }

        [TestMethod]
        public void TestMethod27()
        {
            string password = "password42069";
            Assert.AreEqual(PasswordHasher.GetHash(password, "nice", 69).Length, PasswordHasher.GetHash(password, "nice42069", 69).Length);
        }

        [TestMethod]
        public void TestMethod28()
        {
            string password = "password42069";
            PasswordHasher.Init("nice", 69);
            Assert.IsNotNull(PasswordHasher.GetHash(password));
        }

        [TestMethod]
        public void TestMethod29()
        {
            string password = "password42069";
            PasswordHasher.Init(null, 0);
            Assert.IsNotNull(PasswordHasher.GetHash(password));
        }

        [TestMethod]
        public void TestMethod30()
        {
            string password = "password42069";
            PasswordHasher.Init("nice", 69);
            string hash1 = PasswordHasher.GetHash(password);
            string hash2 = PasswordHasher.GetHash(password, "nice", 69);
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void TestMethod31()
        {
            string password = "password42069";
            PasswordHasher.Init("nice", 69);
            string hash1 = PasswordHasher.GetHash(password);
            string hash2 = PasswordHasher.GetHash(password, "nice69", 69);
            Assert.AreNotEqual(hash1, hash2);
        }


    }
}
