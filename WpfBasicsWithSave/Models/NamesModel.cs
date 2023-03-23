using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBasicsWithSave.Models // not sure if its Model
{
    public class NamesModel : INotifyPropertyChanged
    {
        // Encapsulation
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                this.NotifyPropertyChanged("firstName");
                    }
        }

        // Handles update the UI.this consept is very important, i need to dig deeper
        // I think i have to use methods similar to this for every object i want to update, and display to the user in an app.
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string probertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(probertyName));
            }
        }
    }
}
