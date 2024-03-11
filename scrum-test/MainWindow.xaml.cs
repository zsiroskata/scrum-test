using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace scrum_test
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
			lbl1f.Content = ((ListBoxItem)lbx1.SelectedItem).Content;
			lbl2f.Content = ((ComboBoxItem)cmb1.SelectedItem).Content;

			lbx3f.Items.Clear();
            foreach (CheckBox checkBox in stackP3f.Children)
            {
				if (checkBox.IsChecked == true)
				{
					lbx3f.Items.Add(checkBox.Content);
				}
            }
        }
    }
}