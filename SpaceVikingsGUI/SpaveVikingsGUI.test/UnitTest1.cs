//using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Xunit;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Tests
{
    public class LoginTest
    {
        [Fact]
        public void GettingStarted()
        {
            Application application =
                Application.Launch(
                    @"D:\Skoli\Skoli\4.SEMESTER\PRJ4\GUI_V2\SpaceVikingsGUI\SpaceVikingsGUI\bin\Debug\SpaceVikingsGUI.exe");
            Window main = application.GetWindow("MainWindow");
            main.Get<TextBox>(SearchCriteria.Indexed(0)).Text = "test";
            var pass = main.Get<TextBox>(SearchCriteria.Indexed(1));
            pass.BulkText = "string";
            //main.Get<Button>(SearchCriteria.ByText("Login")).Click();
            Assert.That(pass.BulkText,Is.EqualTo("string"));
                
        }
        
        


    }
}