using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP1_Razor.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string Titulo { get; set; }

        [BindProperty]
        public DateTime Data { get; set; }

        [BindProperty]
        public string Local { get; set; }

        public string Message { get; set; }

        // Classe interna 
        public class Event
        {
            public string Titulo { get; set; }
            public DateTime Data { get; set; }
            public string Local { get; set; }
        }

        public static Action<Event> OnEventCreated;

        static CreateModel()
        {
            
            OnEventCreated = (evento) =>
            {
                Console.WriteLine($"[LOG] Evento criado: {evento.Titulo}, em {evento.Data.ToShortDateString()} no local {evento.Local}");
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var novoEvento = new Event
            {
                Titulo = this.Titulo,
                Data = this.Data,
                Local = this.Local
            };

            OnEventCreated?.Invoke(novoEvento);

            Message = "Evento cadastrado com sucesso!";
            return Page();
        }
    }
}