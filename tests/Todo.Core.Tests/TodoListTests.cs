namespace Todo.Core.Tests
{
    using System.Linq;
    using Todo.Core;
    using Xunit;

    public class TodoListTests
    {
        [Fact]
        public void AddIncrementsCount()
        {
            var list = new TodoList();
            _ = list.Add("task");

            Assert.Equal(1, list.Count);
        }

        [Fact]
        public void RemoveByIdWorks()
        {
            var list = new TodoList();
            var i = list.Add("a");

            Assert.True(list.Remove(i.Id));
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void FindReturnsMatches()
        {
            var list = new TodoList();
            _ = list.Add("Buy milk");
            _ = list.Add("Read book");

            var found = list.Find("buy").ToList();
            Assert.Single(found);
        }
    }
}
