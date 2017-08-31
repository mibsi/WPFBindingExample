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

namespace WPFBindingExample
{
	/// <summary>
	/// Interaction logic for PageOk.xaml
	/// </summary>
	public partial class PageOk : Page
	{
		public PageOk(int number)
		{
			InitializeComponent();
			textBlock.Text = "Your number is " + number;
		}
	}
}
