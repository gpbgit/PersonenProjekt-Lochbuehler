using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonenProjekt
{
    public class Datei
    {
        private string datei = "Personen.csv";
        private FileStream fs;

        public List<Person> liesPersonenDatei()
        {
            List<Person> liPers = new List<Person>();
            StreamReader sr = null;
            fs = null;
            string zeile;
            try
            {
                fs = new FileStream(datei, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    zeile = sr.ReadLine();
                    string[] daten = zeile.Split(';');

                    liPers.Add(
                        new Person( daten[0],   // Nachname
                                    daten[1],   // Vorname
                                    daten[2],   // strasse
                                    daten[3],   // plz
                                    daten[4],   // ort
                                    daten[5],   // KdnNr
                                    daten[6],   // Geschlecht
                                    daten[7]    // Anrede
                            )
                        );
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
                if (fs != null)
                    fs.Close();
            }

            return liPers;
        }
        public void schreibePersonenDatei(List<Person> liPers)
        {
            StreamWriter sw = null;
            fs = null;
            string zeile;

            try
            {
                fs = new FileStream(datei, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                foreach( Person p in liPers)
                {
                    zeile =  p.Nachname + ";";
                    zeile += p.Vorname + ";";
                    zeile += p.Strasse_nr + ";";
                    zeile += p.Plz + ";";
                    zeile += p.Ort + ";";
                    zeile += p.Kdnnr + ";";
                    zeile += p.Geschlecht + ";";
                    zeile += p.Anrede + ";";

                    sw.WriteLine(zeile);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
                if (fs != null)
                    fs.Close();
            }
        }
    }
}
