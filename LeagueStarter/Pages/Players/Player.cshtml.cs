using League.Data;
using League.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace League.Pages.Players
{
    public class PlayerModel : PageModel
    {
        // inject the Entity Framework context
        private readonly LeagueContext _context;

        public PlayerModel (LeagueContext context)
        {
            _context = context;
        }

        // load a single player based on Id
        public Player Player { get; set; }

        public async Task OnGetAsync(string id)
        {
            Player = await _context.Players.FindAsync(id);
        }
    }
}
