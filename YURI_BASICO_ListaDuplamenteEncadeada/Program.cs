/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 08/03/2015
 * Time: 16:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListaDuplamenteEncadeada
{
	class Program
	{
		public static void Main(string[] args)
		{
				Lista L = new Lista();
				L.Insere("5",0);
				L.Insere("10",1);
				L.Insere("9",2);
				L.Insere("3",3);
				L.Insere("15",4);
				L.Insere("21",5);
                L.Insere("200",1);
				L.Remove(1);
				Console.WriteLine("Lista em ordem normal!");
				L.ListarElementos();
				Console.WriteLine("Lista em ordem inversa!");
				L.ListarInversamenteElementos();
				Console.ReadLine();
		}
	}
}