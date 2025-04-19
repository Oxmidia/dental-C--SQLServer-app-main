public static class GeneradorPDF
{
    public static void GenerarRecibo(string paciente, string monto, ...)
    {
        Document doc = new Document();
        PdfWriter.GetInstance(doc, new FileStream($"Recibo_{DateTime.Now:yyyyMMdd}.pdf", FileMode.Create));
        // Añadir logo, tabla, etc. (como en ejemplos anteriores)
    }
}