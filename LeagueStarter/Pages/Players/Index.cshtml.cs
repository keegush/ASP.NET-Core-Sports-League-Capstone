using League.Data;
using League.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace League.Pages.Players
{
    public class IndexModel : PageModel
    {
        // inject the Entity Framework context
        private readonly LeagueContext _context;

        public IndexModel(LeagueContext context)
        {
            _context = context;
        }

        public List<Player> Players { get; set; }

        // make a series of variables for the filter and search form
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedTeam { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedPosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; } = "Name";
        public SelectList AllTeams { get; set; }
        public SelectList AllPositions { get; set; }

        // read the favorite team cookie into this member variable
        public string FavoriteTeam { get; set; }

        public async Task OnGetAsync()
        {
            // create a base query that retrieves all players
            var players = from p in _context.Players
                          select p;

            // modify the query for the player that is being searched for
            if (!string.IsNullOrEmpty(SearchString))
            {
                players = players.Where(x => x.Name.ToLower().Contains(SearchString.ToLower()));
            }

            // modify the query is the user is filtering
            if (!string.IsNullOrEmpty(SelectedTeam))
            {
                players = players.Where(x => x.TeamId == SelectedTeam);
            }

            if (!string.IsNullOrEmpty(SelectedPosition))
            {
                players = players.Where(x => x.Position == SelectedPosition);
            }

            // modify the query is the user is sorting
            switch (SortField)
            {
                case "Number": players = players.OrderBy(x => x.Number).ThenBy(p => p.TeamId); break;
                case "Name": players = players.OrderBy(x => x.Name).ThenBy(p => p.TeamId); break;
                case "Position": players = players.OrderBy(x => x.Position).ThenBy(p => p.TeamId); break;
            }

            // make 2 select lists for the filter dropdowns
            IQueryable<string> teamQuery = from t in _context.Teams
                                           orderby t.TeamId
                                           select t.TeamId;

            AllTeams = new SelectList(await teamQuery.ToListAsync());

            IQueryable<string> positionQuery = (from p in _context.Players
                                                orderby p.Position
                                                select p.Position).Distinct();

            AllPositions = new SelectList(await positionQuery.ToListAsync());

            // read the favorite team from a cookie
            FavoriteTeam = HttpContext.Session.GetString("_Favorite");

            // finally retrieve any players according to filter, search, and sort options
            Players = await players.ToListAsync();
        }

        // return a string for the class of each player <a> tag, bold for starter, gold for favorite
        public string PlayerClass(Player Player)
        {
            string Class = "d-flex";
            if (Player.Depth == 1)
                Class += " starter";
            if (Player.TeamId == FavoriteTeam)
                Class += " favorite";
            return Class;
        }
    }
}
