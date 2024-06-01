using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupDeletionTest : TestBase
    {
        [Test]
        public void TestGroupDeletion()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            if (oldGroups.Count == 0) // Если нет групп, создаем новую
            {
                GroupData newGroup = new GroupData() { Name = "test" };
                app.Groups.Add(newGroup);
                oldGroups = app.Groups.GetGroupList();
            }

            app.Groups.Remove(0); 

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
