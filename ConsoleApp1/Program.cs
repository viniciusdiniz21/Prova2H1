using ConsoleApp1;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

void Exercicio1()
{
    int Multiplica(int a, int b)
    {
        if (a > 1)
        {
            return b + Multiplica(a -1, b);
        }
        else
        {
            return b;
        }
    }
    var resultado = Multiplica(6, 4);
    Console.WriteLine($"{resultado}");
    Console.ReadLine();
}
Exercicio1();

void Exercicio2()
{
    //1 - F -> Não é a mais eficiente, pois seu Big(O) é O(n) enquanto a busca binária é O(log n)
    //2 - F -> A complexidade da busca binária é O(log n)
    //3 - F -> Pode ser implementada em listas não ordenadas
    //4 - F -> A complexidade é O(n)
}

void Exercicio3()
{
    static int FuncaoEspecial(int[] array, int target, int index)
    {
        // verificação de parada, caso todos os itens da lista tenham sido verificados
        if (index >= array.Length)
        {
            // Elemento nÃ£o encontrado
            return -1;
        }
        // Condição de caso o valo tenha sido encontrado, retorna a posição dentro do array que o mesmo se encontra
        else if (array[index] == target)
        {
            // Elemento encontrado
            return index;
        }
        // Caso não tenha encontrado naquele indice, faz novamente a busca para o indice seguinte
        else
        {
            // Chama recursivamente a funÃ§Ã£o para buscar o prÃ³ximo elemento
            return FuncaoEspecial(array, target, index + 1);
        }
    }

    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10, 12, 14 };

        int target = 10;
        int index = FuncaoEspecial(numbers, target, 0);
      
        // verifica se o retorno não e referente a uma busca sem sucesso
        if (index != -1)
        {
            Console.WriteLine("O elemento {0} foi encontrado no Ã­ndice {1}.", target, index);
        }
        // retorno para caso a lista toda tenha sido verificada e o valor não tenha sido encontrado
        else
        {
            Console.WriteLine("O elemento {0} nÃ£o foi encontrado no array.", target);
        }
    }

    //////////////////////////////////////////////////////
    ///letra B)
    /// 1- V -> O algoritmo verifica todas as posições do vetor, ate encontrar o valo correto,
    /// o vetor pode ser crescente ou decrescente
    /// 2- V -> O algoritmo verifica todas as posições do vetor, ate encontrar o valo correto,
    /// o vetor pode ser crescente ou decrescente
    /// 3- V -> Por se tratar de um algoritmo de busca linear ele pode sim buscar valores de uma lista 
    /// não ordenada
    /// 

void Exercicio4()
    {
        // A) Verbo GET
        // B) Verbo POST
        // C)
        string url = "http://localhost:3000/candidadosSedeCopa2030";
        async void GetDados(string url)
        {
            using (HttpClient client = new HttpClient())

            {

                try

                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    response.EnsureSuccessStatusCode();



                    string responseBody = await response.Content.ReadAsStringAsync();





                    // Fazendo o parsing da resposta JSON

                    List<DadosApi> data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DadosApi>>(responseBody);


                }

                catch (HttpRequestException ex)

                {

                    Console.WriteLine($"Ocorreu um erro ao fazer a requisição HTTP: {ex.Message}");

                }

                catch (Exception ex)

                {

                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");

                }

            }



            Console.ReadLine();
        }
    }
}

