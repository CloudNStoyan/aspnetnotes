using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Post(int id)
        {
            var service = new NoteService();
            var note = service.GetAllNotes().FirstOrDefault(x => x.Id == id);
            if (note == null)
            {
                return this.View("NotFound");
            }
            return this.View(note);
        }

        public IActionResult AllPosts()
        {
            var service = new NoteService();
            var notes = service.GetAllNotes();
            return this.View(notes);
        }
    }
}
