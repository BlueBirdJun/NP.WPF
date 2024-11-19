using Jamesnet.Core;
using NP.Home.Local.ViewModels;
using NP.Home.Views;
using NP.Main.Local.ViewModels;
using NP.Main.Views;
using NP.Menu.Local.ViewModels;
using NP.Menu.Views;
using NP.Support.Local.Services;
using NP.Task1.Local.ViewModels;
using NP.Task1.Views;

namespace NP.WPF;

public class NPBootStrap : AppBootstrapper
{
	protected override void OnStartup()
	{
		ViewModelMapper.Register<MainContent, MainContentVM>();
		ViewModelMapper.Register<MenuContent, MenuVM>();
		ViewModelMapper.Register<Task1Content, Task1ContentVM>();
		ViewModelMapper.Register<HomeContent, HomeContentVM>();

	}

	protected override void RegisterDependencies()
	{

		


		Container.RegisterSingleton<IView, MainContent>();
		Container.RegisterSingleton<IView, MenuContent>();
		Container.RegisterSingleton<IView, Task1Content>();
		Container.RegisterSingleton<IView, HomeContent>();

		IView mainContent = Container.Resolve<MainContent>();
		IView HomeContent = Container.Resolve<HomeContent>();

		Layer.Mapping("MainLayer", mainContent);
	}

	protected override void RegisterViewModels()
	{
		
	}
}
