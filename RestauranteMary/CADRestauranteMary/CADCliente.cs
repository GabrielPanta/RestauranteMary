using CADRestauranteMary.DSRestauranteMaryTableAdapters;
namespace CADRestauranteMary
{
    public class CADCliente
    {
        private static ClienteTableAdapter adapter = new ClienteTableAdapter();
        public static DSRestauranteMary.ClienteDataTable GetData()
        {
            return adapter.GetData();
        }

        public static void InsertCliente(string Nombre, string Apellidos, string Observaciones)
        {
            adapter.InsertCliente(Nombre, Apellidos, Observaciones);
        }

        public static void UpdateCliente(string Nombre, string Apellidos, string Observaciones,int IdCliente)
        {
            adapter.UpdateCliente(Nombre, Apellidos, Observaciones,IdCliente);
        }

        public static void DeleteCliente(int IdCliente)
        {
            adapter.DeleteCliente( IdCliente);
        }
    }
}
