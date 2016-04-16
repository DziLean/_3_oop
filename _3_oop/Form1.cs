using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace _3_oop
{
    public partial class FlyerName : Form
    {
        public static List<Animal> LType = new List<Animal>();


        public static bool IsValid(string a, string b = "1")
        {
            try
            {
                int age = int.Parse(a);
                int speed = int.Parse(b);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static void ClearFields(List<TextBox> LT)
        {
            foreach (TextBox t in LT)
            {
                t.Text = "";
            }
        }

        public List<Animal> ListOfAnimal { get; set; }
        public FlyerName()
        {
            InitializeComponent();
            FlyersCanFly.Items.Add("true");
            FlyersCanFly.Items.Add("false");
            WalkerIsWalker.Items.Add("true");
            WalkerIsWalker.Items.Add("false");
            SwimmersIsFish.Items.Add("true");
            SwimmersIsFish.Items.Add("false");
            FlyersCanFly.Enabled = true;
            WalkerIsWalker.Enabled = false;
            SwimmersIsFish.Enabled = false;
            FlyersCanFly.SelectedItem = "true";
            ListOfAnimal = new List<Animal>();

            LType.Add(new Salmon());
            LType.Add(new Dolphin());
            LType.Add(new Fox());
            LType.Add(new Snake());
            LType.Add(new Bird());
            LType.Add(new Butterfly());
        }

        private void _List_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void Salmon_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(SwimmersAge.Text, SwimmersSpeed.Text))
                {
                    Salmon sl = new Salmon(SwimmersName.Text, int.Parse(SwimmersAge.Text), SwimmersLocation.Text, int.Parse(SwimmersSpeed.Text));
                    ListOfAnimal.Add(sl);
                    ChooseAnimal.Items.Add(sl);
                    List<TextBox> LT = new List<TextBox>();
                    LT.Add(SwimmersName);
                    LT.Add(SwimmersAge);
                    LT.Add(SwimmersLocation);
                    LT.Add(SwimmersSpeed);
                    ClearFields(LT);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Dolphin_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(SwimmersAge.Text, SwimmersSpeed.Text))
                {
                    Dolphin d = new Dolphin(SwimmersName.Text, int.Parse(SwimmersAge.Text), SwimmersLocation.Text, int.Parse(SwimmersSpeed.Text));
                    ListOfAnimal.Add(d);
                    ChooseAnimal.Items.Add(d);
                    List<TextBox> LT = new List<TextBox>();
                    LT.Add(SwimmersName);
                    LT.Add(SwimmersAge);
                    LT.Add(SwimmersLocation);
                    LT.Add(SwimmersSpeed);
                    ClearFields(LT);

                }
            }
            catch (Exception ex)
            { }
        }

        private void Fox_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(WalkersAge.Text))
                {
                    Fox f = new Fox(WalkersName.Text, int.Parse(WalkersAge.Text), WhatDoesTheSay.Text, WalkersAreal.Text);
                    ListOfAnimal.Add(f);
                    ChooseAnimal.Items.Add(f);
                    List<TextBox> LT = new List<TextBox>();
                    LT.Add(WalkersName);
                    LT.Add(WalkersAge);
                    LT.Add(WhatDoesTheSay);
                    LT.Add(WalkersAreal);
                    ClearFields(LT);
                }
            }
            catch (Exception ex) { }
        }

        private void Snake_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(WalkersAge.Text))
                {
                    Snake sn = new Snake(WalkersName.Text, int.Parse(WalkersAge.Text), WhatDoesTheSay.Text, WalkersAreal.Text);
                    ListOfAnimal.Add(sn);
                    ChooseAnimal.Items.Add(sn);
                    List<TextBox> LT = new List<TextBox>();
                    LT.Add(WalkersName);
                    LT.Add(WalkersAge);
                    LT.Add(WhatDoesTheSay);
                    LT.Add(WalkersAreal);
                    ClearFields(LT);
                }
            }
            catch (Exception ex) { }
        }

        private void Bird_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(FlyersAge.Text, FlyersWingsQuantity.Text))
                {
                    Bird b = new Bird(FlyersName.Text, int.Parse(FlyersAge.Text), bool.Parse(FlyersCanFly.Text), int.Parse(FlyersWingsQuantity.Text));
                    ListOfAnimal.Add(b);
                    ChooseAnimal.Items.Add(b);
                    List<TextBox> LT = new List<TextBox>();
                    LT.Add(FlyersName);
                    LT.Add(FlyersAge);
                    LT.Add(FlyersWingsQuantity);
                    ClearFields(LT);
                }
            }
            catch (Exception ex) { }
        }

        private void Butterfly_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(FlyersAge.Text, FlyersWingsQuantity.Text))
                {
                    Butterfly bu = new Butterfly(FlyersName.Text, int.Parse(FlyersAge.Text), bool.Parse(FlyersCanFly.Text), int.Parse(FlyersWingsQuantity.Text));
                    ListOfAnimal.Add(bu);
                    ChooseAnimal.Items.Add(bu);
                    List<TextBox> LT = new List<TextBox>();
                    LT.Add(FlyersName);
                    LT.Add(FlyersAge);
                    LT.Add(FlyersWingsQuantity);
                    ClearFields(LT);
                }
            }
            catch (Exception ex) { }
        }

        private void WalkersAreal_TextChanged(object sender, EventArgs e)
        {

        }

        private void _Delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            int ind = ChooseAnimal.SelectedIndex;
            Animal an = ListOfAnimal[ind];
            var json = JsonConvert.SerializeObject(an, settings);
            ChangeProp.Text = json;
        }

        private void Serialize_Click(object sender, EventArgs e)
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                var json = JsonConvert.SerializeObject(ListOfAnimal, settings);
                _Console.Text = json;
                while (ChooseAnimal.Items.Count > 0)
                {
                    ChooseAnimal.Items.RemoveAt(0);
                }
                ListOfAnimal = new List<Animal>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deserialization error");
            }
        }

        private void _Console_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            try
            {
                ListOfAnimal = JsonConvert.DeserializeObject<List<Animal>>(_Console.Text, settings);
                for (int i = 0; i < ListOfAnimal.Count; ++i)
                    ChooseAnimal.Items.Add(ListOfAnimal[i]);
                _Console.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deserialization error");
            }

        }

        private void _delete_Click(object sender, EventArgs e)
        {
            int ind = ChooseAnimal.SelectedIndex;
            ListOfAnimal.RemoveAt(ind);
            ChooseAnimal.Items.RemoveAt(ind);
        }

        private void change_Click(object sender, EventArgs e)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            try
            {
                Animal an = JsonConvert.DeserializeObject<Animal>(ChangeProp.Text, settings);
                int i = ChooseAnimal.SelectedIndex;
                ListOfAnimal[i] = an;
                ChooseAnimal.Items[i] = an;
                ChangeProp.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deserialization error");
            }

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
