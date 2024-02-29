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

namespace Practicheskaya2
{
   
    public partial class MainWindow : Window
    {
        List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            Users.ItemsSource = people;
        }

        private void Registr(object sender, RoutedEventArgs e)
        {
            if (firstPassword.Text == secondPassword.Text)
            {
                DateTime? selectedDate = birthday.SelectedDate;
                //people.Add(new Person(firstName.Text, lastName.Text, patronymic.Text, selectedDate.Value.ToShortDateString()));
                people.Add(new Person { FirstName = firstName.Text, LastName = lastName.Text, Patronymic = patronymic.Text, Birthday = selectedDate.Value.Date.ToShortDateString() });
                Users.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}
