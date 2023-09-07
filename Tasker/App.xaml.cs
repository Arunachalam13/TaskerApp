using Tasker.MVVM.Views;

namespace Tasker;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();
        MainPage = new NavigationPage(new MainView());
        //MainPage = new TiggersDemo();
        //MainPage = new NewTaskView();
    }
}
