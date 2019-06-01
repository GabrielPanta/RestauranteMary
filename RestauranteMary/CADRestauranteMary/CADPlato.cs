
using CADRestauranteMary.DSRestauranteMaryTableAdapters;

namespace CADRestauranteMary
{
    public class CADPlato
    {
        private static PlatoTableAdapter adapter = new PlatoTableAdapter();
        public static DSRestauranteMary.PlatoDataTable GetData()
        {
            return adapter.GetData();
        }
        public static void InsertPlato(string Nombre, string Descripcion)
        {
            adapter.InsertPlato(Nombre, Descripcion);
        }
        public static void UpdatePlato(string Nombre, string Descripcion, int IdPlato)
        {
            adapter.UpdatePlato(Nombre, Descripcion, IdPlato);
        }
        public static void DeletePlato(int IdPlato)
        {
            adapter.DeletePlato(IdPlato);
        }
    }
}
