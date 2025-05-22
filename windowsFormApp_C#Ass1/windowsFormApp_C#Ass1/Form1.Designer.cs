namespace windowsFormApp_C_Ass1
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
            TextBox = new TextBox();
            label1 = new Label();
            ComoBox = new ComboBox();
            ListBox = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkGray;
            btnSubmit.Location = new Point(713, 108);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Add";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // TextBox
            // 
            TextBox.BackColor = Color.Yellow;
            TextBox.Location = new Point(542, 108);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(165, 23);
            TextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(545, 90);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 2;
            label1.Text = "Add a New Quality Attribute";
            // 
            // ComoBox
            // 
            ComoBox.BackColor = SystemColors.ControlDark;
            ComoBox.FormattingEnabled = true;
            ComoBox.Items.AddRange(new object[] { "Availaibility", "Deployability", "Energy Effiency", "Modifiability", "Performance" });
            ComoBox.Location = new Point(71, 60);
            ComoBox.Name = "ComoBox";
            ComoBox.Size = new Size(121, 23);
            ComoBox.TabIndex = 3;
            ComoBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ListBox
            // 
            ListBox.BackColor = SystemColors.ActiveBorder;
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 15;
            ListBox.Location = new Point(72, 173);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(234, 169);
            ListBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 155);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 5;
            label2.Text = "Non-functional Requirements";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(ListBox);
            Controls.Add(ComoBox);
            Controls.Add(label1);
            Controls.Add(TextBox);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox TextBox;
        private Label label1;
        private ComboBox ComoBox;
        private ListBox ListBox;
        private Label label2;
    }
}
