using Jamesnet.Core;
using NP.Main.Local.ViewModels;
using NP.Main.Views;
using NP.Menu.Local.ViewModels;
using NP.Menu.Views;
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
	}

	protected override void RegisterDependencies()
	{
		Container.RegisterSingleton<IView, MainContent>();
		Container.RegisterSingleton<IView, MenuContent>();
		Container.RegisterSingleton<IView, Task1Content>();

		IView mainContent = Container.Resolve<MainContent>();

		Layer.Mapping("MainLayer", mainContent);
	}

	protected override void RegisterViewModels()
	{
		
	}
}
