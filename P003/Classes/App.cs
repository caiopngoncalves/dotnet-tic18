using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P003;

public class ProdutoNaoEncontradoException : Exception
{
    public ProdutoNaoEncontradoException(string codigo)
        : base($"Produto com código {codigo} não encontrado.")
    {
    }
}

public class App
{
    private List<(string Codigo, string Nome, int Quantidade, double Preco)> Produtos = new List<(string, string, int, double)>();

    private void Cadastro()
    {
        Console.WriteLine("Digite o código do produto");
        string codigo = Console.ReadLine()!;

        Console.WriteLine("Digite o nome do produto");
        string nome = Console.ReadLine()!;

        int quantidade;
        while (true)
        {
            Console.WriteLine("Digite a quantidade desse produto");
            if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Quantidade inválida. Digite um valor inteiro não negativo.");
            }
        }

        double preco;
        while (true)
        {
            Console.WriteLine("Digite o preço desse produto");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out preco) && preco >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Preço inválido. Digite um valor numérico não negativo.");
            }
        }

        this.Produtos.Add((Codigo: codigo, Nome: nome, Quantidade: quantidade, Preco: preco));
        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    private void ConsultaPeloCod()
    {
        Console.WriteLine("Digite o código do produto");
        string codigo = Console.ReadLine()!;

        var produto = this.Produtos.Find(x => x.Codigo == codigo);

        if (produto != default)
        {
            Console.WriteLine($" Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
        else
        {
            throw new ProdutoNaoEncontradoException(codigo);
        }
    }

    private void AtualizarEstoque()
    {
        Console.WriteLine("Digite o código do produto que deseja atualizar");
        string codigo = Console.ReadLine()!;

        Console.WriteLine("1. Atualizar entrada");
        Console.WriteLine("2. Atualziar saída");
        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                this.AtualizarEntrada(codigo);
                break;
            case "2":
                this.AtualizarSaida(codigo);
                break;
            default:
                Console.WriteLine("Escolha inválida");
                break;
        }
    }

    private void AtualizarEntrada(string codigo)
    {
        Console.WriteLine("Digite a quantidade de entrada");
        int entrada = int.Parse(Console.ReadLine()!);
        int index = this.Produtos.FindIndex(x => x.Codigo == codigo);

        if (index != -1)
        {
            var produtoAtualizado = (Produtos[index].Codigo, Produtos[index].Nome, Produtos[index].Quantidade + entrada, Produtos[index].Preco);
            Produtos[index] = produtoAtualizado;
            Console.WriteLine($"Entrada de {entrada} unidades realizada com sucesso. Estoque atual: {Produtos[index].Quantidade}");
        }
        else
        {
            Console.WriteLine($"Produto com código {codigo} não encontrado.");
        }
    }

    private void AtualizarSaida(string codigo)
    {
        Console.WriteLine("Digite a quantidade de saída");
        int saida = int.Parse(Console.ReadLine()!);

        var produto = this.Produtos.Find(x => x.Codigo == codigo);

        if (produto != default && saida <= produto.Quantidade)
        {
            int index = this.Produtos.FindIndex(x => x.Codigo == codigo);
            var produtoAtualizado = (Produtos[index].Codigo, Produtos[index].Nome, Produtos[index].Quantidade - saida, Produtos[index].Preco);
            Produtos[index] = produtoAtualizado;
            Console.WriteLine($"Saída de {saida} unidades realizada com sucesso. Estoque atual: {produto.Quantidade - saida}");
        }
        else if (produto == default)
        {
            Console.WriteLine($"Produto com código {codigo} não encontrado.");
        }
        else
        {
            Console.WriteLine("Não é possível atualizar o estoque pois o valor de saída é maior que a quantidade em estoque!");
        }
    }

    private void ListarProdEstoque()
    {
        Console.WriteLine("Digite o limite inferior de quantidade:");
        int limite = int.Parse(Console.ReadLine()!);

        var produtosAbaixoLimite = Produtos.Where(p => p.Quantidade < limite);

        Console.WriteLine("Produtos com quantidade abaixo do limite:");
        foreach (var produto in produtosAbaixoLimite)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
    }

    private void ListarProdByMinMax()
    {
        Console.WriteLine("Digite o valor mínimo:");
        double minimo = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o valor máximo:");
        double maximo = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        var produtosNoIntervalo = Produtos.Where(p => p.Preco >= minimo && p.Preco <= maximo);

        Console.WriteLine("Produtos dentro do intervalo de valores:");
        foreach (var produto in produtosNoIntervalo)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
    }

    private void ListarValorTotal()
    {
        double valorTotalEstoque = Produtos.Sum(p => p.Quantidade * p.Preco);

        Console.WriteLine($"Valor total do estoque: {valorTotalEstoque:C}");

        Console.WriteLine("Valores totais por produto:");
        foreach (var produto in Produtos)
        {
            double valorTotalProduto = produto.Quantidade * produto.Preco;
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Valor Total: {valorTotalProduto:C}");
        }
    }

    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("1. Cadastrar novo produto");
            Console.WriteLine("2. Consultar pelo código do produto");
            Console.WriteLine("3. Atualizar o estoque de produtos");
            Console.WriteLine("4. Listar produtos com quantidade abaixo de um limite");
            Console.WriteLine("5. Listar produtos de acordo a uma faixa de valores");
            Console.WriteLine("6. Listar valores totais de estoque e de cada produto");
            Console.WriteLine("0. Sair do programa");

            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            try
            {
                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Cadastrar novo produto: ");
                        this.Cadastro();
                        break;
                    case "2":
                        Console.WriteLine("Consultar pelo código do produto: ");
                        this.ConsultaPeloCod();
                        break;
                    case "3":
                        Console.WriteLine("Atualizar o estoque de produtos: ");
                        this.AtualizarEstoque();
                        break;
                    case "4":
                        Console.WriteLine("Listar produtos com quantidade abaixo de um limite: ");
                        this.ListarProdEstoque();
                        break;
                    case "5":
                        Console.WriteLine("Listar produtos de acordo a uma faixa de valores: ");
                        this.ListarProdByMinMax();
                        break;
                    case "6":
                        Console.WriteLine("Listar valores totais de estoque e de cada produto: ");
                        this.ListarValorTotal();
                        break;
                    case "0":
                        Console.WriteLine("Saindo do programa.");
                        return;
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }
            }
            catch (ProdutoNaoEncontradoException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}