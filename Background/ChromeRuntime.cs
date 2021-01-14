using System;

namespace x3.Chrome.Background
{
    public abstract class AbstractChromeRuntime:IChromeRuntime
    {
        public abstract void StartListeningToRuntimeMessages();
        public event Action<CreateNewInactiveTabMessage> CreateNewInactiveTabMessage;

        protected void StringMessageHandler(string stringMessage)
        {
            if(Chrome.CreateNewInactiveTabMessage.SharesTitle(stringMessage))
            {
                OnCreateNewInactiveTabMessage(Chrome.CreateNewInactiveTabMessage.FromMessage(stringMessage));
            }
        }

        private void OnCreateNewInactiveTabMessage(CreateNewInactiveTabMessage createNewInactiveTabMessage)
        {
            CreateNewInactiveTabMessage?.Invoke(createNewInactiveTabMessage);
        }

    }

    public interface IChromeRuntime
    {
        void StartListeningToRuntimeMessages();
        event Action<CreateNewInactiveTabMessage> CreateNewInactiveTabMessage;
    }
    

}
