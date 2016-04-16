using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace CookingAp
{
    public partial class addFood : Form
    {
        OleDbConnection dbConnect = new OleDbConnection();
     

        public addFood()
        {
            InitializeComponent();
            enabledFalse();

        }

        //connects to database, populates, clears fields for new data
 
        public void enabledFalse()
        {
            nameBox.Text = null;
            priceBox.Text = null;
            unitBox.Text = null;
            addItem.Enabled = false;
            priceBox.Enabled = false;
            unitBox.Enabled = false;
        } 

        private void addItem_Click(object sender, EventArgs e)
        {
            dbConnect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Personal Files\Documents\food.mdb;Persist Security Info = False";
            dbConnect.Open();
            OleDbCommand writeFood = new OleDbCommand("Insert into Ingredients(Ingredient, Price, Unit) Values(@Ingredient, @Price, @Unit)", dbConnect);

            writeFood.Parameters.AddWithValue("@Ingredient", nameBox.Text);
            writeFood.Parameters.AddWithValue("@Price", priceBox.Text);
            writeFood.Parameters.AddWithValue("@Unit", unitBox.Text);

         
            savedLabel.Text = "Your entry has been saved";

            timer1.Interval = (1500);
            timer1.Start();
            writeFood.ExecuteNonQuery();
            dbConnect.Close();            
        }

        //stops timer emptys label
        private void timer1_Tick(object sender, EventArgs e)
        {
            enabledFalse();
            savedLabel.Text = string.Empty;
            addItem.Enabled = false;
            timer1.Stop();
        }

        private void unitBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addItem.Enabled = true;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            priceBox.Enabled = true;
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            unitBox.Enabled = true;
        }
    }

}
