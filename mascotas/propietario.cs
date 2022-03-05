using System;

namespace mascotas{

	public class propietario{

		private Int32 CI;
		private String Nombre;
		private String Direccion;
		private Int16 Edad;

		public Int32 ci{
			get{return CI;} set{CI = value;}
		}
		public String nombre{
			get{return Nombre;} set{Nombre = value;}
		}
		public String direccion{
			get{return Direccion;} set{Direccion = value;}
		}
		public Int16 edad{
			get{return Edad;} set{Edad = value;}
		}
		public Char sexo{get; set;}
		
		public propietario(){
			CI = 0; Nombre = ""; Direccion = ""; Edad = 0; sexo = '\n';
		}
	}
}
