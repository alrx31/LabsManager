using domain.entities;
using LabsManager.domain.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LabsManager
{
    public partial class LabsManager : Form
    {
        private PersonsBase _person;
        private int ruleLevel;
        private readonly ISubjectsService _subjectsServ;
        private Subject SelectedSubject;

        private List<Subject> subjects = new List<Subject>();
        // 0 - unauthorized
        // 1 - student
        // 2 - teacher
        // 3 - admin

        public LabsManager()
        {
            InitializeComponent();
            _person = new Student
            {
                id = 1,
                name = "Иванов Иван Иванович",
                login = "ivanov",
                password = "123",
                faculty = "ФИТ",
                group= 12
            };
            ruleLevel = 1;

            _subjectsServ = new SubjectsService();
            panelIndicator.Location = new Point(0, 20);
        }

        private void LabsManager_Load(object sender, EventArgs e)
        {
            /*var Login = new LoginForm();
            var result = Login.Login(ref ruleLevel, ref _person);
            if (result == 0) { this.Close(); }*/

            GetSubjects();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }




        private bool isMousePress = false;
        private Point _clickPoint;
        private Point _formStartPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePress = true;
            _clickPoint = Cursor.Position;
            _formStartPoint = Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePress)
            {
                var cursorOffsetPoint = new Point( //считаем смещение курсора от старта
                    Cursor.Position.X - _clickPoint.X,
                    Cursor.Position.Y - _clickPoint.Y);

                Location = new Point( //смещаем форму от начальной позиции в соответствии со смещением курсора
                    _formStartPoint.X + cursorOffsetPoint.X,
                    _formStartPoint.Y + cursorOffsetPoint.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePress = false;
            _clickPoint = Point.Empty;
        }

        private void panelButton1_MouseHover(object sender, EventArgs e)
        {
            panelButton1.BackColor = Color.FromArgb(10, 10, 250);
        }

        private void panelButton1_MouseLeave(object sender, EventArgs e)
        {
            panelButton1.BackColor = Color.Transparent;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panelButton2.BackColor = Color.FromArgb(10, 10, 250);

        }

        private void panelButton2_MouseLeave(object sender, EventArgs e)
        {

            panelButton2.BackColor = Color.Transparent;
        }

        private void profilePanel_VisibleChanged(object sender, EventArgs e)
        {


            if (profilePanel.Visible == true)
            {
                ProfileLabelName.Text = _person.name;
                ProfilelabelLogin.Text = _person.login;
                ProfilelabelFaculty.Text = _person.faculty;

                if (ruleLevel == 1)
                {
                    ProfilelabelGroup.Text = "" + ((Student)_person).group;
                }
                if (ruleLevel >= 2)
                {
                    if (ruleLevel == 3)
                    {
                        ProfilelabelAdmin.Visible = true;
                    }
                    Profilelabel4.Text = "Кафедра";
                    ProfilelabelGroup.Text = ((Teacher)_person).cafedra;
                }

            }
        }

        private void panelButton2_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = false;
            SubjectsList.Visible = true;
            panelIndicator.Location = new Point(0, 70);
        }

        private void panelButton1_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = true;
            SubjectsList.Visible = false;
            panelIndicator.Location = new Point(0, 20);
        }


        private async Task GetSubjects()
        {
            this.subjects = await _subjectsServ.getAllSubjects();
            FillSubjectsList(this.subjects);
        }

        private void Createbutton1_Click(object sender, EventArgs e)
        {
            var CreateForm = new CreateSubjectForm();
            CreateForm.ShowDialog();

        }

        private void OpenTheSubjectMenu(object sender, EventArgs e)
        {

            var sender1 = sender.ToString().Split("Text: ")[1][0].ToString();


            var SubjectMenuForm = new SubjectMenuForm(subjects.ElementAt(int.Parse(sender1)-1), _person,ruleLevel);


            SubjectMenuForm.ShowDialog();

        }

        private void SubjectsList_VisibleChanged(object sender, EventArgs e)
        {
            if (SubjectsList.Visible)
            {
                if (ruleLevel >= 2)
                {
                    Createbutton1.Visible = true;
                }
                else
                {
                    Createbutton1.Visible = false;
                }
            }
        }



        private void FillSubjectsList(List<Subject> subjects)
        {
            flowLayoutPanelListSubjects.Controls.Clear();
            if (subjects.Count > 0)
            {
                foreach (Subject subject in subjects)
                {
                    var panel = new Panel();
                    panel.Size = new Size(500, 150);
                    panel.Location = new Point(20, 20);
                    panel.BackColor = Color.White;
                    panel.Cursor = Cursors.Hand;
                    panel.BorderStyle = BorderStyle.None;
                    panel.Click += OpenTheSubjectMenu;
                    flowLayoutPanelListSubjects.Controls.Add(panel);

                    var labelName = new Label();
                    labelName.Dock = DockStyle.Fill;
                    labelName.Text = subject.id + "" + ". Название: " + subject.name + "\nКоличество Лабораторных: " + (subject.labs != null ? subject.labs.Count + "" : 0 + "") + "\nОписание: " + subject.description + "\nНужно часов: " + subject.needHours + "\nАвтор: " + subject.author.name;
                    labelName.Cursor = Cursors.Hand;
                    labelName.Click += OpenTheSubjectMenu;
                    panel.Controls.Add(labelName);
                }
            }
            else
            {
                var panel = new Panel();
                panel.Size = new Size(500, 30);
                panel.Location = new Point(20, 20);
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.None;
                panel.Click += OpenTheSubjectMenu;
                flowLayoutPanelListSubjects.Controls.Add(panel);

                var labelNotFound = new Label();
                labelNotFound.Dock = DockStyle.Fill;
                labelNotFound.TextAlign = ContentAlignment.MiddleCenter;
                labelNotFound.Text = "Предметы не найдены";
                panel.Controls.Add(labelNotFound);
            }
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string value = textBoxSearch.Text.Trim().ToLower();
            var tempCollection  = new List<Subject>();
            foreach (Subject s in this.subjects) {
                if (s.name.ToLower().Contains(value))
                {
                    tempCollection.Add(s);
                }    
            }
            FillSubjectsList(tempCollection);
        }
    }

}
