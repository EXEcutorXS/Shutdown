namespace ShutdownTimer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button30 = new System.Windows.Forms.Button();
            this.button60 = new System.Windows.Forms.Button();
            this.button90 = new System.Windows.Forms.Button();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button45 = new System.Windows.Forms.Button();
            this.button120 = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(12, 12);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 23);
            this.button30.TabIndex = 0;
            this.button30.Text = "30 минут";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.setTimer);
            // 
            // button60
            // 
            this.button60.Location = new System.Drawing.Point(174, 12);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(75, 23);
            this.button60.TabIndex = 1;
            this.button60.Text = "60 минут";
            this.button60.UseVisualStyleBackColor = true;
            this.button60.Click += new System.EventHandler(this.setTimer);
            // 
            // button90
            // 
            this.button90.Location = new System.Drawing.Point(255, 12);
            this.button90.Name = "button90";
            this.button90.Size = new System.Drawing.Size(75, 23);
            this.button90.TabIndex = 2;
            this.button90.Text = "90 минут";
            this.button90.UseVisualStyleBackColor = true;
            this.button90.Click += new System.EventHandler(this.setTimer);
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elapsedTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.elapsedTime.Location = new System.Drawing.Point(84, 55);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(254, 50);
            this.elapsedTime.TabIndex = 4;
            this.elapsedTime.Text = "00:00:00";
            this.elapsedTime.Click += new System.EventHandler(this.elapsedTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(93, 12);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(75, 23);
            this.button45.TabIndex = 6;
            this.button45.Text = "45 минут";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.setTimer);
            // 
            // button120
            // 
            this.button120.Location = new System.Drawing.Point(336, 12);
            this.button120.Name = "button120";
            this.button120.Size = new System.Drawing.Size(75, 23);
            this.button120.TabIndex = 9;
            this.button120.Text = "120 минут";
            this.button120.UseVisualStyleBackColor = true;
            this.button120.Click += new System.EventHandler(this.setTimer);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "ИКОНКА!!!1АДИН";
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 114);
            this.Controls.Add(this.button120);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.elapsedTime);
            this.Controls.Add(this.button90);
            this.Controls.Add(this.button60);
            this.Controls.Add(this.button30);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Таймер сна";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button60;
        private System.Windows.Forms.Button button90;
        private System.Windows.Forms.Label elapsedTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button120;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}

