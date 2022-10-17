using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{

   
    internal class Caja2 : Cajero, ICajero2
    {
        public Caja2() { }
        Cajero C2 = new Cajero();

        public void CreaCajero()
        { C2.CrearCajero(cedula, nombre, telefono, direccion); }

        public void AsignaCajero()
        { C2.AsignarCajero(cedula, numeroCaja); }

        public void CierraCaja()
        { C2.CerrarCaja(cedula, montoTotal); }

        public void PagaServicios()
        { C2.PagarServicios(); }

        public void CambiaCheques()
        { C2.CambiarCheques(); }

        public void Deposita()
        { C2.Depositar(); }

        public void EmitirChequeras() { }
        public void EmitirBonos() { }


    }
}
