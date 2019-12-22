using System;
using System.Web.Mvc;

namespace MVCTextBoxIOKullanimi.Models
{
    public class Trumbowyg
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [AllowHtml]
        public string Icerik { get; set; }
        public DateTime OlusturmaTarih { get; set; } = DateTime.Now;
    }
}