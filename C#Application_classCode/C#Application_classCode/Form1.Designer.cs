namespace C_Application_classCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            listGroceries = new ListBox();
            tbFood = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkSlateBlue;
            btnSubmit.Location = new Point(199, 250);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "clickMe!";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // listGroceries
            // 
            listGroceries.FormattingEnabled = true;
            listGroceries.ItemHeight = 15;
            listGroceries.Items.AddRange(new object[] { "milk", "bread", "eggs" });
            listGroceries.Location = new Point(462, 211);
            listGroceries.Name = "listGroceries";
            listGroceries.Size = new Size(120, 94);
            listGroceries.TabIndex = 1;
            listGroceries.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tbFood
            // 
            tbFood.Location = new Point(199, 221);
            tbFood.Name = "tbFood";
            tbFood.Size = new Size(100, 23);
            tbFood.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 198);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter food item:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tbFood);
            Controls.Add(listGroceries);
            Controls.Add(btnSubmit);
            ForeColor = Color.CornflowerBlue;
            Name = "Form1";
            Text = "ClickMe!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private ListBox listGroceries;
        private TextBox tbFood;
        private Label label1;
    }
}
