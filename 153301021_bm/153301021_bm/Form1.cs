using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _153301021_bm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        private Cikti BM;
        private void Hesapla_Click(object sender, EventArgs e)
        {
            double hassaslik, kirlilik, miktar;
            dataGridView1.ClearSelection();
            hassaslik = Convert.ToDouble(numericUpDown_hassaslik.Value);
            kirlilik = Convert.ToDouble(numericUpDown_kirlilik.Value);
            miktar = Convert.ToDouble(numericUpDown_miktar.Value);

            
            BM = new Cikti(hassaslik, kirlilik,miktar);

            
            BM.DurumHesapla();
            BM.KuralHesapla();


            listBox1.Items.Clear();
            foreach (var a in BM.mumdai)
                listBox1.Items.Add(a.ToString());

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < BM.hassasList.Count; i++)
                {
                    for (int j = 0; j < BM.kirliList.Count; j++)
                    {
                        for (int k = 0; k < BM.miktarList.Count; k++)
                        {
                            if (row.Cells[1].Value.ToString() == BM.hassasList[i].ToString() && 
                                row.Cells[2].Value.ToString() == BM.kirliList[j].ToString() &&
                                row.Cells[3].Value.ToString() == BM.miktarList[k].ToString())
                            {
                                row.Selected = true;

                            }
                        }
                    }
                }
            }
            
            
            BM.Sonuc();


            label_donusHizi.Text = BM.DonusHizi.ToString();
            label_sure.Text = BM.Sure.ToString();
            label_deterjan.Text = BM.Deterjan.ToString();

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mat m = new Mat();
            dataGridView1.DataSource = m.dt;
            dataGridView1.ClearSelection();
            
        }


        
    }
}
