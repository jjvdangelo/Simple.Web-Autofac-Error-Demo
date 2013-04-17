namespace SW.Autofac
{
    using Simple.Web.Autofac;

    public class AutofacConfiguration : AutofacStartupBase
    {
        protected override global::Autofac.IContainer BuildContainer ()
        {
            return new Autofac.AutofacConfiguration ().BuildContainer ();
        }
    }
}