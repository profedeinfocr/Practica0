using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{
    internal class Menu
    {
        public Menu()//Constructor de Clase Menu
        {
        }

        public int tipoUsuario { get; set; }
        public int servicio { get; set; }
        public int servicioCajero { get; set; }
        enum Riesgo { 
        
        Bajo,
        Medio,
        Alto
        
        }

        Riesgo servicio4 = Riesgo.Bajo;
        Riesgo servicio5 = Riesgo.Medio;
        Riesgo servicio6 = Riesgo.Alto;

        public void MostrarMenu() //Metodo para mostrar menu de Opciones
        {

            Console.WriteLine(" Bienvenido al Sistema del Gran Banco!");
            Console.WriteLine(" Por favor identifíquese como Cliente o Jefe de Cajas?" );
            Console.WriteLine(" 1.- Cliente");
            Console.WriteLine(" 2.- Jefe de Cajas\n");
            Console.WriteLine(" Ingrese una opción: ");
            
            switch (tipoUsuario =  int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine(" \nUsted se ha identificado como cliente del banco\n" +
                    "Seleccione el servicio que necesita:\n" +
                "1.- Pago de Servicios Públicos\n" +
                "2.- Cambio de cheques\n" +
                "3.- Depósitos\n" +
                "4.- Emisión de tarjetas de crédito, débito y prepago\n" +
                "5.- Emisión de chequeras\n" +
                "6.- Créditos hipotecarios y préstamos para autos ");
                    Console.WriteLine(" Ingrese una opción: \n");
                    //Console.ReadKey();
                    switch (servicio = int.Parse(Console.ReadLine())) 
                    {
                     case 1:
                     Console.WriteLine("\nLos siguientes cajeros le permiten pagar servicios publicos\n" +
                    "por favor elija una opción de cajero:\n" +
                    "1.- Cajero 1\n" +
                    "2.- Cajero 2\n" +
                    "3.- Cajero 3\n" );
                            Console.WriteLine(" Ingrese una opción: \n");
                            switch (servicioCajero = int.Parse(Console.ReadLine())) {
                            case 1:
                                    Console.WriteLine("\nEl cajero 1 podrá ayudarle con los siguientes servicios, elija una opción:\n" +
                            "1.- Pago de servicios públicos\n" +
                            "2.- Cambio de cheques\n" +
                            "3.- Realice un depósito\n" +
                            "4.- Emisión de tarjetas de crédito, débito y prepago\n");
                            break;

                            case 2:
                             Console.WriteLine("\nEl cajero 2 podrá ayudarle con los siguientes servicios, elija una opción:\n" +
                            "1.- Pago de servicios públicos\n" +
                            "2.- Cambio de cheques\n" +
                            "3.- Realice un depósito\n" +
                            "4.- Emisión de Chequeras\n");
                             break;

                            case 3:
                            Console.WriteLine("\nEl cajero 3 podrá ayudarle con los siguientes servicios, elija una opción:\n" +
                            "1.- Pago de servicios públicos\n" +
                            "2.- Cambio de cheques\n" +
                            "3.- Realice un depósito\n" +
                            "4.- Créditos hipotecarios y préstamos para autos\n");
                             break;
                            } Console.ReadKey();
                            break;

                     case 2:
                            Console.WriteLine("\nLos siguientes cajeros le permiten cambiar cheques\n" +
                           "por favor elija una opción de cajero:\n" +
                           "1.- Cajero 1\n" +
                           "2.- Cajero 2\n" +
                           "3.- Cajero 3\n");
                            Console.WriteLine(" Ingrese una opción: \n");
                            switch (servicioCajero = int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("\nEl cajero 1 podrá ayudarle con los siguientes servicios, elija una opción:\n" +
                            "1.- Pago de servicios públicos\n" +
                            "2.- Cambio de cheques\n" +
                            "3.- Realice un depósito\n" +
                            "4.- Emisión de tarjetas de crédito, débito y prepago\n");
                                    break;

                                case 2:
                                    Console.WriteLine("\nEl cajero 2 podrá ayudarle con los siguientes servicios, elija una opción:\n" +
                                   "1.- Pago de servicios públicos\n" +
                                   "2.- Cambio de cheques\n" +
                                   "3.- Realice un depósito\n" +
                                   "4.- Emisión de Chequeras\n");
                                    break;

                                case 3:
                                    Console.WriteLine("\nEl cajero 3 podrá ayudarle con los siguientes servicios, elija una opción:\n" +
                                    "1.- Pago de servicios públicos\n" +
                                    "2.- Cambio de cheques\n" +
                                    "3.- Realice un depósito\n" +
                                    "4.- Créditos hipotecarios y préstamos para autos\n");
                                    break;
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("\nLos siguientes cajeros le permiten realizar depósitos\n" +
                           "por favor elija una opción de cajero:\n" +
                           "1.- Cajero 1\n" +
                           "2.- Cajero 2\n" +
                           "3.- Cajero 3\n");
                            Console.WriteLine(" Ingrese una opción: \n");
                            switch (servicioCajero = int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("\nEl cajero 1 podrá ayudarle con los siguientes servicios, elija una opción:\n" +
                            "1.- Pago de servicios públicos\n" +
                            "2.- Cambio de cheques\n" +
                            "3.- Realice un depósito\n" +
                            "4.- Emisión de tarjetas de crédito, débito y prepago\n");
                                    break;

                                case 2:
                                    Console.WriteLine("\nEl cajero 2 podrá ayudarle con los siguientes servicios, elija una opción:\n" +
                                   "1.- Pago de servicios públicos\n" +
                                   "2.- Cambio de cheques\n" +
                                   "3.- Realice un depósito\n" +
                                   "4.- Emisión de Chequeras\n");
                                    break;

                                case 3:
                                    Console.WriteLine("\nEl cajero 3 podrá ayudarle con los siguientes servicios, elija una opción:\n" +
                                    "1.- Pago de servicios públicos\n" +
                                    "2.- Cambio de cheques\n" +
                                    "3.- Realice un depósito\n" +
                                    "4.- Créditos hipotecarios y préstamos para autos\n");
                                    break;
                            }
                            Console.ReadKey();
                            break;
                     case 4:
                            Console.WriteLine("Esta transacción es considerada de riesgo: "+servicio4);
                            Console.WriteLine("\nUnicamente Cajero 1 puede ayudarle con esta transacción\n" +
                           "por favor elija una uno de los servicios que ofrece Cajero 1:\n" +
                           "1.- Pago de servicios públicos\n" +
                            "2.- Cambio de cheques\n" +
                            "3.- Realice un depósito\n" +
                            "4.- Emisión de tarjetas de crédito, débito y prepago\n");
                            Console.ReadKey();
                            break;

                     case 5:
                            Console.WriteLine("Esta transacción es considerada de riesgo: " + servicio5);
                            Console.WriteLine("\nUnicamente Cajero 2 puede ayudarle con esta transacción\n" +
                           "por favor elija una uno de los servicios que ofrece Cajero 2:\n" +
                            "1.- Pago de servicios públicos\n" +
                            "2.- Cambio de cheques\n" +
                            "3.- Realice un depósito\n" +
                            "5.- Emisión de Chequeras\n");
                            Console.ReadKey();
                            break;

                     case 6:
                            Console.WriteLine("Esta transacción es considerada de riesgo: " + servicio6);
                            Console.WriteLine("\nUnicamente Cajero 3 puede ayudarle con esta transacción\n" +
                           "por favor elija una uno de los servicios que ofrece Cajero 2:\n" +
                            "1.- Pago de servicios públicos\n" +
                            "2.- Cambio de cheques\n" +
                            "3.- Realice un depósito\n" +
                            "6.- Créditos hipotecarios y préstamos de autos\n");
                            Console.ReadKey();
                            break;
                    }


                    break;
                case 2:
                    Console.WriteLine("\nUsted se ha identificado como Jefe de Cajas ");
                    Console.ReadKey();
                    break;
            }
            
            

        }
    }
}