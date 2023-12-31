﻿namespace FlyffServerManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btn_stopServer = new Button();
            textBox_Account = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_Certifier = new TextBox();
            label3 = new Label();
            textBox_Core = new TextBox();
            label4 = new Label();
            textBox_Database = new TextBox();
            label5 = new Label();
            textBox_World = new TextBox();
            label6 = new Label();
            textBox_Cache = new TextBox();
            label7 = new Label();
            textBox_Login = new TextBox();
            Status_Account = new Panel();
            Status_Certifier = new Panel();
            Status_Database = new Panel();
            Status_Core = new Panel();
            Status_Login = new Panel();
            Status_Cache = new Panel();
            Status_World = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            button_client_ini = new Button();
            Status_Client = new Panel();
            label8 = new Label();
            textBox_Client = new TextBox();
            button_account_ini = new Button();
            button_certifier_ini = new Button();
            button_database_ini = new Button();
            button_core_ini = new Button();
            button_login_ini = new Button();
            button_cache_ini = new Button();
            button_world_ini = new Button();
            groupBox2 = new GroupBox();
            button6 = new Button();
            textBox_waitingTime = new TextBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(28, 430);
            button1.Name = "button1";
            button1.Size = new Size(119, 45);
            button1.TabIndex = 0;
            button1.Text = "Start Server";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_stopServer
            // 
            btn_stopServer.BackColor = Color.Salmon;
            btn_stopServer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stopServer.Location = new Point(153, 430);
            btn_stopServer.Name = "btn_stopServer";
            btn_stopServer.Size = new Size(119, 45);
            btn_stopServer.TabIndex = 1;
            btn_stopServer.Text = "Stop Server";
            btn_stopServer.UseVisualStyleBackColor = false;
            btn_stopServer.Click += btn_stopServer_Click;
            // 
            // textBox_Account
            // 
            textBox_Account.Location = new Point(28, 108);
            textBox_Account.Name = "textBox_Account";
            textBox_Account.Size = new Size(341, 23);
            textBox_Account.TabIndex = 2;
            textBox_Account.TextChanged += textBox_Account_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 90);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "Account Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 136);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Certifier";
            // 
            // textBox_Certifier
            // 
            textBox_Certifier.Location = new Point(28, 154);
            textBox_Certifier.Name = "textBox_Certifier";
            textBox_Certifier.Size = new Size(341, 23);
            textBox_Certifier.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 228);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 9;
            label3.Text = "Core";
            // 
            // textBox_Core
            // 
            textBox_Core.Location = new Point(28, 246);
            textBox_Core.Name = "textBox_Core";
            textBox_Core.Size = new Size(341, 23);
            textBox_Core.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 182);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Database";
            // 
            // textBox_Database
            // 
            textBox_Database.Location = new Point(28, 200);
            textBox_Database.Name = "textBox_Database";
            textBox_Database.Size = new Size(341, 23);
            textBox_Database.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 367);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 15;
            label5.Text = "World";
            // 
            // textBox_World
            // 
            textBox_World.Location = new Point(28, 385);
            textBox_World.Name = "textBox_World";
            textBox_World.Size = new Size(341, 23);
            textBox_World.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 321);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 13;
            label6.Text = "Cache";
            // 
            // textBox_Cache
            // 
            textBox_Cache.Location = new Point(28, 339);
            textBox_Cache.Name = "textBox_Cache";
            textBox_Cache.Size = new Size(341, 23);
            textBox_Cache.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 275);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 11;
            label7.Text = "Login";
            // 
            // textBox_Login
            // 
            textBox_Login.Location = new Point(28, 293);
            textBox_Login.Name = "textBox_Login";
            textBox_Login.Size = new Size(341, 23);
            textBox_Login.TabIndex = 10;
            // 
            // Status_Account
            // 
            Status_Account.BackColor = Color.Red;
            Status_Account.Location = new Point(3, 110);
            Status_Account.Name = "Status_Account";
            Status_Account.Size = new Size(19, 20);
            Status_Account.TabIndex = 16;
            // 
            // Status_Certifier
            // 
            Status_Certifier.BackColor = Color.Red;
            Status_Certifier.Location = new Point(3, 154);
            Status_Certifier.Name = "Status_Certifier";
            Status_Certifier.Size = new Size(19, 20);
            Status_Certifier.TabIndex = 17;
            // 
            // Status_Database
            // 
            Status_Database.BackColor = Color.Red;
            Status_Database.Location = new Point(3, 200);
            Status_Database.Name = "Status_Database";
            Status_Database.Size = new Size(19, 20);
            Status_Database.TabIndex = 17;
            // 
            // Status_Core
            // 
            Status_Core.BackColor = Color.Red;
            Status_Core.Location = new Point(3, 246);
            Status_Core.Name = "Status_Core";
            Status_Core.Size = new Size(19, 20);
            Status_Core.TabIndex = 17;
            // 
            // Status_Login
            // 
            Status_Login.BackColor = Color.Red;
            Status_Login.Location = new Point(3, 293);
            Status_Login.Name = "Status_Login";
            Status_Login.Size = new Size(19, 20);
            Status_Login.TabIndex = 17;
            // 
            // Status_Cache
            // 
            Status_Cache.BackColor = Color.Red;
            Status_Cache.Location = new Point(3, 339);
            Status_Cache.Name = "Status_Cache";
            Status_Cache.Size = new Size(19, 20);
            Status_Cache.TabIndex = 17;
            // 
            // Status_World
            // 
            Status_World.BackColor = Color.Red;
            Status_World.Location = new Point(3, 385);
            Status_World.Name = "Status_World";
            Status_World.Size = new Size(19, 20);
            Status_World.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(278, 430);
            button2.Name = "button2";
            button2.Size = new Size(119, 45);
            button2.TabIndex = 18;
            button2.Text = "Restart Server";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(29, 89);
            button3.Name = "button3";
            button3.Size = new Size(119, 45);
            button3.TabIndex = 19;
            button3.Text = "Start Client";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(154, 89);
            button4.Name = "button4";
            button4.Size = new Size(119, 45);
            button4.TabIndex = 20;
            button4.Text = "Stop Client";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(279, 89);
            button5.Name = "button5";
            button5.Size = new Size(119, 45);
            button5.TabIndex = 21;
            button5.Text = "Restart Client";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_client_ini);
            groupBox1.Controls.Add(Status_Client);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox_Client);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(522, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 202);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client";
            // 
            // button_client_ini
            // 
            button_client_ini.Location = new Point(375, 34);
            button_client_ini.Name = "button_client_ini";
            button_client_ini.Size = new Size(43, 23);
            button_client_ini.TabIndex = 30;
            button_client_ini.Text = "ini";
            button_client_ini.UseVisualStyleBackColor = true;
            button_client_ini.Click += button_client_ini_Click;
            // 
            // Status_Client
            // 
            Status_Client.BackColor = Color.Red;
            Status_Client.Location = new Point(3, 36);
            Status_Client.Name = "Status_Client";
            Status_Client.Size = new Size(19, 20);
            Status_Client.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 16);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 24;
            label8.Text = "Client Path";
            // 
            // textBox_Client
            // 
            textBox_Client.Location = new Point(28, 34);
            textBox_Client.Name = "textBox_Client";
            textBox_Client.Size = new Size(341, 23);
            textBox_Client.TabIndex = 23;
            // 
            // button_account_ini
            // 
            button_account_ini.Location = new Point(375, 108);
            button_account_ini.Name = "button_account_ini";
            button_account_ini.Size = new Size(43, 23);
            button_account_ini.TabIndex = 23;
            button_account_ini.Text = "ini";
            button_account_ini.UseVisualStyleBackColor = true;
            button_account_ini.Click += button_account_ini_Click;
            // 
            // button_certifier_ini
            // 
            button_certifier_ini.Location = new Point(375, 154);
            button_certifier_ini.Name = "button_certifier_ini";
            button_certifier_ini.Size = new Size(43, 23);
            button_certifier_ini.TabIndex = 24;
            button_certifier_ini.Text = "ini";
            button_certifier_ini.UseVisualStyleBackColor = true;
            button_certifier_ini.Click += button_certifier_ini_Click;
            // 
            // button_database_ini
            // 
            button_database_ini.Location = new Point(375, 200);
            button_database_ini.Name = "button_database_ini";
            button_database_ini.Size = new Size(43, 23);
            button_database_ini.TabIndex = 25;
            button_database_ini.Text = "ini";
            button_database_ini.UseVisualStyleBackColor = true;
            button_database_ini.Click += button_database_ini_Click;
            // 
            // button_core_ini
            // 
            button_core_ini.Location = new Point(375, 246);
            button_core_ini.Name = "button_core_ini";
            button_core_ini.Size = new Size(43, 23);
            button_core_ini.TabIndex = 26;
            button_core_ini.Text = "ini";
            button_core_ini.UseVisualStyleBackColor = true;
            button_core_ini.Click += button_core_ini_Click;
            // 
            // button_login_ini
            // 
            button_login_ini.Location = new Point(375, 293);
            button_login_ini.Name = "button_login_ini";
            button_login_ini.Size = new Size(43, 23);
            button_login_ini.TabIndex = 27;
            button_login_ini.Text = "ini";
            button_login_ini.UseVisualStyleBackColor = true;
            button_login_ini.Click += button_login_ini_Click;
            // 
            // button_cache_ini
            // 
            button_cache_ini.Location = new Point(375, 339);
            button_cache_ini.Name = "button_cache_ini";
            button_cache_ini.Size = new Size(43, 23);
            button_cache_ini.TabIndex = 28;
            button_cache_ini.Text = "ini";
            button_cache_ini.UseVisualStyleBackColor = true;
            button_cache_ini.Click += button_cache_ini_Click;
            // 
            // button_world_ini
            // 
            button_world_ini.Location = new Point(375, 385);
            button_world_ini.Name = "button_world_ini";
            button_world_ini.Size = new Size(43, 23);
            button_world_ini.TabIndex = 29;
            button_world_ini.Text = "ini";
            button_world_ini.UseVisualStyleBackColor = true;
            button_world_ini.Click += button_world_ini_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_waitingTime);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox_Account);
            groupBox2.Controls.Add(button_world_ini);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button_cache_ini);
            groupBox2.Controls.Add(btn_stopServer);
            groupBox2.Controls.Add(button_login_ini);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button_core_ini);
            groupBox2.Controls.Add(textBox_Certifier);
            groupBox2.Controls.Add(button_database_ini);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button_certifier_ini);
            groupBox2.Controls.Add(textBox_Database);
            groupBox2.Controls.Add(button_account_ini);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox_Core);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Status_World);
            groupBox2.Controls.Add(textBox_Login);
            groupBox2.Controls.Add(Status_Cache);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(Status_Login);
            groupBox2.Controls.Add(textBox_Cache);
            groupBox2.Controls.Add(Status_Core);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(Status_Database);
            groupBox2.Controls.Add(textBox_World);
            groupBox2.Controls.Add(Status_Certifier);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(Status_Account);
            groupBox2.Location = new Point(12, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 572);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Server";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(6, 79);
            button6.Name = "button6";
            button6.Size = new Size(139, 51);
            button6.TabIndex = 32;
            button6.Text = "Update Config File";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox_waitingTime
            // 
            textBox_waitingTime.Location = new Point(6, 39);
            textBox_waitingTime.Name = "textBox_waitingTime";
            textBox_waitingTime.Size = new Size(100, 23);
            textBox_waitingTime.TabIndex = 31;
            textBox_waitingTime.TextChanged += textBox_waitingTime_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 21);
            label9.Name = "label9";
            label9.Size = new Size(192, 15);
            label9.TabIndex = 30;
            label9.Text = "Waiting Time Between Server Starts";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button6);
            groupBox3.Location = new Point(525, 409);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(461, 201);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tool";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(6, 22);
            button7.Name = "button7";
            button7.Size = new Size(139, 51);
            button7.TabIndex = 33;
            button7.Text = "Open Config";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 608);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Main";
            Text = "Flyff Server Manager";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btn_stopServer;
        private TextBox textBox_Account;
        private Label label1;
        private Label label2;
        private TextBox textBox_Certifier;
        private Label label3;
        private TextBox textBox_Core;
        private Label label4;
        private TextBox textBox_Database;
        private Label label5;
        private TextBox textBox_World;
        private Label label6;
        private TextBox textBox_Cache;
        private Label label7;
        private TextBox textBox_Login;
        private Panel Status_Account;
        private Panel Status_Certifier;
        private Panel Status_Database;
        private Panel Status_Core;
        private Panel Status_Login;
        private Panel Status_Cache;
        private Panel Status_World;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private Panel Status_Client;
        private Label label8;
        private TextBox textBox_Client;
        private Button button_account_ini;
        private Button button_certifier_ini;
        private Button button_database_ini;
        private Button button_core_ini;
        private Button button_login_ini;
        private Button button_cache_ini;
        private Button button_client_ini;
        private Button button_world_ini;
        private GroupBox groupBox2;
        private TextBox textBox_waitingTime;
        private Label label9;
        private Button button6;
        private GroupBox groupBox3;
        private Button button7;
    }
}