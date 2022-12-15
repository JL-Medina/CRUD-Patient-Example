namespace PatientCRUD.Views
{
    partial class formPatientDetail
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
            this.genderComboBoxUpdate = new System.Windows.Forms.ComboBox();
            this.apartmentTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.floorTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.streetNumberTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.streetTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerUpdate = new System.Windows.Forms.DateTimePicker();
            this.LastNameTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.FirstNameTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.updateButton1 = new System.Windows.Forms.Button();
            this.AddressId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddressId);
            this.groupBox1.Controls.Add(this.genderComboBoxUpdate);
            this.groupBox1.Controls.Add(this.apartmentTextBoxUpdate);
            this.groupBox1.Controls.Add(this.floorTextBoxUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.streetNumberTextBoxUpdate);
            this.groupBox1.Controls.Add(this.streetTextBoxUpdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerUpdate);
            this.groupBox1.Controls.Add(this.LastNameTextBoxUpdate);
            this.groupBox1.Controls.Add(this.FirstNameTextBoxUpdate);
            this.groupBox1.Controls.Add(this.GenderLabel);
            this.groupBox1.Controls.Add(this.BirthDateLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.patientIdLabel);
            this.groupBox1.Controls.Add(this.updateButton1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 459);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del paciente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // genderComboBoxUpdate
            // 
            this.genderComboBoxUpdate.FormattingEnabled = true;
            this.genderComboBoxUpdate.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.genderComboBoxUpdate.Location = new System.Drawing.Point(169, 106);
            this.genderComboBoxUpdate.Name = "genderComboBoxUpdate";
            this.genderComboBoxUpdate.Size = new System.Drawing.Size(150, 23);
            this.genderComboBoxUpdate.TabIndex = 43;
            // 
            // apartmentTextBoxUpdate
            // 
            this.apartmentTextBoxUpdate.Location = new System.Drawing.Point(169, 333);
            this.apartmentTextBoxUpdate.Name = "apartmentTextBoxUpdate";
            this.apartmentTextBoxUpdate.Size = new System.Drawing.Size(317, 23);
            this.apartmentTextBoxUpdate.TabIndex = 42;
            // 
            // floorTextBoxUpdate
            // 
            this.floorTextBoxUpdate.AcceptsReturn = true;
            this.floorTextBoxUpdate.AcceptsTab = true;
            this.floorTextBoxUpdate.AllowDrop = true;
            this.floorTextBoxUpdate.Location = new System.Drawing.Point(169, 298);
            this.floorTextBoxUpdate.Name = "floorTextBoxUpdate";
            this.floorTextBoxUpdate.Size = new System.Drawing.Size(317, 23);
            this.floorTextBoxUpdate.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Dpto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Piso";
            // 
            // streetNumberTextBoxUpdate
            // 
            this.streetNumberTextBoxUpdate.Location = new System.Drawing.Point(169, 260);
            this.streetNumberTextBoxUpdate.Name = "streetNumberTextBoxUpdate";
            this.streetNumberTextBoxUpdate.Size = new System.Drawing.Size(317, 23);
            this.streetNumberTextBoxUpdate.TabIndex = 38;
            // 
            // streetTextBoxUpdate
            // 
            this.streetTextBoxUpdate.Location = new System.Drawing.Point(169, 225);
            this.streetTextBoxUpdate.Name = "streetTextBoxUpdate";
            this.streetTextBoxUpdate.Size = new System.Drawing.Size(317, 23);
            this.streetTextBoxUpdate.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Calle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Domicilio";
            // 
            // dateTimePickerUpdate
            // 
            this.dateTimePickerUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUpdate.Location = new System.Drawing.Point(169, 148);
            this.dateTimePickerUpdate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerUpdate.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerUpdate.Name = "dateTimePickerUpdate";
            this.dateTimePickerUpdate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerUpdate.TabIndex = 33;
            this.dateTimePickerUpdate.Value = new System.DateTime(2022, 12, 14, 0, 0, 0, 0);
            // 
            // LastNameTextBoxUpdate
            // 
            this.LastNameTextBoxUpdate.Location = new System.Drawing.Point(169, 70);
            this.LastNameTextBoxUpdate.Name = "LastNameTextBoxUpdate";
            this.LastNameTextBoxUpdate.Size = new System.Drawing.Size(317, 23);
            this.LastNameTextBoxUpdate.TabIndex = 32;
            // 
            // FirstNameTextBoxUpdate
            // 
            this.FirstNameTextBoxUpdate.Location = new System.Drawing.Point(169, 35);
            this.FirstNameTextBoxUpdate.Name = "FirstNameTextBoxUpdate";
            this.FirstNameTextBoxUpdate.Size = new System.Drawing.Size(317, 23);
            this.FirstNameTextBoxUpdate.TabIndex = 31;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(73, 109);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(32, 15);
            this.GenderLabel.TabIndex = 30;
            this.GenderLabel.Text = "Sexo";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(36, 151);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(117, 15);
            this.BirthDateLabel.TabIndex = 29;
            this.BirthDateLabel.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nro de Paciente:";
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Location = new System.Drawing.Point(401, 9);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(91, 15);
            this.patientIdLabel.TabIndex = 18;
            this.patientIdLabel.Text = "Nro de paciente";
            // 
            // updateButton1
            // 
            this.updateButton1.Location = new System.Drawing.Point(370, 385);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(116, 23);
            this.updateButton1.TabIndex = 17;
            this.updateButton1.Text = "Guardar Cambios";
            this.updateButton1.UseVisualStyleBackColor = true;
            this.updateButton1.Click += new System.EventHandler(this.updateButton1_Click);
            // 
            // AddressId
            // 
            this.AddressId.AutoSize = true;
            this.AddressId.Location = new System.Drawing.Point(169, 194);
            this.AddressId.Name = "AddressId";
            this.AddressId.Size = new System.Drawing.Size(59, 15);
            this.AddressId.TabIndex = 44;
            this.AddressId.Text = "AddressId";
            // 
            // formPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 461);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPatientDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del paciente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button updateButton1;
        public Label patientIdLabel;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label GenderLabel;
        private Label BirthDateLabel;
        private Label label7;
        private Label label8;
        public ComboBox genderComboBoxUpdate;
        public TextBox apartmentTextBoxUpdate;
        public TextBox floorTextBoxUpdate;
        public TextBox streetNumberTextBoxUpdate;
        public TextBox streetTextBoxUpdate;
        public DateTimePicker dateTimePickerUpdate;
        public TextBox LastNameTextBoxUpdate;
        public TextBox FirstNameTextBoxUpdate;
        public Label AddressId;
    }
}