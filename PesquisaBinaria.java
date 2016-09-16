package trabalholpoo;

public class PesquisaBinaria {

    public static int pesquisabinario(int[] vetor, int chave) {
        int meio;
        int inicio, fim;
        inicio = 0;
        fim = vetor.length - 1;

        while (inicio <= fim) {
            meio = (inicio + fim) / 2;
            if (vetor[meio] == chave) {

                return meio;
            } else if (vetor[meio] < chave) {
                inicio = meio + 1;
            } else {
                fim = meio - 1;
            }
        }
        return -vetor.length - 1;

    }
    public static int meio;

    public int ordenara(int[] vetor) {

        int i, j, eleito, menor, pos;
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
        return vetor[i];
    }

}
