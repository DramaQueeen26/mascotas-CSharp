using System;
using System.Collections.Generic;

namespace mascotas{

	class Program{
		public static void Main(string[] args){
			mascota[] array_mascota = new mascota[30];
			for(Int16 m = 0; m < 30; m++){
				array_mascota[m] = new mascota();
			}
			List<propietario> lista_propietario = new List<propietario>();
			
			lista_propietario.Add(new propietario{ci = 22234532, nombre = "Pedro Ramos", direccion = "Cabudare", edad = 25, sexo = 'M'});
			lista_propietario.Add(new propietario{ci = 17564728, nombre = "Carla Mendoza", direccion = "Centro", edad = 32, sexo = 'F'});
			lista_propietario.Add(new propietario{ci = 15726382, nombre = "Jose Lopez", direccion = "Obelisco", edad = 38, sexo = 'M'});
			lista_propietario.Add(new propietario{ci = 16473923, nombre = "Juan Mujica", direccion = "Cuji", edad = 35, sexo = 'M'});
			lista_propietario.Add(new propietario{ci = 25374934, nombre = "Gabriela Escalona", direccion = "Cuji", edad = 23, sexo = 'F'});
			lista_propietario.Add(new propietario{ci = 23647283, nombre = "Maria Perez", direccion = "Centro", edad = 26, sexo = 'F'});
			lista_propietario.Add(new propietario{ci = 26374723, nombre = "Alejandra Melendez", direccion = "Centro", edad = 21, sexo = 'M'});
			lista_propietario.Add(new propietario{ci = 27632834, nombre = "Ricardo Castillo", direccion = "Cabudare", edad = 20, sexo = 'M'});
			
			Int16 contador = 0;
			Char respuesta = 'S';
			
			Console.WriteLine("Datos registrados: \n");
			foreach (propietario lista in lista_propietario ){
				Console.WriteLine("CI: {0} Nombre: {1} Direccion: {2} Edad: {3} Sexo: {4} \n", lista.ci, lista.nombre, lista.direccion, lista.edad, lista.sexo);
				while(respuesta == 'S'){
					Console.WriteLine("Ingrese el nombre la mascota: ");
					array_mascota[contador].nombre = Console.ReadLine();
					Console.WriteLine("Ingrese el tipo de mascota: (Perro, Gato, Loro, Conejo o Tortuga)");
					array_mascota[contador].tipo = Console.ReadLine();
					while(array_mascota[contador].tipo != "Perro" && array_mascota[contador].tipo != "Gato" && array_mascota[contador].tipo != "Loro" && array_mascota[contador].tipo != "Conejo" && array_mascota[contador].tipo != "Tortuga"){
						Console.WriteLine("Error. Ingrese un tipo de animal correcto:");
						array_mascota[contador].tipo = Console.ReadLine();
					}
					Console.WriteLine("Ingrese el dia que nacio: ");
					array_mascota[contador].d = Convert.ToInt16(Console.ReadLine());
					while(array_mascota[contador].d <= 0 || array_mascota[contador].d > 31){
						Console.WriteLine("Introduzca un dia valido: ");
						array_mascota[contador].d = Convert.ToInt16(Console.ReadLine());
					}
					
					Console.WriteLine("Ingrese el mes que nacio: ");
					array_mascota[contador].m = Convert.ToInt16(Console.ReadLine());
					while(array_mascota[contador].m <= 0 || array_mascota[contador].m > 12){
						Console.WriteLine("Introduzca un mes valido: ");
						array_mascota[contador].m = Convert.ToInt16(Console.ReadLine());
					}
					
					Console.WriteLine("Ingrese el anio que nacio: ");
					array_mascota[contador].a = Convert.ToInt16(Console.ReadLine());
					while(array_mascota[contador].a <= 1950 || array_mascota[contador].a > 2020){
						Console.WriteLine("Introduzca un anio valido: ");
						array_mascota[contador].a = Convert.ToInt16(Console.ReadLine());
					}
					
					Console.WriteLine("Ingrese el sexo de la mascota: F/M");
					array_mascota[contador].sexo = Convert.ToChar(Console.ReadLine());
					while(array_mascota[contador].sexo != 'F' && array_mascota[contador].sexo != 'M'){
						Console.WriteLine("Ingrese el sexo correcto de la mascota: F o M");
						array_mascota[contador].sexo = Convert.ToChar(Console.ReadLine());
					}
					Console.WriteLine("Ingrese si la mascota vive o no: S/N");
					array_mascota[contador].vive = Convert.ToChar(Console.ReadLine());
					while(array_mascota[contador].vive != 'S' && array_mascota[contador].vive != 'N'){
						Console.WriteLine("Error. Ingrese si vive o no: S o N");
						array_mascota[contador].sexo = Convert.ToChar(Console.ReadLine());
					}
					Console.WriteLine("Quiere registrar otra mascota? (S/N): ");
					respuesta = Convert.ToChar(Console.ReadLine());
					while(respuesta != 'S' && respuesta != 'N'){
						Console.WriteLine("Error. Quiere registrar otra mascota? S/N");
						respuesta = Convert.ToChar(Console.ReadLine());
					}
					array_mascota[contador].propietario_mascota = lista.nombre;
					Console.WriteLine("\n");
					contador++;
				}
				respuesta = 'S';
				if(contador == 29){
					Console.WriteLine("El numero maximo para registrar mascotas se ha alcanzado \n");
					break;
				}
			}
			
			
			Console.WriteLine("Los propietarios registrados junto a sus mascotas son: \n");
			foreach (propietario lista in lista_propietario){
			
				Int16 n = 0;	
				Console.WriteLine("CI: {0} Nombre: {1} Direccion: {2} Edad: {3} Sexo: {4} \n", lista.ci, lista.nombre, lista.direccion, lista.edad, lista.sexo);
				
				Console.WriteLine("Datos de la(s) mascota(s): \n");
				while(n < 30){
					if (lista.nombre == array_mascota[n].propietario_mascota){
						Console.WriteLine("Nombre: " + array_mascota[n].nombre);
						Console.WriteLine("Tipo: " + array_mascota[n].tipo);
						Console.WriteLine("Fecha de nacimiento: {0}/{1}/{2}", array_mascota[n].d, array_mascota[n].m, array_mascota[n].a);
						Console.WriteLine("Sexo: " + array_mascota[n].sexo);
						Console.WriteLine("Vive: " + array_mascota[n].vive + "\n");			
					}
					n++;
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}