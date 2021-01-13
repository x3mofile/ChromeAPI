using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x3.Chrome
{
    public class Null_ChromeRuntime:IChromeRuntime
    {
        public void SendCreateNewInactiveTabMessage(string url)
        {
            //Do nothing
        }
    }



    public interface IChromeRuntime
    {
        void SendCreateNewInactiveTabMessage(string url);


    }

    public abstract class AbstractChromeRuntime:IChromeRuntime
    {
        public void SendCreateNewInactiveTabMessage(string url)
        {
            SendCreateNewInactiveTabMessage(new CreateNewInactiveTabMessage(url));
        }

        protected abstract void SendCreateNewInactiveTabMessage(CreateNewInactiveTabMessage createNewInactiveTabMessage);



    }
}
