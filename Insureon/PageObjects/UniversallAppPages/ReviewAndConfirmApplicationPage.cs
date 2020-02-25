using Insureon.PageObjects.AgencyPortalPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Insureon.PageObjects.UniversallAppPages
{
    public class ReviewAndConfirmApplicationPage : BaseUniAppPage
    {
        public ReviewAndConfirmApplicationPage()
        {

        }

        public ClientDetailsPage NavigateToClientDetailsPage()
        {
            submitButton.Click();
            Thread.Sleep(100000);
            return new ClientDetailsPage();
        }
    }
}
