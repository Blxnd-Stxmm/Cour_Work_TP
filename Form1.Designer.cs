namespace Cours_Work1
{
    partial class Interpol_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interpol_Form));
            this.Search_Panel = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.Button_refresh = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Panel_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Display_panel = new System.Windows.Forms.Panel();
            this.pictureBoxInterpol = new System.Windows.Forms.PictureBox();
            this.labelDisplayWeight = new System.Windows.Forms.Label();
            this.labelDisplayHeight = new System.Windows.Forms.Label();
            this.labelDisplayEye = new System.Windows.Forms.Label();
            this.labelDisplayHair = new System.Windows.Forms.Label();
            this.labelDisplaySigns = new System.Windows.Forms.Label();
            this.labelDisplayPlaceBirth = new System.Windows.Forms.Label();
            this.labelDisplayCityzenship = new System.Windows.Forms.Label();
            this.labelDisplayResidence = new System.Windows.Forms.Label();
            this.labelDisplayLanguages = new System.Windows.Forms.Label();
            this.labelDisplayCase = new System.Windows.Forms.Label();
            this.labelDisplayProfession = new System.Windows.Forms.Label();
            this.labellast_case = new System.Windows.Forms.Label();
            this.labelProfession = new System.Windows.Forms.Label();
            this.know_languages = new System.Windows.Forms.Label();
            this.labellast_place_of_residence = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelPlaceofBirth = new System.Windows.Forms.Label();
            this.labelCityzenship = new System.Windows.Forms.Label();
            this.labelSpecial_signs = new System.Windows.Forms.Label();
            this.labelEye = new System.Windows.Forms.Label();
            this.labelHair = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.Label_Nickname = new System.Windows.Forms.Label();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.Label_FristName = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.CreateNew_Button = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.Search_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Display_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInterpol)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Panel
            // 
            this.Search_Panel.BackColor = System.Drawing.Color.Tomato;
            this.Search_Panel.Controls.Add(this.buttonSave);
            this.Search_Panel.Controls.Add(this.Button_refresh);
            this.Search_Panel.Controls.Add(this.textBox_search);
            this.Search_Panel.Controls.Add(this.pictureBox1);
            this.Search_Panel.Controls.Add(this.Clear_Button);
            this.Search_Panel.Controls.Add(this.Panel_label);
            this.Search_Panel.Location = new System.Drawing.Point(0, 41);
            this.Search_Panel.Name = "Search_Panel";
            this.Search_Panel.Size = new System.Drawing.Size(1096, 78);
            this.Search_Panel.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Tomato;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(623, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(79, 46);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Button_refresh
            // 
            this.Button_refresh.BackColor = System.Drawing.Color.Tomato;
            this.Button_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_refresh.FlatAppearance.BorderSize = 0;
            this.Button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_refresh.Image = global::Cours_Work1.Properties.Resources.system_regular_18_autorenew;
            this.Button_refresh.Location = new System.Drawing.Point(762, 16);
            this.Button_refresh.Name = "Button_refresh";
            this.Button_refresh.Size = new System.Drawing.Size(45, 46);
            this.Button_refresh.TabIndex = 4;
            this.Button_refresh.UseVisualStyleBackColor = false;
            this.Button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search.Location = new System.Drawing.Point(874, 28);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(176, 29);
            this.textBox_search.TabIndex = 3;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tomato;
            this.pictureBox1.Image = global::Cours_Work1.Properties.Resources.system_regular_42_search;
            this.pictureBox1.Location = new System.Drawing.Point(813, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.Tomato;
            this.Clear_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_Button.FlatAppearance.BorderSize = 0;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Image = global::Cours_Work1.Properties.Resources.system_regular_39_trash;
            this.Clear_Button.Location = new System.Drawing.Point(711, 16);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(45, 46);
            this.Clear_Button.TabIndex = 1;
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Panel_label
            // 
            this.Panel_label.AutoSize = true;
            this.Panel_label.Font = new System.Drawing.Font("Bahnschrift Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Panel_label.ForeColor = System.Drawing.Color.Black;
            this.Panel_label.Location = new System.Drawing.Point(32, 8);
            this.Panel_label.Name = "Panel_label";
            this.Panel_label.Size = new System.Drawing.Size(427, 58);
            this.Panel_label.TabIndex = 0;
            this.Panel_label.Text = "Interpol Data Base";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(21, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(250, 421);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Display_panel
            // 
            this.Display_panel.BackColor = System.Drawing.Color.OldLace;
            this.Display_panel.Controls.Add(this.pictureBoxInterpol);
            this.Display_panel.Controls.Add(this.labelDisplayWeight);
            this.Display_panel.Controls.Add(this.labelDisplayHeight);
            this.Display_panel.Controls.Add(this.labelDisplayEye);
            this.Display_panel.Controls.Add(this.labelDisplayHair);
            this.Display_panel.Controls.Add(this.labelDisplaySigns);
            this.Display_panel.Controls.Add(this.labelDisplayPlaceBirth);
            this.Display_panel.Controls.Add(this.labelDisplayCityzenship);
            this.Display_panel.Controls.Add(this.labelDisplayResidence);
            this.Display_panel.Controls.Add(this.labelDisplayLanguages);
            this.Display_panel.Controls.Add(this.labelDisplayCase);
            this.Display_panel.Controls.Add(this.labelDisplayProfession);
            this.Display_panel.Controls.Add(this.labellast_case);
            this.Display_panel.Controls.Add(this.labelProfession);
            this.Display_panel.Controls.Add(this.know_languages);
            this.Display_panel.Controls.Add(this.labellast_place_of_residence);
            this.Display_panel.Controls.Add(this.labelDateOfBirth);
            this.Display_panel.Controls.Add(this.labelPlaceofBirth);
            this.Display_panel.Controls.Add(this.labelCityzenship);
            this.Display_panel.Controls.Add(this.labelSpecial_signs);
            this.Display_panel.Controls.Add(this.labelEye);
            this.Display_panel.Controls.Add(this.labelHair);
            this.Display_panel.Controls.Add(this.labelHeight);
            this.Display_panel.Controls.Add(this.labelWeight);
            this.Display_panel.Controls.Add(this.Label_Nickname);
            this.Display_panel.Controls.Add(this.Label_LastName);
            this.Display_panel.Controls.Add(this.Label_FristName);
            this.Display_panel.Controls.Add(this.Description_label);
            this.Display_panel.Location = new System.Drawing.Point(299, 161);
            this.Display_panel.Name = "Display_panel";
            this.Display_panel.Size = new System.Drawing.Size(751, 523);
            this.Display_panel.TabIndex = 2;
            // 
            // pictureBoxInterpol
            // 
            this.pictureBoxInterpol.Image = global::Cours_Work1.Properties.Resources.pngwing_com__1___1_;
            this.pictureBoxInterpol.Location = new System.Drawing.Point(44, 17);
            this.pictureBoxInterpol.Name = "pictureBoxInterpol";
            this.pictureBoxInterpol.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxInterpol.TabIndex = 28;
            this.pictureBoxInterpol.TabStop = false;
            // 
            // labelDisplayWeight
            // 
            this.labelDisplayWeight.AutoSize = true;
            this.labelDisplayWeight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayWeight.Location = new System.Drawing.Point(291, 110);
            this.labelDisplayWeight.Name = "labelDisplayWeight";
            this.labelDisplayWeight.Size = new System.Drawing.Size(43, 22);
            this.labelDisplayWeight.TabIndex = 27;
            this.labelDisplayWeight.Text = "___";
            // 
            // labelDisplayHeight
            // 
            this.labelDisplayHeight.AutoSize = true;
            this.labelDisplayHeight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayHeight.Location = new System.Drawing.Point(445, 110);
            this.labelDisplayHeight.Name = "labelDisplayHeight";
            this.labelDisplayHeight.Size = new System.Drawing.Size(43, 22);
            this.labelDisplayHeight.TabIndex = 26;
            this.labelDisplayHeight.Text = "___";
            // 
            // labelDisplayEye
            // 
            this.labelDisplayEye.AutoSize = true;
            this.labelDisplayEye.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayEye.Location = new System.Drawing.Point(673, 110);
            this.labelDisplayEye.Name = "labelDisplayEye";
            this.labelDisplayEye.Size = new System.Drawing.Size(43, 22);
            this.labelDisplayEye.TabIndex = 25;
            this.labelDisplayEye.Text = "___";
            // 
            // labelDisplayHair
            // 
            this.labelDisplayHair.AutoSize = true;
            this.labelDisplayHair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayHair.Location = new System.Drawing.Point(566, 110);
            this.labelDisplayHair.Name = "labelDisplayHair";
            this.labelDisplayHair.Size = new System.Drawing.Size(43, 22);
            this.labelDisplayHair.TabIndex = 24;
            this.labelDisplayHair.Text = "___";
            // 
            // labelDisplaySigns
            // 
            this.labelDisplaySigns.AutoSize = true;
            this.labelDisplaySigns.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplaySigns.Location = new System.Drawing.Point(182, 199);
            this.labelDisplaySigns.Name = "labelDisplaySigns";
            this.labelDisplaySigns.Size = new System.Drawing.Size(461, 22);
            this.labelDisplaySigns.TabIndex = 23;
            this.labelDisplaySigns.Text = "_________________________________________";
            // 
            // labelDisplayPlaceBirth
            // 
            this.labelDisplayPlaceBirth.AutoSize = true;
            this.labelDisplayPlaceBirth.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayPlaceBirth.Location = new System.Drawing.Point(496, 264);
            this.labelDisplayPlaceBirth.Name = "labelDisplayPlaceBirth";
            this.labelDisplayPlaceBirth.Size = new System.Drawing.Size(208, 22);
            this.labelDisplayPlaceBirth.TabIndex = 22;
            this.labelDisplayPlaceBirth.Text = "__________________";
            // 
            // labelDisplayCityzenship
            // 
            this.labelDisplayCityzenship.AutoSize = true;
            this.labelDisplayCityzenship.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayCityzenship.Location = new System.Drawing.Point(159, 264);
            this.labelDisplayCityzenship.Name = "labelDisplayCityzenship";
            this.labelDisplayCityzenship.Size = new System.Drawing.Size(153, 22);
            this.labelDisplayCityzenship.TabIndex = 21;
            this.labelDisplayCityzenship.Text = "_____________";
            // 
            // labelDisplayResidence
            // 
            this.labelDisplayResidence.AutoSize = true;
            this.labelDisplayResidence.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayResidence.Location = new System.Drawing.Point(20, 376);
            this.labelDisplayResidence.Name = "labelDisplayResidence";
            this.labelDisplayResidence.Size = new System.Drawing.Size(208, 22);
            this.labelDisplayResidence.TabIndex = 20;
            this.labelDisplayResidence.Text = "__________________";
            // 
            // labelDisplayLanguages
            // 
            this.labelDisplayLanguages.AutoSize = true;
            this.labelDisplayLanguages.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayLanguages.Location = new System.Drawing.Point(430, 376);
            this.labelDisplayLanguages.Name = "labelDisplayLanguages";
            this.labelDisplayLanguages.Size = new System.Drawing.Size(274, 22);
            this.labelDisplayLanguages.TabIndex = 19;
            this.labelDisplayLanguages.Text = "________________________";
            // 
            // labelDisplayCase
            // 
            this.labelDisplayCase.AutoSize = true;
            this.labelDisplayCase.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayCase.Location = new System.Drawing.Point(387, 474);
            this.labelDisplayCase.Name = "labelDisplayCase";
            this.labelDisplayCase.Size = new System.Drawing.Size(329, 22);
            this.labelDisplayCase.TabIndex = 18;
            this.labelDisplayCase.Text = "_____________________________";
            // 
            // labelDisplayProfession
            // 
            this.labelDisplayProfession.AutoSize = true;
            this.labelDisplayProfession.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayProfession.Location = new System.Drawing.Point(18, 474);
            this.labelDisplayProfession.Name = "labelDisplayProfession";
            this.labelDisplayProfession.Size = new System.Drawing.Size(230, 22);
            this.labelDisplayProfession.TabIndex = 17;
            this.labelDisplayProfession.Text = "____________________";
            // 
            // labellast_case
            // 
            this.labellast_case.AutoSize = true;
            this.labellast_case.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellast_case.Location = new System.Drawing.Point(480, 438);
            this.labellast_case.Name = "labellast_case";
            this.labellast_case.Size = new System.Drawing.Size(110, 29);
            this.labellast_case.TabIndex = 16;
            this.labellast_case.Text = "Last case:";
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProfession.Location = new System.Drawing.Point(24, 438);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(204, 29);
            this.labelProfession.TabIndex = 15;
            this.labelProfession.Text = "Criminal profession:";
            // 
            // know_languages
            // 
            this.know_languages.AutoSize = true;
            this.know_languages.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.know_languages.Location = new System.Drawing.Point(433, 336);
            this.know_languages.Name = "know_languages";
            this.know_languages.Size = new System.Drawing.Size(250, 29);
            this.know_languages.TabIndex = 14;
            this.know_languages.Text = "Knowledge of languages:";
            // 
            // labellast_place_of_residence
            // 
            this.labellast_place_of_residence.AutoSize = true;
            this.labellast_place_of_residence.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellast_place_of_residence.Location = new System.Drawing.Point(18, 336);
            this.labellast_place_of_residence.Name = "labellast_place_of_residence";
            this.labellast_place_of_residence.Size = new System.Drawing.Size(237, 29);
            this.labellast_place_of_residence.TabIndex = 13;
            this.labellast_place_of_residence.Text = "Last place of residence:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(618, 37);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(118, 25);
            this.labelDateOfBirth.TabIndex = 12;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelPlaceofBirth
            // 
            this.labelPlaceofBirth.AutoSize = true;
            this.labelPlaceofBirth.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlaceofBirth.Location = new System.Drawing.Point(349, 259);
            this.labelPlaceofBirth.Name = "labelPlaceofBirth";
            this.labelPlaceofBirth.Size = new System.Drawing.Size(146, 29);
            this.labelPlaceofBirth.TabIndex = 11;
            this.labelPlaceofBirth.Text = "Place of Birth:";
            // 
            // labelCityzenship
            // 
            this.labelCityzenship.AutoSize = true;
            this.labelCityzenship.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCityzenship.Location = new System.Drawing.Point(30, 259);
            this.labelCityzenship.Name = "labelCityzenship";
            this.labelCityzenship.Size = new System.Drawing.Size(130, 29);
            this.labelCityzenship.TabIndex = 10;
            this.labelCityzenship.Text = "Cityzenship:";
            // 
            // labelSpecial_signs
            // 
            this.labelSpecial_signs.AutoSize = true;
            this.labelSpecial_signs.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecial_signs.Location = new System.Drawing.Point(30, 194);
            this.labelSpecial_signs.Name = "labelSpecial_signs";
            this.labelSpecial_signs.Size = new System.Drawing.Size(146, 29);
            this.labelSpecial_signs.TabIndex = 9;
            this.labelSpecial_signs.Text = "Special Signs:";
            // 
            // labelEye
            // 
            this.labelEye.AutoSize = true;
            this.labelEye.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEye.Location = new System.Drawing.Point(628, 103);
            this.labelEye.Name = "labelEye";
            this.labelEye.Size = new System.Drawing.Size(55, 29);
            this.labelEye.TabIndex = 8;
            this.labelEye.Text = "Eye:";
            // 
            // labelHair
            // 
            this.labelHair.AutoSize = true;
            this.labelHair.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHair.Location = new System.Drawing.Point(509, 103);
            this.labelHair.Name = "labelHair";
            this.labelHair.Size = new System.Drawing.Size(58, 29);
            this.labelHair.TabIndex = 7;
            this.labelHair.Text = "Hair:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(356, 103);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(81, 29);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight.Location = new System.Drawing.Point(197, 103);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(86, 29);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Weight:";
            // 
            // Label_Nickname
            // 
            this.Label_Nickname.AutoSize = true;
            this.Label_Nickname.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Nickname.Location = new System.Drawing.Point(409, 32);
            this.Label_Nickname.Name = "Label_Nickname";
            this.Label_Nickname.Size = new System.Drawing.Size(106, 29);
            this.Label_Nickname.TabIndex = 4;
            this.Label_Nickname.Text = "Nickname";
            // 
            // Label_LastName
            // 
            this.Label_LastName.AutoSize = true;
            this.Label_LastName.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_LastName.Location = new System.Drawing.Point(290, 32);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(113, 29);
            this.Label_LastName.TabIndex = 3;
            this.Label_LastName.Text = "Last Name";
            // 
            // Label_FristName
            // 
            this.Label_FristName.AutoSize = true;
            this.Label_FristName.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FristName.Location = new System.Drawing.Point(197, 32);
            this.Label_FristName.Name = "Label_FristName";
            this.Label_FristName.Size = new System.Drawing.Size(67, 29);
            this.Label_FristName.TabIndex = 2;
            this.Label_FristName.Text = "Name";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_label.Location = new System.Drawing.Point(26, 17);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(0, 18);
            this.Description_label.TabIndex = 0;
            // 
            // CreateNew_Button
            // 
            this.CreateNew_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.CreateNew_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateNew_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNew_Button.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNew_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateNew_Button.Location = new System.Drawing.Point(21, 599);
            this.CreateNew_Button.Name = "CreateNew_Button";
            this.CreateNew_Button.Size = new System.Drawing.Size(101, 58);
            this.CreateNew_Button.TabIndex = 3;
            this.CreateNew_Button.Text = "Create";
            this.CreateNew_Button.UseVisualStyleBackColor = false;
            this.CreateNew_Button.Click += new System.EventHandler(this.CreateNew_Button_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.Location = new System.Drawing.Point(156, 599);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 58);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Interpol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1091, 709);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.CreateNew_Button);
            this.Controls.Add(this.Display_panel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interpol_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERPOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Search_Panel.ResumeLayout(false);
            this.Search_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Display_panel.ResumeLayout(false);
            this.Display_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInterpol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Search_Panel;
        private System.Windows.Forms.Label Panel_label;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel Display_panel;
        private System.Windows.Forms.Button CreateNew_Button;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.Label Label_Nickname;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.Label Label_FristName;
        private System.Windows.Forms.Button Button_refresh;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHair;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labellast_place_of_residence;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelPlaceofBirth;
        private System.Windows.Forms.Label labelCityzenship;
        private System.Windows.Forms.Label labelSpecial_signs;
        private System.Windows.Forms.Label labelEye;
        private System.Windows.Forms.Label labellast_case;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.Label know_languages;
        private System.Windows.Forms.Label labelDisplayEye;
        private System.Windows.Forms.Label labelDisplayHair;
        private System.Windows.Forms.Label labelDisplaySigns;
        private System.Windows.Forms.Label labelDisplayPlaceBirth;
        private System.Windows.Forms.Label labelDisplayCityzenship;
        private System.Windows.Forms.Label labelDisplayResidence;
        private System.Windows.Forms.Label labelDisplayLanguages;
        private System.Windows.Forms.Label labelDisplayCase;
        private System.Windows.Forms.Label labelDisplayProfession;
        private System.Windows.Forms.Label labelDisplayWeight;
        private System.Windows.Forms.Label labelDisplayHeight;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxInterpol;
        private System.Windows.Forms.Button buttonEdit;
    }
}

