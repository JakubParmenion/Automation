using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Automation.Support
{
    interface ITestingFramework
    {
        void maximize();

        void cleanAllCookies();

        void navigateToWebPage(String pageUrl);

        void click(String xPath);

        void quiteAndFinish();

        void sendKeys(String xPath, String keys);

        string getText(String xPath);
    }
}
