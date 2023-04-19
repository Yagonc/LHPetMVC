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
        // Instancias do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "867.032.950-31", "arthut.antunes@sp.senai.br", "magruda");
        Cliente cliente2 = new Cliente(02, "William Godoy", "032.213.987.04", "will.godoy@gmail.com", "Ziquinho");
        Cliente cliente3 = new Cliente(03, "Homem Chopp", "173.365.476-07", "homemchopp@gmai.com", "Hoegaarden" );
        Cliente cliente4 = new Cliente(04, "Jorge Sampaoli", "316.352.414-10", "carecaodofla@gmail.com", "Refuerzos");
        Cliente cliente5 = new Cliente(05, "Fizz da Silva", "001.200.030-04", "cheirinhodepeixe@gmail.com", "Tubarão");
        
        // Lista de Clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        

        // Instancias do tipo fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/001-80", "c-shap@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "CTRL ALT DOG", "15.836.698/001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPed INC", "40.810.224/001", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/001", "contato@bff.us");
        
        // Lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaClientes = listaClientes;

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
