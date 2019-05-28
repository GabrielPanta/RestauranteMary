namespace CADRestauranteMary
{
    using CADRestauranteMary.DSRestauranteMaryTableAdapters;
    public class CADUsuario
    {
        private static UsuarioTableAdapter adaptador = new UsuarioTableAdapter();
        public static bool ValidarUsuario(string Codigo, string Contraseña)
        {
            if (adaptador.ValidaUsuario(Codigo, Contraseña) == null)
            {
                return true;
            }
            return false;
        }
    }
}
