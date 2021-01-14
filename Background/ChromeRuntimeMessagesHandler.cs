namespace x3.Chrome.Background
{
    public class ChromeRuntimeMessagesHandler:IChromeRuntimeMessagesHandler
    {
        private readonly IChromeRuntime Runtime;
        private readonly IChromeTabs Tabs;

        public ChromeRuntimeMessagesHandler(IChromeRuntime runtime, IChromeTabs tabs)
        {
            Runtime=runtime;
            Tabs=tabs;
            Setup();

        }

        private void Setup()
        {
            Runtime.CreateNewInactiveTabMessage+=Tabs.CreateNewInactiveTab;
        }

        public void StartHandlingRuntimeMessages()
        {
            Runtime.StartListeningToRuntimeMessages();
        }
    }

    public interface IChromeRuntimeMessagesHandler
    {
        void StartHandlingRuntimeMessages();

    }

}