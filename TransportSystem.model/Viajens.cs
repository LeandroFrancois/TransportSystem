namespace Modelos;

public class Viagem
{
    public int? Id { get; set; }
    public Motorista? Motorista { get; set; }
    public Veiculo? Veiculo { get; set; }
    public DateTime? DataHoraPartida { get; set; }
    public DateTime? DataHoraChegada { get; set; }
    public StatusViagem? Status { get; set; }
    public decimal? Valor { get; set; }
    public ICollection<Passageiro> Passageiros { get; set; } = new List<Passageiro>();

    public Viagem()
    {
    }

    public Viagem(int id, Motorista motorista, Veiculo veiculo, DateTime dataHoraPartida, DateTime? dataHoraChegada, StatusViagem status, decimal valor)
    {
        Id = id;
        Motorista = motorista;
        Veiculo = veiculo;
        DataHoraPartida = dataHoraPartida;
        DataHoraChegada = dataHoraChegada;
        Status = status;
        Valor = valor;
    }

    public enum StatusViagem
    {
        Agendada,
        EmAndamento,
        Concluida,
        Cancelada
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Viagem otherViagem = (Viagem)obj;

        if (this.Id != otherViagem.Id)
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        return $"[Motorista: {Motorista?.Nome}, Veiculo: {Veiculo?.model}, Partida: {DataHoraPartida}, Chegada: {DataHoraChegada}, Status: {Status}, Valor: {Valor}]";
    }

    public bool Validate()
    {
        var isValid = Motorista != null && Veiculo != null && DataHoraPartida != null && Valor != null && Status != null;
        if (!isValid)
        {
            throw new Exception("Dados Inválidos");
        }
        return true;
    }
}
