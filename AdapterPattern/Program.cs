using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio Patrón Adaptador

            • Crear un servicio devuelva una lista de entidades que contiene el id de la sucursal y el
            nombre de la sucursal, así como un total de ventas del día.
            • Crear un segundo servicio que devuelva un json que incluye cadenas con el id de la
            sucursal y el nombre de la sucursal, así como un total de ventas del día.
            • Crear un servicio que consuma el primer servicio (recibirá como dependencia la interfaz
            del primer servicio)
            • Modificación:
            • Se requiere cambiar el primer servicio por el segundo servicio para recuperar las
            sucursales. 
            */
            IJsonService jsonService = new JsonService();
            IVentasService adapter = new Adapter(jsonService);

            IVentasPrinter ventasPrinter = new AdapterClient(adapter);
            ventasPrinter.PrintSales();

        }
    }
}
