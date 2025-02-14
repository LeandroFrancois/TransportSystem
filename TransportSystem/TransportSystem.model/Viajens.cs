namespace Modelos;
public class Viagem
{

    public Viagem(DateTime datahorapartida, decimal valor){
        DataHoraPartida = datahorapartida;
        Valor = valor;
    }

    public int Id { get; set; }
    public Motorista? Motorista { get; set; }
    public Veiculo? Veiculo { get; set; }
    public DateTime DataHoraPartida { get; set; }
    public DateTime? DataHoraChegada { get; set; }
    public StatusViagem Status { get; set; }
    public decimal Valor { get; set; }
    public ICollection<Passageiro> Passageiros { get; set; } = new List<Passageiro>();

    public enum StatusViagem
    {
        Agendada,
        EmAndamento,
        Concluida,
        Cancelada
    }
}