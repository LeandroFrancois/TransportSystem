namespace Modelos;

public class Passageiro
{
    public int? IdPassageiro { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }

    public Passageiro() {}

    public Passageiro(int idPassageiro, string nome, string cpf, string telefone, string email)
    {
        IdPassageiro = idPassageiro;
        Nome = nome;
        CPF = cpf;
        Telefone = telefone;
        Email = email;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Passageiro otherPassageiro = (Passageiro)obj;

        if (this.IdPassageiro != otherPassageiro.IdPassageiro)
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return IdPassageiro.GetHashCode();
    }

    public override string ToString()
    {
        return $"[{Nome}, {CPF}, {Telefone}, {Email}]";
    }

    public bool Validate()
    {
        var isValid = !string.IsNullOrWhiteSpace(Nome) && !string.IsNullOrWhiteSpace(CPF) &&
                      !string.IsNullOrWhiteSpace(Telefone) && !string.IsNullOrWhiteSpace(Email);
        if (!isValid)
        {
            throw new Exception("Dados Inválidos");
        }
        return true;
    }
}
