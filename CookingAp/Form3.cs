using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace CookingAp
{
    public partial class createMeal : Form
    {
        MainMenu _owner;
     
        OleDbConnection dbConnect = new OleDbConnection();
        decimal mealTotalPrice = 0;
        decimal holdValue = 0;
        
        //provides list of ingredients from ingredient table
        public createMeal(MainMenu owner)
        {
            _owner = owner;
            InitializeComponent();

            dbConnect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Personal Files\Documents\food.mdb;Persist Security Info = False";
            ingredientDrop.Enabled = false;
            amountText.Enabled = false;
            addIngredient.Enabled = false;
            createRecipe.Enabled = false;

            dbConnect.Open();
            readIngredients();

        }


        // clears field for new data, begins timer


        //repopulates combo box from Ingriedents, clears Recipe.save


        private void createRecipe_Click(object sender, EventArgs e)
        {
            OleDbCommand populateMaster = new OleDbCommand("INSERT INTO MasterRecipe SELECT Recipe_ID AS Recipe_ID, Ingredients AS Ingredients, Price AS Price FROM TempStorage;", dbConnect);



            populateMaster.ExecuteNonQuery();



            recipeSaved.Text = "Your recipe has been succesfully saved";
            recipeNameTextBox.Text = null;

            timer2.Interval = (1500);
            timer2.Start();
        }




        private void timer2_Tick(object sender, EventArgs e)
        {

            individualIngredientCost.Text = string.Empty;
            recipeSaved.Text = string.Empty;
            newRecipe.Items.Clear();
            recipeNameTextBox.Enabled = true;
            ingredientDrop.Items.Clear();
            ingredientDrop.Enabled = false;
            amountText.Enabled = false;
            createRecipe.Enabled = false;
            addIngredient.Enabled = false;
            timer2.Stop();
            totalRecipeCost.Text = null;
            _owner.clearTemp();
            readIngredients();
         


        }


        private void readIngredients()
        {

            OleDbDataReader readIngredient = null;
            OleDbCommand loadFood = new OleDbCommand("SELECT * from Ingredients", dbConnect);
            readIngredient = loadFood.ExecuteReader();

            while (readIngredient.Read())
            {
                ingredientDrop.Items.Add(readIngredient["Ingredient"]);
            }
        }

        private void recipeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ingredientDrop.Enabled = true;
       


        }

        private void addIngredient_Click(object sender, EventArgs e)
        {
            createRecipe.Enabled = true;
        
            OleDbCommand writeIngredient = new OleDbCommand("Insert into TempStorage(Ingredients) Values(@Ingredient)", dbConnect);
            OleDbCommand writeRecipe = new OleDbCommand("UPDATE TempStorage Set Recipe_ID = @Recipe_ID", dbConnect);
            OleDbCommand updatePrice = new OleDbCommand("UPDATE Ingredients INNER JOIN TempStorage ON Ingredients.Ingredient = TempStorage.Ingredients SET TempStorage.Price = Ingredients.Price * '" + amountText.Text + "' WHERE '" + ingredientDrop.SelectedItem + "' = TempStorage.Ingredients;", dbConnect);
         


         




            writeRecipe.Parameters.AddWithValue("@Recipe_ID", recipeNameTextBox.Text);


            writeIngredient.Parameters.AddWithValue("@Ingredient", ingredientDrop.SelectedItem);

          
            newRecipe.Items.Add(ingredientDrop.SelectedItem);
            writeIngredient.ExecuteNonQuery();
            writeRecipe.ExecuteNonQuery();
            updatePrice.ExecuteNonQuery();
         

            mealTotalPrice = mealTotalPrice + Convert.ToDecimal(individualIngredientCost.Text); 
            ingredientDrop.Items.Remove(ingredientDrop.SelectedItem);
            recipeNameTextBox.Enabled = false;
            amountText.Enabled = false;
            addIngredient.Enabled = false;
            totalRecipeCost.Text = Convert.ToString(mealTotalPrice);
            ingredientDrop.Text = "Select Ingredient";
          


        }

        //sets unit amount to 1 populates unit.Label with corresponding unit based on ingredient
        private void ingredientDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

            OleDbDataReader readUnit = null;
            OleDbCommand loadUnit= new OleDbCommand("SELECT Unit from Ingredients WHERE Ingredients.Ingredient = '" + ingredientDrop.SelectedItem + "';", dbConnect);
            readUnit = loadUnit.ExecuteReader();
            while (readUnit.Read()) 

            {
                unitLabel.Text = Convert.ToString(readUnit["Unit"]);

            }

            amountText.Enabled = true;
            amountText.Text = "1";

        }

     

        private void createMeal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown|| e.CloseReason == CloseReason.UserClosing)
                _owner.PerformRefresh();
               _owner.clearTemp();

        }
        
        private void amountText_TextChanged(object sender, EventArgs e)
        {
            addIngredient.Enabled = true;
            OleDbCommand loadFood = new OleDbCommand("SELECT SUM(Price) from Ingredients WHERE Ingredients.Ingredient = '" + ingredientDrop.SelectedItem + "';", dbConnect);
            object readPrice = loadFood.ExecuteScalar();
            decimal holdValue = Convert.ToDecimal(readPrice) * Convert.ToDecimal(amountText.Text);
            individualIngredientCost.Text = Convert.ToString(holdValue);
           
        }

        private void createMeal_Load(object sender, EventArgs e)
        {

        }
    }
}
