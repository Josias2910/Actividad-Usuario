using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActUsuario
{
    public class Usuario
    {
        //Getters y Setters, Atributos
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _mail;
        private int _edad;
        private string _domicilio;


        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }
        public int DNI
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }
        public string Mail
        {
            get
            {
                return this._mail;
            }
            set
            {
                this.Mail = value;
            }
        }
        public int Edad
        {
            get
            {
                return this._edad;
            }
            set
            {
                this._edad = value;
            }
        }
        public string Domicilio
        {
            get
            {
                return this._domicilio;
            }
            set
            {
                this.Domicilio = value;
            }
        }


        //Constructor por defecto
        public Usuario()
        {
            _nombre = string.Empty;
            _apellido = string.Empty;
            _dni = 0;
            _mail = string.Empty;
            _edad = 0;
            _domicilio = string.Empty;
        }


        //Constructor Parametrizado
        public Usuario(string nombre, string apellido, int dni, string mail, int edad, string domicilio)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._mail = mail;
            this._edad = edad;
            this._domicilio = domicilio;
        }


        //Metodos


        public void MostrarDatos()
        {
            Console.WriteLine("Ingrese DNI: ");
            int DniIngresado = Convert.ToInt32(Console.ReadLine());

            while (DniIngresado != this._dni)
            {
                Console.WriteLine("Dni Incorrecto, ingreselo nuevamente");
                DniIngresado = Convert.ToInt32(Console.ReadLine());
            }

            if (DniIngresado == this._dni)
            {
                Console.WriteLine("Nombre: " + this._nombre + "\nApellido: " + this._apellido + "\nDNI: " + this._dni + "\nMail: " + this._mail + "\nedad: " + this._edad + "\ndomicilio: " + this._domicilio);
            }
        }

        public void EsMayorDeEdad()
        {
            if (this._edad > 18)
            {
                Console.WriteLine("\nEs mayor");
            }
            else
            {
                Console.WriteLine("Es menor");
            }
        }

        public void EsGmail()
        {
            if (this._mail.Contains("gmail"))
            {
                Console.WriteLine("\nEs gmail");
            }
            else
            {
                Console.WriteLine("No es gmail");
            }
        }

        public void CambiarDireccion()
        {
            Console.WriteLine("\nIngrese la nueva direccion: ");
            string? Direccion = Console.ReadLine();
            this._domicilio = Direccion;
            Console.WriteLine("La nueva direccion es: " + this._domicilio);
        }
    }
}
