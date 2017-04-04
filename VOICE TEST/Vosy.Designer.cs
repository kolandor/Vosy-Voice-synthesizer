namespace VOICE_TEST
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSay = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            notifyIconMessage = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelVoices = new System.Windows.Forms.Label();
            this.comboBoxVoices = new System.Windows.Forms.ComboBox();
            this.trackBarVoiceSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVoiceSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSay
            // 
            this.buttonSay.Location = new System.Drawing.Point(12, 50);
            this.buttonSay.Name = "buttonSay";
            this.buttonSay.Size = new System.Drawing.Size(126, 25);
            this.buttonSay.TabIndex = 0;
            this.buttonSay.Text = "SAY";
            this.buttonSay.UseVisualStyleBackColor = true;
            this.buttonSay.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 34);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(66, 13);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "TEXT to say";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(144, 52);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // notifyIconMessage
            // 
            notifyIconMessage.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMessage.Icon")));
            notifyIconMessage.Text = "notifyIcon1";
            // 
            // mainText
            // 
            this.mainText.Location = new System.Drawing.Point(12, 82);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(872, 477);
            this.mainText.TabIndex = 6;
            this.mainText.Text = "Приветствую! Я голосовой синтезатор!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.authorsToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // labelVoices
            // 
            this.labelVoices.AutoSize = true;
            this.labelVoices.Location = new System.Drawing.Point(838, 38);
            this.labelVoices.Name = "labelVoices";
            this.labelVoices.Size = new System.Drawing.Size(46, 13);
            this.labelVoices.TabIndex = 3;
            this.labelVoices.Text = "VOICES";
            // 
            // comboBoxVoices
            // 
            this.comboBoxVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoices.FormattingEnabled = true;
            this.comboBoxVoices.Location = new System.Drawing.Point(624, 54);
            this.comboBoxVoices.Name = "comboBoxVoices";
            this.comboBoxVoices.Size = new System.Drawing.Size(260, 21);
            this.comboBoxVoices.TabIndex = 1;
            this.comboBoxVoices.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // trackBarVoiceSpeed
            // 
            this.trackBarVoiceSpeed.Location = new System.Drawing.Point(335, 38);
            this.trackBarVoiceSpeed.Minimum = -10;
            this.trackBarVoiceSpeed.Name = "trackBarVoiceSpeed";
            this.trackBarVoiceSpeed.Size = new System.Drawing.Size(270, 45);
            this.trackBarVoiceSpeed.TabIndex = 8;
            this.trackBarVoiceSpeed.Scroll += new System.EventHandler(this.trackBarVoiceSpeed_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(343, 66);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(68, 13);
            this.labelSpeed.TabIndex = 9;
            this.labelSpeed.Text = "Voice Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 564);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.trackBarVoiceSpeed);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelVoices);
            this.Controls.Add(this.comboBoxVoices);
            this.Controls.Add(this.buttonSay);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VOICE SYNTESIER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVoiceSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSay;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox mainText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.Label labelVoices;
        private System.Windows.Forms.ComboBox comboBoxVoices;
        private System.Windows.Forms.TrackBar trackBarVoiceSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private static System.Windows.Forms.NotifyIcon notifyIconMessage;
    }
}

