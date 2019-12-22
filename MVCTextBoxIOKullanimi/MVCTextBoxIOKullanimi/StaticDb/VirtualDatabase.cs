using MVCTextBoxIOKullanimi.Models;
using System.Collections.Generic;

namespace MVCTextBoxIOKullanimi.StaticDb
{
    public static class VirtualDatabase
    {
        private static List<Trumbowyg> _metinler = new List<Trumbowyg>();

        public static List<Trumbowyg> Metinler
        {
            get
            {
                return _metinler;
            }
        }


        public static void Ekle(Trumbowyg metin)
        {
            _metinler.Add(metin);
        }
    }
}