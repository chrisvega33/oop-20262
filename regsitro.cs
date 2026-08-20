using Prueba_base_de_datos.Data;
using Prueba_base_de_datos.Models;
using System.ComponentModel.Design;
using System.Drawing;

namespace Prueba_base_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Bienvenido al registro de la unah que sea hacer? ");
            Console.WriteLine("1. iniciar seccion");
            Console.WriteLine("2. crear un nuevo usuario");
        
            try
            {   
                n=int.Parse(Console.ReadLine());
               
  switch(n)
            {
                   
                case 1:
                        string ncuel, contral;
                        Usuarios1 UsuarioBusq=null;
                        do
                        {
                            
                            Console.Clear();
                            Console.WriteLine("ingrese su numero de cuenta");
                            ncuel = Console.ReadLine();
                            Console.WriteLine("ingrese su contraseña");
                            contral = Console.ReadLine();
                            VegaContext contexto = new VegaContext();
                             UsuarioBusq = contexto.Usuarios1s.FirstOrDefault(u => u.NumeroDeCuenta.ToString() == ncuel && u.Contraseña.ToString() == contral);
                            if (UsuarioBusq != null)
                            {
                                Console.Clear();
                                Barrio barrio1 = new Barrio(UsuarioBusq.ColoniaActual, UsuarioBusq.CiudadActual);
                                Nacimiento naci1 = new Nacimiento(UsuarioBusq.CiudadNacimiento, UsuarioBusq.LugarNacimiento);
                                Persona per1 = new Persona(UsuarioBusq.Nombre, UsuarioBusq.Dni, barrio1, naci1);

                                Console.WriteLine($"Bienvendid@ {per1.Nombre} su numero de cuenta es {UsuarioBusq.NumeroDeCuenta}");
                           
                            }
                            else
                                Console.WriteLine("el usuario o contraseña es incorrecto intentelo de nuevo");
                            Thread.Sleep(1500);
                        } while (UsuarioBusq==null);
                        break;

                case 2:
                        
                       VegaContext contex=new VegaContext();
                        
                        string nom,dni,ciu,col,lnac,cnac,contra;
                    Console.WriteLine("Bienvenido a la creacion de usuario");
                        Console.WriteLine("***************");

                       nom= pedir("Cual es su nombre?");
                      
                        dni=pedir("Cual es su dni?");


                        col = pedir("cual es su colonia?");


                        ciu = pedir("cual es su ciudad?");


                        lnac = pedir("cual es su lugar de nacimiento?");


                        cnac = pedir("cual es su ciudad de nacimiento?");
                        

                        contra=pedir("ingrese su contraseña");
                        
                        Console.WriteLine("listo..");
                        Thread.Sleep(1000);
                        Console.Clear();


                       

                        Random r=new Random();
                        double rcuenta;
                        rcuenta=r.Next(1000000,9999999);
                        string ncuenta;
                        ncuenta = "2026" + rcuenta;
                      
                        
                        Usuarios1 usuarioo = new Usuarios1
                        {
                            NumeroDeCuenta = long.Parse(ncuenta),
                            Contraseña = contra,
                            Nombre=nom,
                            Dni=dni,
                            ColoniaActual=col,
                            CiudadActual=ciu,
                            CiudadNacimiento=cnac,
                            LugarNacimiento=lnac,
                        };
                           
                        
                        contex.Usuarios1s.Add(usuarioo);
                        contex.SaveChanges();
                        Console.WriteLine("registrado correctamente");
                        Console.WriteLine($"su numero de cuenta asiganado es {ncuenta}");

                        Console.WriteLine("1. Matricula");
                        Console.WriteLine("2. cerrar secion");

                        break;

                default:
                    break;
            }    

            }
            catch (Exception)
            {
                Console.WriteLine("tiene que ingresar un numero entre 1 y 2");
             
            }
          
            static string pedir(string info)
            {
                string dato;
                do
                {
                    Console.WriteLine(info);
                    dato = Console.ReadLine();

                    if (dato.Trim() == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("No puede estar el campo vacio");
                        Console.ResetColor();
                    }
                    else return dato;
                  
                } while (true);
                
            }

        }
    }
}
