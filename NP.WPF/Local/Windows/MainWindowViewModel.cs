using Jamesnet.Core;
using NP.Support.Local.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using Wpf.Ui;
using Wpf.Ui.Controls;
using System.Windows.Controls;

namespace NP.WPF.Local.Windows;
public class MainWindowViewModel : ViewModelBase, IViewLoadable
{
	 
	public ObservableCollection<NavigationViewItem> Naviitems { get; set; } =new ObservableCollection<NavigationViewItem>();

	public ObservableCollection<NavigationViewItem> NavigationFooter { get; set; } = new ObservableCollection<NavigationViewItem>();
	public ObservableCollection<Wpf.Ui.Controls.MenuItem> TrayMenuItems { get; set; } = new ObservableCollection<Wpf.Ui.Controls.MenuItem>();

	public MainWindowViewModel()
	{
		Naviitems.Add(new NavigationViewItem()
		{
			Content = "Home",
			Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
			//TargetPageType = typeof(HomePage)
		});
		Naviitems.Add(new NavigationViewItem()
		{
			Content = "Menu1",
			Icon = new SymbolIcon { Symbol = SymbolRegular.Add28 },
			//TargetPageType = typeof(HomePage)
		});
		Naviitems.Add(new NavigationViewItem()
		{
			Content = "Menu2",
			Icon = new SymbolIcon { Symbol = SymbolRegular.AlbumAdd24 },
		 
			//TargetPageType = typeof(HomePage)
		});


		NavigationFooter =
		[
			 new NavigationViewItem()
				{
					 Content = "Settings",
					 Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
					 TargetPageType = typeof(Local.Pages.SettingsPage)
				},
		  ];

		TrayMenuItems = [new() { Header = "Home", Tag = "tray_home" }];


	}
	private string _currentMenu ="aaaa";


	public string CurrentMenu
	{
		get => _currentMenu;
		set => SetProperty(ref _currentMenu, value);
	}

	public void Loaded()
	{

	}
}
