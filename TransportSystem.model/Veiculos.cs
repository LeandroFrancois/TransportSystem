namespace Modelos;

public class Veiculo
{
    public int? IdVeiculo { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public string? Placa { get; set; }
    public string? Ano { get; set; }
    public string? Capacidade { get; set; }

    public Veiculo() {}

    public Veiculo(int idVeiculo, string marca, string modelo, string placa, string ano, string capacidade)
    {
        IdVeiculo = idVeiculo;
        Marca = marca;
        Modelo = modelo;
        Placa = placa;
        Ano = ano;
        Capacidade = capacidade;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Veiculo otherVeiculo = (Veiculo)obj;

        if (this.IdVeiculo != otherVeiculo.IdVeiculo)
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return IdVeiculo.GetHashCode();
    }

    public override string ToString()
    {
        return $"[{Marca}, {Modelo}, {Placa}, {Ano}, {Capacidade}]";
    }

    public bool Validate()
    {
        var isValid = !string.IsNullOrWhiteSpace(Marca) && !string.IsNullOrWhiteSpace(Modelo) &&
                      !string.IsNullOrWhiteSpace(Placa) && Ano != null && !string.IsNullOrWhiteSpace(Capacidade);
        if (!isValid)
        {
            throw new Exception("Dados Inválidos");
        }
        return true;
    }
}
