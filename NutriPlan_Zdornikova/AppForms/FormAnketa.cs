using Guna.UI2.WinForms;
using NutriPlan_Zdornikova.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static NutriPlan_Zdornikova.Program;

namespace NutriPlan_Zdornikova.AppForms
{
    public partial class FormAnketa : Form
    {
        int SelectedGenderId = 0;
        public FormAnketa()
        {
            InitializeComponent();
            labelUser.Text = $"Приветствую, {Session.CurrentUser.FullName}! Пожалуйста, заполните анкету для получения персонального плана питания.";
            labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelUser.AutoSize = false;
            labelUser.Size = new Size(400, 50);
        }

      


        private void FormAnketa_Load(object sender, EventArgs e)
        {

        }

        private void FormAnketa_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.ActivityLevel". При необходимости она может быть перемещена или удалена.
            this.activityLevelTableAdapter.Fill(this.nutriPlan_ZdornikovaDataSet.ActivityLevel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.Goal". При необходимости она может быть перемещена или удалена.
            this.goalTableAdapter.Fill(this.nutriPlan_ZdornikovaDataSet.Goal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.UserProfiles". При необходимости она может быть перемещена или удалена.
            this.userProfilesTableAdapter.Fill(this.nutriPlan_ZdornikovaDataSet.UserProfiles);


        }


        private void buttonMale_Click(object sender, EventArgs e)
        {
            var btn = (Guna.UI2.WinForms.Guna2Button)sender;

            if (btn.Tag != null)
            {
                SelectedGenderId = int.Parse(btn.Tag.ToString());
            }
        }

      

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            panel1Step.Visible = false;
            panel2Step.Visible = true;

            ProgressBar1.Value = 33;
        }

        private void ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonNext2_Click(object sender, EventArgs e)
        {
            panel2Step.Visible = false;
            panel3Step.Visible = true;
            ProgressBar1.Value = 66;
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            panel2Step.Visible = false;
            panel1Step.Visible = true;
            ProgressBar1.Value = 0;
        }

        private void TrackBarHeigh_ValueChanged(object sender, EventArgs e)
        {
            labelHeight.Text = $"{TrackBarHeigh.Value} см";
        }

        private void TrackBarWeight_ValueChanged(object sender, EventArgs e)
        {
            labelWeight.Text = $"{TrackBarWeight.Value} кг";
        }

        private void ButtonLast2_Click(object sender, EventArgs e)
        {
            panel3Step.Visible = false;
            panel2Step.Visible = true;
            ProgressBar1.Value = 33;
        }

        private void CaloriesTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            int val =   CaloriesTrackBar1.Value;
            string tipTitle = "";
            string tipText = "";
            labelCount.Text = $"{val} ккал/день";

            if (val < 1500)
            {
                tipTitle = "НИЗКИЙ КАЛОРАЖ";
                tipText = "Обычно для быстрого похудения.\nТребует контроля врача!";
            }
            else if (val >= 1500 && val <= 2200)
            {
                tipTitle = "ПОДДЕРЖАНИЕ";
                tipText = "Средняя норма для большинства людей\nс умеренной активностью.";
            }
            else if (val > 2200 && val <= 3000)
            {
                tipTitle = "ПРОФИЦИТ";
                tipText = "Подходит для тренировок\nи постепенного набора массы.";
            }
            else
            {
                tipTitle = "ВЫСОКАЯ ЭНЕРГИЯ";
                tipText = "Для атлетов или тяжелого\nфизического труда.";
            }

            // Собираем чистый текст без тегов
            string fullMessage = $"{tipTitle}\n{tipText}";

            // Выводим подсказку
            CaloriesToolTip.SetToolTip(CaloriesTrackBar1, fullMessage);

            // Обновляем число под ползунком
            labelcalories.Text = $"{val} ккал";
        }
        

        private void CalulateResults()
        {
            int calories = (int)CaloriesTrackBar1.Value;
            double weight = (double)TrackBarWeight.Value; // берем из поля на 2-м или 3-м шаге

            // Расчет БЖУ (30/30/40)
            double p = (calories * 0.30) / 4;
            double f = (calories * 0.30) / 9;
            double c = (calories * 0.40) / 4;

            // Расчет воды (30 мл на 1 кг веса)
            double water = weight * 0.03;

            // Выводим БЖУ красиво
            labelBjuRes.Text = $"БЕЛКИ: {Math.Round(p)}г  |  ЖИРЫ: {Math.Round(f)}г  |  УГЛЕВОДЫ: {Math.Round(c)}г";

            // Выводим норму воды
            labelWaterNorm.Text = $"Ваша суточная норма воды: {Math.Round(water, 1)} л.";

            // Генерация текстового совета в зависимости от цели (из Step 2)
            int goalId = (int)GoalComboBox1.SelectedValue;
            string advice = "";

            switch (goalId)
            {
                case 1: advice = "Цель — Похудение: Старайтесь не превышать норму углеводов и делайте упор на овощи."; break;
                case 2: advice = "Цель — Баланс: Ваше питание сбалансировано. Поддерживайте текущую активность."; break;
                case 3: advice = "Цель — Набор: Уделите внимание белкам и сложным углеводам перед тренировкой."; break;
            }

            labelMainAdvace.Text = advice;
        }
        
        private void ButtonNext3_Click(object sender, EventArgs e)
        {
            panel3Step.Visible = false;
            panel4Step.Visible = true;

            panel4Step.BringToFront();
            ProgressBar1.Value = 100;
            CalulateResults();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NutriPlanDB())
                {
                    // 1. Создаем объект анкеты
                    var newAnketa = new UserProfiles
                    {
                        // Данные пользователя (ID берем из глобальной сессии, которую делали при входе)
                        UserId = Session.CurrentUser.Id,

                        // Данные с 1-й панели
                        IdGender = SelectedGenderId, // Наша переменная из кнопок М/Ж
                        DateOfBirthday = dateOfBirthdayDateTimePicker.Value,

                        // Данные со 2-й панели (из ComboBox)
                        idGoal = (int)GoalComboBox1.SelectedValue,
                        IdActivityLevel = (int)ActivityLevelComboBox2.SelectedValue,

                        // Данные с 3-й панели (из TrackBar или Numeric)
                        weightCM = (int)TrackBarWeight.Value,
                        heightCM = (int)TrackBarHeigh.Value,
                        DailyCalories = (int)CaloriesTrackBar1.Value,

                        Updatet_at = DateTime.Now
                    };

                    // 2. Добавляем в контекст и сохраняем
                    context.UserProfiles.Add(newAnketa);
                    if (SelectedGenderId == 0)
                    {
                        MessageBox.Show("Пожалуйста, выберите ваш пол на первом шаге анкеты!");
                        return;
                    }
                    if (Session.CurrentUser == null || Session.CurrentUser.Id == 0)
                    {
                        MessageBox.Show("Ошибка: Пользователь не авторизован! ID равен 0.");
                        return; // Не даем базе выкинуть ошибку
                    }
                    context.SaveChanges();

                    // 3. Уведомление и переход
                    MessageBox.Show("Данные успешно сохранены! Ваш персональный план питания готов.",
                                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Открываем главную форму приложения
                    //FormMain mainForm = new FormMain();
                    //mainForm.Show();

                    // Закрываем анкету
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Если что-то пошло не так (например, БД недоступна)
                MessageBox.Show(ex.InnerException?.InnerException?.Message ?? ex.Message);
            }
        }

        private void panel4Step_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

