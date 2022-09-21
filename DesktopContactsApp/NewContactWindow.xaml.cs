using DesktopContactsApp.Classes;
using SQLite;
using System.IO;
using System.Windows;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact();
            contact.Name = nameTextBox.Text;
            contact.Email = emailTextBox.Text;
            contact.Phone = phonenoTextBox.Text;
          
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                _ = connection.CreateTable<Contact>();
                _ = connection.Insert(contact);
            }
            Close();
        }
    }
}
