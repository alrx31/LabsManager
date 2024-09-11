using domain.entities;
using domain.services;

namespace LabsManager
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authServic;
        private PersonsBase _person;
        private int ruleLevel;

        public LoginForm()
        {
            InitializeComponent();
            _authServic = new AuthService();
        }

        public int Login(ref int RuleLevel, ref PersonsBase person)
        {
            this.ShowDialog();
            if(_person != null && ruleLevel != 0)
            {
                person = _person;
                RuleLevel = ruleLevel;
                return 1;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loadlabel.Visible = true;
            PersonsBase? loginResult = _authServic.Login(login: logintextBox1.Text, password: logintextBox2.Text);
            var res = checkAuth(loginResult);
            Loadlabel.Visible = false;
            if (res == 0)
            {
                MessageBox.Show("Invalid login or password");
                return;
            }
            
            _person = loginResult;
            



            this.Close();

        }

        private void DisaibleLoginForm()
        {
            logintextBox1.Visible = false;
            logintextBox2.Visible = false;
            loginbutton1.Visible = false;
            loginlabel1.Visible = false;
            loginlabel2.Visible = false;
            loginlinkLabel1.Visible = false;
        }
        private void EnableLoginForm()
        {
            logintextBox1.Visible = true;
            logintextBox2.Visible = true;
            loginbutton1.Visible = true;
            loginlabel1.Visible = true;
            loginlabel2.Visible = true;
            loginlinkLabel1.Visible = true;
        }


        

        private int checkAuth(PersonsBase person)
        {
            if (person is Student)
            {
                this.ruleLevel = 1;
                return 1;


            }
            if (person is Teacher)
            {
                if (((Teacher)person).isAdmin)
                {
                    this.ruleLevel = 3;
                    return 1;
                }
                this.ruleLevel = 2;
                return 1;
            }
            return 0;
        }

        private void loginlinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
