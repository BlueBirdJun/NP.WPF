using NP.Support.UI.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NP.Support.UI.Features;
public class NPWallpaper :Control
{
	public static readonly DependencyProperty MenuNameProperty = DependencyProperty.Register("MenuName", typeof(string), typeof(NPWallpaper), new PropertyMetadata(null, OnMenuNameChanged));
	public string MenuName
	{
		get { return (string)GetValue(MenuNameProperty); }
		set { SetValue(MenuNameProperty, value); }
	}

	public NPWallpaper()
	{
		DefaultStyleKey = typeof(NPWallpaper);
	}

	private static void OnMenuNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is NPWallpaper wallpaper)
		{
			wallpaper.UpdateVisualState();
		}
	}

	private void UpdateVisualState()
	{
		switch (MenuName)
		{
			case "COLLECTION": VisualStateManager.GoToState(this, "ExpandedSidebarState", false); break;
			case "SHOP": VisualStateManager.GoToState(this, "ExpandedSidebarState", false); break;
			case "PROFILE": VisualStateManager.GoToState(this, "ExpandedSidebarState", false); break;
			case "CLASH": VisualStateManager.GoToState(this, "MediumSidebarState", false); break;
			case "TFT": VisualStateManager.GoToState(this, "NarrowSidebarState", false); break;
			default: VisualStateManager.GoToState(this, "DefaultState", false); break;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		UpdateVisualState();
	}
}
