using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeLine.Infrastucture.ViewComponents.Interfaces;

namespace TimeLine.Main.Views.Navigation {
	public interface INavigationView : IView {
		NavigationViewModel ViewModel {
			get;
		}
	}
}
