using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NP.WPF;
public partial class App : Application
{
	public App()
	{
		var bootstrapper = new NPBootStrap();
		bootstrapper.Run();
	}
}