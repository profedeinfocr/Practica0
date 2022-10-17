using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{
   
    public class Caja1 : Cajero, ICajero1
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

        public void EmitirTarjetaCredito() {}
        public void EmitirTarjetaDebito() { }
        public void EmitirTarjetaPrepago() { }

    }
}
