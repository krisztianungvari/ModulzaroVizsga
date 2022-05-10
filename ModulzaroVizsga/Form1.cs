using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ModulzaroVizsga
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

     
        private void button_Hozzaadas_tombhaz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (textBox_Cim.Text))
            {
                MessageBox.Show("Nincs kitöltve!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericUpDown_Alapterulet.Value < 20)
            {
                MessageBox.Show("Túl kevés alapterület lett megadva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox_Epitesi_anyag.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePicker_MKezdete.Value > dateTimePicker_MVege.Value)
            {
                MessageBox.Show("Nincs kitöltve!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox_Hazak.Items.Add(new Tombhaz(false, textBox_Cim.Text, (int)numericUpDown_Alapterulet.Value,comboBox_Epitesi_anyag.SelectedItem.ToString(), dateTimePicker_MKezdete.Value, dateTimePicker_MVege.Value, (int)numericUpDown_Lakasokszama.Value, comboBox_LakasfentartasTipusa.SelectedItem.ToString(),checkBox1.Checked));

        }

        private void button_Hozzaadas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Cim.Text))
            {
                MessageBox.Show("Nincs kitöltve!", "Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (numericUpDown_Alapterulet.Value < 20)
            {
                MessageBox.Show("Túl kevés alapterület lett megadva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox_Epitesi_anyag.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePicker_MKezdete.Value > dateTimePicker_MVege.Value)
            {
                MessageBox.Show("Nincs kitöltve!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox_Hazak.Items.Add(new Csaladihaz(textBox_Cim.Text, (int)numericUpDown_Alapterulet.Value, true, comboBox_Epitesi_anyag.SelectedItem.ToString(), dateTimePicker_MKezdete.Value, dateTimePicker_MVege.Value, (int)numericUpDown_ottelekok.Value, checkBox_Garazs.Checked,comboBox_Tetotipus.SelectedItem.ToString()));
        }

     

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Biztosan ki akar lépni?", "Kérdés");
            using (StreamWriter sw = new StreamWriter("epuletek.csv"))
            {
                foreach (object item in listBox_Hazak.Items)
                {
                    //sw.WriteLine(string.Join(";", item.Cim,item.Alapterület,item.Befejezes,));
                    if (item.GetType() == typeof(Csaladihaz))
                    {
                        ((Csaladihaz)item).ToString();
                    }
                    else
                    {
                        ((Tombhaz)item).ToString();

                    }
                }
            }
        }

        private void listBox_Hazak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Hazak.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijölölés!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (typeof(Csaladihaz)==listBox_Hazak.SelectedItem.GetType())
            {
                Csaladihaz csaladihaz = (Csaladihaz)listBox_Hazak.SelectedItem;
                textBox_Cim.Text = csaladihaz.Cim;
                numericUpDown_Alapterulet.Value = csaladihaz.Alapterület;
                dateTimePicker_MKezdete.Value = csaladihaz.Kezdes;
                dateTimePicker_MVege.Value = csaladihaz.Befejezes;
                textBox_becsultAr.Text = csaladihaz.becsultar().ToString("#,##0");


            }
            else
            {
                Tombhaz tombhaz = (Tombhaz)listBox_Hazak.SelectedItem;
                textBox_Cim.Text = tombhaz.Cim;
                numericUpDown_Alapterulet.Value = tombhaz.Alapterület;
                dateTimePicker_MKezdete.Value = tombhaz.Kezdes;
                dateTimePicker_MVege.Value = tombhaz.Befejezes;
                textBox_becsultAr.Text = tombhaz.becsultar().ToString("#,##0");
            }
        }

        private void listBox_Hazak_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Hazak.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijölölés!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Hazak haz = (Hazak)listBox_Hazak.SelectedItem;
            string s = haz.Cim + Environment.NewLine + haz.Alapterület + Environment.NewLine + haz.Kezdes + Environment.NewLine + haz.Befejezes;
            MessageBox.Show(s);
        }

        private void button_Torles_Click(object sender, EventArgs e)
        {
            if (listBox_Hazak.SelectedIndex < 0)
            {
                MessageBox.Show("Biztosan törli?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            listBox_Hazak.Items.RemoveAt(listBox_Hazak.SelectedIndex);
        }

        private void button_Aktualisak_Click(object sender, EventArgs e)
        {
            if (listBox_Hazak.SelectedIndex < 0)
            {
                return;
            }
            foreach (Hazak item in listBox_Hazak.Items)
            {
                listBox_Aktualis.Items.Add(item);
            }
        }
    }
}
