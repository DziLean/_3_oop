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
    public partial class FlyerName : Form
    {
        public List<Animal> ListOfAnimal { get; set; }
        public FlyerName()
        {
            InitializeComponent();          
            _SolidLiquid.Items.Add("Solid");
            _SolidLiquid.Items.Add("Liquid");
            CanFly.Items.Add("true");
            CanFly.Items.Add("false");
            CanFly.SelectedItem = "true";
            _SolidLiquid.SelectedItem = "Solid";
            ListOfDrugs = new List<Drug>();

        }

        private void _List_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void _Fenibut_Click(object sender, EventArgs e)
        {
            Butterfly Feni = new Butterfly(SwimmersName.Text.Trim(),int.Parse(SwimmersAge.Text),_SolidLiquid.SelectedItem.ToString(), Convert.ToBoolean(CanFly.SelectedItem));
            ListOfDrugs.Add(Feni);
        }

        private void _Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnimalSpace_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
            
    }
}
  //Fenibut Feni = new Fenibut();
  //          Noshpa Nosh = new Noshpa();
  //          Smekta Smek = new Smekta();
  //          Tobrecks Tobr = new Tobrecks();
  //          Validol Vali = new Validol();y
  //          Vitus Vitu = new Vitus();
  //          _List.Items.Add(Feni);
  //          _List.Items.Add(Nosh);
  //          _List.Items.Add(Smek);
  //          _List.Items.Add(Tobr);
  //          _List.Items.Add(Vali);
  //          _List.Items.Add(Vitu);
