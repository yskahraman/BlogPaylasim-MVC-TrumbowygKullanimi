using MVCTextBoxIOKullanimi.Models;
using MVCTextBoxIOKullanimi.StaticDb;
using System.Linq;
using System.Web.Mvc;

namespace MVCTextBoxIOKullanimi.Controllers
{
    public class EditorController : Controller
    {
        // GET: Editor
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        //[ValidateInput(false)] Bunu yapma !!       
        public ActionResult Ekle(Trumbowyg trumbowyg)
        {
            VirtualDatabase.Ekle(trumbowyg);
            return RedirectToAction("Goster", "Editor");
        }
 

        public ActionResult Goster()
        {
           var gelenIcerik= VirtualDatabase.Metinler.OrderByDescending(I=>I.OlusturmaTarih).FirstOrDefault();
            return View(gelenIcerik);
        }
    }
}