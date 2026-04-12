using NutriPlan_Zdornikova.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NutriPlan_Zdornikova.Program;

namespace NutriPlan_Zdornikova.AppForms
{
    public partial class LoginForm : Form
    {
        private string targetText = "Добро пожаловать в NutriPlan"; // Текст, который будем печатать
        private string currentText = "";         // Текущий напечатанный текст
        private int charIndex = 0;
        private Users _user;
        public LoginForm()
        {
            InitializeComponent();
            labelWelcome.Text = "";
            this.Load += RegistrationForm_Load; 
            timerwriterTimer.Tick += timerwriterTimer_Tick;

            _user = new Users();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.Users". При необходимости она может быть перемещена или удалена.
         
            timerwriterTimer.Start();

        }

        private void passwordHashLabel_Click(object sender, EventArgs e)
        {

        }

        private void timerwriterTimer_Tick(object sender, EventArgs e)
        {

            if (charIndex < targetText.Length)
            {
                // Добавляем следующий символ
                currentText += targetText[charIndex];
                labelWelcome.Text = currentText;

                charIndex++;
            }
            else
            {
                // Текст напечатан полностью, останавливаем таймер
                timerwriterTimer.Stop();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void completingRegistration()
        {
           
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordHashTextBox.Text.Trim();

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(Convert.ToString(emailTextBox.Text), emailPattern))
            {
                MessageBox.Show("Пожалуйста, введите корректный email.");
                return;
            }
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new NutriPlanDB())
                {
                    // Ищем пользователя с таким email и паролем
                    var user = context.Users.FirstOrDefault(u => u.email == email && u.PasswordHash == password);

                    if (user != null)
                    {
                        MessageBox.Show($"Добро пожаловать, {user.FullName}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);



                       
                      

                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Неверный Email или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
       
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
                 RegistratuonForm registratuonForm   = new RegistratuonForm();
                 registratuonForm.Show();
       


            

        }
    }
}
