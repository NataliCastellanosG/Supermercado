using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class Producto
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }

        private float valor;

        private float descuento;

        public float Valor
        {
            get { return valor; }
            set
            {
                if (value >= 0)
                    valor = value;
                else
                    Console.WriteLine('\n' + "El valor no puede ser negativo");
            }
        }

        public float Descuento
        {
            get { return descuento; }
            set
            {
                if (value >= 0 && value <= 60) descuento = value;
                else Console.WriteLine('\n' + "El descuento debe estar entre 0% y 60%");
            }
        }

        public Producto(string _nombre, string _descripcion, string _marca, float _valor, float _descuento)
        {
            nombre = _nombre;
            descripcion = _descripcion;
            marca = _marca;
            Valor = _valor;
            Descuento = _descuento;
        }

        public void Describir()
        {
            Console.WriteLine("Producto: " + nombre);
            Console.WriteLine("Descripción: " + descripcion);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Valor: " + Valor);
            Console.WriteLine("Descuento: " + Descuento);
        }

    }
}

