using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PropertyDomain3;

namespace PropertyDomain.Tests
{
    [TestClass]
    public class NameUnitTests
    {
        [TestMethod]
        public void NameObjectConstructedProperlyTest()
        {
            try
            {
                var name = new Name("James", null, "Still");
                Assert.IsNotNull(name);
            }
            catch
            {
                Assert.Fail("Error thrown constructing a Name object.");
            }
        }

        [TestMethod]
        public void FirstNameCannotBeEmptyTest()
        {
            try
            {
                var name = new Name("", null, "Still");
                Assert.Fail("ArgumentException was not throw for empty first name.");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, "You must specify a first name.");
            }
        }

        [TestMethod]
        public void LastNameCannotBeEmptyTest()
        {
            try
            {
                var name = new Name("James", null, "");
                Assert.Fail("ArgumentException was not throw for empty last name.");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, "You must specify a last name.");
            }
        }

        [TestMethod]
        public void FirstNameCannotBeNullTest()
        {
            try
            {
                var name = new Name(null, null, "Still");
                Assert.Fail("ArgumentException was not throw for null first name.");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, "You must specify a first name.");
            }
        }

        [TestMethod]
        public void LastNameCannotBeNullTest()
        {
            try
            {
                var name = new Name("James", null, null);
                Assert.Fail("ArgumentException was not throw for null last name.");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(e.Message, "You must specify a last name.");
            }
        }

        [TestMethod]
        public void FromFirstNameTest()
        {
            var name = new Name("James", null, "Still");
            Assert.IsNotNull(name);
            Assert.AreEqual(name.FirstName, "James");
            Assert.AreEqual(name.LastName, "Still");

            name = name.FromFirstName("Cesar");
            Assert.AreEqual(name.FirstName, "Cesar");
            Assert.AreEqual(name.LastName, "Still");
        }

        [TestMethod]
        public void FromMiddleNameTest()
        {
            var name = new Name("James", "Charles", "Still");
            Assert.IsNotNull(name);
            Assert.AreEqual(name.FirstName, "James");
            Assert.AreEqual(name.MiddleName, "Charles");
            Assert.AreEqual(name.LastName, "Still");

            name = name.FromMiddleName("Estrada");
            Assert.AreEqual(name.FirstName, "James");
            Assert.AreEqual(name.MiddleName, "Estrada");
            Assert.AreEqual(name.LastName, "Still");
        }

        [TestMethod]
        public void FromLastNameTest()
        {
            var name = new Name("James", null, "Still");
            Assert.IsNotNull(name);
            Assert.AreEqual(name.FirstName, "James");
            Assert.AreEqual(name.LastName, "Still");

            name = name.FromLastName("Chavez");
            Assert.AreEqual(name.FirstName, "James");
            Assert.AreEqual(name.LastName, "Chavez");
        }
    }
}
