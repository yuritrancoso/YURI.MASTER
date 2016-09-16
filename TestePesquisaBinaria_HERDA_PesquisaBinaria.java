package trabalholpoo;

import java.util.Arrays;
import java.util.Scanner;

public class TestePesquisaBinaria extends PesquisaBinaria
{

    public static void main(String args[])
    {
        Scanner entrada = new Scanner(System.in);
        System.out.println("Informe o tamanho do vetor :");
        
        int size = entrada.nextInt();
        int vetor[] = new int[size];
        int i;

//carregando os números no vetor
        for (i = 0; i <= vetor.length - 1; i++) 
        {
            System.out.println(" Digite o vetor" + (i + 1) + " numero ");
            vetor[i] = entrada.nextInt();
        }
        PesquisaBinaria ordenar = new PesquisaBinaria();
        
        ordenar.ordenara(vetor);
        
        for (i = 0; i <= vetor.length - 1; i++) 
        {
            System.out.println((i + 1) + " Valor:" + vetor[i]);
        }
        boolean continuar = true;
        
        while (continuar) 
        {
            String sair;
            System.out.println("informe a chave de Pesquisa: ");
            
            int chave = entrada.nextInt();
            int indice = pesquisabinario(vetor, chave);
            
            System.out.println("A chave " + chave + " foi encontrada na posição: " + indice);
            System.out.println("Digite sair para finalizar o programa: ");
            
            sair = entrada.next();
            
            if ("sair".equals(sair))
            {
                continuar = false;
                System.out.println("Programa finalizado!!!");
            }
            else
            {
                System.out.println("Escolhe outra chave: ");
            }
        }
    }


}
