namespace Modelos;

public class Cidade
{
    //public Cidade() {}

    public Cidade(string nome, string estado, string pais)
    {
        Nome = nome;
        Estado = estado;
        Pais = pais;
    }

    public int? IdCidade { get; set; }
    public string Nome { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (Cidade)obj;

        return base.Equals(IdCidade.HasValue && other.IdCidade.HasValue
                            && IdCidade == other.IdCidade);
    }

    public override int GetHashCode()
    {
        return IdCidade.HasValue ? IdCidade.GetHashCode() : 0;
    }

    public override string ToString()
    {
        return $"[{IdCidade}, {Nome}, {Estado}, {Pais}]";
    }
}
