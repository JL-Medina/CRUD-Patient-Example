namespace PatientCRUD.Views
{
    partial class AddAddressForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PatientID = new System.Windows.Forms.Label();
            this.AddAddressButtonForm = new System.Windows.Forms.Button();
            this.AddStreetNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddFloorTextBox = new System.Windows.Forms.TextBox();
            this.AddApartTextBox = new System.Windows.Forms.TextBox();
            this.AddStreeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PatientID);
            this.groupBox1.Controls.Add(this.AddAddressButtonForm);
            this.groupBox1.Controls.Add(this.AddStreetNumberTextBox);
            this.groupBox1.Controls.Add(this.AddFloorTextBox);
            this.groupBox1.Controls.Add(this.AddApartTextBox);
            this.groupBox1.Controls.Add(this.AddStreeTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Domicilio";
            // 
            // PatientID
            // 
            this.PatientID.AutoSize = true;
            this.PatientID.Location = new System.Drawing.Point(311, 19);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(0, 15);
            this.PatientID.TabIndex = 9;
            this.PatientID.Visible = false;
            // 
            // AddAddressButtonForm
            // 
            this.AddAddressButtonForm.Location = new System.Drawing.Point(138, 212);
            this.AddAddressButtonForm.Name = "AddAddressButtonForm";
            this.AddAddressButtonForm.Size = new System.Drawing.Size(75, 23);
            this.AddAddressButtonForm.TabIndex = 8;
            this.AddAddressButtonForm.Text = "Guardar";
            this.AddAddressButtonForm.UseVisualStyleBackColor = true;
            this.AddAddressButtonForm.Click += new System.EventHandler(this.AddAddressButtonForm_Click);
            // 
            // AddStreetNumberTextBox
            // 
            this.AddStreetNumberTextBox.Location = new System.Drawing.Point(72, 77);
            this.AddStreetNumberTextBox.Name = "AddStreetNumberTextBox";
            this.AddStreetNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.AddStreetNumberTextBox.TabIndex = 7;
            // 
            // AddFloorTextBox
            // 
            this.AddFloorTextBox.Location = new System.Drawing.Point(64, 113);
            this.AddFloorTextBox.Name = "AddFloorTextBox";
            this.AddFloorTextBox.Size = new System.Drawing.Size(100, 23);
            this.AddFloorTextBox.TabIndex = 6;
            // 
            // AddApartTextBox
            // 
            this.AddApartTextBox.Location = new System.Drawing.Point(104, 151);
            this.AddApartTextBox.Name = "AddApartTextBox";
            this.AddApartTextBox.Size = new System.Drawing.Size(100, 23);
            this.AddApartTextBox.TabIndex = 5;
            // 
            // AddStreeTextBox
            // 
            this.AddStreeTextBox.Location = new System.Drawing.Point(64, 44);
            this.AddStreeTextBox.Name = "AddStreeTextBox";
            this.AddStreeTextBox.Size = new System.Drawing.Size(209, 23);
            this.AddStreeTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Piso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calle:";
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 272);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Domicilio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button AddAddressButtonForm;
        public TextBox AddStreetNumberTextBox;
        public TextBox AddFloorTextBox;
        public TextBox AddApartTextBox;
        public TextBox AddStreeTextBox;
        public Label PatientID;
    }
}