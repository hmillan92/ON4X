namespace ON4X.ViewModels
{
    public class MainViewModel
    {

        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            this.Products = new ProductsViewModel();
        }
    }
}
