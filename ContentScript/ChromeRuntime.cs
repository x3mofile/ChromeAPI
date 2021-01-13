namespace x3.Chrome.ContentScript
{
    public class Null_ChromeRuntime:IChromeRuntime
    {
        public void SendCreateNewInactiveTabMessage(string url)
        {
            //Do nothing
        }
    }


    public abstract class AbstractChromeRuntime:IChromeRuntime
    {
        public void SendCreateNewInactiveTabMessage(string url)
        {
            SendCreateNewInactiveTabMessage(new CreateNewInactiveTabMessage(url));
        }

        protected abstract void SendCreateNewInactiveTabMessage(CreateNewInactiveTabMessage createNewInactiveTabMessage);
        

    }

    public interface IChromeRuntime
    {
        void SendCreateNewInactiveTabMessage(string url);


    }
}
