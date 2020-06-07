using DemoUILibrary;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        BindingList<string> errors = new BindingList<string>();
        public Form()
        {
            InitializeComponent();

            errorList.DataSource = errors;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            errors.Clear();

            PersonModel person = new PersonModel();
            person.FirstName = firstNameValue.Text;
            person.LastName = lastNameValue.Text;
            person.DateOfBirth = dateOfBirthPicker.Value;

            PersonValidator validator = new PersonValidator();
            ValidationResult results = validator.Validate(person);

            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    errors.Add(failure.ErrorMessage);
                }
            }

            MessageBox.Show("Complete Operation");
        }
    }
}
