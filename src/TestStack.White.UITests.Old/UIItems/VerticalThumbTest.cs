using NUnit.Framework;
using White.Core.UIItems;
using White.Core.UITests.Testing;

namespace White.Core.UITests.UIItems
{
    [TestFixture, WPFCategory]
    public class VerticalThumbTest : ControlsActionTest
    {
        protected override string CommandLineArguments
        {
            get { return VerticalGridSplitter; }
        }

        [Test]
        public void Find()
        {
            var thumb = Window.Get<Thumb>("splitter");
            Assert.AreNotEqual(null, thumb);
        }

        [Test]
        public void Slide()
        {
            var thumb = Window.Get<Thumb>("splitter");
            double originalY = thumb.Location.Y;
            thumb.SlideVertically(50);
            Assert.AreEqual(originalY + 50, thumb.Location.Y);
        }
    }
}