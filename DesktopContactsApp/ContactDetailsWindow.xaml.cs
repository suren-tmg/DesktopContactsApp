using DesktopContactsApp.Classes;
using SQLite;
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
using System.Windows.Shapes;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for ContactDetailsWindow.xaml
    /// </summary>
    public partial class ContactDetailsWindow : Window
    {
        private readonly Contact contact;
        public ContactDetailsWindow(Contact _contact)
        {
            InitializeComponent();

            contact = _contact;

            SetValue();
        }

        private void SetValue()
        {
            nameTextBox.Text = contact.Name;
            emailTextBox.Text = contact.Email;
            phonenoTextBox.Text = contact.Phone;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            contact.Name = nameTextBox.Text;
            contact.Email = emailTextBox.Text;
            contact.Phone = phonenoTextBox.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                _ = connection.CreateTable<Contact>();
                _ = connection.Update(contact);
            }
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                _ = connection.CreateTable<Contact>();
                _ = connection.Delete(contact);
            }
            Close();
        }
    }
}
