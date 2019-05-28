
namespace CADRestauranteMary
{
    using CADRestauranteMary.DSRestauranteMaryTableAdapters;
    public class CADCocinero
    {
        private static CocineroTableAdapter adapter = new CocineroTableAdapter();
        public static DSRestauranteMary.CocineroDataTable GetData()
        {
            return adapter.GetData();
        }
        public static void InsertCocinero(string Nombre,string Apellidos)
        {
            adapter.InsertCocinero(Nombre, Apellidos);
        }
        public static void UpdateCocinero(string Nombre,string Apellidos,int IdCocinero)
        {
            adapter.UpdateCocinero(Nombre, Apellidos, IdCocinero);
        }
        public static void DeleteCocinero(int IdCocinero)
        {
            adapter.DeleteCocinero(IdCocinero);
        }
    }
}
