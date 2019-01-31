namespace ON4X.Infrastructure
{
    using ON4X.ViewModels;

    class InstanceLocator
    {

        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
