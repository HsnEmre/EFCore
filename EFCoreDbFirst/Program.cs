// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using EFCoreDbFirst.DAL;
using Microsoft.EntityFrameworkCore;

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(x =>
    {
        Console.WriteLine($"{x.id} {x.Name}");

    });
    Console.ReadLine();

}
