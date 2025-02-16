using System;

namespace Services;

public class PassageiroService
{
    public async Task ShowCategories(){
        var context = new EFContext();
        var categoryRepository = new GenericRepository<Passageiro>(context);
        var categories = await categoryRepository.GetAllAsync();
        foreach(var element in categories){
            Console.WriteLine(element);
        }
    }

    public async void RegisterCategory(Passageiro passageiro){
        var context = new EFContext();
        var repository = new GenericRepository<Passageiro>(context);
        await repository.AddAsync(passageiro);
        Console.WriteLine("Passageiro cadastrado com sucesso!");
    } 
}
