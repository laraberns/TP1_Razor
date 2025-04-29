using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP1_Razor.Pages
{
    public class AddProductModel : PageModel
    {
        public void OnPost()
        {
            var nome = Request.Form["Nome"];
            var preco = Request.Form["Preco"];
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Preço: " + preco);
        }
    }
}
