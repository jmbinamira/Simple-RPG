using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BaseNotificationClass : INotifyPropertyChanged  
    {
        //#1
        public event PropertyChangedEventHandler PropertyChanged;  
        //#2
        protected virtual void OnPropertyChanged(string propertyName)  
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


/*
> Used whenever a class notifies other classes if its properties changed (requires 2 things)
*/
