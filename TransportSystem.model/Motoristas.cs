namespace Modelos;

public class Motorista
{
    public int? IdMotorista { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public string? CNH { get; set; }
    public DateTime? ValidadeCNH { get; set; }
    public StatusMotorista? Status { get; set; }

    public Motorista()
    {
    }

    public Motorista(int idMotorista, string nome, string cpf, string cnh, DateTime validadeCNH, StatusMotorista status)
    {
        IdMotorista = idMotorista;
        Nome = nome;
        CPF = cpf;
        CNH = cnh;
        ValidadeCNH = validadeCNH;
        Status = status;
    }

    public enum StatusMotorista
    {
        Disponivel,
        EmViagem,
        LicencaSuspensa
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Motorista otherMotorista = (Motorista)obj;

        if (this.IdMotorista != otherMotorista.IdMotorista)
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return IdMotorista.GetHashCode();
    }

    public override string ToString()
    {
        return $"[{Nome}, {CPF}, {CNH}, {ValidadeCNH}, {Status}]";
    }

    public bool Validate()
    {
        var isValid = !string.IsNullOrWhiteSpace(Nome) && !string.IsNullOrWhiteSpace(CPF) &&
                      !string.IsNullOrWhiteSpace(CNH) && ValidadeCNH != null && Status != null;
        if (!isValid)
        {
            throw new Exception("Dados Inválidos");
        }
        return true;
    }
}
