public partial class CrearAdminForm : Form
{
    private void btnGuardar_Click(object sender, EventArgs e)
    {
        string sql = @"INSERT INTO usuarios (usuario, contraseña, pregunta1, respuesta1, pregunta2, respuesta2, rol) 
                       VALUES (@user, @pass, @p1, @r1, @p2, @r2, 'admin')";
        // Usar DatabaseManager para ejecutar (similar a otros forms)
    }
}