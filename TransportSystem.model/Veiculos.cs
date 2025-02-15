namespace Modelos;

public class Veiculo
{
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }

    public Veiculo()
    {
    }

    public Veiculo(int id, string nome, string cpf, string telefone, string email)
    {
        Id = id;
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

        if (this.Id != otherPassageiro.Id)
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
