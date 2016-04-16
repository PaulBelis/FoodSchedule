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
using System.IO;
using System.Security.AccessControl;
using System.Security.Permissions;

namespace CookingAp
{
    public partial class MainMenu : Form
    {
        OleDbConnection dbConnect = new OleDbConnection();

        decimal weeklyCostStorage = 0;

        public MainMenu()
        {

            dbConnect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Personal Files\Documents\food.mdb;Persist Security Info = False";
            dbConnect.Open();
            InitializeComponent();
            makeFalse();
            PerformRefresh();
            clearTemp();
        }

        public void makeFalse()
        {
            recipeBox.Enabled = false;
            addMeal.Enabled = false;
            leftoverBox.Checked = false;
            leftoverBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = new addFood();
            form1.Show(this);
        }


        private void createMeal_Click(object sender, EventArgs e)
        {
            createMeal newForm = new createMeal(this);
            newForm.Show();
        }



        public void sumWeeklyMealPrice()
        {
            OleDbCommand doMath = new OleDbCommand("SELECT SUM(Price) FROM MasterRecipe WHERE Recipe_ID = '" + recipeBox.Text + "'", dbConnect);

            object result = doMath.ExecuteScalar();
            mealPrice.Text = Convert.ToString(result);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            addMeal.Enabled = true;
            leftoverBox.Enabled = true;
            sumWeeklyMealPrice();
        
        }



        private void addMeal_Click(object sender, EventArgs e)
        {
            weeklyCostStorage = weeklyCostStorage + Convert.ToDecimal(mealPrice.Text);
            weeklyPlan.Items.Add(string.Format(" {0}: {1}(${2}{3}",dayBox.Text, recipeBox.Text,mealPrice.Text,")"));
            weeklyCost.Text = Convert.ToString(weeklyCostStorage);
            dayBox.Items.Remove(dayBox.SelectedItem);
            recipeBox.Text = "Select Meal";
            dayBox.Text = "Select Day";
            makeFalse();
        
            
        }
        public void PerformRefresh()
        {
            recipeBox.Items.Clear();
            OleDbDataReader readIngredient = null;
            OleDbCommand loadFood = new OleDbCommand("SELECT DISTINCT Recipe_ID from MasterRecipe", dbConnect);
        
            readIngredient = loadFood.ExecuteReader();
            while (readIngredient.Read())

            { 
                recipeBox.Items.Add(readIngredient["Recipe_ID"]);

            }
            

        }
     

        public void clearTemp()
        {
            OleDbCommand clearTable = new OleDbCommand("DELETE FROM TempStorage", dbConnect);
            clearTable.ExecuteNonQuery();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.UserClosing)

            {
                clearTemp();
            }
        }

        private void dayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            recipeBox.Enabled = true;
            
        }

        private void leftoverBox_CheckedChanged_1(object sender, EventArgs e)
        {
            mealPrice.Text = "0";
            if (leftoverBox.Checked == false)
            {
                sumWeeklyMealPrice();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {



            StringBuilder buildStrings = new StringBuilder();
            foreach (string day in weeklyPlan.Items)
            {
                buildStrings.AppendLine(day);

            }

          

            string userAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string input = "Weekly Menu";
             string result = string.Format("{0}  {1:yyyy-MM-dd}",input, DateTime.Now);

             string pathing = @"C:\Program Files\Meal App\" + result + ".txt";
            // var combine = Path.Combine(userAppData, pathing);
            //Path.Combine(userAppData, pathing);

           
            System.IO.File.WriteAllText(pathing, buildStrings.ToString());


        







            // OleDbCommand writeWeeklyPlan = new OleDbCommand("INSERT INTO MealPlanStorage SELECT Recipe_ID AS Recipe_ID, Ingredients AS Ingredient, Price AS Price FROM MasterRecipe;", dbConnect);
            //OleDbCommand datePlan = new OleDbCommand("Insert into MealPlanStorage(Date) Values(@Date)", dbConnect);
            //datePlan.Parameters.AddWithValue("@Date", );

            //writeWeeklyPlan.ExecuteNonQuery();
            // datePlan.ExecuteNonQuery();
        }

//        private void button3_Click(object sender, EventArgs e)
  //      {
    //        DateTime time = DateTime.Now;
      //      MessageBox.Show(time.ToString("M"));
        //}
    }



}

