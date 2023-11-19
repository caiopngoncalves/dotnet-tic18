using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P002.Class
{
    public class App
    {
        private List<Tarefa> Tarefas = new List<Tarefa>();

        private void Criar()
        {
            System.Console.WriteLine("Digite um título: ");
            string titulo = Console.ReadLine();
            System.Console.WriteLine("Digite uma descrição: ");
            string descrição = Console.ReadLine();
            System.Console.WriteLine("Digite um dia: ");
            int dia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite um mes: ");
            int mes = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Tarefa concluida? (s/n): ");
            string aux = Console.ReadLine();
            bool entradaConclusao;
            if (aux == "s")
            {
                entradaConclusao = true;
            }
            else
            {
                entradaConclusao = false;
            }

            DateTime data = new DateTime(ano, mes, dia);
            Tarefa tarefa = new Tarefa(titulo, descrição, data, entradaConclusao);
            this.Tarefas.Add(tarefa);
        }

        private void ListarTodos()
        {
            System.Console.WriteLine("Essas são todas as tarefas: ");
            int indice = 0;
            foreach (Tarefa t in this.Tarefas)
            {
                System.Console.WriteLine("Tarefa numero " + indice + ":");
                t.Print();
                indice++;
            }
        }
        private void ListarConcluida()
        {
            System.Console.WriteLine("Essas são todas as tarefas concluídas: ");
            foreach (Tarefa t in this.Tarefas)
            {
                if (t.Conclusao)
                {
                    t.Print();
                }
            }
        }
        private void ListarNConcluida()
        {
            System.Console.WriteLine("Essas são todas as tarefas não concluídas: ");
            foreach (Tarefa t in this.Tarefas)
            {
                if (!t.Conclusao)
                {
                    t.Print();
                }
            }
        }
        private void AlterarConclusao()
        {
            this.ListarTodos();
            System.Console.WriteLine("Digite o número da tarefa que você quer alterar a conclusão: ");
            int numero = int.Parse(Console.ReadLine());
            this.Tarefas[numero].Conclusao = !this.Tarefas[numero].Conclusao;
        }
        private void Excluir()
        {
            this.ListarTodos();
            System.Console.WriteLine("Digite o número da tarefa que você quer excluir: ");
            int numero = int.Parse(Console.ReadLine());
            this.Tarefas.RemoveAt(numero);
        }
        private void Pesquisar()
        {

        }
        private void Estatisticas()
        {

        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Criar Tarefa");
                Console.WriteLine("2. Listar todas as tarefas");
                Console.WriteLine("3. Listar tarefas concluidas");
                Console.WriteLine("4. Listar tarefas não concluidas");
                Console.WriteLine("5. Alterar conclusão de uma tarefa");
                Console.WriteLine("6. Excluir uma tarefa");
                Console.WriteLine("7. Pesquisar uma tarefa pela nome");
                Console.WriteLine("8. Estatisticas");
                Console.WriteLine("0. Sair do programa");

                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("1. Criar Tarefa: ");
                        this.Criar();
                        break;
                    case "2":
                        Console.WriteLine("Listar todas as tarefas: ");
                        this.ListarTodos();
                        break;
                    case "3":
                        Console.WriteLine("Listar tarefas concluidas: ");
                        this.ListarConcluida();
                        break;
                    case "4":
                        Console.WriteLine("Listar tarefas não concluidas: ");
                        this.ListarNConcluida();
                        break;
                    case "5":
                        Console.WriteLine("Alterar conclusão de uma tarefa: ");
                        this.AlterarConclusao();
                        break;
                    case "6":
                        Console.WriteLine("Excluir uma tarefa: ");
                        this.Excluir();
                        break;
                    case "7":
                        Console.WriteLine("Pesquisar uma tarefa pela nome: ");
                        this.Pesquisar();
                        break;
                    case "8":
                        Console.WriteLine("Estatisticas: ");
                        this.Estatisticas();
                        break;
                    case "0":
                        Console.WriteLine("Saindo do programa.");
                        return;
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}