
const int offresult = 1;
const int MAXVALUE = 100;
const int MAXPLAYERS = 10;
int round = 0;
int tamanho_cartela = 5;
bool endgame = false;
int n_jogadores = 0, cartela_maxima = 0;
int[] num_sorteados = new int[MAXVALUE];
int[] quantidade_cartelas = new int[MAXVALUE];
string[] nomes_jogadores = new string[MAXPLAYERS];

/*
 Funções Auxiliares Para Simplificar o Código
 */

bool Get_Decision()
{
    int op = 2;
    do
    {
        Console.WriteLine("\nDeseja Recomeçar o Jogo?\n 1-) Sim\n 2-) Não");
        op = int.Parse(Console.ReadLine());
    } while((op != 1)&&(op != 2));
    if (op == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int Get_Value(string text)
{
    int num = 0;
    do
    {
        Console.Write($"\nInsira o valor de {text}: ");
        num = int.Parse(Console.ReadLine());
        if (num <= 0)
        {
            Console.WriteLine("\n O valor digitado deve ser positivo");
        }
    } while (num <= 0);
    return num;
}
void Print_Vector(int[] vector)
{
    Console.Write("\nO vetor possui valores: ");
    for (int i =0; i < vector.Length; i++)
    {
        Console.Write($"{vector[i]:00} ");
    }
}
int Afunilar_Intervalo(int num, int max)
{
    int aux = 0;
    float numx = num;
    for(int i = 0; i < 10; i++)
    {
        if (numx > ((max) * ((float)i / 10)))
        {
            aux = (int)((max) * ((float)i / 10));
        }
    }
    return aux;
}
int[] Embaralhar_Vetor(int[] vet, int shuffle_count)
{
    int random1 = 0, random2 = 0, aux = 0;
    for(int i = 0; i< shuffle_count; i++)
    {
        random1 = new Random().Next(1, 99);
        random2 = new Random().Next(1, 99);
        aux = vet[random2];
        vet[random2] = vet[random1];
        vet[random1] = aux;

    }
    return vet;
}
bool Contains_Vet(int num_search, int[] vet_search)
{
    int count = 0;
    for(int i=0;i< vet_search.Length;i++)
    {
        if (vet_search[i] == num_search)
        {
            count ++;
        }
    }
    if(count == 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}
int Encontrar_Elemento_Cartela(int[,] cartela, int linha, int tamanho_cartela)
{
    return cartela[linha, tamanho_cartela];
}

/*
 Funções
 */

int[] Gerar_Numeros()
{
    int[] num_sort = new int[MAXVALUE-1];
    for (int i = 1; i < MAXVALUE; i++)
    {
        num_sort[i - 1] = i;
    }
    return num_sort;
}
int[] Gerar_Numeros_Cartela(int quantidade)
{
    int random = 0, position = 0, aux=0;
    int[] valores = new int[quantidade];
    int[] range = Gerar_Numeros();
    do
    {
        random = new Random().Next(1, 100);
        aux = Afunilar_Intervalo(random, MAXVALUE);
        for (int i = aux; i< random; i++)
        {
            if (range[i] != 0)
            {
                if ((random == range[i]))
                {
                    valores[position] = random;
                    range[i] = 0;
                    position++;
                }
            }
        }
    } while (position != quantidade);
    return valores;
}
int[,] Criar_Cartela(int indice_jogador, int contador_tabela)
{
    int num_count = 0;
    int[] num_sorteados = Gerar_Numeros_Cartela(tamanho_cartela * tamanho_cartela);
    int[,] cartela = new int[tamanho_cartela, (tamanho_cartela+1)];
    for(int i=0; i< tamanho_cartela; i++)
    {
        for (int j = 0; j <= tamanho_cartela; j++)
        {
            if(j != tamanho_cartela)
            {
                cartela[i, j] = num_sorteados[num_count];
                num_count++;

            }
            else
            {
                if (j >= 0)
                {
                    cartela[0, j] = contador_tabela; //Identificador do número da tabela

                    if (j >= 1)
                    {
                        cartela[1, j] = indice_jogador; //Identificador do proprietário da tabela

                        if (j >= 2)
                        {
                            cartela[2, j] = 0; //Identificador de linha conquistada
                            if (j >= 3)
                            {
                                cartela[3, j] = 0; //Identificador de coluna conquistada
                                if (j >= 4)
                                {
                                    cartela[4, j] = 0; //Identificador de bingo conquistado
                                }
                            }

                        }

                    }

                }
            }// Adições a coluna "invisível"
        }
    }
    return cartela;
}
void Imprimir_Cartela(int[,] cartela, string nomes_jogadores)
{
    string end = "";
    Console.WriteLine();
    for (int i = 0; i < tamanho_cartela; i++)
    {
        Console.Write("------------------------\n");
        for (int j = 0; j < tamanho_cartela + offresult; j++) // REMOVER +1 para ocultar informações
        {
            if(j < 4)
            {
                end = "|";
            }
            else
            {
                end = "";
            }
            Console.Write($" {cartela[i,j]:00} {end}");
        }
        Console.WriteLine();
    }
    Console.Write("------------------------\n");
    Console.WriteLine();
    Console.WriteLine($"Cartela número: {cartela[0, tamanho_cartela]:00}");
    Console.WriteLine($"Jogador: {nomes_jogadores}");
    Console.WriteLine($"Pontuação Linha: {cartela[2, tamanho_cartela]}");
    Console.WriteLine($"Pontuação Coluna: {cartela[3, tamanho_cartela]}");
    Console.WriteLine($"Pontuação Bingo: {cartela[4, tamanho_cartela]}");
}
int[] Anunciar_Numero(int[] num_sorteados, int round, int[] numeros_sorteados_descartados)
{
    int[] aux = new int[num_sorteados.Length];
    if(round == 0)
    {
        num_sorteados = Embaralhar_Vetor(Gerar_Numeros(), 50);
    }
    else
    {
        Console.Write("\nOs números já sorteados são: ");
        for (int i = 0; i < round; i++)
        {
            if ((numeros_sorteados_descartados[i] != 0))
            {
                Console.Write($" {numeros_sorteados_descartados[i]:00} ");
            }else if (num_sorteados[i] != 0)
            {
                num_sorteados[i] = 0;
            }
        }
    }
    Console.WriteLine($"\n\nRound {round} \nO número sorteado foi: {num_sorteados[round]:00}\n");
    return num_sorteados;
}

int[][,] Atribuir_Cartelas_Jogadores(int num, int[][,] cartelas_jogadores, int contador_cartela, int n_jogadores)
{
    if (num == 1)
    {
        for (int i = 0; i <= n_jogadores; i++)
        {
            for (int j = 0; j < quantidade_cartelas[i]; j++)
            {
                cartelas_jogadores[contador_cartela] = new int[tamanho_cartela, tamanho_cartela + 1];
                cartelas_jogadores[contador_cartela] = Criar_Cartela((n_jogadores - i), contador_cartela);
                cartelas_jogadores[contador_cartela][0, tamanho_cartela] = contador_cartela; //Salvando o código da tabela na coluna MAX
                cartelas_jogadores[contador_cartela][1, tamanho_cartela] = (n_jogadores - i); //Salvando o código da tabela na coluna MAX
                contador_cartela++;
            }
        }
    }
    for (int i = 0; i <= n_jogadores; i++)
    {
        for (int j = 0; j < quantidade_cartelas[i]; j++)
        {
            Imprimir_Cartela(cartelas_jogadores[(i * cartela_maxima) + j], nomes_jogadores[i]);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
    }

    return cartelas_jogadores;
}
int[] Retornar_Diferenca(int [] num_sorteados,int[] numeros_sorteados_descartados, int round)
{
    int[] aux = new int[num_sorteados.Length];
    int j = 0;
    for(int i = 0;i < num_sorteados.Length; i++)
    {
        if (num_sorteados[i] != 0 && i <= round)
        {
            numeros_sorteados_descartados[j] = num_sorteados[i];
            j++;
        }
    }
    return numeros_sorteados_descartados;
}

int[][,] Pontuar_Cartelas(int[][,] cartela, int[] sorteados)
{
    int[,] matriz_booleana = new int[tamanho_cartela,tamanho_cartela];
    for(int jogador = 0; jogador < n_jogadores; jogador++)
    {
        for(int n_cartelas = 0; n_cartelas < quantidade_cartelas[jogador]; n_cartelas++)
        {
            int[] soma_linha = new int[tamanho_cartela];
            int[] soma_coluna = new int[tamanho_cartela];
            int bingo = 0;
            for (int lin = tamanho_cartela - 1; lin >= 0; lin--)
            {
                for (int col = 0; col < tamanho_cartela; col++)
                {
                    if (Contains_Vet(cartela[jogador][lin, col], sorteados))
                    {
                        matriz_booleana[lin, col] = 1;
                    }
                }
            }
            for (int lin = 0; lin < tamanho_cartela; lin++)
            {
                for (int col = 0; col < tamanho_cartela; col++)
                {
                    bingo += matriz_booleana[lin, col];
                    soma_linha[col] += matriz_booleana[lin, col];
                    soma_coluna[lin] += matriz_booleana[lin, col];
                }   
            }
            if (bingo == tamanho_cartela * tamanho_cartela)
            {
                cartela[jogador][0, 5] = 5;
            }
            if (Contains_Vet(tamanho_cartela, soma_coluna))
            {
                cartela[jogador][0, 4] = 1;
            }
            if (Contains_Vet(tamanho_cartela, soma_linha))
            {
                cartela[jogador][0, 3] = 1;
            }
        }
    }
    return cartela;
}

/* 
   -  BINGO - 
   FORMATO DA CARTELA:
    | dado | dado | dado | dado | dado | Índice do jogador |
    | dado | dado | dado | dado | dado | Índice da cartela |
    | dado | dado | dado | dado | dado | score_linha       |
    | dado | dado | dado | dado | dado | score_coluna      |
    | dado | dado | dado | dado | dado | score_bingo       |

--- ROTEIRO ---

1-) Definir Nº Jogadores
        - Definir cartelas para jogadores
2-) Gerar Números a Serem Sorteados
3-) Imprimir Jogadores, Cartelas e Pontuações
4-) Sortear Numero e Atualizar Matrizes
5-) Checar Cartelas e Pontuações
6-) Imprimir Resultados
 */

//----------------------------------------------------------------------------------------------

// GAME STARTING...

int[] numeros_sorteados_descartados = new int[MAXVALUE-1];
int[,] pontuacoes = new int[n_jogadores + 1, 3];
int contador_cartela = 0;
int[][,] cartelas_jogadores = new int[MAXPLAYERS][,];

Console.WriteLine();
do
{
    Console.Clear();
    // GAME SETTING ......
    //n_jogadores = Get_Value("número de jogadores") - 1;
    //cartela_maxima = Get_Value("cartelas máximas por jogador");
    n_jogadores = 0;
    cartela_maxima = 1;
    Console.Clear();
    for (int i = 0; i <= n_jogadores; i++)
    {
        Console.Write($"\n{(i + 1)}º jogador, digite seu nome: ");
        nomes_jogadores[i] = Console.ReadLine();
        do
        {
            Console.Write($"\n{(i + 1)}º jogador, digite quantas cartelas deseja jogar: ");
            quantidade_cartelas[i] = int.Parse(Console.ReadLine());
            if(quantidade_cartelas[i] <= 0 || quantidade_cartelas[i] > cartela_maxima)
            {
                Console.Write($"\nInsira uma opção válida, entre 1 e {cartela_maxima} \n");
            }
        } while (quantidade_cartelas[i] <= 0 || quantidade_cartelas[i]> cartela_maxima);
        Console.Clear();
    } // Salvando informações dos jogadores

    cartelas_jogadores = Atribuir_Cartelas_Jogadores(1,cartelas_jogadores, contador_cartela,n_jogadores); // Atribuindo cartelas para os jogadores

    do // GAME RUNNING ......
    {
        num_sorteados = Anunciar_Numero(num_sorteados, round, numeros_sorteados_descartados);
        Console.ReadKey();
        Console.Clear();
        numeros_sorteados_descartados = Retornar_Diferenca(num_sorteados,numeros_sorteados_descartados, round);
        cartelas_jogadores = Pontuar_Cartelas(cartelas_jogadores, num_sorteados);
        cartelas_jogadores = Atribuir_Cartelas_Jogadores(2, cartelas_jogadores, contador_cartela, n_jogadores);
        round++;
        //endgame = Check_Game_Win();
        Console.ReadKey();
        Console.Clear();

    } while (!endgame && round < num_sorteados.Length -1);
    round = 0;
} while (Get_Decision());
Console.WriteLine("\n  ---  OBRIGADO POR JOGAR  ---  ");
Print_Vector(num_sorteados);
Console.ReadKey();

