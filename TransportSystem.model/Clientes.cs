namespace Modelos;

public class Cliente
{
    public int? IdCliente { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? Cpf { get; set; }

    public Cliente()
    {
    }

    public Cliente(int idCliente, string nome, string email, string telefone, string cpf)
    {
        IdCliente = idCliente;
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Cpf = cpf;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Cliente otherCliente = (Cliente)obj;

        if (this.IdCliente != otherCliente.IdCliente)
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return IdCliente.GetHashCode();
    }

    public override string ToString()
    {
        return $"[{Nome}, {Email}, {Telefone}, {Cpf}]";
    }

    public bool Validate()
    {
        var isValid = !string.IsNullOrWhiteSpace(Nome) && !string.IsNullOrWhiteSpace(Email) &&
                      !string.IsNullOrWhiteSpace(Telefone) && !string.IsNullOrWhiteSpace(Cpf);
        if (!isValid)
        {
            throw new Exception("Dados Inválidos");
        }
        return true;
    }
}
