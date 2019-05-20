using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeLine.Infrastucture.ViewComponents.Interfaces;

namespace TimeLine.Main.Views.Main
{
    public interface IMainView : IView
    {
        MainViewModel ViewModel
        {
            get;
        }
    }
}
