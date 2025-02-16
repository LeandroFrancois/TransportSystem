using System;
using Modelos;
using Services;

namespace Register;

public class PassageiroRegister
{
    public Passageiro newCategory(){
        var passageiro = new Passageiro();
        var service = new PassageiroService();
        while(true){
            Console.WriteLine("Informe o nome da nova categoria: ");
            passageiro.Name = Console.ReadLine();
            if(passageiro.Validate()){
                service.RegisterCategory(passageiro);
                return passageiro;
            }
        }
    }
}
