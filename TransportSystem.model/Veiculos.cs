namespace Modelos;

public class Veiculo
{
    public int? Id { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public string? Placa { get; set; }
    public string? Ano { get; set; }
    public string? Capacidade { get; set; }

    public Veiculo()
    {
    }

    public Veiculo(int id, string marca, string modelo, string placa, string ano, string capacidade)
    {
        Id = id;
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

        if (this.Id != otherVeiculo.Id)
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
