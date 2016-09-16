/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 15/03/2015
 * Time: 12:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PilhaEncadeada
{
	/// <summary>
	/// Description of Pilha.
	/// </summary>
	public class Pilha
	{
		private No Topo;
		
		public void Empilha(string elemento)
		{
			No novoNo = new No();
			novoNo.Valor = elemento;
			
			if (Topo != null)
			{
				novoNo.Anterior = Topo;
			}
			
			Topo = novoNo;
			
		}
		
		public string Desempilha()
		{
			if (Topo != null)
			{
				string valor = Topo.Valor;			
				
				Topo = Topo.Anterior;
				
				return valor;
			}
			else
			{
				Console.WriteLine("Pilha Vazia!");
				return null;
			}
			
		}		
		
	}
}
