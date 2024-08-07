namespace Stashify.Views.CRUD.WishList;

public partial class WishListDetailPage : ContentPage
{
    public int ProductId { get; private set; }

    public WishListDetailPage(int prodId)
    {
        InitializeComponent();
        ProductId = prodId;

        BindingContext = this;

        // Load the details for the given ProductId
        //LoadProductDetails();
    }

    //private void LoadProductDetails()
    //{
        // Implementation for loading product details based on ProductId
    //}
}