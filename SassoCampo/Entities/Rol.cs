using System;
using System.Collections.Generic;

public class Rol
{
	int id;
	string nombre;
	List<Permiso> permisos;

	public Rol(int id, string nombre, List<Permiso> permisos)
	{
		Id = id;
		Nombre = nombre;
		Permisos = permisos;
	}

	public int Id { get => id; set => id = value; }
	public string Nombre { get => nombre; set => nombre = value; }
	public List<Permiso> Permisos { get => permisos; set => permisos = value; }
}
