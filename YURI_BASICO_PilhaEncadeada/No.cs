/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 21/02/2015
 * Time: 20:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PilhaEncadeada
{
	
	public class No
	{
		private string _valor;
		
		public string Valor
		{
			get {return _valor;}
			set {_valor = value;}
		}

		private No _anterior;
		
		public No Anterior
		{
			get {return _anterior;}
			set {_anterior = value;}
		}		
	}
}
