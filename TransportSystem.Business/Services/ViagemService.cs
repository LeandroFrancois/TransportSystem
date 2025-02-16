using System;

namespace Services;

public class ViagemService
{
    public async Task ShowCategories(){
        var context = new EFContext();
        var categoryRepository = new GenericRepository<Viagem>(context);
        var categories = await categoryRepository.GetAllAsync();
        foreach(var element in categories){
            Console.WriteLine(element);
        }
    }

    public async void RegisterCategory(Viagem viagem){
        var context = new EFContext();
        var repository = new GenericRepository<Viagem>(context);
        await repository.AddAsync(viagem);
        Console.WriteLine("Viagem cadastrado com sucesso!");
    } 
}
