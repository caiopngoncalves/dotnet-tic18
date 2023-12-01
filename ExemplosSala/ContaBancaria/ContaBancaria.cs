namespace Namespace;
public class ContaBancaria
{
    private double _saldo;
    public double Saldo { get => _saldo;  set { 
            if(value <= 0){
                throw new ArithmeticException("Saldo não pode ser negativo");
            } else{
                _saldo = value;
            }
        } }
}
