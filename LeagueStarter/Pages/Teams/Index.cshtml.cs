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

namespace League.Pages.Teams
{
    public class IndexModel : PageModel
    {
        // inject the Entity Framework context
        private readonly LeagueContext _context;

        public IndexModel(LeagueContext context)
        {
            _context = context;
        }

        // load all leagues, conferences, and divisions
        public List<Conference> Conferences { get; set; }
        public List<Division> Divisions { get; set; }
        public List<Team> Teams { get; set; }

        //allow storage of a favorite team
        [BindProperty(SupportsGet = true)]
        public string FavoriteTeam { get; set; }

        public SelectList AllTeams { get; set; }

        public async Task OnGetAsync()
        {
            // load all records from 3 tables
            Conferences = await GetConferences();
            Divisions = await GetDivisions();
            Teams = await GetTeams();


            // make a list of teams for the favorite select dropdown
            IQueryable<string> teamQuery = from t in _context.Teams
                                           orderby t.TeamId
                                           select t.TeamId;

            AllTeams = new SelectList(await teamQuery.ToListAsync());

            // if a favorite exists manage the cookie
            if (FavoriteTeam != null)
            {
                HttpContext.Session.SetString("_Favorite", FavoriteTeam);
            }
            else
            {
                FavoriteTeam = HttpContext.Session.GetString("_Favorite");
            }
        }

        // get all divisions in a conference and sort them
        public List<Division> GetConferenceDivisions(string ConferenceId)
        {
            return Divisions.Where(d => d.ConferenceId.Equals(ConferenceId)).OrderBy(d => d.Name).ToList();
        }

        // get all teams in a division and sort them

        public List<Team> GetDivisionTeams(string DivisionId)
        {
            return Teams.Where(t => t.DivisionId.Equals(DivisionId)).OrderByDescending(t => t.Win).ToList();
        }

        // load all records from 3 tables
        public async Task<List<Conference>> GetConferences()
        {
            return await _context.Conferences.ToListAsync();
        }
        public async Task<List<Division>> GetDivisions()
        {
            return await _context.Divisions.OrderBy(x => x.DivisionId).ToListAsync();
        }
        public async Task<List<Team>> GetTeams()
        {
            return await _context.Teams.OrderByDescending(x => x.Win).ToListAsync();
        }
    }
}
