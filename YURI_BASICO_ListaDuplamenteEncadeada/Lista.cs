/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 08/03/2015
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ListaDuplamenteEncadeada
{
	/// <summary>
	/// Description of Lista.
	/// </summary>
	public class Lista
	{
private No _cabeca, _cauda;
		
		public void Insere(string elemento,int posicao)
		{
			No noAnterior, proximoNo;
			
			No novoNo = new No();
			novoNo.Valor = elemento;
			
			noAnterior = null;
			
			if (_cabeca == null)
			{
				_cabeca = novoNo;
				
			}
			else
			{
				noAnterior = BuscaNo(posicao - 1);
				proximoNo = BuscaNo(posicao);
				
				noAnterior.Proximo = novoNo;
				novoNo.Anterior = noAnterior;
				
				novoNo.Proximo = proximoNo;
				if (proximoNo != null)
					proximoNo.Anterior = novoNo;
				
				if (noAnterior == _cauda)
				   _cauda.Proximo = novoNo;
			}
			
			if (noAnterior == _cauda)
			   _cauda = novoNo;
			
		}
		
		public No BuscaNo(int indice)
		{
			No temp;
			temp = this._cabeca;
			int i = 0;
			Boolean encontrou = false;
			
			while (temp != null)
			{
				if (i == indice)
				{
					encontrou = true;
					break;
				}
				
				temp = temp.Proximo;
				i=i+1;				
			}
			if (encontrou == true)
				return temp;
			else
				return null;
			
		}
		
		public void Remove (int idx)
		{
			No proximoNo = this.BuscaNo(idx + 1);
			No noParaRemover = this.BuscaNo(idx);
			
			if (noParaRemover == null) return;
			
			
			if (noParaRemover == _cabeca)
			{
				_cabeca = _cabeca.Proximo;
				noParaRemover.Proximo = null;
				return;
			}
			
			No noAnterior = this.BuscaNo(idx-1);
				
			noAnterior.Proximo = noParaRemover.Proximo;
			
			if (proximoNo != null)
				proximoNo.Anterior = noAnterior;
			
			if (noParaRemover.Proximo == null)
			{
				_cauda = noAnterior;
			}
			
			noParaRemover.Proximo = null;
		}
		
		public void ListarElementos ()
		{
			No temp;
			temp = this._cabeca;
			
			while (temp != null)
			{
				Console.WriteLine(temp.Valor);
				temp = temp.Proximo;
			}
			
		}
		
		public void ListarInversamenteElementos ()
		{
			No temp;
			temp = this._cauda;
			
			while (temp != null)
			{
				Console.WriteLine(temp.Valor);
				temp = temp.Anterior;
			}
			
		}		
		
	}
}
