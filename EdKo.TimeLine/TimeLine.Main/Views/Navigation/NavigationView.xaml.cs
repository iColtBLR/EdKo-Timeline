using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.Unity;
using TimeLine.Main.Views.Main;

namespace TimeLine.Main.Views.Navigation {
	/// <summary>
	/// Interaction logic for NavigationView.xaml
	/// </summary>
	public partial class NavigationView : UserControl, INavigationView {
		public NavigationView() {
			InitializeComponent();
		}

		[Dependency]
		public NavigationViewModel ViewModel {
			get {
				return DataContext as NavigationViewModel;
			}
			set {
				DataContext = value;
			}
		}
	}
}