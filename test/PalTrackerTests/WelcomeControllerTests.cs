using PalTracker;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PalTrackerTests
{
    public class WelcomeControllerTests
    {
        [Fact]
        public void GetTest()
        {
            WelcomeMessage message = new WelcomeMessage("Testing");
            WelcomeController controller = new WelcomeController(message);
            string result = controller.SayHello();
            Assert.NotEmpty(result);
            Assert.NotNull(result);
            Assert.True(result.Length > 1);
            
        }
    }
}
