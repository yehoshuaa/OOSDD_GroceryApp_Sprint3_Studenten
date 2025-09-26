using Grocery.App.ViewModels;
using System.Collections.Generic;   // [verzameling]
using System.Linq;                  // [LINQ]
using System.Windows.Input;         // [opdracht]


namespace Grocery.App.Views;

public partial class GroceryListItemsView : ContentPage
{
	public GroceryListItemsView(GroceryListItemsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}