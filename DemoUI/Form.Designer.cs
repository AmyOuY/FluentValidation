namespace DemoUI
{
    partial class Form
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
            this.createUserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.createButton = new System.Windows.Forms.Button();
            this.errorList = new System.Windows.Forms.ListBox();
            this.errorListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createUserLabel
            // 
            this.createUserLabel.AutoSize = true;
            this.createUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.createUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLabel.Location = new System.Drawing.Point(139, 22);
            this.createUserLabel.Name = "createUserLabel";
            this.createUserLabel.Size = new System.Drawing.Size(142, 29);
            this.createUserLabel.TabIndex = 0;
            this.createUserLabel.Text = "Create User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(144, 91);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(200, 22);
            this.firstNameValue.TabIndex = 2;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(143, 141);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(200, 22);
            this.lastNameValue.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(34, 141);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(91, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(34, 194);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(105, 20);
            this.dobLabel.TabIndex = 5;
            this.dobLabel.Text = "Date of Birth";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(143, 194);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 22);
            this.dateOfBirthPicker.TabIndex = 6;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(143, 262);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(83, 35);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // errorList
            // 
            this.errorList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorList.FormattingEnabled = true;
            this.errorList.ItemHeight = 16;
            this.errorList.Location = new System.Drawing.Point(395, 91);
            this.errorList.Name = "errorList";
            this.errorList.Size = new System.Drawing.Size(347, 228);
            this.errorList.TabIndex = 8;
            // 
            // errorListLabel
            // 
            this.errorListLabel.AutoSize = true;
            this.errorListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorListLabel.Location = new System.Drawing.Point(391, 68);
            this.errorListLabel.Name = "errorListLabel";
            this.errorListLabel.Size = new System.Drawing.Size(80, 20);
            this.errorListLabel.TabIndex = 9;
            this.errorListLabel.Text = "Error List";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorListLabel);
            this.Controls.Add(this.errorList);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUserLabel);
            this.Name = "Form";
            this.Text = "Fluent Validation DemoUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createUserLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ListBox errorList;
        private System.Windows.Forms.Label errorListLabel;
    }
}

