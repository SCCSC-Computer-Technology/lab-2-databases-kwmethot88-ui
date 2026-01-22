/*
 * Kyle Methot
 * CPT 206 A80H
 * Lab 2 Databases
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethotK_Lab2_CPT_206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAscending_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.AscendingPopulationOrder(this.cityDBDataSet.City);
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.DescendingPopulationOrder(this.cityDBDataSet.City);
        }

        private void btnCityNames_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortByCityNames(this.cityDBDataSet.City);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Total Population is: " + this.cityTableAdapter.TotalPopulation());
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Total Average is: " + this.cityTableAdapter.AveragePopulation());
        }

        private void btnHighestPopulation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Highest Population is: " + this.cityTableAdapter.HighestPopulation());
        }

        private void btnLowestPopulation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Lowest Population is: " + this.cityTableAdapter.LowestPopulation());
        }
    }
}
