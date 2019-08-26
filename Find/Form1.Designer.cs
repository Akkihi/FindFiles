namespace Find
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Path_Text = new System.Windows.Forms.TextBox();
            this.Filename_Text = new System.Windows.Forms.TextBox();
            this.Path_Btn = new System.Windows.Forms.Button();
            this.Filename_Btn = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.WordinFile_Text = new System.Windows.Forms.TextBox();
            this.ListView = new System.Windows.Forms.ListView();
            this.Filename_Label = new System.Windows.Forms.Label();
            this.StopSearch_Btn = new System.Windows.Forms.Button();
            this.ResumeSearch_Btn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Timer_Label = new System.Windows.Forms.Label();
            this.Akkihiinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Path_Text
            // 
            this.Path_Text.Location = new System.Drawing.Point(21, 12);
            this.Path_Text.Name = "Path_Text";
            this.Path_Text.Size = new System.Drawing.Size(417, 20);
            this.Path_Text.TabIndex = 0;
            this.Path_Text.TextChanged += new System.EventHandler(this.Path_Text_TextChanged);
            // 
            // Filename_Text
            // 
            this.Filename_Text.Location = new System.Drawing.Point(21, 47);
            this.Filename_Text.Name = "Filename_Text";
            this.Filename_Text.Size = new System.Drawing.Size(417, 20);
            this.Filename_Text.TabIndex = 1;
            // 
            // Path_Btn
            // 
            this.Path_Btn.Location = new System.Drawing.Point(444, 12);
            this.Path_Btn.Name = "Path_Btn";
            this.Path_Btn.Size = new System.Drawing.Size(28, 20);
            this.Path_Btn.TabIndex = 2;
            this.Path_Btn.Text = "...";
            this.Path_Btn.UseVisualStyleBackColor = true;
            this.Path_Btn.Click += new System.EventHandler(this.Path_Btn_Click);
            // 
            // Filename_Btn
            // 
            this.Filename_Btn.Enabled = false;
            this.Filename_Btn.Location = new System.Drawing.Point(445, 201);
            this.Filename_Btn.Name = "Filename_Btn";
            this.Filename_Btn.Size = new System.Drawing.Size(127, 20);
            this.Filename_Btn.TabIndex = 3;
            this.Filename_Btn.Text = "Новый Поиск";
            this.Filename_Btn.UseVisualStyleBackColor = true;
            this.Filename_Btn.Click += new System.EventHandler(this.Filename_Btn_Click);
            // 
            // WordinFile_Text
            // 
            this.WordinFile_Text.Location = new System.Drawing.Point(21, 78);
            this.WordinFile_Text.Name = "WordinFile_Text";
            this.WordinFile_Text.Size = new System.Drawing.Size(417, 20);
            this.WordinFile_Text.TabIndex = 6;
            this.WordinFile_Text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ListView
            // 
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(21, 115);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(417, 302);
            this.ListView.TabIndex = 7;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.List;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged_1);
            this.ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            // 
            // Filename_Label
            // 
            this.Filename_Label.AutoSize = true;
            this.Filename_Label.Location = new System.Drawing.Point(18, 430);
            this.Filename_Label.Name = "Filename_Label";
            this.Filename_Label.Size = new System.Drawing.Size(0, 13);
            this.Filename_Label.TabIndex = 8;
            // 
            // StopSearch_Btn
            // 
            this.StopSearch_Btn.Enabled = false;
            this.StopSearch_Btn.Location = new System.Drawing.Point(445, 237);
            this.StopSearch_Btn.Name = "StopSearch_Btn";
            this.StopSearch_Btn.Size = new System.Drawing.Size(127, 20);
            this.StopSearch_Btn.TabIndex = 9;
            this.StopSearch_Btn.Text = "Остановить поиск";
            this.StopSearch_Btn.UseVisualStyleBackColor = true;
            this.StopSearch_Btn.Click += new System.EventHandler(this.StopSearch_Btn_Click);
            // 
            // ResumeSearch_Btn
            // 
            this.ResumeSearch_Btn.Enabled = false;
            this.ResumeSearch_Btn.Location = new System.Drawing.Point(445, 273);
            this.ResumeSearch_Btn.Name = "ResumeSearch_Btn";
            this.ResumeSearch_Btn.Size = new System.Drawing.Size(127, 20);
            this.ResumeSearch_Btn.TabIndex = 10;
            this.ResumeSearch_Btn.Text = "Продолжить поиск";
            this.ResumeSearch_Btn.UseVisualStyleBackColor = true;
            this.ResumeSearch_Btn.Click += new System.EventHandler(this.ResumeSearch_Btn_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.PrivateTimer);
            // 
            // Timer_Label
            // 
            this.Timer_Label.AutoSize = true;
            this.Timer_Label.Location = new System.Drawing.Point(18, 467);
            this.Timer_Label.Name = "Timer_Label";
            this.Timer_Label.Size = new System.Drawing.Size(0, 13);
            this.Timer_Label.TabIndex = 11;
            // 
            // Akkihiinfo
            // 
            this.Akkihiinfo.AutoSize = true;
            this.Akkihiinfo.Location = new System.Drawing.Point(1063, 194);
            this.Akkihiinfo.Name = "Akkihiinfo";
            this.Akkihiinfo.Size = new System.Drawing.Size(56, 13);
            this.Akkihiinfo.TabIndex = 12;
            this.Akkihiinfo.Text = "Akkihi.info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.Akkihiinfo);
            this.Controls.Add(this.Timer_Label);
            this.Controls.Add(this.ResumeSearch_Btn);
            this.Controls.Add(this.StopSearch_Btn);
            this.Controls.Add(this.Filename_Label);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.WordinFile_Text);
            this.Controls.Add(this.Filename_Btn);
            this.Controls.Add(this.Path_Btn);
            this.Controls.Add(this.Filename_Text);
            this.Controls.Add(this.Path_Text);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 530);
            this.MinimumSize = new System.Drawing.Size(800, 530);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск файлов по критериям";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path_Text;
        private System.Windows.Forms.TextBox Filename_Text;
        private System.Windows.Forms.Button Path_Btn;
        private System.Windows.Forms.Button Filename_Btn;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.TextBox WordinFile_Text;
        private System.Windows.Forms.Label Filename_Label;
        public System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Button StopSearch_Btn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Timer_Label;
        public System.Windows.Forms.Button ResumeSearch_Btn;
        private System.Windows.Forms.Label Akkihiinfo;
    }
}

