using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactListLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Service service = new Service();
            service.AddGroup(new Group());
            Group g1 = new Group("g1");
            Assert.IsNull(service.FindGroup(g1.GroupName));
            service.AddGroup(g1);
            Assert.AreSame(g1, service.FindGroup(g1.GroupName));
            Person p1 = new Person("p1");
            service.AddPerson("g1", p1);
            Assert.AreSame(p1, service.FindPerson("p1"));
            service.RemoveGroup(g1);
            Assert.IsNull(service.FindGroup(g1.GroupName));
            //Assert
        }
        [TestMethod]
        public void TestSerialization()
        {
            Service service = new Service();
            service.AddGroup(new Group("p1"));
            service.AddGroup(new Group("p2"));
            service.AddPerson(null, new Person("aa", "110"));
            service.AddPerson("p1", new Person("bb", "120"));
            service.Serialization.Serialization(service.ContactList);
        }
    }
}
