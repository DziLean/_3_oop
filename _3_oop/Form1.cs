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
        public Drug ListOfDrugs { get; set; }
        public DrugSpace()
        {
            InitializeComponent();

        }                
    }
}
