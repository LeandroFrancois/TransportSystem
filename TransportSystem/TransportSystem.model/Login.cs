namespace Modelos;
public class Login
{
    public Login() {}

    public Login(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }

    public int? IdLogin { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (Login)obj;

        return base.Equals(IdLogin.HasValue && other.IdLogin.HasValue
                            && IdLogin == other.IdLogin);
    }

    public override int GetHashCode()
    {
        return IdLogin.HasValue ? IdLogin.GetHashCode() : 0;
    }

    public override string ToString()
    {
        return $"[{IdLogin}, {Email}]";
    }
}