using Tasker.MVVM.ViewModels;

namespace Tasker.MVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel mainViewModel;
	public MainView()
	{
		InitializeComponent();
        mainViewModel = new MainViewModel();
		BindingContext = mainViewModel;
	}

    private void checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        mainViewModel.UpdateData();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		var taskView = new NewTaskView
		{
			BindingContext = new NewTaskViewModel
			{
				Tasks = mainViewModel.Tasks,
				Categories = mainViewModel.Categories,
			}
		};
		Navigation.PushAsync(taskView);
    }
}