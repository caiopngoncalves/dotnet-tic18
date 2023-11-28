namespace Namespace;
public class App
{
    private List<Pessoa> pessoas = new List<Pessoa>();


    private void createCliente(Cliente x){
        foreach (Pessoa p in pessoas){
            if(p is Cliente){
                if(p.Cpf == x.Cpf){
                    throw new Exception("Cpf já existe!");

                }
            }
        
        };
        pessoas.Add(x);
    }

        private void createCoach(Treinador x){
        foreach (Pessoa p in pessoas){
            if(p is Treinador){
                if(p.Cpf == x.Cpf){
                    throw new Exception("Cpf já existe!");
                }
            }
        
        };
        pessoas.Add(x);
    }
    public void getCoachByMinMaxAge(){
        System.Console.WriteLine("Digite um valor mínimo de idade:");
        int min = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Digite um valor máximo de idade:");
        int max = int.Parse(Console.ReadLine()!);

        foreach (Pessoa p in pessoas){
            if(p is Treinador){
                if(p.getIdade() >= min && p.getIdade() <= max){
                    System.Console.WriteLine("Nome: " + p.Nome + " - Data de Nascimento: " + p.DataNascimento + " - Cpf: " + p.Cpf);
                }
            }
        };
    }

    public void getClientByMinMaxAge(){
        System.Console.WriteLine("Digite um valor mínimo de idade:");
        int min = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Digite um valor máximo de idade:");
        int max = int.Parse(Console.ReadLine()!);

        foreach (Pessoa p in pessoas){
            if(p is Cliente){
                if(p.getIdade() > min && p.getIdade() < max){
                    System.Console.WriteLine("Nome: " + p.Nome + " - Data de Nascimento: " + p.DataNascimento + " - Cpf: " + p.Cpf);
                }
            }
        };
    }

    public void getClientByImc(){
        System.Console.WriteLine("Digite um valor base para o imc");
        double min = double.Parse(Console.ReadLine()!);

        foreach (Pessoa p in pessoas){
            if(p is Cliente){
                Cliente c = (Cliente)p;
                if(c.getImc() >= min){
                    System.Console.WriteLine("Nome: " + p.Nome + " - Data de Nascimento: " + p.DataNascimento + " - Cpf: " + p.Cpf);
                }
            }
        };
    }

    public void getClientByAlph(){
        this.pessoas = this.pessoas.OrderBy(c => c.Nome).ToList();
        foreach (Pessoa p in pessoas){
            if(p is Cliente){

                System.Console.WriteLine("Nome: " + p.Nome + " - Data de Nascimento: " + p.DataNascimento + " - Cpf: " + p.Cpf);
                
            }
        };
    }

    public void getClientByAge(){
        this.pessoas = this.pessoas.OrderBy(c => c.getIdade()).ToList();
        foreach (Pessoa p in pessoas){
            if(p is Cliente){

                System.Console.WriteLine("Nome: " + p.Nome + " - Data de Nascimento: " + p.DataNascimento + " - Cpf: " + p.Cpf);
                
            }
        };
    }

    public void getClientAndCoachBirthday(){
        System.Console.WriteLine("Digite um mes de 1 ate 12:");
        int mes = int.Parse(Console.ReadLine()!);
        foreach (Pessoa p in pessoas){
            if(p.DataNascimento.Month == mes){

                System.Console.WriteLine("Nome: " + p.Nome + " - Data de Nascimento: " + p.DataNascimento + " - Cpf: " + p.Cpf);
                
            }
        };
    }


    public void Executar(){

        Cliente cliente= new Cliente();
        cliente.Nome = "Caio";
        cliente.Cpf = "12345678901";
        cliente.DataNascimento = new DateTime(1990, 5, 1);
        cliente.Peso = 60;
        cliente.Altura = 1.50;
        Cliente cliente2= new Cliente();
        cliente2.Nome = "Fernando";
        cliente2.Cpf = "12345678902";
        cliente2.DataNascimento = new DateTime(1980, 5, 1);
        cliente2.Peso = 60;
        cliente2.Altura = 1.80;
        Cliente cliente3= new Cliente();
        cliente3.Nome = "Alex";
        cliente3.Cpf = "99345678901";
        cliente3.DataNascimento = new DateTime(1970, 6, 1);
        cliente3.Peso = 60;
        cliente3.Altura = 1.60;

        Treinador treinador = new Treinador();
        treinador.Nome = "Marcos";
        treinador.Cpf = "98345678901";
        treinador.DataNascimento = new DateTime(1995, 7, 1);
        treinador.Cref= "123456";
        Treinador treinador2 = new Treinador();
        treinador2.Nome = "Sheila";
        treinador2.Cpf = "97345348911";
        treinador2.DataNascimento = new DateTime(1985, 8, 1);
        treinador2.Cref= "123256";
        Treinador treinador3 = new Treinador();
        treinador3.Nome = "Graça";
        treinador3.Cpf = "95343678901";
        treinador3.DataNascimento = new DateTime(1975, 5, 1);
        treinador3.Cref= "134456";

        this.createCliente(cliente);
        this.createCliente(cliente2);
        this.createCliente(cliente3);
        this.createCoach(treinador);
        this.createCoach(treinador2);
        this.createCoach(treinador3);
        
        


        Console.WriteLine("1. Treinadores com idade entre dois valores");
        this.getCoachByMinMaxAge();
        Console.WriteLine("2. Clientes com idade entre dois valores");
        this.getClientByMinMaxAge();
        Console.WriteLine("3. Clientes com IMC (peso/altura*altura) maior que um valor informado,em ordem crescente");
        this.getClientByImc();
        Console.WriteLine("4. Clientes em ordem alfabética");
        this.getClientByAlph();
        Console.WriteLine("5. Clientes do mais velho para mais novo");
        getClientByAge();
        Console.WriteLine("6. Treinadores e clientes aniversariantes do mês informado");
        getClientAndCoachBirthday();
    }
}
