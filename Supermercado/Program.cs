using Supermercado;

class Program
{
    static void Main(string[] args)
    {
        Producto producto = new Producto(
            "Arroz",
            "Arroz premium",
            "Diana",
            5000,
            55);

        producto.Describir();

        Producto producto2 = new Producto(
            "Café",
            "Nescafé 750 gr ",
            "Nescafé",
            10000,
            65);

        Console.WriteLine("\n");

        producto2.Describir();
    }
}