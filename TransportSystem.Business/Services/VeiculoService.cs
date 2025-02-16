using System;

namespace Services;

public class VeiculoService
{
    public async Task ShowCategories(){
        var context = new EFContext();
        var categoryRepository = new GenericRepository<Veiculo>(context);
        var categories = await categoryRepository.GetAllAsync();
        foreach(var element in categories){
            Console.WriteLine(element);
        }
    }

    public async void RegisterCategory(Veiculo veiculo){
        var context = new EFContext();
        var repository = new GenericRepository<Veiculo>(context);
        await repository.AddAsync(veiculo);
        Console.WriteLine("Veiculo cadastrado com sucesso!");
    } 
}
