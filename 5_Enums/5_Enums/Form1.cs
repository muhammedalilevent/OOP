using _5_Enums.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Enums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartmanlar.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbDepartmanlar.SelectedIndex == -1) return;
            Personel p = new Personel();
            p.Adi = txtPersonel.Text;
            p.Departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), cmbDepartmanlar.Text);
            //if (cmbDepartmanlar.SelectedIndex == -1) return;
            //switch (p.Departman)
            //{
            //    case Departmanlar.Yazılım:
            //        MessageBox.Show("Hoş geldin Yazılımcı!...");
            //        break;
            //    case Departmanlar.Sistem:
            //        MessageBox.Show("Hoş geldin Next Nextçi!...");
            //        break;
            //    case Departmanlar.Muhasebe:
            //        MessageBox.Show("Hoş geldin Muhasebeci!...");
            //        break;
            //    case Departmanlar.IK:
            //        MessageBox.Show("Hoş geldin IK!...");
            //        break;
            //    case Departmanlar.Pazarlama:
            //        MessageBox.Show("Hoş geldin Pazarlamacı!...");
            //        break;
            //    case Departmanlar.Üretim:
            //        MessageBox.Show("Hoş geldin Üretimci!...");
            //        break;
            //}
            try
            {
                if (true)//işlem başarılı ise
                {
                    MessageBox.Show(ResultMessage.GetMessage(Messagetype.Saved,p.GetType().Name));
                }
                else // işlem başarısız ise
                {
                    MessageBox.Show(ResultMessage.GetMessage(Messagetype.NotSaved,"Beceriksiz "));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ResultMessage.GetMessage(Messagetype.Exception,ex.Message));
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            try
            {
                if (true)//işlem başarılı ise
                {
                    MessageBox.Show(ResultMessage.GetMessage(Messagetype.Updated, p.GetType().Name));
                }
                else // işlem başarısız ise
                {
                    MessageBox.Show(ResultMessage.GetMessage(Messagetype.NotUpdated, p.GetType().Name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ResultMessage.GetMessage(Messagetype.Exception, ex.Message));
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            try
            {
                if (true)//işlem başarılı ise
                {
                    throw new Exception();
                    //MessageBox.Show(ResultMessage.GetMessage(Messagetype.Deleted, p.GetType().Name));
                }
                else // işlem başarısız ise
                {
                    MessageBox.Show(ResultMessage.GetMessage(Messagetype.NotDeleted, p.GetType().Name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ResultMessage.GetMessage(Messagetype.Exception, ex.Message));
            }
        }
    }
}
