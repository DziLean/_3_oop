using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_oop
{
    public partial class DrugSpace : Form
    {
        public List<Drug> ListOfDrugs { get; set; }
        public DrugSpace()
        {
            InitializeComponent();          
            _SolidLiquid.Items.Add("Solid");
            _SolidLiquid.Items.Add("Liquid");
            _Bool.Items.Add("true");
            _Bool.Items.Add("false");
            _Bool.SelectedItem = "true";
            _SolidLiquid.SelectedItem = "Solid";
            ListOfDrugs = new List<Drug>();

        }

        private void _List_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void _Fenibut_Click(object sender, EventArgs e)
        {
            Butterfly Feni = new Butterfly(_Name.Text.Trim(),int.Parse(_Cost.Text),_SolidLiquid.SelectedItem.ToString(), Convert.ToBoolean(_Bool.SelectedItem));
            ListOfDrugs.Add(Feni);
        }

        private void _Name_TextChanged(object sender, EventArgs e)
        {

        }
            
    }
}
  //Fenibut Feni = new Fenibut();
  //          Noshpa Nosh = new Noshpa();
  //          Smekta Smek = new Smekta();
  //          Tobrecks Tobr = new Tobrecks();
  //          Validol Vali = new Validol();
  //          Vitus Vitu = new Vitus();
  //          _List.Items.Add(Feni);
  //          _List.Items.Add(Nosh);
  //          _List.Items.Add(Smek);
  //          _List.Items.Add(Tobr);
  //          _List.Items.Add(Vali);
  //          _List.Items.Add(Vitu);
