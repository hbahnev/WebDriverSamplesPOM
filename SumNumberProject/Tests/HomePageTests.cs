using NUnit.Framework;

namespace SumNumberProject.Tests
{
    public class HomePageTests : BaseTests
    {
        [Test]
        public void Test_HomePage_TitleAndHeading()
        {
            var page = new HomePage(driver);
            page.Open();
            Assert.That(page.GetPageTitle(), Is.EqualTo("MVC Example"));
            Assert.That(page.GetPageHeadingTexts(), Is.EqualTo("Students Registry"));
            Assert.Greater(page.GetStudentsCount(), 0);
        }

        [Test]
        public void Test_HomePage_OpenViewStudentsPage()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.LinkViewStudentPage.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).isOpen());
        }

        [Test]
        public void Test_HomePage_OpenAddStudentPage()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.LinkAddStudentPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).isOpen());
        }

        [Test]
        public void Test_HomePage_ViewHomeLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.LinkHomePage.Click();
            Assert.IsTrue(home_page.isOpen());
        }

        [Test]
        public void Test_HomePage_Content()
        {
            var home_page = new HomePage(driver);
            home_page.Open();

            Assert.AreEqual("MVC Example", home_page.GetPageTitle());
            Assert.AreEqual("Students Registry", home_page.GetPageHeadingTexts());
            home_page.GetStudentsCount();
        }
    }
}