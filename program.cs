 using SistemasDeFacturacion.Entidades;

public class SitemaDeFacturacion

{
    public static void Main()
     {
        FacturaEskimo factura = new FacturaEskimo("Jose Martin", 1000);
        // MostrarInformacion(factura);

        MostrarInformacion(factura);
        factura.RegistrarCompra(300, DateTime.UtcNow, "Compra de super eskimo");
        factura.RegistrarCompra(120, DateTime.UtcNow, "Compra de un fruta rellena ");
        try
        {
            factura.RegistrarCompra(130, DateTime.UtcNow, "Compra de ron con pasa");
        }

        catch (Exception exception)

        {
            Console.WriteLine("Excepcion Capturada: " + exception.Message);
        }

        MostrarInformacion(factura);
    }

 

    public static void MostrarInformacion(FacturaEskimo factura)
    {

        Console.WriteLine("===================== Informacion de la factura =====================");
        Console.WriteLine("Numero de factura: " + factura.Numero);
        Console.WriteLine("Cliente: " + factura.Cliente);
        Console.WriteLine("Total: " + factura.Total);
        // Console.WriteLine("===================== Fin =====================");

    }

}