namespace Car_Inventory
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
            txtresult = new TextBox();
            txtbrand = new TextBox();
            lblbrand = new Label();
            txtcolour = new TextBox();
            txtmodel = new TextBox();
            label2 = new Label();
            lblmodel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtresult
            // 
            txtresult.BackColor = SystemColors.ControlDarkDark;
            txtresult.ForeColor = SystemColors.Info;
            txtresult.Location = new Point(262, 44);
            txtresult.Multiline = true;
            txtresult.Name = "txtresult";
            txtresult.ReadOnly = true;
            txtresult.Size = new Size(350, 401);
            txtresult.TabIndex = 0;
            // 
            // txtbrand
            // 
            txtbrand.Location = new Point(42, 103);
            txtbrand.Name = "txtbrand";
            txtbrand.Size = new Size(170, 23);
            txtbrand.TabIndex = 1;
            // 
            // lblbrand
            // 
            lblbrand.AutoSize = true;
            lblbrand.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbrand.Location = new Point(42, 74);
            lblbrand.Name = "lblbrand";
            lblbrand.Size = new Size(75, 26);
            lblbrand.TabIndex = 2;
            lblbrand.Text = "Brand";
            // 
            // txtcolour
            // 
            txtcolour.Location = new Point(42, 160);
            txtcolour.Name = "txtcolour";
            txtcolour.Size = new Size(170, 23);
            txtcolour.TabIndex = 3;
            // 
            // txtmodel
            // 
            txtmodel.Location = new Point(42, 220);
            txtmodel.Name = "txtmodel";
            txtmodel.Size = new Size(170, 23);
            txtmodel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 131);
            label2.Name = "label2";
            label2.Size = new Size(82, 26);
            label2.TabIndex = 6;
            label2.Text = "Colour";
            // 
            // lblmodel
            // 
            lblmodel.AutoSize = true;
            lblmodel.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmodel.Location = new Point(42, 191);
            lblmodel.Name = "lblmodel";
            lblmodel.Size = new Size(77, 26);
            lblmodel.TabIndex = 7;
            lblmodel.Text = "Model";
            // 
            // button1
            // 
            button1.Font = new Font("AWAKENNING Personal Use", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(64, 280);
            button1.Name = "button1";
            button1.Size = new Size(117, 45);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 499);
            Controls.Add(button1);
            Controls.Add(lblmodel);
            Controls.Add(label2);
            Controls.Add(txtmodel);
            Controls.Add(txtcolour);
            Controls.Add(lblbrand);
            Controls.Add(txtbrand);
            Controls.Add(txtresult);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Car Inventory";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtresult;
        private TextBox txtbrand;
        private Label lblbrand;
        private TextBox txtcolour;
        private TextBox txtmodel;
        private Label label2;
        private Label lblmodel;
        private Button button1;
    }
}
