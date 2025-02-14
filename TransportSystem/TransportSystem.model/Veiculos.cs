namespace Modelos;
public class Veiculo
{
    public Veiculo(string placa, string modelo){
        Placa = placa;
        Modelo = modelo;
    }
    public int IdVeiculo { get; set; }
    public string Placa { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public int Ano { get; set; }
    public int Capacidade { get; set; }
    public StatusVeiculo Status { get; set; }

    public enum StatusVeiculo
    {
        Disponivel,
        EmViagem,
        EmManutencao
    }

    public override string ToString()
    {
        return $"[{IdVeiculo}, {Placa}, {Modelo}]";
    }
    
}


