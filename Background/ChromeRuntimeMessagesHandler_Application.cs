

namespace x3.Chrome.Background
{
    public class ChromeRuntimeMessagesHandler_Application:IChromeRuntimeMessagesHandler_Application
    {
        private readonly IChromeRuntimeMessagesHandler ChromeRuntimeMessagesHandler;

        public ChromeRuntimeMessagesHandler_Application(IChromeRuntimeMessagesHandler chromeRuntimeMessagesHandler)
        {
            ChromeRuntimeMessagesHandler=chromeRuntimeMessagesHandler;
        }
        public void Run()
        {
            ChromeRuntimeMessagesHandler.StartHandlingRuntimeMessages();
        }



    }


    public interface IChromeRuntimeMessagesHandler_Application
    {
        void Run();

    }
}