using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_event_8
{
    public partial class Form1 : Form
    {
        private List<Building> buildings = new List<Building>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double T))
            {
                foreach (var building in buildings)
                {
                    if (T < 10)
                        building.TurnOnHeating();
                    else
                        building.Heating = "Heating is off";
                }
                UpdateListBox();
            }
        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var building in buildings)
            {
                listBox1.Items.Add($"{building.GetType().Name}: {building.Heating}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buildings.Clear(); // Очищаем список перед добавлением новых зданий
            buildings.Add(new PrivateHouse());
            buildings.Add(new ApartmentBuilding());
            UpdateListBox();
        }
    }
}
