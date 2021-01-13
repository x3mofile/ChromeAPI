namespace x3.Chrome
{
    public class CreateNewInactiveTabMessage
    {
        public CreateNewInactiveTabMessage(string url) => Url = url;

        public readonly string Url;

        public override string ToString() => $"{Title}{Url}";


        public static string Title => "x3.CreateNewInactiveTab";
        public static CreateNewInactiveTabMessage FromMessage(string message) => new CreateNewInactiveTabMessage(message.eAfterFirst(Title));
        public static bool SharesTitle(string message) => message.StartsWith(Title);
    }

    

    
}