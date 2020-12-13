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

namespace Fluent_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = new Student();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            studentBindingSource.EndEdit();
            Student student = studentBindingSource.Current as Student;
            if (student != null)
            {
                StudentValidator validations = new StudentValidator();
                ValidationResult result = validations.Validate(student);
                IList<ValidationFailure> failures = result.Errors;

                if (!result.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // save to database
            }
        }
    }
}
