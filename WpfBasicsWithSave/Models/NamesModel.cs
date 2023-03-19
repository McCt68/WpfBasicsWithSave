using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBasicsWithSave.Models // not sure if its Model
{
    public class NamesModel
    {
        // Encapsulation
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }
}
