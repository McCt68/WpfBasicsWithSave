using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using WpfBasicsWithSave.Models;

namespace WpfBasicsWithSave
{
    /// <summary>
    /// Interaction logic for DemoMainWindow.xaml
    /// </summary>
    public partial class DemoMainWindow : Window
    {

        SaveDataModel saveDataModel = new SaveDataModel(); 

        // Instatiating an ObserableCollection (Similar to a List) containing FirstNameModel's where each model is a unique name ??
        ObservableCollection<NamesModel> firstNameModels = new ObservableCollection<NamesModel>();
        public DemoMainWindow()
        {
            InitializeComponent(); // I think this kinda build the WPF window ??

            TxtUCSaveToFileLocation.txtLimitedInput.Text = saveDataModel.FullPath; 
            TxtUCEnteredName.txtLimitedInput.Text = "Michael";

            // fake data
            firstNameModels.Add(new NamesModel() { FirstName = "Bente"});
            firstNameModels.Add(new NamesModel() { FirstName = "Knud"});
            firstNameModels.Add(new NamesModel() { FirstName = "Hanne"});
            firstNameModels.Add(new NamesModel() { FirstName = "Irene"});
                       
            //
            LstBxNames.DisplayMemberPath = "FirstName";

            // Update the ListView in the UI when the user add a new name with BtnAddName_Click
            LstBxNames.ItemsSource = firstNameModels; // need to add a name to the listview in xaml ??


        }

        // This method run when we click the Add Name To List button
        private void BtnAddName_Click(object sender, RoutedEventArgs e)
        {
            // 
            // firstNameModels.Add(new NamesModel() { FirstName = TxtUCEnteredName.txtLimitedInput.Text });

            // Add to first index, to always show new entry on top - not in tutorial
            firstNameModels.Add(new NamesModel() { FirstName = TxtUCEnteredName.txtLimitedInput.Text });

            // Todo
            // Clear the text field after the user press enter, to make it ready for another entry
            TxtUCEnteredName.txtLimitedInput.Text = ""; // Not in the tutorial

            // Todo
            // Place cursor so its ready to input another name - Not in the tutorial              
            TxtUCEnteredName.txtLimitedInput.Focus();

        }
    }
}
