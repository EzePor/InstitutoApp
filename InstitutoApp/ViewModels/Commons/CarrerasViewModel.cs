using InstitutoApp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoApp.ViewModels.Commons
{
    public class CarrerasViewModel : NotificationObject
    {
		private bool activityStart;

		public bool ActivityStart
		{
			get { return activityStart; }
			set { activityStart = value;
				OnPropertyChanged();
			}
		}

        public CarrerasViewModel()
        {
			activityStart = true;
        }
    }
}
