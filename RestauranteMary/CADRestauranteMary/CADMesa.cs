
namespace CADRestauranteMary
{
    using CADRestauranteMary.DSRestauranteMaryTableAdapters;
    public class CADMesa
    {
        private static MesaTableAdapter adapter = new MesaTableAdapter();
        public static DSRestauranteMary.MesaDataTable GetData()
        {
            return adapter.GetData();
        }
        public static void InsertMesa(int NumMaxComensales,string Ubicacion)
        {
            adapter.InsertMesa(NumMaxComensales, Ubicacion);
        }

        public static void UpdateMesa(int NumMaxComensales, string Ubicacion, int IdMesa)
        {
            adapter.UpdateMesa(NumMaxComensales, Ubicacion, IdMesa);
        }

        public static void DeleteMesa(int IdMesa)
        {
            adapter.DeleteMesa(IdMesa);
        }
    }
}
