/*
 * Created by SharpDevelop.
 * User: YURI
 * Date: 10/05/2015
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BuscaBinaria
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[] A = new int[10];
		    
		    A[0] = 10;
		    A[1] = 20;
		    A[2] = 30;
		    A[3] = 40;
		    A[4] = 50;
		    A[5] = 60;
		    A[6] = 70;
		    A[7] = 80;
		    A[8] = 90;
		    A[9] = 100;
		    
		    FncBuscaBinaria(A,70,0,9);
		    	
			Console.ReadKey(true);
		}
		
		
		public static object FncBuscaBinaria(int[] inputArray, int key, int min, int max)
		{
			while (min <=max)
		    {
		       int mid = (min + max) / 2;
		       if (key == inputArray[mid])
		       {
		            return ++mid;
		       }
		       else if (key < inputArray[mid])
		       {
		           max = mid - 1;
		       }
		       else
		       {
		            min = mid + 1;
		       }
		   }
		   return "Nil";
		}
	}
}