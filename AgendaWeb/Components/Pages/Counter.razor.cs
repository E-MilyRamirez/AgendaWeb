using Microsoft.Data.SqlClient;
using System.Data;

namespace AgendaWeb.Components.Pages
{
    public partial class Counter
    {
    private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            string connectionString = "Server=localhost;Database=AgendaDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";

            SqlConnection connection = new SqlConnection(connectionString);

            String query = "INSERT INTO Contactos(Nombre, Telefono, Email) VALUES('Desde VS', '6621456823', 'Naura@gmail.com')";

            SqlCommand command = new SqlCommand(query, connection);

            command.CommandType = CommandType.Text;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Dispose();
        }
    }
}