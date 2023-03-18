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

        // I may need to have these as nullable
        public string Title { get; set; }

        public int MaxLength { get; set; }  
    }
}
