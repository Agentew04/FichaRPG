﻿using Windows.Storage;
using Windows.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Ficha
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ConfigPage : Page
    {
        public ConfigPage()
        {
            this.InitializeComponent();
            savefoldertext.Text = SavingUWP.savefile.Path;

        }
        public ConfigViewModel ViewModel = new ConfigViewModel();

        private void autosaveswitch_IsEnabledChanged(object sender, Windows.UI.Xaml.DependencyPropertyChangedEventArgs e)
        {
            ViewModel.CChangeAutoSave.Execute(e);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewModel.CSetAutoSaveInterval.Execute(e);
        }
    }
}
