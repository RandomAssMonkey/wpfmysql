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

namespace wpfmysql
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		EmployeeService employeeService;
		public MainWindow()
		{
			InitializeComponent();
			employeeService = new EmployeeService();
			Read();
		}

		private void Read()
		{
			EmployeeTable.ItemsSource = employeeService.GetAll();
		}

		private void AddBtn_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ModifyBtn_Click(object sender, RoutedEventArgs e)
		{

		}

		private void DeleteBtn_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
