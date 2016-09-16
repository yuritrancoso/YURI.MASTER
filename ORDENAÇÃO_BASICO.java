/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package chamada;

/**
 *
 * @author YURI
 */
import java.util.Scanner;

public class chamada {

    public static void main(String[] YURI) {
        Scanner ler = new Scanner(System.in);
        int vetor[] = new int[10000];
        String caso = null;

        System.out.println("Para baixar as fotos do dia\nDigite baixar  ");
        caso = ler.next();

        if (caso.equals("baixar")) {

            for (int i = 0; i < vetor.length; i++) {
                int x = 1 + (int) (Math.random() * 10000);
                vetor[i] = x;
                System.out.println("Imagem " + vetor[i]);

            }

        }

        System.out.println("\nEscolhe um dos três metodos de ordenação:\n"
                + " 1-- Insertion Sort.\n"
                + " 2-- Selection sort.\n"
                + " 3-- Bubbler Sort.");
        int num = ler.nextInt();
        int i, eleito, j, menor, pos, chave, meio;
        int inicio = 0;
        int fim = vetor.length - 1;
        if (num == 1) {
            long tempoInicial = System.currentTimeMillis();
//ordenando de forma crescente
//laço com a quantidade de elementos do vetor -1
            for (i = 1; i <= vetor.length - 1; i++) {
                eleito = vetor[i];
                j = i - 1;
//laço que percorre os elementos à esquerda do numero eleito
//ou até encontrar a posição para recolocação do numero eleito
//respeitando a ordenação procurada
                while (j >= 0 && vetor[j] > eleito) {
                    vetor[j + 1] = vetor[j];
                    j = j - 1;
                }
                vetor[j + 1] = eleito;
            }
//mostrando o vetor ordenado
            for (i = 0; i <= vetor.length - 1; i++) {
                System.out.println((i + 1) + " numero: " + vetor[i]);
            }
            long tempoFinal = System.currentTimeMillis();
            System.out.printf("%.3f ms%n", (tempoFinal - tempoInicial) / 1000d);
        } else if (num == 2) {

            long tempoInicial = System.currentTimeMillis();
            for (i = 0; i <= vetor.length - 2; i++) {
                eleito = vetor[i];
                menor = vetor[i + 1];
                pos = i + 1;
                for (j = i + 2; j <= vetor.length - 1; j++) {
                    if (vetor[j] < menor) {
                        menor = vetor[j];
                        pos = j;
                    }
                }
                if (menor < eleito) {
                    vetor[i] = vetor[pos];
                    vetor[pos] = eleito;
                }
            }
            for (i = 0; i <= vetor.length - 1; i++) {
                System.out.println((i + 1) + " numero: " + vetor[i]);
            }
            long tempoFinal = System.currentTimeMillis();
            System.out.printf("%.3f ms%n", (tempoFinal - tempoInicial) / 1000d);
        } else if (num == 3) {
            long tempoInicial = System.currentTimeMillis();
            //ordenando de forma crescente
//laço que percorre da 1º posição a penúltima posição do vetor
//elegendo um numero para ser comparado
            for (i = 0; i <= vetor.length - 2; i++) {
                eleito = vetor[i];
//encontra o menor numero a direita do eleito com sua //respectiva posição
//posição do eleito = i
//primeiro numero a direita do eleito na posiçao = i + 1
                menor = vetor[i + 1];
                pos = i + 1;
//laço que percorre os elementos que estão a direita do
//numero eleito, retornando o menor numero a direita e sua posição
                for (j = i + 2; j <= vetor.length - 1; j++) {
                    if (vetor[j] < menor) {
                        menor = vetor[j];
                        pos = j;
                    }
                }
//troca do numero eleito com o numero da posiçao pos
//o numero da posição pos e o menor numero a direita do numero eleito
                if (menor < eleito) {
                    vetor[i] = vetor[pos];
                    vetor[pos] = eleito;
                }
            }
//mostrando o vetor ordenado
            for (i = 0; i <= vetor.length - 1; i++) {
                System.out.println("Posiçao "+(i + 1) + " Imagem:" + vetor[i]);
            }
            long tempoFinal = System.currentTimeMillis();
            System.out.printf("\nTempo Gasto "+"%.3f ms%n", (tempoFinal - tempoInicial) / 1000d);
        } else {
            System.out.println("O nomero da escolha digitado e invalido ");
        }
        System.out.println("Escolha uma Imagen para ser localizada: ");
        chave = ler.nextInt();

        while (inicio <= fim) {
            meio = (inicio + fim) / 2;
            if (vetor[meio] == chave) {

                System.out.println("Imagem " + chave + " localizado");
                return;
            } else if (vetor[meio] < chave) {
                inicio = meio + 1;
            } else {
                fim = meio - 1;
            }
        }
        System.out.println(chave + " Imagen nao localizada!!!");
    }
}
