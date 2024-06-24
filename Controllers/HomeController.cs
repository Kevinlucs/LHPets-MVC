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
        //Instâncias do tipo clientes.
        Cliente cliente1 = new Cliente(01, "Kevin", "06567251142", "kevinlucas2024@gmail.com", "Bento");
        Cliente cliente2 = new Cliente(02, "Marcos", "06567251144", "marcos2024@gmail.com", "nestor");
        Cliente cliente3 = new Cliente(03, "Vinicius", "06567251145", "vinicius2024@gmail.com", "arroz");
        Cliente cliente4 = new Cliente(04, "Jorge", "06567251146", "jorge2024@gmail.com", "amendoim");
        Cliente cliente5 = new Cliente(05, "Alvin", "06567251147", "alvin2024@gmail.com", "trovão");

        // lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //Instâncias do tipo fornecedores.
        Fornecedor fornecedor1 = new Fornecedor(01, "Kevin Coop", "06.158.220/0001-80", "kevinlucas2024@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Marcos S/A", "06.158.220/0001-81", "marcos2024@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Vinicius Ltda", "06.158.220/0001-80", "vinicius2024@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Jorge inc", "06.158.220/0001-80", "jorge2024@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Alvin Enterprise", "06.158.220/0001-80", "alvin2024@gmail.com");

        // lista de fornecedores e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
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
