using System;

namespace Services;

public class ClienteService
{
    public async Task ShowCategories(){
        var context = new EFContext();
        var categoryRepository = new GenericRepository<Cliente>(context);
        var categories = await categoryRepository.GetAllAsync();
        foreach(var element in categories){
            Console.WriteLine(element);
        }
    }

    public async void RegisterCategory(Cliente cliente){
        var context = new EFContext();
        var repository = new GenericRepository<Cliente>(context);
        await repository.AddAsync(cliente);
        Console.WriteLine("Cliente cadastrado com sucesso!");
    } 
}
