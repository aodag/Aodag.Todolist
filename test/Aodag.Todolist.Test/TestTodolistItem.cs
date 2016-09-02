using Xunit;

namespace Aodag.Todolist
{
    public class TestTodolistItem
    {
        [Fact]
        public void Finish()
        {
            var target = new Models.TodolistItem();
            target.Finish();
            Assert.True(target.Finished);
        }
    }
}
