namespace CookingAp
{
    partial class createMeal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.createRecipe = new System.Windows.Forms.Button();
            this.recipeSaved = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.newRecipeName = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ingredientDrop = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.amountText = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.newRecipe = new System.Windows.Forms.ListBox();
            this.addIngredient = new System.Windows.Forms.Button();
            this.individualIngredientCost = new System.Windows.Forms.Label();
            this.recipeCostStatic = new System.Windows.Forms.Label();
            this.totalRecipeCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createRecipe
            // 
            this.createRecipe.Location = new System.Drawing.Point(218, 280);
            this.createRecipe.Name = "createRecipe";
            this.createRecipe.Size = new System.Drawing.Size(120, 31);
            this.createRecipe.TabIndex = 0;
            this.createRecipe.Text = "Create Recipe";
            this.createRecipe.UseVisualStyleBackColor = true;
            this.createRecipe.Click += new System.EventHandler(this.createRecipe_Click);
            // 
            // recipeSaved
            // 
            this.recipeSaved.AutoSize = true;
            this.recipeSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeSaved.Location = new System.Drawing.Point(30, 178);
            this.recipeSaved.Name = "recipeSaved";
            this.recipeSaved.Size = new System.Drawing.Size(0, 13);
            this.recipeSaved.TabIndex = 5;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.Location = new System.Drawing.Point(20, 35);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.recipeNameTextBox.TabIndex = 6;
            this.recipeNameTextBox.TextChanged += new System.EventHandler(this.recipeNameTextBox_TextChanged);
            // 
            // newRecipeName
            // 
            this.newRecipeName.AutoSize = true;
            this.newRecipeName.Location = new System.Drawing.Point(31, 11);
            this.newRecipeName.Name = "newRecipeName";
            this.newRecipeName.Size = new System.Drawing.Size(73, 13);
            this.newRecipeName.TabIndex = 7;
            this.newRecipeName.Text = "Recipe name:";
            // 
            // ingredientDrop
            // 
            this.ingredientDrop.FormattingEnabled = true;
            this.ingredientDrop.Location = new System.Drawing.Point(12, 77);
            this.ingredientDrop.Name = "ingredientDrop";
            this.ingredientDrop.Size = new System.Drawing.Size(98, 21);
            this.ingredientDrop.TabIndex = 8;
            this.ingredientDrop.Text = "Select Ingredient";
            this.ingredientDrop.SelectedIndexChanged += new System.EventHandler(this.ingredientDrop_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // amountText
            // 
            this.amountText.Location = new System.Drawing.Point(116, 77);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(93, 20);
            this.amountText.TabIndex = 10;
            this.amountText.TextChanged += new System.EventHandler(this.amountText_TextChanged);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(215, 80);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(0, 13);
            this.unitLabel.TabIndex = 11;
            // 
            // newRecipe
            // 
            this.newRecipe.FormattingEnabled = true;
            this.newRecipe.Location = new System.Drawing.Point(12, 166);
            this.newRecipe.Name = "newRecipe";
            this.newRecipe.Size = new System.Drawing.Size(90, 108);
            this.newRecipe.TabIndex = 12;
            // 
            // addIngredient
            // 
            this.addIngredient.Location = new System.Drawing.Point(275, 236);
            this.addIngredient.Name = "addIngredient";
            this.addIngredient.Size = new System.Drawing.Size(59, 38);
            this.addIngredient.TabIndex = 13;
            this.addIngredient.Text = "button1";
            this.addIngredient.UseVisualStyleBackColor = true;
            this.addIngredient.Click += new System.EventHandler(this.addIngredient_Click);
            // 
            // individualIngredientCost
            // 
            this.individualIngredientCost.AutoSize = true;
            this.individualIngredientCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.individualIngredientCost.Location = new System.Drawing.Point(12, 101);
            this.individualIngredientCost.Name = "individualIngredientCost";
            this.individualIngredientCost.Size = new System.Drawing.Size(0, 13);
            this.individualIngredientCost.TabIndex = 15;
            // 
            // recipeCostStatic
            // 
            this.recipeCostStatic.AutoSize = true;
            this.recipeCostStatic.Location = new System.Drawing.Point(113, 100);
            this.recipeCostStatic.Name = "recipeCostStatic";
            this.recipeCostStatic.Size = new System.Drawing.Size(68, 13);
            this.recipeCostStatic.TabIndex = 16;
            this.recipeCostStatic.Text = "Recipe Cost:";
            // 
            // totalRecipeCost
            // 
            this.totalRecipeCost.AutoSize = true;
            this.totalRecipeCost.Location = new System.Drawing.Point(166, 134);
            this.totalRecipeCost.Name = "totalRecipeCost";
            this.totalRecipeCost.Size = new System.Drawing.Size(0, 13);
            this.totalRecipeCost.TabIndex = 17;
            // 
            // createMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 323);
            this.Controls.Add(this.totalRecipeCost);
            this.Controls.Add(this.recipeCostStatic);
            this.Controls.Add(this.individualIngredientCost);
            this.Controls.Add(this.addIngredient);
            this.Controls.Add(this.newRecipe);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.ingredientDrop);
            this.Controls.Add(this.newRecipeName);
            this.Controls.Add(this.recipeNameTextBox);
            this.Controls.Add(this.recipeSaved);
            this.Controls.Add(this.createRecipe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "createMeal";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.createMeal_FormClosing);
            this.Load += new System.EventHandler(this.createMeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createRecipe;
        private System.Windows.Forms.Label recipeSaved;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.Label newRecipeName;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ComboBox ingredientDrop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.ListBox newRecipe;
        private System.Windows.Forms.Button addIngredient;
        private System.Windows.Forms.Label individualIngredientCost;
        private System.Windows.Forms.Label recipeCostStatic;
        private System.Windows.Forms.Label totalRecipeCost;
    }
}