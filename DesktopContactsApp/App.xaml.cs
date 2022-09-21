using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string database = "Contacts.db";
        public static string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        public static string databasePath = Path.Combine(folderPath, database);
    }
}
