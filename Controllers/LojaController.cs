using Microsoft.AspNetCore.Mvc;
using AvaliacaoLP3.ViewModels;

namespace AvaliacaoLP3.Controllers;

public class LojaController : Controller
{
    //private static List<LojaViewModel> lojas = new List<LojaViewModel>();
     private static List<LojaViewModel> lojas = new List<LojaViewModel>{
            new LojaViewModel(32, "piso 3", "Tênis Brasil", "Aqui você encontra os tênis", true, "tenis@email.com"),
            new LojaViewModel(33, "piso 3", "Lembranças Já", "Vem comprar sua lembrança", true, "lemb@email.com"),
            new LojaViewModel(12, "piso 1", "Sorvetinho Gelado", "Sorvetinho Gelado", false, "sorvet@email.com"),
        };

    public IActionResult Index(int id)
    {
        return View(lojas[id-1]);
    }

    public IActionResult Gerenciamento()
    {
        return View();
    }

    public IActionResult Cadastramento()
    {
        return View();
    }

    public IActionResult Detalhes()
    {
        return View();
    }
}