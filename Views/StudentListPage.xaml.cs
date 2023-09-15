using MauiApp4.ViewModels;

namespace MauiApp4.Views;

public partial class StudentListPage : ContentPage
{
	public StudentListPage(StudentListPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}