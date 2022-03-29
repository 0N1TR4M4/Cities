using Cities.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cities.View
{
    public partial class CitiesVIew : Form
    {
        CitiesController citiesController = new CitiesController();

        public CitiesVIew()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCities.DataSource = citiesController.GetAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshTable()
        {
            dgvCities.DataSource = citiesController.GetAll();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            Models.City cities = new Models.City();
            cities.Population = int.Parse(populationtxt.Text);
            cities.City1 = citytxt.Text;
            citiesController.CreateCity(cities);
            RefreshTable();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCities.CurrentRow;
            int id = int.Parse(row.Cells["Id"].Value.ToString());
            citiesController.UpdateCities(id, );
            RefreshTable();
        }
    }
}
