/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 08/03/2015
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListaDuplamenteEncadeada
{
	/// <summary>
	/// Description of No.
	/// </summary>
	public class No
	{
		private string _valor;
		
		public string Valor
		{
			get {return _valor;}
			set {_valor = value;}
		}

		private No _proximo;
		
		public No Proximo
		{
			get {return _proximo;}
			set {_proximo = value;}
		}	

        private No _anterior;
		
		public No Anterior
		{
			get {return _anterior;}
			set {_anterior = value;}
		}			
	}
}
