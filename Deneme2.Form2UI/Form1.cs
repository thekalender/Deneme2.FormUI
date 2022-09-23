using Deneme2.Business;
using Deneme2.DataAccess;
using Deneme2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme2.Form2UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentManager studentManager = new StudentManager(new EfStudentDal());

        private void Form1_Load(object sender, EventArgs e)
        {
            dgrwStudent.DataSource = studentManager.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = Convert.ToInt32(tbxId.Text);
            student.FirstName = tbxFirstName.Text;
            student.LastName=tbxLastName.Text;
            
            studentManager.GetAll().Add(student);

            dgrwStudent.DataSource = null;
            dgrwStudent.DataSource = studentManager.GetAll();

        }
    }
}
