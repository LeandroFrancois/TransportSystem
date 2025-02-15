namespace Modelos;

public class Login
{
    public int? IdLogin { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }

    public Login()
    {
    }

    public Login(int idLogin, string email, string senha)
    {
        IdLogin = idLogin;
        Email = email;
        Senha = senha;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Login otherLogin = (Login)obj;

        if (this.IdLogin != otherLogin.IdLogin)
        {
            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return IdLogin.GetHashCode();
    }

    public override string ToString()
    {
        return $"[{Email}]";
    }

    public bool Validate()
    {
        var isValid = !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Senha);
        if (!isValid)
        {
            throw new Exception("Dados Inválidos");
        }
        return true;
    }
}
