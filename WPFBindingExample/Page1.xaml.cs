using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPFBindingExample
{
	/// <summary>
	/// Interaction logic for Page1.xaml
	/// </summary>
	public partial class Page1 : Page, INotifyPropertyChanged
	{
		public Page1()
		{
			InitializeComponent();
			DataContext = this;

		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private int myNumber;
		public string MyNumber
		{
			get
			{
				return myNumber.ToString();
			}
			set
			{
				try
				{
					int.TryParse(value, out myNumber);
					OnPropertyChanged("MyNumber");
				}
				catch (Exception)
				{ }
			}
		}

		private void tbMyNumber_TextChanged(object sender, TextChangedEventArgs e)
		{
			try
			{
				TextBox tb = (TextBox)sender;
				int f;
				if (tb.Text != "")
				{
					if (!int.TryParse(tb.Text, out f))
						throw new Exception();
				}
			}
			catch (Exception)
			{
				tbMyNumber.Text = "";
			}
		}

		private void btnNext_Click(object sender, RoutedEventArgs e)
		{
			this.NavigationService.Navigate(new PageOk(myNumber));
		}
	}
}
