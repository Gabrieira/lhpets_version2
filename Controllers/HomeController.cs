using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Gabriel Oliveira", "898.032.950-41","gabriel@teste.com", "Bolinha");
        Cliente cliente2 = new Cliente(02, "Maria Santos", "560.863.061-09","maria@teste.com", "Mesclado");
        Cliente cliente3 = new Cliente(03, "Andrezza Interaminense", "494.152.386-58","andrezza@teste.com", "Babalu");
        Cliente cliente4 = new Cliente(04, "Gustavo Silva", "788.656.941-57","gustavo@teste.com", "Treloso");
        Cliente cliente5 = new Cliente(05, "Esmie Chagas", "245.212.362-51","esmie@teste.com", "Chiclete");

        List<Cliente> listaClientes = new List<Cliente>(); // criei a lista e atribui todos
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        //Instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.810.224/0001-83","boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "TikTok Dogs", "87.945.350/0001-09","noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05,"Bifinho Forever", "18.760.614/0001-37","contato@bff.us");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>(); // criei a lista e atribui todos
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
