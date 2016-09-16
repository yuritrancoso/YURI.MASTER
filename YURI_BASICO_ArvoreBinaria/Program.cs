/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 23/04/2015
 * Time: 16:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ArvoreBinaria
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Arvore A = new Arvore();
			
			A.InserirNo(20);
			A.InserirNo(12);
			A.InserirNo(15);
			A.InserirNo(13);
			A.InserirNo(19);
			A.InserirNo(28);
			A.InserirNo(22);
			A.InserirNo(35);
			A.InserirNo(30);

			
			
			A.PreOrder_Rec(A.raiz);
			Console.WriteLine();
			A.InOrder_Rec(A.raiz);
			Console.WriteLine();
			A.PostOrder_Rec(A.raiz);
			Console.ReadKey();
	
		}
	}
}