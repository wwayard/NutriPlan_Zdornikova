namespace NutriPlan_Zdornikova.AppForms
{
    partial class FormAnketa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.tableAdapterManager = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet1TableAdapters.TableAdapterManager();
            this.usersTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet1TableAdapters.UsersTableAdapter();
            this.nutriPlan_ZdornikovaDataSet = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timerwriterTimer = new System.Windows.Forms.Timer(this.components);
            this.labelUser = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2Step = new System.Windows.Forms.Panel();
            this.ActivityLevelComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.activityLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GoalComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonLast = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNext2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1Step = new System.Windows.Forms.Panel();
            this.ButtonNext = new Guna.UI2.WinForms.Guna2Button();
            this.buttonFemale = new Guna.UI2.WinForms.Guna2Button();
            this.dateOfBirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userProfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonMale = new Guna.UI2.WinForms.Guna2Button();
            this.userProfilesTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet1TableAdapters.UserProfilesTableAdapter();
            this.goalTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet1TableAdapters.GoalTableAdapter();
            this.activityLevelTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet1TableAdapters.ActivityLevelTableAdapter();
            this.panel3Step = new System.Windows.Forms.Panel();
            this.ButtonLast2 = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNext3 = new Guna.UI2.WinForms.Guna2Button();
            this.TrackBarHeigh = new Guna.UI2.WinForms.Guna2TrackBar();
            this.TrackBarWeight = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeigh = new System.Windows.Forms.Label();
            this.labeLw = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CaloriesTrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelcalories = new System.Windows.Forms.Label();
            this.CaloriesToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.panel4Step = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonFinish = new Guna.UI2.WinForms.Guna2Button();
            this.labelRecommend = new System.Windows.Forms.Label();
            this.labelBjuRes = new System.Windows.Forms.Label();
            this.labelWaterNorm = new System.Windows.Forms.Label();
            this.labelMainAdvace = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nutriPlan_ZdornikovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox)).BeginInit();
            this.panel2Step.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            this.panel1Step.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilesBindingSource)).BeginInit();
            this.panel3Step.SuspendLayout();
            this.panel4Step.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fullNameLabel.Location = new System.Drawing.Point(215, 88);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(256, 63);
            fullNameLabel.TabIndex = 12;
            fullNameLabel.Text = "Укажите дату рождения:";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(215, 184);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(226, 38);
            label1.TabIndex = 13;
            label1.Text = "Укажите пол:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(373, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(207, 26);
            label2.TabIndex = 4;
            label2.Text = "Выберите свою цель:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(330, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(299, 26);
            label3.TabIndex = 5;
            label3.Text = "Какой образ жизни вы ведете?:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityLevelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dishesTableAdapter = null;
            this.tableAdapterManager.FoodLogsTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.GoalTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.TypesMealTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserProfilesTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.ViewDishesTableAdapter = null;
            this.tableAdapterManager.WeightHistoryTableAdapter = null;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // nutriPlan_ZdornikovaDataSet
            // 
            this.nutriPlan_ZdornikovaDataSet.DataSetName = "NutriPlan_ZdornikovaDataSet";
            this.nutriPlan_ZdornikovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(259, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(99, 19);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Регистрация ";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer1.Panel1.Controls.Add(this.ProgressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.labelUser);
            this.splitContainer1.Panel1.Controls.Add(this.guna2PictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.panel4Step);
            this.splitContainer1.Panel2.Controls.Add(this.panel3Step);
            this.splitContainer1.Panel2.Controls.Add(this.panel2Step);
            this.splitContainer1.Panel2.Controls.Add(this.panel1Step);
            this.splitContainer1.Size = new System.Drawing.Size(930, 540);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.TabIndex = 2;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BorderRadius = 10;
            this.ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ProgressBar1.Location = new System.Drawing.Point(3, 82);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProgressBar1.Size = new System.Drawing.Size(924, 24);
            this.ProgressBar1.TabIndex = 3;
            this.ProgressBar1.Text = "ProgressBar";
            this.ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBar1.ValueChanged += new System.EventHandler(this.ProgressBar1_ValueChanged);
            // 
            // guna2PictureBox
            // 
            this.guna2PictureBox.BorderRadius = 20;
            this.guna2PictureBox.Image = global::NutriPlan_Zdornikova.Properties.Resources.free_icon_logo_187869;
            this.guna2PictureBox.ImageRotate = 0F;
            this.guna2PictureBox.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox.Name = "guna2PictureBox";
            this.guna2PictureBox.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox.TabIndex = 0;
            this.guna2PictureBox.TabStop = false;
            // 
            // panel2Step
            // 
            this.panel2Step.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2Step.Controls.Add(this.ActivityLevelComboBox2);
            this.panel2Step.Controls.Add(this.GoalComboBox1);
            this.panel2Step.Controls.Add(this.ButtonLast);
            this.panel2Step.Controls.Add(this.ButtonNext2);
            this.panel2Step.Controls.Add(label3);
            this.panel2Step.Controls.Add(label2);
            this.panel2Step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2Step.Location = new System.Drawing.Point(0, 0);
            this.panel2Step.Name = "panel2Step";
            this.panel2Step.Size = new System.Drawing.Size(930, 427);
            this.panel2Step.TabIndex = 15;
            this.panel2Step.Visible = false;
            // 
            // ActivityLevelComboBox2
            // 
            this.ActivityLevelComboBox2.AutoRoundedCorners = true;
            this.ActivityLevelComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.ActivityLevelComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ActivityLevelComboBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ActivityLevelComboBox2.DataSource = this.activityLevelBindingSource;
            this.ActivityLevelComboBox2.DisplayMember = "nameActivity";
            this.ActivityLevelComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ActivityLevelComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActivityLevelComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ActivityLevelComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ActivityLevelComboBox2.Font = new System.Drawing.Font("Candara", 12F);
            this.ActivityLevelComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ActivityLevelComboBox2.ItemHeight = 30;
            this.ActivityLevelComboBox2.Location = new System.Drawing.Point(261, 191);
            this.ActivityLevelComboBox2.Name = "ActivityLevelComboBox2";
            this.ActivityLevelComboBox2.Size = new System.Drawing.Size(416, 36);
            this.ActivityLevelComboBox2.TabIndex = 18;
            this.ActivityLevelComboBox2.ValueMember = "idActivity";
            // 
            // activityLevelBindingSource
            // 
            this.activityLevelBindingSource.DataMember = "ActivityLevel";
            this.activityLevelBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // GoalComboBox1
            // 
            this.GoalComboBox1.AutoRoundedCorners = true;
            this.GoalComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.GoalComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GoalComboBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.GoalComboBox1.DataSource = this.goalBindingSource;
            this.GoalComboBox1.DisplayMember = "NameGoal";
            this.GoalComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GoalComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GoalComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GoalComboBox1.Font = new System.Drawing.Font("Candara", 12F);
            this.GoalComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GoalComboBox1.ItemHeight = 30;
            this.GoalComboBox1.Location = new System.Drawing.Point(261, 79);
            this.GoalComboBox1.Name = "GoalComboBox1";
            this.GoalComboBox1.Size = new System.Drawing.Size(416, 36);
            this.GoalComboBox1.TabIndex = 17;
            this.GoalComboBox1.ValueMember = "IdGoal";
            // 
            // goalBindingSource
            // 
            this.goalBindingSource.DataMember = "Goal";
            this.goalBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // ButtonLast
            // 
            this.ButtonLast.Animated = true;
            this.ButtonLast.BorderRadius = 10;
            this.ButtonLast.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ButtonLast.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLast.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLast.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLast.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonLast.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLast.ForeColor = System.Drawing.Color.Black;
            this.ButtonLast.Location = new System.Drawing.Point(378, 345);
            this.ButtonLast.Name = "ButtonLast";
            this.ButtonLast.Size = new System.Drawing.Size(201, 37);
            this.ButtonLast.TabIndex = 16;
            this.ButtonLast.Text = "Назад";
            this.ButtonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // ButtonNext2
            // 
            this.ButtonNext2.Animated = true;
            this.ButtonNext2.BorderRadius = 10;
            this.ButtonNext2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ButtonNext2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNext2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNext2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonNext2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonNext2.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonNext2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNext2.ForeColor = System.Drawing.Color.Black;
            this.ButtonNext2.Location = new System.Drawing.Point(378, 291);
            this.ButtonNext2.Name = "ButtonNext2";
            this.ButtonNext2.Size = new System.Drawing.Size(201, 37);
            this.ButtonNext2.TabIndex = 15;
            this.ButtonNext2.Text = "Далее";
            this.ButtonNext2.Click += new System.EventHandler(this.ButtonNext2_Click);
            // 
            // panel1Step
            // 
            this.panel1Step.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1Step.Controls.Add(this.ButtonNext);
            this.panel1Step.Controls.Add(label1);
            this.panel1Step.Controls.Add(fullNameLabel);
            this.panel1Step.Controls.Add(this.buttonFemale);
            this.panel1Step.Controls.Add(this.dateOfBirthdayDateTimePicker);
            this.panel1Step.Controls.Add(this.buttonMale);
            this.panel1Step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1Step.Location = new System.Drawing.Point(0, 0);
            this.panel1Step.Name = "panel1Step";
            this.panel1Step.Size = new System.Drawing.Size(930, 427);
            this.panel1Step.TabIndex = 0;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Animated = true;
            this.ButtonNext.BorderRadius = 10;
            this.ButtonNext.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ButtonNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonNext.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonNext.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNext.ForeColor = System.Drawing.Color.Black;
            this.ButtonNext.Location = new System.Drawing.Point(362, 363);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(201, 37);
            this.ButtonNext.TabIndex = 14;
            this.ButtonNext.Text = "Далее";
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonFemale
            // 
            this.buttonFemale.Animated = true;
            this.buttonFemale.BorderRadius = 10;
            this.buttonFemale.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.buttonFemale.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFemale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFemale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFemale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFemale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFemale.FillColor = System.Drawing.Color.MistyRose;
            this.buttonFemale.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFemale.ForeColor = System.Drawing.Color.Black;
            this.buttonFemale.Location = new System.Drawing.Point(486, 233);
            this.buttonFemale.Name = "buttonFemale";
            this.buttonFemale.Size = new System.Drawing.Size(224, 33);
            this.buttonFemale.TabIndex = 11;
            this.buttonFemale.Tag = "2";
            this.buttonFemale.Text = "Женщина";
            this.buttonFemale.Click += new System.EventHandler(this.buttonMale_Click);
            // 
            // dateOfBirthdayDateTimePicker
            // 
            this.dateOfBirthdayDateTimePicker.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dateOfBirthdayDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateOfBirthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userProfilesBindingSource, "DateOfBirthday", true));
            this.dateOfBirthdayDateTimePicker.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthdayDateTimePicker.Location = new System.Drawing.Point(486, 88);
            this.dateOfBirthdayDateTimePicker.Name = "dateOfBirthdayDateTimePicker";
            this.dateOfBirthdayDateTimePicker.Size = new System.Drawing.Size(236, 37);
            this.dateOfBirthdayDateTimePicker.TabIndex = 9;
            // 
            // userProfilesBindingSource
            // 
            this.userProfilesBindingSource.DataMember = "UserProfiles";
            this.userProfilesBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // buttonMale
            // 
            this.buttonMale.Animated = true;
            this.buttonMale.BorderRadius = 10;
            this.buttonMale.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.buttonMale.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonMale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMale.FillColor = System.Drawing.Color.MistyRose;
            this.buttonMale.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMale.ForeColor = System.Drawing.Color.Black;
            this.buttonMale.Location = new System.Drawing.Point(486, 184);
            this.buttonMale.Name = "buttonMale";
            this.buttonMale.Size = new System.Drawing.Size(224, 33);
            this.buttonMale.TabIndex = 10;
            this.buttonMale.Tag = "1";
            this.buttonMale.Text = "Мужчина";
            // 
            // userProfilesTableAdapter
            // 
            this.userProfilesTableAdapter.ClearBeforeFill = true;
            // 
            // goalTableAdapter
            // 
            this.goalTableAdapter.ClearBeforeFill = true;
            // 
            // activityLevelTableAdapter
            // 
            this.activityLevelTableAdapter.ClearBeforeFill = true;
            // 
            // panel3Step
            // 
            this.panel3Step.Controls.Add(this.labelcalories);
            this.panel3Step.Controls.Add(this.labelCount);
            this.panel3Step.Controls.Add(this.CaloriesTrackBar1);
            this.panel3Step.Controls.Add(this.labeLw);
            this.panel3Step.Controls.Add(this.labelHeigh);
            this.panel3Step.Controls.Add(this.labelWeight);
            this.panel3Step.Controls.Add(this.labelHeight);
            this.panel3Step.Controls.Add(this.TrackBarWeight);
            this.panel3Step.Controls.Add(this.TrackBarHeigh);
            this.panel3Step.Controls.Add(this.ButtonLast2);
            this.panel3Step.Controls.Add(this.ButtonNext3);
            this.panel3Step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3Step.Location = new System.Drawing.Point(0, 0);
            this.panel3Step.Name = "panel3Step";
            this.panel3Step.Size = new System.Drawing.Size(930, 427);
            this.panel3Step.TabIndex = 19;
            this.panel3Step.Visible = false;
            // 
            // ButtonLast2
            // 
            this.ButtonLast2.Animated = true;
            this.ButtonLast2.BorderRadius = 10;
            this.ButtonLast2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ButtonLast2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLast2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLast2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLast2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLast2.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonLast2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLast2.ForeColor = System.Drawing.Color.Black;
            this.ButtonLast2.Location = new System.Drawing.Point(362, 356);
            this.ButtonLast2.Name = "ButtonLast2";
            this.ButtonLast2.Size = new System.Drawing.Size(201, 37);
            this.ButtonLast2.TabIndex = 18;
            this.ButtonLast2.Text = "Назад";
            this.ButtonLast2.Click += new System.EventHandler(this.ButtonLast2_Click);
            // 
            // ButtonNext3
            // 
            this.ButtonNext3.Animated = true;
            this.ButtonNext3.BorderRadius = 10;
            this.ButtonNext3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ButtonNext3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNext3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNext3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonNext3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonNext3.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonNext3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNext3.ForeColor = System.Drawing.Color.Black;
            this.ButtonNext3.Location = new System.Drawing.Point(362, 302);
            this.ButtonNext3.Name = "ButtonNext3";
            this.ButtonNext3.Size = new System.Drawing.Size(201, 37);
            this.ButtonNext3.TabIndex = 17;
            this.ButtonNext3.Text = "Далее";
            this.ButtonNext3.Click += new System.EventHandler(this.ButtonNext3_Click);
            // 
            // TrackBarHeigh
            // 
            this.TrackBarHeigh.DisplayFocus = true;
            this.TrackBarHeigh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TrackBarHeigh.IndicateFocus = true;
            this.TrackBarHeigh.Location = new System.Drawing.Point(263, 52);
            this.TrackBarHeigh.Maximum = 250;
            this.TrackBarHeigh.Minimum = 100;
            this.TrackBarHeigh.Name = "TrackBarHeigh";
            this.TrackBarHeigh.Size = new System.Drawing.Size(498, 23);
            this.TrackBarHeigh.TabIndex = 19;
            this.TrackBarHeigh.ThumbColor = System.Drawing.Color.MediumPurple;
            this.TrackBarHeigh.Value = 100;
            this.TrackBarHeigh.ValueChanged += new System.EventHandler(this.TrackBarHeigh_ValueChanged);
            // 
            // TrackBarWeight
            // 
            this.TrackBarWeight.DisplayFocus = true;
            this.TrackBarWeight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TrackBarWeight.IndicateFocus = true;
            this.TrackBarWeight.Location = new System.Drawing.Point(263, 130);
            this.TrackBarWeight.Maximum = 250;
            this.TrackBarWeight.Minimum = 30;
            this.TrackBarWeight.Name = "TrackBarWeight";
            this.TrackBarWeight.Size = new System.Drawing.Size(498, 23);
            this.TrackBarWeight.TabIndex = 20;
            this.TrackBarWeight.ThumbColor = System.Drawing.Color.MediumPurple;
            this.TrackBarWeight.ValueChanged += new System.EventHandler(this.TrackBarWeight_ValueChanged);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(502, 26);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(35, 23);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "127";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight.Location = new System.Drawing.Point(502, 95);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(29, 23);
            this.labelWeight.TabIndex = 21;
            this.labelWeight.Text = "54";
            this.labelWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeigh
            // 
            this.labelHeigh.AutoSize = true;
            this.labelHeigh.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeigh.Location = new System.Drawing.Point(32, 38);
            this.labelHeigh.Name = "labelHeigh";
            this.labelHeigh.Size = new System.Drawing.Size(102, 26);
            this.labelHeigh.TabIndex = 22;
            this.labelHeigh.Text = "Ваш рост:";
            this.labelHeigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeLw
            // 
            this.labeLw.AutoSize = true;
            this.labeLw.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeLw.Location = new System.Drawing.Point(32, 127);
            this.labeLw.Name = "labeLw";
            this.labeLw.Size = new System.Drawing.Size(90, 26);
            this.labeLw.TabIndex = 23;
            this.labeLw.Text = "Ваш вес:";
            this.labeLw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // CaloriesTrackBar1
            // 
            this.CaloriesTrackBar1.DisplayFocus = true;
            this.CaloriesTrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CaloriesTrackBar1.IndicateFocus = true;
            this.CaloriesTrackBar1.Location = new System.Drawing.Point(461, 206);
            this.CaloriesTrackBar1.Maximum = 4000;
            this.CaloriesTrackBar1.Minimum = 1200;
            this.CaloriesTrackBar1.Name = "CaloriesTrackBar1";
            this.CaloriesTrackBar1.Size = new System.Drawing.Size(300, 23);
            this.CaloriesTrackBar1.TabIndex = 24;
            this.CaloriesTrackBar1.ThumbColor = System.Drawing.Color.MediumPurple;
            this.CaloriesTrackBar1.Value = 2000;
            this.CaloriesTrackBar1.ValueChanged += new System.EventHandler(this.CaloriesTrackBar1_ValueChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(32, 203);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(411, 26);
            this.labelCount.TabIndex = 25;
            this.labelCount.Text = "Количество потребляемых калорий в день:";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelcalories
            // 
            this.labelcalories.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcalories.Location = new System.Drawing.Point(441, 235);
            this.labelcalories.Name = "labelcalories";
            this.labelcalories.Size = new System.Drawing.Size(340, 41);
            this.labelcalories.TabIndex = 26;
            this.labelcalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaloriesToolTip
            // 
            this.CaloriesToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CaloriesToolTip.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaloriesToolTip.ForeColor = System.Drawing.Color.Black;
            this.CaloriesToolTip.IsBalloon = true;
            this.CaloriesToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // panel4Step
            // 
            this.panel4Step.Controls.Add(this.labelMainAdvace);
            this.panel4Step.Controls.Add(this.labelWaterNorm);
            this.panel4Step.Controls.Add(this.labelBjuRes);
            this.panel4Step.Controls.Add(this.labelRecommend);
            this.panel4Step.Controls.Add(this.guna2Button1);
            this.panel4Step.Controls.Add(this.ButtonFinish);
            this.panel4Step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4Step.Location = new System.Drawing.Point(0, 0);
            this.panel4Step.Name = "panel4Step";
            this.panel4Step.Size = new System.Drawing.Size(930, 427);
            this.panel4Step.TabIndex = 27;
            this.panel4Step.Visible = false;
            this.panel4Step.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4Step_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.MistyRose;
            this.guna2Button1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(364, 374);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(201, 37);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Назад";
            // 
            // ButtonFinish
            // 
            this.ButtonFinish.Animated = true;
            this.ButtonFinish.BorderRadius = 10;
            this.ButtonFinish.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ButtonFinish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonFinish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonFinish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonFinish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonFinish.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonFinish.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFinish.ForeColor = System.Drawing.Color.Black;
            this.ButtonFinish.Location = new System.Drawing.Point(364, 320);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(201, 37);
            this.ButtonFinish.TabIndex = 19;
            this.ButtonFinish.Text = "Завершить";
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // labelRecommend
            // 
            this.labelRecommend.AutoSize = true;
            this.labelRecommend.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecommend.Location = new System.Drawing.Point(357, 20);
            this.labelRecommend.Name = "labelRecommend";
            this.labelRecommend.Size = new System.Drawing.Size(197, 29);
            this.labelRecommend.TabIndex = 4;
            this.labelRecommend.Text = "РЕКОМЕНДАЦИИ";
            this.labelRecommend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBjuRes
            // 
            this.labelBjuRes.AutoSize = true;
            this.labelBjuRes.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBjuRes.Location = new System.Drawing.Point(86, 120);
            this.labelBjuRes.Name = "labelBjuRes";
            this.labelBjuRes.Size = new System.Drawing.Size(18, 26);
            this.labelBjuRes.TabIndex = 21;
            this.labelBjuRes.Text = "/";
            this.labelBjuRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWaterNorm
            // 
            this.labelWaterNorm.AutoSize = true;
            this.labelWaterNorm.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWaterNorm.Location = new System.Drawing.Point(86, 174);
            this.labelWaterNorm.Name = "labelWaterNorm";
            this.labelWaterNorm.Size = new System.Drawing.Size(18, 26);
            this.labelWaterNorm.TabIndex = 22;
            this.labelWaterNorm.Text = "/";
            this.labelWaterNorm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMainAdvace
            // 
            this.labelMainAdvace.AutoSize = true;
            this.labelMainAdvace.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainAdvace.Location = new System.Drawing.Point(86, 220);
            this.labelMainAdvace.Name = "labelMainAdvace";
            this.labelMainAdvace.Size = new System.Drawing.Size(18, 26);
            this.labelMainAdvace.TabIndex = 23;
            this.labelMainAdvace.Text = "/";
            this.labelMainAdvace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainAdvace.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormAnketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAnketa";
            this.Text = "Анкета";
            this.Load += new System.EventHandler(this.FormAnketa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nutriPlan_ZdornikovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox)).EndInit();
            this.panel2Step.ResumeLayout(false);
            this.panel2Step.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            this.panel1Step.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userProfilesBindingSource)).EndInit();
            this.panel3Step.ResumeLayout(false);
            this.panel3Step.PerformLayout();
            this.panel4Step.ResumeLayout(false);
            this.panel4Step.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NutriPlan_ZdornikovaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private NutriPlan_ZdornikovaDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private NutriPlan_ZdornikovaDataSet1 nutriPlan_ZdornikovaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox;
        private System.Windows.Forms.Timer timerwriterTimer;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource userProfilesBindingSource;
        private NutriPlan_ZdornikovaDataSet1TableAdapters.UserProfilesTableAdapter userProfilesTableAdapter;
        private System.Windows.Forms.Panel panel1Step;
        private Guna.UI2.WinForms.Guna2Button buttonFemale;
        private System.Windows.Forms.DateTimePicker dateOfBirthdayDateTimePicker;
        private Guna.UI2.WinForms.Guna2Button buttonMale;
        private Guna.UI2.WinForms.Guna2Button ButtonNext;
        private System.Windows.Forms.Panel panel2Step;
        private System.Windows.Forms.BindingSource goalBindingSource;
        private NutriPlan_ZdornikovaDataSet1TableAdapters.GoalTableAdapter goalTableAdapter;
        private System.Windows.Forms.BindingSource activityLevelBindingSource;
        private NutriPlan_ZdornikovaDataSet1TableAdapters.ActivityLevelTableAdapter activityLevelTableAdapter;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar1;
        private Guna.UI2.WinForms.Guna2Button ButtonLast;
        private Guna.UI2.WinForms.Guna2Button ButtonNext2;
        private Guna.UI2.WinForms.Guna2ComboBox GoalComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ActivityLevelComboBox2;
        private System.Windows.Forms.Panel panel3Step;
        private Guna.UI2.WinForms.Guna2Button ButtonLast2;
        private Guna.UI2.WinForms.Guna2Button ButtonNext3;
        private System.Windows.Forms.Label labelHeigh;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBarWeight;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBarHeigh;
        private System.Windows.Forms.Label labeLw;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelCount;
        private Guna.UI2.WinForms.Guna2TrackBar CaloriesTrackBar1;
        private System.Windows.Forms.Label labelcalories;
        private Guna.UI2.WinForms.Guna2HtmlToolTip CaloriesToolTip;
        private System.Windows.Forms.Panel panel4Step;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button ButtonFinish;
        private System.Windows.Forms.Label labelRecommend;
        private System.Windows.Forms.Label labelMainAdvace;
        private System.Windows.Forms.Label labelWaterNorm;
        private System.Windows.Forms.Label labelBjuRes;
    }
}