using System;
using Modelos;

namespace Register;

public class PassageiroRegister
{
    public Passageiro newCategory(){
        var passageiro = new Passageiro();
        var service = new PassageiroService();
        while(true){
            Console.WriteLine("Informe o nome da nova categoria: ");
            category.Name = Console.ReadLine();
            if(category.Validate()){
                service.RegisterCategory(category);
                return category;
            }
        }
    }
}
