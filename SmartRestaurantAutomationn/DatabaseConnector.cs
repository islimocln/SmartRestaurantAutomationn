using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SmartRestaurantAutomationn
{
    internal class DatabaseConnector
    {
        private MySqlConnection connection;

        // Constructor - Sınıf oluşturulurken bağlantı otomatik olarak açılır
        public DatabaseConnector()
        {
            
            string connectionString = "Server=localhost;Port=3307;Database=restoran_otomasyonu;Uid=root;Pwd=DataSafe1234;";

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Veritabanına bağlandı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bağlantı hatası: {ex.Message}");
                throw;
            }
        }

        // Bağlantı nesnesini döndürmek için bir özellik
        public MySqlConnection Connection
        {
            get { return connection; }
        }
    }
}
