using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
//using ClassLib;
using ClassLib;


namespace TestProject1
{

    public class Login__1_ : BaseWebAiiTest
    {
        ClassLib.MyClass obj = new ClassLib.MyClass();
        //Test_16_09.Class1 cls = new Test_16_09.Class1();
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Wait for Exists 'LogMeOutLink'")]
        public void Login_CodedStep()
        {
            // Wait for Exists 'LogMeOutLink'
            
           
            
            Pages.MyAccountMyStore.LogMeOutLink.Wait.ForExists(Class12.timeOut);
            
        }
    
        [CodedStep(@"Enter text 'catharin.mathumitha@gmail.com' in 'EmailText'")]
        public void Login_1_CodedStep()
        {
            // Enter text 'catharin.mathumitha@gmail.com' in 'EmailText'
           // Actions.SetText(Pages.LoginMyStore.EmailText, Class1.username);
           /* string username;
            string name1 = Class1.method(name.ToString());
           
            Actions.SetText(Pages.LoginMyStore.EmailText,name1);*/
          //  string user = Test_16_09.Class1.navigate(name);
            
            //string text = ClassLib.MyClass.
            
            string name2 = ClassLib.MyClass.username;
            Actions.SetText(Pages.LoginMyStore.EmailText, name2);
            Console.WriteLine(name2);
            
            
            
        }
    }
}
