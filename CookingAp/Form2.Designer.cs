namespace CookingAp
{
    partial class addFood
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.addItem = new System.Windows.Forms.Button();
            this.savedLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.foodLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 28);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(60, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(78, 28);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(60, 20);
            this.priceBox.TabIndex = 2;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            // 
            // unitBox
            // 
            this.unitBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Gram",
            "Ounce",
            "Pound",
            "Each"});
            this.unitBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.unitBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Items.AddRange(new object[] {
            "Gram",
            "Ounce",
            "Pound",
            "Each"});
            this.unitBox.Location = new System.Drawing.Point(144, 27);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(60, 21);
            this.unitBox.TabIndex = 3;
            this.unitBox.Text = "Unit";
            this.unitBox.SelectedIndexChanged += new System.EventHandler(this.unitBox_SelectedIndexChanged);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(133, 72);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 23);
            this.addItem.TabIndex = 4;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // savedLabel
            // 
            this.savedLabel.AutoSize = true;
            this.savedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedLabel.Location = new System.Drawing.Point(27, 56);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(0, 13);
            this.savedLabel.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(24, 9);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(35, 13);
            this.foodLabel.TabIndex = 6;
            this.foodLabel.Text = "Food";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(90, 9);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 13);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(156, 9);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(30, 13);
            this.unitLabel.TabIndex = 8;
            this.unitLabel.Text = "Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // addFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.savedLabel);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Name = "addFood";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label savedLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label label1;
    }
}