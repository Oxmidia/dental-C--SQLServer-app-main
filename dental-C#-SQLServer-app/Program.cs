
using dental_C__SQLServer_app.Classes;

namespace dental_C__SQLServer_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        private static readonly Database database = new();
        public static Microsoft.Data.SqlClient.SqlConnection connection = database.Connection();
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Application.Run(new UserPanel());
        }
    }
}
// Modificar el método Main():
if (!DatabaseManager.VerificarAdminExistente())
{
    Application.Run(new Forms.CrearAdminForm()); // Nuevo formulario
}
else
{
    Application.Run(new Forms.LoginForm());
}
