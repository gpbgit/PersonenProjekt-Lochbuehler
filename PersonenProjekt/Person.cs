using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenProjekt
{
    public class Person
    {
        private string nachname;
        private string vorname;
        private string strasse_nr;
        private string plz;
        private string ort;
        private string kdnnr;
        private string geschlecht;
        private string anrede;
        #region props
        public string Nachname { get => nachname; set => nachname = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Strasse_nr { get => strasse_nr; set => strasse_nr = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Kdnnr { get => kdnnr; set => kdnnr = value; }
        public string Geschlecht { get => geschlecht; set => geschlecht = value; }
        public string Anrede { get => anrede; set => anrede = value; }
        #endregion props
        public Person( string nn, string vn )
        {
            nachname = nn;
            vorname = vn;
        }
        public Person(string nn, string vn, string str, string plz, 
            string ort, string knr, string geschl, string anr)
        {
            nachname = nn;
            vorname = vn;
            strasse_nr = str;
            this.plz = plz;
            this.ort = ort;
            kdnnr = knr;
            geschlecht = geschl;
            anrede = anr;
        }
        public string getName()
        {
            return vorname + " " + nachname;
        }
    }
}
