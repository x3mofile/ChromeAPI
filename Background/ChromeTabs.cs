namespace x3.Chrome.Background
{
    public abstract class AbstractChromeTabs:IChromeTabs
    {
        public void CreateNewInactiveTab(CreateNewInactiveTabMessage createNewInactiveTabMessage)
        {
            CreateNewInactiveTab(createNewInactiveTabMessage.Url);
        }
        protected abstract void CreateNewInactiveTab(string url);
    }

    public interface IChromeTabs
    {
        void CreateNewInactiveTab(CreateNewInactiveTabMessage createNewInactiveTabMessage);
    }
}