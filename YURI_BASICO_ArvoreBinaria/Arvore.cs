/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 23/04/2015
 * Time: 16:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ArvoreBinaria
{
	/// <summary>
	/// Description of Arvore.
	/// </summary>
	public class Arvore
	{
        public No raiz = null;
        private No current = null;
        private No tempParent = null;   
            
        public void InserirNo (int info)
		{
		 
		    No novoNo = new No();
		    novoNo.Valor = info;
		 
		    if (raiz == null) //First node insertion  
		        raiz = novoNo;       
		    else
		    {
		       current = raiz;
		       while (true)
		       {
		           tempParent = current;
		           if (Convert.ToInt32(novoNo.Valor) < Convert.ToInt32(current.Valor))
		           {
		               current = current.NoEsq;
		               if(current== null)
		               {
		                    tempParent.NoEsq = novoNo;
		                    novoNo.NoPai =tempParent;
		                    return;
		                }
		           }
		           else
		           {
		               current = current.NoDir;
		               if(current == null)
		               {
		                    tempParent.NoDir= novoNo;
		                    novoNo.NoPai = tempParent;
		                    return;
		               }
		           }
		        }
		    }
		}
        
       public void PreOrder_Rec (No raiz)
	    {
		    if (raiz != null)
		    {
		        Console.Write(raiz.Valor+" ");
		        PreOrder_Rec(raiz.NoEsq);
		        PreOrder_Rec(raiz.NoDir);
		    }
	    }
       
		public void InOrder_Rec(No raiz)
		{
		    if (raiz != null)
		     {
		          InOrder_Rec(raiz.NoEsq);
		          Console.Write(raiz.Valor +" ");
		          InOrder_Rec(raiz.NoDir);
		    }
		}
		
		public void PostOrder_Rec(No raiz)
		{
		    if (raiz != null)
		   {
		         PostOrder_Rec(raiz.NoEsq);
		         PostOrder_Rec(raiz.NoDir);
		         Console.Write(raiz.Valor +" ");
		   }
		}		
       
       }
	
	
}
