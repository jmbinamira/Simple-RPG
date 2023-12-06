using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BaseNotificationClass : INotifyPropertyChanged  //Used whenever a class notifies other classes if its properties changed (requires 2 things)
    {
        public event PropertyChangedEventHandler PropertyChanged;  //#1
        protected virtual void OnPropertyChanged(string propertyName)  //#2
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
