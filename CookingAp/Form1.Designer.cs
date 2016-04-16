namespace CookingAp
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.createMeal = new System.Windows.Forms.Button();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.recipeBox = new System.Windows.Forms.ComboBox();
            this.weeklyPlan = new System.Windows.Forms.ListBox();
            this.addMeal = new System.Windows.Forms.Button();
            this.leftoverBox = new System.Windows.Forms.CheckBox();
            this.weeklyCost = new System.Windows.Forms.Label();
            this.mealPrice = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Food";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createMeal
            // 
            this.createMeal.Location = new System.Drawing.Point(247, 47);
            this.createMeal.Name = "createMeal";
            this.createMeal.Size = new System.Drawing.Size(75, 36);
            this.createMeal.TabIndex = 1;
            this.createMeal.Text = "Create Recipe";
            this.createMeal.UseVisualStyleBackColor = true;
            this.createMeal.Click += new System.EventHandler(this.createMeal_Click);
            // 
            // dayBox
            // 
            this.dayBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Gram",
            "Ounce",
            "Pound",
            "Each"});
            this.dayBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dayBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Items.AddRange(new object[] {
            "Monday",
            "Tuseday",
            "Wednesday",
            "Thursday",
            "Firday",
            "Saturday",
            "Sunday"});
            this.dayBox.Location = new System.Drawing.Point(15, 12);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(115, 21);
            this.dayBox.TabIndex = 4;
            this.dayBox.Text = "Select Day";
            this.dayBox.SelectedIndexChanged += new System.EventHandler(this.dayBox_SelectedIndexChanged);
            // 
            // recipeBox
            // 
            this.recipeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Gram",
            "Ounce",
            "Pound",
            "Each"});
            this.recipeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.recipeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.recipeBox.FormattingEnabled = true;
            this.recipeBox.Items.AddRange(new object[] {
            ""});
            this.recipeBox.Location = new System.Drawing.Point(136, 12);
            this.recipeBox.Name = "recipeBox";
            this.recipeBox.Size = new System.Drawing.Size(115, 21);
            this.recipeBox.TabIndex = 14;
            this.recipeBox.Text = "Select Meal";
            this.recipeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // weeklyPlan
            // 
            this.weeklyPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyPlan.FormattingEnabled = true;
            this.weeklyPlan.ItemHeight = 20;
            this.weeklyPlan.Location = new System.Drawing.Point(11, 89);
            this.weeklyPlan.Name = "weeklyPlan";
            this.weeklyPlan.Size = new System.Drawing.Size(325, 144);
            this.weeklyPlan.TabIndex = 15;
            // 
            // addMeal
            // 
            this.addMeal.Location = new System.Drawing.Point(22, 46);
            this.addMeal.Name = "addMeal";
            this.addMeal.Size = new System.Drawing.Size(64, 35);
            this.addMeal.TabIndex = 17;
            this.addMeal.Text = "Add Meal";
            this.addMeal.UseVisualStyleBackColor = true;
            this.addMeal.Click += new System.EventHandler(this.addMeal_Click);
            // 
            // leftoverBox
            // 
            this.leftoverBox.AutoSize = true;
            this.leftoverBox.Location = new System.Drawing.Point(257, 16);
            this.leftoverBox.Name = "leftoverBox";
            this.leftoverBox.Size = new System.Drawing.Size(65, 17);
            this.leftoverBox.TabIndex = 18;
            this.leftoverBox.Text = "Leftover";
            this.leftoverBox.UseVisualStyleBackColor = true;
            this.leftoverBox.CheckedChanged += new System.EventHandler(this.leftoverBox_CheckedChanged_1);
            // 
            // weeklyCost
            // 
            this.weeklyCost.AutoSize = true;
            this.weeklyCost.Location = new System.Drawing.Point(139, 411);
            this.weeklyCost.Name = "weeklyCost";
            this.weeklyCost.Size = new System.Drawing.Size(0, 13);
            this.weeklyCost.TabIndex = 19;
            // 
            // mealPrice
            // 
            this.mealPrice.AutoSize = true;
            this.mealPrice.Location = new System.Drawing.Point(282, 417);
            this.mealPrice.Name = "mealPrice";
            this.mealPrice.Size = new System.Drawing.Size(0, 13);
            this.mealPrice.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "Create Meal Plan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.weeklyCost);
            this.Controls.Add(this.leftoverBox);
            this.Controls.Add(this.addMeal);
            this.Controls.Add(this.mealPrice);
            this.Controls.Add(this.weeklyPlan);
            this.Controls.Add(this.recipeBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.createMeal);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createMeal;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.ComboBox recipeBox;
        private System.Windows.Forms.ListBox weeklyPlan;
        private System.Windows.Forms.Button addMeal;
        private System.Windows.Forms.CheckBox leftoverBox;
        private System.Windows.Forms.Label weeklyCost;
        private System.Windows.Forms.Label mealPrice;
        private System.Windows.Forms.Button button2;
    }
}

