namespace SW.Autofac
{
    using Simple.Web;

    [UriTemplate("/")]
    public class Home : IGet
    {
        public Status Get () { return 200; }
    }
}