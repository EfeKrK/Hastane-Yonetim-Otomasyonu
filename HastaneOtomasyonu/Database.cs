using System;
using MySql.Data.MySqlClient;

namespace HastaneOtomasyonu
{
    internal class Database
    {
        public static string ConnectionString { get; private set; }

        public MySqlConnection Connection { get; private set; }

        public Database()
        {
            // MySQL bağlantı bilgilerini belirt
            
            ConnectionString = "Server=localhost;Port=3306;Database=hastaneotomasyonu;User ID=root;Password=;";

            // Bağlantıyı oluştur
            Connection = new MySqlConnection(ConnectionString);
        }

        public void OpenConnection()
        {
            try
            {
                // Bağlantıyı aç
                Connection.Open();
                Console.WriteLine("MySQL bağlantısı başarıyla açıldı.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL bağlantı hatası: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                // Bağlantıyı kapat
                Connection.Close();
                Console.WriteLine("MySQL bağlantısı başarıyla kapatıldı.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL bağlantı kapatma hatası: " + ex.Message);
            }
        }
    }
}
