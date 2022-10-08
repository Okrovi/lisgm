namespace LISGM
{
    public partial class AuthorizationsWindow : Form
    {
        public UserApp userApp = new UserApp();

        public AuthorizationsWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 & textBox2.Text.Length != 0)
            {
                Authorization authorization = new Authorization(this.textBox1.Text, this.textBox2.Text, this);

                string errorChecking = authorization.loginUser();

                if (errorChecking != "ErDB")
                {
                    if (errorChecking != "Er")
                    {
                        OrderWindow orderWindow = new OrderWindow(this, userApp);
                        orderWindow.Show();
                        this.Hide();
                        this.label3.Text = "";
                    }
                    else
                    {
                        this.label3.Text = "Некорректные имя пользователя или пароль!";
                    }
                }
                else
                {
                    this.label3.Text = "Нет ответа от базы данных!";
                }
            }
            else
            {
                this.label3.Text = "Введите данные!";                
            }

            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}