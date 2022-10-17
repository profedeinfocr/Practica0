using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{
    internal class Caja3 : Cajero
    {
        public Caja3() { }
        Cajero C3 = new Cajero();

        public void CreaCajero()
        { C3.CrearCajero(cedula, nombre, telefono, direccion); }

        public void AsignaCajero()
        { C3.AsignarCajero(cedula, numeroCaja); }

        public void CierraCaja()
        { C3.CerrarCaja(cedula, montoTotal); }

        public void PagaServicios()
        { C3.PagarServicios(); }

        public void CambiaCheques()
        { C3.CambiarCheques(); }

        public void Deposita()
        { C3.Depositar(); }

    }
}
