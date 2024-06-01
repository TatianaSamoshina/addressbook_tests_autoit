using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTest : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            List<GroupData> oldgroups = app.Groups.GetGroupList();

            GroupData newGroup = new GroupData() { Name = "test" };

            app.Groups.Add(newGroup);

            List<GroupData> newgroups = app.Groups.GetGroupList();
            oldgroups.Add(newGroup);
            oldgroups.Sort();
            newgroups.Sort();
            Assert.AreEqual(oldgroups, newgroups);
        }
    }
}