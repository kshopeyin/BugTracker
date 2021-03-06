using BugTracker.Controllers;
using BugTracker.Models;
using Xunit;

namespace BugTracker.BugTrackerTest
{
    public class UserControllerTests
    {
        private readonly IDataProcess<User> _userConnection = new UserController();

        [Fact]
        // Test that the connection is correct.
        public void UserConnectionTest()
        {
            Assert.True(_userConnection.Init());
        }

        // Test the insert function of the controller. Need to figure out how to run this without
        // actually hitting the database.
        [Fact]
        public void UserInsertTest()
        {
            Assert.True(_userConnection.Init());
            Assert.True(_userConnection.Insert(new User("Tom", "Tom", "Smith", "password123", "tom@tom.com", AuthLevel.Admin)));
        }

        [Fact]
        public void UserUpdateTest()
        {
            Assert.True(_userConnection.Init());
            Assert.True(_userConnection.Update(new User(0, "test", "Tester", "McTester", "test", "test@test.com", true,
                AuthLevel.User)));
        }

        // Only run this test when we have to because we will have to query or hardcore that value everytime.
        [Fact]
        public void UserDeleteTest()
        {
            Assert.True(_userConnection.Init());
            Assert.True(_userConnection.Delete(0));
        }

        [Fact]
        public void UserSelectAllTest()
        {
            Assert.True(_userConnection.Init());
            Assert.True(_userConnection.SelectAll().Count > 0);
        }

        [Fact]
        public void UserSelectRowTest()
        {
            Assert.True(_userConnection.Init());
            Assert.True(_userConnection.SelectRow(1) != null);
        }
    }
}