namespace x3.Chrome
{
    public class CreateNewInactiveTabMessage
    {
        public static CreateNewInactiveTabMessage FromMessage(string message)
        {
            return new CreateNewInactiveTabMessage(message.eAfterFirst(Title));
        }

        public CreateNewInactiveTabMessage(string url)
        {
            Url = url;
        }

        public readonly string Url;

        public static bool SharesTitle(string message) => message.StartsWith(Title);
        public static string Title => "x3.CreateNewInactiveTab";
        public override string ToString() => $"{Title}{Url}";

    }

    

    
}