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

namespace WpfBasicsWithSave
{
    /// <summary>
    /// Interaction logic for UCLabelTextBoxInput.xaml
    /// </summary>
    public partial class UCLabelTextBoxInput : UserControl
    {
        public UCLabelTextBoxInput()
        {
            InitializeComponent();

            this.DataContext = this;
        }
       


        // PROBERTY EXAMPLE ----- NOT USED IN TUTORIAL
        //public string name;
        //public string TitleWithGetSet
        //{
        //    get { return name; }
        //    set
        //    {
        //        name = value;
        //    }
        //}
        // EXAMPLE END


        // I may need to have these as nullable

        // These two are auto proberty's, they have the same functionality as the example above
        // IT automatecly creates a var called title and maxLenght ?? - Not sure about this ??
        public string Title { get; set; }

        public int MaxLength { get; set; }  
    }
}
