﻿using domain.entities;
using System.Text.Json;

namespace LabsManager
{
    public partial class LabsManager : Form
    {

        private int ruleLevel;
        private PersonsBase _person;
        private bool isMine = false;
        private List<Lab> labs = new List<Lab>();
        private List<PassLabModel> labsPassModels = new List<PassLabModel>();
        private bool isPassModelsInList = false;
        private int _pageNumber = 1;

        // 1 - all labs
        // 2 - labs to check
        // 3 - labs with mark

        // 0 - unauthorized
        // 1 - student
        // 2 - teacher
        // 3 - admin

        public LabsManager()
        {
            InitializeComponent();
            _person = new Teacher
            {
                id = 1,
                name = "Иванов Иван Иванович",
                login = "ivanov",
                password = "123",
                cafedra = "лфывоалф"
            };
            ruleLevel = 2;

            panelIndicator.Location = new Point(0, 20);


        }

        private void LabsManager_Load(object sender, EventArgs e)
        {

            var Login = new LoginForm();
            var result = Login.Login(ref ruleLevel, ref _person);
            if (result == 0) { this.Close(); }

            GetLabs();
            GetPassModels();

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

        private void panelButton3_MouseEnter(object sender, EventArgs e)
        {
            panelButton3.BackColor = Color.FromArgb(10, 10, 250);

        }
        private void panelButton4_MouseEnter(object sender, EventArgs e)
        {
            panelButton4.BackColor = Color.FromArgb(10, 10, 250);
        }

        private void panelButton3_MouseLeave(object sender, EventArgs e)
        {
            panelButton3.BackColor = Color.Transparent;
        }

        private void panelButton2_MouseLeave(object sender, EventArgs e)
        {

            panelButton2.BackColor = Color.Transparent;
        }
        private void panelButton4_MouseLeave(object sender, EventArgs e)
        {

            panelButton4.BackColor = Color.Transparent;
        }

        private void profilePanel_VisibleChanged(object sender, EventArgs e)
        {

            Profilelabel3.Visible = false;
            ProfilelabelFaculty.Visible = false;

            if (profilePanel.Visible == true)
            {
                ProfileLabelName.Text = _person.name;
                ProfilelabelLogin.Text = _person.login;

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
            _pageNumber = 1;
            isMine = false;
            profilePanel.Visible = false;

            isPassModelsInList = false;

            SubjectsList.Visible = false;
            SubjectsList.Visible = true;


            panelIndicator.Location = new Point(0, 27+67);
        }

        private void panelButton1_Click(object sender, EventArgs e)
        {
            _pageNumber = 0;
            profilePanel.Visible = true;
            SubjectsList.Visible = false;
            panelIndicator.Location = new Point(0, 27);
        }

        private void panelButton3_Click(object sender, EventArgs e)
        {
            _pageNumber = 2;
            isMine = true;
            profilePanel.Visible = false;
            // need to redraw component
            isPassModelsInList = true;

            SubjectsList.Visible = false;
            SubjectsList.Visible = true;

            panelIndicator.Location = new Point(0, 27+67*2);
        }
        private void panelButton4_Click(object sender, EventArgs e)
        {
            _pageNumber = 3;
            isMine = true;
            isPassModelsInList = true;
            profilePanel.Visible = false;
            // need Component


            SubjectsList.Visible = false;
            SubjectsList.Visible = true;

            panelIndicator.Location = new Point(0, 27+67*3);
        }





        private void Createbutton1_Click(object sender, EventArgs e)
        {
            var createLabFrom = new CreateLabForm(_person.id);
            createLabFrom.ShowDialog();
            GetLabs();
            FillLabs(labs);
        }


        private void SubjectsList_VisibleChanged(object sender, EventArgs e)
        {
            if (SubjectsList.Visible)
            {
                if (!isPassModelsInList)
                {
                    FillLabs(labs);

                    if (ruleLevel >= 2 && !isMine && _pageNumber == 1)
                    {
                        Createbutton1.Visible = true;
                        Statisticbutton1.Visible = true;
                    }
                    else
                    {
                        Createbutton1.Visible = false;
                        Statisticbutton1.Visible = false;
                    }
                }
                else
                {
                    Createbutton1.Visible = false;
                    Statisticbutton1.Visible = false;
                    FillLabsPassModels();
                }
            }

        }

        private List<PassLabModel> filterLabsThatPassed(List<PassLabModel> labs, int rule)
        // 1 - checked 
        // 2 - not checked
        {
            var res = new List<PassLabModel>();
            foreach (var l in labs)
            {
                if (rule == 1)
                {
                    if (
                        l.StudentId == _person.id && l.isPassed ||
                        ruleLevel >= 2 && l.isPassed
                    )
                    {
                        res.Add(l);
                    }
                }
                else if (rule == 2)
                {
                    if (
                        l.StudentId == _person.id && !l.isPassed
                        || ruleLevel >= 2 && !l.isPassed
                    )
                    {
                        res.Add(l);
                    }
                }
            }
            return res;
        }

        private void FillLabsPassModels()
        {
            GetLabs();
            GetPassModels();
            var labsPassModeles = labsPassModels;
            flowLayoutPanelListSubjects.Controls.Clear();

            if (_pageNumber == 3)
            {
                labsPassModeles = filterLabsThatPassed(labsPassModels, 1);
            }

            if (_pageNumber == 2)
            {
                labsPassModeles = filterLabsThatPassed(labsPassModels, 2);
            }


            if (labsPassModeles.Any())
            {
                foreach (PassLabModel lab in labsPassModeles)
                {
                    var panel = new Panel();
                    panel.Size = new Size(1200, 100);
                    panel.Location = new Point(20, 20);
                    panel.BackColor = Color.White;
                    panel.Cursor = Cursors.Hand;
                    panel.BorderStyle = BorderStyle.None;

                    var label = new Label();
                    label.Text = lab.lab?.name;
                    label.Location = new Point(10, 10);
                    label.AutoSize = true;
                    label.Font = new Font("Arial", 24, FontStyle.Bold);
                    panel.Controls.Add(label);

                    var label1 = new Label();
                    label1.Text = "Студент: " + lab.student?.name;
                    label1.Location = new Point(10, 50);
                    label1.AutoSize = true;
                    label1.Font = new Font("Arial", 16, FontStyle.Bold);
                    panel.Controls.Add(label1);


                    System.EventHandler function = (sender, e) =>
                    {
                        var labForm = new PassLabShowForm(_person.id, ruleLevel == 2, lab);
                        labForm.ShowDialog();
                        GetPassModels();
                        FillLabsPassModels();
                    };

                    panel.Click += function;

                    label.Click += function;

                    label1.Click += function;

                    flowLayoutPanelListSubjects.Controls.Add(panel);
                }
            }
            else
            {
                var panel = new Panel();
                panel.Size = new Size(1200, 30);
                panel.Location = new Point(20, 20);
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.None;
                flowLayoutPanelListSubjects.Controls.Add(panel);

                var labelNotFound = new Label();
                labelNotFound.Dock = DockStyle.Fill;
                labelNotFound.TextAlign = ContentAlignment.MiddleCenter;
                labelNotFound.Text = "Никто еще не сдал отчеты";
                panel.Controls.Add(labelNotFound);
            }
        }


        private void FillLabs(List<Lab> _labs)
        {
            flowLayoutPanelListSubjects.Controls.Clear();

            if (labs.Count > 0)
            {
                foreach (Lab lab in labs)
                {
                    var panel = new Panel();
                    panel.Size = new Size(1200, 100);
                    panel.Location = new Point(20, 20);
                    panel.BackColor = Color.White;
                    panel.Cursor = Cursors.Hand;
                    panel.BorderStyle = BorderStyle.None;

                    var label = new Label();
                    label.Text = lab.name;
                    label.Location = new Point(10, 10);
                    label.AutoSize = true;
                    label.Font = new Font("Arial", 24, FontStyle.Bold);
                    panel.Controls.Add(label);

                    var label1 = new Label();
                    label1.Text = "Срок: " + lab.lastTimeToPass.ToString("d");
                    label1.Location = new Point(10, 50);
                    label1.AutoSize = true;
                    label1.Font = new Font("Arial", 16, FontStyle.Bold);
                    panel.Controls.Add(label1);


                    System.EventHandler function = (sender, e) =>
                    {
                        var labForm = new LabForm(_person.id, lab, ruleLevel == 3);
                        labForm.ShowDialog();
                        GetLabs();
                        FillLabs(labs);
                    };
                    panel.Click += function;

                    label.Click += function;

                    label1.Click += function;

                    flowLayoutPanelListSubjects.Controls.Add(panel);
                }
            }
            else
            {
                var panel = new Panel();
                panel.Size = new Size(1200, 30);
                panel.Location = new Point(20, 20);
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.None;
                flowLayoutPanelListSubjects.Controls.Add(panel);

                var labelNotFound = new Label();
                labelNotFound.Dock = DockStyle.Fill;
                labelNotFound.TextAlign = ContentAlignment.MiddleCenter;
                labelNotFound.Text = "Лабораторные не найдены";
                panel.Controls.Add(labelNotFound);
            }
        }



        private void GetLabs()
        {
            // get all labs by get method
            var url = $"{ENV.BASEURL}/api/labs";
            var client = new HttpClient();
            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                labs = JsonSerializer.Deserialize<List<Lab>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            else
            {
                return;
            }
        }

        private void GetPassModels()
        {
            var url = $"{ENV.BASEURL}/api/pass";
            var client = new HttpClient();
            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                labsPassModels = JsonSerializer.Deserialize<List<PassLabModel>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            else
            {
                return;
            }
        }

        private async void Statisticbutton1_Click(object sender, EventArgs e)
        {
            string url = $"{ENV.BASEURL}/api/labs/stats";
            try
            {
                var response =await GetApiResponseAsync(url);

                SaveResponseToFile(response, $"{ENV.DATAFOLDER}/stats.txt");

                MessageBox.Show("Данные успешно сохранены в файл!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private async Task<ApiResponse> GetApiResponseAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<ApiResponse>(responseBody);
            }
        }

        private void SaveResponseToFile(ApiResponse response, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Количество лабораторных работ: " + response.labCounts);
                writer.WriteLine("Количество попыток: " + response.tryPassCount);
                writer.WriteLine("Не проверено: " + response.notChecked);
                writer.WriteLine("Не сдано: " + response.notPassed);
                writer.WriteLine("Сдано: " + response.passed);
                writer.WriteLine("Средний балл сдавших: " + response.averagePassed);
                writer.WriteLine("Средний балл со всеми: " + response.averageWithNotPassed);
                writer.WriteLine("Процент сдавших: " + response.percentOfPassed + "%");
                writer.WriteLine("Среднее количество лабораторных на одного студента: " + response.averageLabsInOneStudent);
            }
        }
    
    }

    public class ApiResponse
    {
        public int labCounts { get; set; }
        public int tryPassCount { get; set; }
        public int notChecked { get; set; }
        public int notPassed { get; set; }
        public int passed { get; set; }
        public double averagePassed { get; set; }
        public double averageWithNotPassed { get; set; }
        public int percentOfPassed { get; set; }
        public double averageLabsInOneStudent { get; set; }
    }
}
