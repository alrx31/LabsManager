using domain.entities;
using domain.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabsManager
{
    public partial class RegisterForm : Form
    {
        private readonly IAuthService _authService;


        public RegisterForm()
        {
            _authService = new AuthService();
            InitializeComponent();
        }

        private void DisaibleStudentInput()
        {
            registerlabel5.Visible = false;
            registertextBox4.Visible = false;
        }
        private void EnableStudentInput()
        {
            registerlabel5.Visible = true;
            registertextBox4.Visible = true;
        }
        private void DisableTeacherInput()
        {
            registerlabel6.Visible = false;
            registertextBox5.Visible = false;
        }

        private void EnableTeacherInput()
        {
            registerlabel6.Visible = true;
            registertextBox5.Visible = true;
        }

        private void registercheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (registercheckBox2.Checked)
            {
                DisaibleStudentInput();
                EnableTeacherInput();
            }
            else
            {
                EnableStudentInput();
                DisableTeacherInput();
            }
        }

        private void registerbutton1_Click(object sender, EventArgs e)
        {
            if (registertextBox1.Text == "" || registertextBox2.Text == "" || registertextBox3.Text == "")
            {
                MessageBox.Show("Fill all fields");
                return;
            }
            if (registercheckBox2.Checked)
            {
                if (registertextBox5.Text == "")
                {
                    MessageBox.Show("Fill all fields");
                    return;
                }
            }
            else
            {
                if (registertextBox4.Text == "")
                {
                    MessageBox.Show("Fill all fields");
                    return;
                }
                // should be a number
                if (!int.TryParse(registertextBox4.Text, out int _))
                {
                    MessageBox.Show("Age should be a number");
                    return;
                }
                Student student = new Student
                {
                    login = registertextBox1.Text,
                    password = registertextBox2.Text,
                    name = registertextBox3.Text,
                    faculty = registercomboBox1.Text,
                    group = int.Parse(registertextBox4.Text),
                };

                int result = _authService.RegisterStudent(student);
                if (result == 0)
                {
                    MessageBox.Show("Somethink error");
                    return;
                }
                else
                {
                    MessageBox.Show("Success");
                    this.Close();
                }


            }
        }

        private void registerbutton1_Click_1(object sender, EventArgs e)
        {
            Loadlabel1.Visible = true;
            int result = 0;
            if (registercheckBox2.Checked)
            {
                result = _authService.RegisterTeacher(new Teacher
                {
                    login = registertextBox1.Text,
                    password = registertextBox2.Text,
                    name = registertextBox3.Text,
                    faculty = registercomboBox1.Text,
                    cafedra = registertextBox5.Text,
                });
            }
            else
            {
                result = _authService.RegisterStudent(new Student
                {
                    login = registertextBox1.Text,
                    password = registertextBox2.Text,
                    name = registertextBox3.Text,
                    faculty = registercomboBox1.Text,
                    group = int.Parse(registertextBox4.Text),
                });
            }
            Loadlabel1.Visible = false;
            if(result == 1)
            {
                MessageBox.Show("Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
