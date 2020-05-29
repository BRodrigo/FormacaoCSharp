
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor) // Se faz obrigatório colocar um retorno no IF e ELSE
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
}