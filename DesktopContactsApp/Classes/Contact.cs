using SQLite;

namespace DesktopContactsApp.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Email}-{Phone}";
        }
    }
}
