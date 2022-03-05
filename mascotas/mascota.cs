using System;

namespace mascotas{
	public class mascota{

		private String Nombre;
		private String Tipo;
		private Char Sexo;
		
		public String nombre{
			get{return Nombre;} set{Nombre = value;}
		}
		public String tipo{
			get{return Tipo;} set{Tipo = value;}
		}
		public Char sexo{
			get{return Sexo;} set{Sexo = value;}
		}
		public Char vive{get; set;}	
		public Int16 d{get; set;}
		public Int16 m{get; set;}
		public Int16 a{get; set;}
		public String propietario_mascota{get; set;}
		
		public mascota(){
			Nombre = ""; Tipo = ""; Sexo = '\n'; vive = '\n';
		}
	}
}
