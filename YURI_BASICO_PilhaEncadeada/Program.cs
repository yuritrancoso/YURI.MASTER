/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 15/03/2015
 * Time: 12:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PilhaEncadeada
{
	class Program
	{
		public static void Main(string[] args)
		{
			Pilha P = new Pilha();
			P.Empilha("A");
			P.Empilha("B");
			P.Empilha("C");
			Console.WriteLine(P.Desempilha());
			Console.WriteLine(P.Desempilha());
			Console.WriteLine(P.Desempilha());
			P.Empilha("D");
			Console.WriteLine(P.Desempilha());
			Console.ReadLine();
		}
	}
}