public partial class ReciboForm : Form
{
    private void btnGenerarPDF_Click(object sender, EventArgs e)
    {
        // Validaciones
        if (!decimal.TryParse(txtMonto.Text, out _))
        {
            MessageBox.Show("Monto inválido");
            return;
        }
        // Generar PDF
        GeneradorPDF.GenerarRecibo(txtPaciente.Text, txtMonto.Text, ...);
    }
}