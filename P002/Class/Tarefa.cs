using System.Data;

namespace P002;

public class Tarefa
{
    public string Titulo;
    public string Descrição;
    public DateTime DataVenc;
    public bool Conclusao;

    public Tarefa(string _titulo, string _descricao, DateTime _dataVenc, bool _conclusao)
    {
        this.Titulo = _titulo;
        this.Descrição = _descricao;
        this.DataVenc = _dataVenc;
        this.Conclusao = _conclusao;
    }

    public void Print()
    {
        Console.WriteLine("Título: " + this.Titulo);
        Console.WriteLine("Descrição: " + this.Descrição);
        Console.WriteLine("Data de vencimento: " + this.DataVenc);
    }

}
