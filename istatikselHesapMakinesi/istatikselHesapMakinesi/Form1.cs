using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istatikselHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Remove(listBox1.SelectedItem);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            float[] sayilar = new float[n];
            for (int i = 0; i < n; i++)
                sayilar[i] = Convert.ToSingle(listBox1.Items[i].ToString());
            StandartSapma sS = new StandartSapma(n, sayilar);
            listBox1.Items.Add("******" + sS.Sonuclu(n, sayilar));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            float[] sayilar = new float[n];
            for (int i = 0; i < n; i++)
                sayilar[i] = Convert.ToSingle(listBox1.Items[i].ToString());
            AritmetikOrtalama aO = new AritmetikOrtalama(sayilar, n);

            listBox1.Items.Clear();
            listBox1.Items.Add("-------------" + aO.Sonuclu(sayilar, n));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            float[] sayilar = new float[n];
            for (int i = 0; i < n; i++)
                sayilar[i] = Convert.ToSingle(listBox1.Items[i].ToString());
            Varyans v = new Varyans(n, sayilar);
            listBox1.Items.Clear();
            listBox1.Items.Add(v.sonuclu(n, sayilar));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            float[] sayilar = new float[n];
            sayilar[0] = Convert.ToSingle(listBox1.Items[0].ToString());
            float max = sayilar[0];
            for (int i = 1; i < n; i++)
            {
                sayilar[i] = Convert.ToSingle(listBox1.Items[i].ToString());
                if (max < sayilar[i]) max = sayilar[i];
            }

            for (int i = 0; i < n; i++)
            {
                sayilar[i] = sayilar[i] / max;
                listBox1.Items.Add("\n" + sayilar[i]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            float[] sayilar = new float[n];
            sayilar[0] = Convert.ToSingle(listBox1.Items[0].ToString());
            float min = sayilar[0];
            for (int i = 1; i < n; i++)
            {
                sayilar[i] = Convert.ToSingle(listBox1.Items[i].ToString());
                if (min > sayilar[i]) min = sayilar[i];
            }

            for (int i = 0; i < n; i++)
            {
                sayilar[i] = (sayilar[i]-min) / min;
                listBox1.Items.Add("\n" + sayilar[i]);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            float[] sayilar = new float[n];
            sayilar[0] = Convert.ToSingle(listBox1.Items[0].ToString());
            float min = sayilar[0];
            for (int i = 1; i < n; i++)
            {
                sayilar[i] = Convert.ToSingle(listBox1.Items[i].ToString());
                if (min > sayilar[i]) min = sayilar[i];
            }

            for (int i = 0; i < n; i++)
            {
                sayilar[i] = (sayilar[i]) / min;
                listBox1.Items.Add("\n" + sayilar[i]);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            float[] sayilar = new float[n];
            sayilar[0] = Convert.ToSingle(listBox1.Items[0].ToString());
            float min = sayilar[0];
            for (int i = 1; i < n; i++)
            {
                sayilar[i] = Convert.ToSingle(listBox1.Items[i].ToString());
                if (min > sayilar[i]) min = sayilar[i];
            }

            for (int i = 0; i < n; i++)
            {
                sayilar[i] = (sayilar[i] - min) / min;
                listBox1.Items.Add("\n" + sayilar[i]);
            }

        }
    }
}
