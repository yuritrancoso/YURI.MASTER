/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 21/02/2015
 * Time: 20:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ArvoreBinaria
{
	
	public class No
	{
		private int _valor;
		
		public int Valor
		{
			get {return _valor;}
			set {_valor = value;}
		}
		
        private No _noPai;
		
		public No NoPai
		{
			get {return _noPai;}
			set {_noPai = value;}
		}		

		private No _noEsq;
		
		public No NoEsq
		{
			get {return _noEsq;}
			set {_noEsq = value;}
		}	

		private No _noDir;
		
		public No NoDir
		{
			get {return _noDir;}
			set {_noDir = value;}
		}			
	}
}
