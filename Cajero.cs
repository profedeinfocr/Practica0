using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{
    internal class Cajero
    {
        public Cajero() { }

        public int cedula { get; set; }
        public string nombre { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public int numeroCaja { get; set; }
        public double montoTotal { get; set; }

        public void CrearCajero(int cedula, string nombre, int telefono, string direccion) { }

        public void AsignarCajero(int cedula, int numeroCaja) { }

        public void CerrarCaja(int cedula, double montoTotal) { }

        public void PagarServicios() { }

        public void CambiarCheques() { }

        public void Depositar() { }

    }
}