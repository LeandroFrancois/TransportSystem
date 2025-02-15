namespace Modelos;
public class Motorista
{
    public Motorista(string nome, string cpf, string cnh){
        Nome = nome;
        CPF = cpf;
        CNH = cnh;
    }
    public int IdMotorista { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string CNH { get; set; } = string.Empty;
    public DateTime ValidadeCNH { get; set; }
    public StatusMotorista Status { get; set; }

    public enum StatusMotorista
    {
        Disponivel,
        EmViagem,
        LicencaSuspensa
    }

    public override string ToString()
    {
        return $"[{IdMotorista}, {Nome}, {CPF}, {CNH}]";
    }
}
