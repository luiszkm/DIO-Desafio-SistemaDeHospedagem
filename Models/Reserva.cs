namespace DesafioProjetoHospedagem.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
      bool capacidadeMaiorOuIgualAHospedes = Suite.Capacidade >= hospedes.Count;
      // *IMPLEMENTE AQUI*
      if (capacidadeMaiorOuIgualAHospedes)
      {
        Hospedes = hospedes;
      }
      else
      {
        // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
        throw new Exception("A capacidade da suíte é menor que o número de hóspedes");
        // *IMPLEMENTE AQUI*
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
      int hospedes = this.Hospedes.Count();
      // *IMPLEMENTE AQUI*
      return hospedes;
    }

    public decimal CalcularValorDiaria()
    {
      // TODO: Retorna o valor da diária
      // Cálculo: DiasReservados X Suite.ValorDiaria
        decimal valorDiaria = this.DiasReservados * this.Suite.ValorDiaria;
      // *IMPLEMENTE AQUI*
      decimal valor = valorDiaria;

      // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
      bool temDesconto = this.DiasReservados >= 10;
      // *IMPLEMENTE AQUI*
      if (temDesconto)
      {
        valor = valorDiaria - (valorDiaria * 0.1m);
      }

      return valor;
    }
  }
}