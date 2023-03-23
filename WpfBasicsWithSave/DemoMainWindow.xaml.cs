using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
            firstNameModels.Add(new NamesModel() { FirstName = "Bente" });
            firstNameModels.Add(new NamesModel() { FirstName = "Knud" });
            firstNameModels.Add(new NamesModel() { FirstName = "Hanne" });
            firstNameModels.Add(new NamesModel() { FirstName = "Irene" });

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

            // Tofo
            // check if new entry is an empty string, then don't add it

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (LstBxNames.SelectedItem != null)
            {
                firstNameModels.Remove(LstBxNames.SelectedItem as NamesModel);
            }

            // Todo
            // add popup that tells user to select an entry to delete if the user has not selected anything to delete
            // Only give that msg if there is anything in the list to delete
        }

        // This part is not very clear for me. I need to dig deeper to fully follow it
        private void BtnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            // is this simple a string with an index value, and a First Names value - I don't understand this syntax
            saveDataModel.FirstNameData = $"Index, First Names{Environment.NewLine}";

            for (int i = 0; i < firstNameModels.Count; i++)
            {
                saveDataModel.FirstNameData += $"{i+1}, {firstNameModels[i].FirstName} {Environment.NewLine}";
            }

            //
            saveDataModel.FullPath = TxtUCSaveToFileLocation.txtLimitedInput.Text;

            // Write to file
            File.WriteAllText(saveDataModel.FullPath, saveDataModel.FirstNameData);

            // User popup msg ??
            MessageBox.Show($"File Saved at {Environment.NewLine} {saveDataModel.FullPath}");

        }

        // right click on a name entry to change it
        private void CMchangeName_Click(object sender, RoutedEventArgs e)
        {
            if(LstBxNames.SelectedItem != null)
            {
                (LstBxNames.SelectedItem as NamesModel).FirstName = TxtUCEnteredName.txtLimitedInput.Text;
            }

            
        }
    }
}
