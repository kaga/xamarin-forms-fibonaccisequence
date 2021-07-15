using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace uitest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void GenerateNextNumber()
        {
            app.Screenshot("Before");
            app.Tap(c => c.Marked("GenerateNextNumberButton"));
            app.Screenshot("After");
            var label = app.WaitForElement(c => c.Marked("NumberLabel")).First();
            Assert.AreEqual("2", label.Text);

        }
    }
}
