using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{
    public class Cajero
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

        /*public interface ICajero1
        {
            void EmitirTarjetaCredito();
            void EmitirTarjetaDebito();
            void EmitirTarjetaPrepago();

        }*/

        /*class Caja1 : Cajero, ICajero1
        {
            public Caja1() { }
            Cajero C1 = new Cajero();

            public void CreaCajero()
            { C1.CrearCajero(cedula, nombre, telefono, direccion); }

            public void AsignaCajero()
            { C1.AsignarCajero(cedula, numeroCaja); }

            public void CierraCaja()
            { C1.CerrarCaja(cedula, montoTotal); }

            public void PagaServicios()
            { C1.PagarServicios(); }

            public void CambiaCheques()
            { C1.CambiarCheques(); }

            public void Deposita()
            { C1.Depositar(); }

            public void EmitirTarjetaCredito() { }
            public void EmitirTarjetaDebito() { }
            public void EmitirTarjetaPrepago() { }
        }*/
    }
}