using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonenProjekt
{
    public partial class Form1 : Form
    {
        private List<Person> liPersonen;
        public Form1()
        {
            InitializeComponent();
            liPersonen = new List<Person>();

            liPersonen.Add(new Person("Hurtig", "Hugo"));
            liPersonen.Add(new Person("Lustig", "Peter", "","","","55","männlich", "Herr"));

            alleAnzeigen();
        }
        // Neuer Eintrag oder vhd. Eintrag ändern
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int x;
                if (!int.TryParse(tbPlz.Text, out x))
                    MessageBox.Show("Falsche PLZ");

                Person p = new Person(tbNachname.Text, tbVorname.Text, tbStrasse.Text,
                    tbPlz.Text, tbOrt.Text, tbKdnNr.Text, tbGeschlecht.Text, lbAnrede.Text);

                if (comboBox1.SelectedIndex != -1)
                {
                    liPersonen[comboBox1.SelectedIndex] = p;
                }
                else
                {
                    liPersonen.Add(p);
                }

                alleAnzeigen();
                leereTbs();
                MessageBox.Show("Daten wurden gespeichert", "Juhu hat geklappt",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void leereTbs()
        {
            tbNachname.Text = "";
            tbVorname.Text = "";
            tbStrasse.Text = "";
            tbPlz.Text = "";
            tbOrt.Text = "";
            tbKdnNr.Text = "";
            tbGeschlecht.Text = "";
        }
        private void alleAnzeigen()
        {
            listBox1.Items.Clear();
            foreach (Person p in liPersonen)
            {
                listBox1.Items.Add(p.getName());
            }

            comboBox1.Items.Clear();
            foreach (Person p in liPersonen)
            {
                comboBox1.Items.Add(p.getName());
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( listBox1.SelectedIndex != -1 )
            {
                personAnzeigen(liPersonen[listBox1.SelectedIndex]);
                button2.Enabled = true;

            }
            else
            {
                button2.Enabled = false;
            }
        }
        private void personAnzeigen(Person p)
        {
            tbNachname.Text = p.Nachname;
            tbVorname.Text = p.Vorname;
            tbStrasse.Text = p.Strasse_nr;
            tbPlz.Text = p.Plz;
            tbOrt.Text = p.Ort;
            tbKdnNr.Text = p.Kdnnr;
            tbGeschlecht.Text = p.Geschlecht;
            if (p.Geschlecht == "männlich")
                rbMaennlich.Checked = true;
            else
                if (p.Geschlecht == "weiblich")
                    rbWeiblich.Checked = true;
                else
                    rbDivers.Checked = true;
            if (p.Anrede == "Herr")
                rbHerr.Checked = true;
            else
                if (p.Anrede == "Frau")
                rbFrau.Checked = true;
            else
                rbOhne.Checked = true;
        }
        // ListBox entmarkieren
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }
        // Eintrag löschen
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    liPersonen.RemoveAt(comboBox1.SelectedIndex);
                    // liPersonen.Remove(liPersonen[listBox1.SelectedIndex]);
                    comboBox1.Text = "";
                    alleAnzeigen();
                    leereTbs();
                }
            }
            catch( Exception ex )
            {
                if( MessageBox.Show(ex.Message, "Achtung Fehler", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) == DialogResult.Yes )
                {
                    MessageBox.Show("Sie haben Ja gedrückt");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                personAnzeigen(liPersonen[comboBox1.SelectedIndex]);
                button2.Enabled = true;

            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void rbMaennlich_CheckedChanged(object sender, EventArgs e)
        {
            if( rbMaennlich.Checked)
            {
                tbGeschlecht.Text = "männlich";
            }
        }

        private void rbWeiblich_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWeiblich.Checked)
            {
                tbGeschlecht.Text = "weiblich";
            }
        }

        private void rbDivers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDivers.Checked)
            {
                tbGeschlecht.Text = "divers";
            }
        }

        private void rbHerr_CheckedChanged(object sender, EventArgs e)
        {
            lbAnrede.Text = "Herr";
        }

        private void rbFrau_CheckedChanged(object sender, EventArgs e)
        {
            lbAnrede.Text = "Frau";
        }

        private void rbOhne_CheckedChanged(object sender, EventArgs e)
        {
            lbAnrede.Text = "Sehr geehrte Damen und Herren";
        }
    }
}
