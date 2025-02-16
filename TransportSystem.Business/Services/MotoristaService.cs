using System;

namespace Services;

public class MotoristaService
{
    public async Task ShowCategories(){
        var context = new EFContext();
        var categoryRepository = new GenericRepository<Motorista>(context);
        var categories = await categoryRepository.GetAllAsync();
        foreach(var element in categories){
            Console.WriteLine(element);
        }
    }

    public async void RegisterCategory(Motorista motorista){
        var context = new EFContext();
        var repository = new GenericRepository<Passageiro>(context);
        await repository.AddAsync(motorista);
        Console.WriteLine("Motorista cadastrado com sucesso!");
    } 
}
