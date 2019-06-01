

namespace CADRestauranteMary
{
    using CADRestauranteMary.DSRestauranteMaryTableAdapters;

    public class CADMoso
    {
        private static MosoTableAdapter adapter = new MosoTableAdapter();
        public static DSRestauranteMary.MosoDataTable GetData()
        {
            return adapter.GetData();
        }
        public static void InsertMoso(string Nombre, string Apellidos)
        {
            adapter.InsertMoso(Nombre, Apellidos);
        }
        public static void UpdateMoso(string Nombre, string Apellidos, int IdMoso)
        {
            adapter.UpdateMoso(Nombre, Apellidos, IdMoso);
        }
        public static void DeleteMoso(int IdMoso)
        {
            adapter.DeleteMoso(IdMoso);
        }
    }
}
