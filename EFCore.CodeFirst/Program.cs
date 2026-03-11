// See https://aka.ms/new-console-template for more information

using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initiliazer.Build();

using (var _context = new AppDbContext())
{
    var newproduct = new Product { Name = "Kalem 33", Price = 200, Stock = 100, Barcode = 123 };
    Console.WriteLine($"ilk state:{_context.Entry(newproduct).State}");

    await _context.AddAsync(newproduct);

    Console.WriteLine($"son state:{_context.Entry(newproduct).State}");

    await _context.SaveChangesAsync();
    Console.WriteLine($"after save:{_context.Entry(newproduct).State}");

    //var products = await _context.Products.ToListAsync();
    //products.ForEach(x =>
    //{
    //    var state = _context.Entry(x).State;
    //    Console.WriteLine($"{x.Id}: {x.Name} - {x.Price} - {x.Stock} - state: {state}");
    //});
}