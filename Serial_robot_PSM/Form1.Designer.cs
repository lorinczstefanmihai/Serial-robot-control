namespace Serial_robot_PSM
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
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_height = new System.Windows.Forms.RadioButton();
            this.radioButton_right = new System.Windows.Forms.RadioButton();
            this.radioButton_left = new System.Windows.Forms.RadioButton();
            this.ScrollBar_left = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScrollBar_right = new System.Windows.Forms.HScrollBar();
            this.button_send = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.port_select = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_valoare_right = new System.Windows.Forms.Label();
            this.label_valoare_left = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.label_valoare_height = new System.Windows.Forms.Label();
            this.ScrollBar_height = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.control_scroll = new System.Windows.Forms.RadioButton();
            this.istoric_comenzi = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_send
            // 
            this.textBox_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_send.Location = new System.Drawing.Point(693, 124);
            this.textBox_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(256, 38);
            this.textBox_send.TabIndex = 0;
            this.textBox_send.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_height);
            this.groupBox1.Controls.Add(this.radioButton_right);
            this.groupBox1.Controls.Add(this.radioButton_left);
            this.groupBox1.Location = new System.Drawing.Point(497, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(189, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alegere brat:";
            // 
            // radioButton_height
            // 
            this.radioButton_height.AutoSize = true;
            this.radioButton_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_height.Location = new System.Drawing.Point(37, 181);
            this.radioButton_height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_height.Name = "radioButton_height";
            this.radioButton_height.Size = new System.Drawing.Size(147, 40);
            this.radioButton_height.TabIndex = 2;
            this.radioButton_height.TabStop = true;
            this.radioButton_height.Text = "HEIGHT";
            this.radioButton_height.UseVisualStyleBackColor = true;
            // 
            // radioButton_right
            // 
            this.radioButton_right.AutoSize = true;
            this.radioButton_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_right.Location = new System.Drawing.Point(37, 103);
            this.radioButton_right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_right.Name = "radioButton_right";
            this.radioButton_right.Size = new System.Drawing.Size(128, 40);
            this.radioButton_right.TabIndex = 1;
            this.radioButton_right.TabStop = true;
            this.radioButton_right.Text = "RIGHT";
            this.radioButton_right.UseVisualStyleBackColor = true;
            // 
            // radioButton_left
            // 
            this.radioButton_left.AutoSize = true;
            this.radioButton_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_left.Location = new System.Drawing.Point(37, 30);
            this.radioButton_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_left.Name = "radioButton_left";
            this.radioButton_left.Size = new System.Drawing.Size(109, 40);
            this.radioButton_left.TabIndex = 0;
            this.radioButton_left.TabStop = true;
            this.radioButton_left.Text = "LEFT";
            this.radioButton_left.UseVisualStyleBackColor = true;
            // 
            // ScrollBar_left
            // 
            this.ScrollBar_left.Enabled = false;
            this.ScrollBar_left.LargeChange = 1;
            this.ScrollBar_left.Location = new System.Drawing.Point(189, 412);
            this.ScrollBar_left.Maximum = 1020;
            this.ScrollBar_left.Name = "ScrollBar_left";
            this.ScrollBar_left.Size = new System.Drawing.Size(549, 44);
            this.ScrollBar_left.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "LEFT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "RIGHT:";
            // 
            // ScrollBar_right
            // 
            this.ScrollBar_right.Enabled = false;
            this.ScrollBar_right.Location = new System.Drawing.Point(189, 489);
            this.ScrollBar_right.Maximum = 2100;
            this.ScrollBar_right.Minimum = 1050;
            this.ScrollBar_right.Name = "ScrollBar_right";
            this.ScrollBar_right.Size = new System.Drawing.Size(549, 44);
            this.ScrollBar_right.TabIndex = 4;
            this.ScrollBar_right.Value = 1050;
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(759, 182);
            this.button_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(133, 59);
            this.button_send.TabIndex = 7;
            this.button_send.Text = "SEND";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // port_select
            // 
            this.port_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_select.FormattingEnabled = true;
            this.port_select.Location = new System.Drawing.Point(51, 126);
            this.port_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.port_select.Name = "port_select";
            this.port_select.Size = new System.Drawing.Size(135, 37);
            this.port_select.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "COM SELECT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(45, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Control robot scrollBar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(491, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Control robot numeric:";
            // 
            // button_connect
            // 
            this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect.Location = new System.Drawing.Point(223, 114);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(143, 64);
            this.button_connect.TabIndex = 12;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label_valoare_right
            // 
            this.label_valoare_right.AutoSize = true;
            this.label_valoare_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valoare_right.Location = new System.Drawing.Point(804, 497);
            this.label_valoare_right.Name = "label_valoare_right";
            this.label_valoare_right.Size = new System.Drawing.Size(33, 36);
            this.label_valoare_right.TabIndex = 14;
            this.label_valoare_right.Text = "0";
            // 
            // label_valoare_left
            // 
            this.label_valoare_left.AutoSize = true;
            this.label_valoare_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valoare_left.Location = new System.Drawing.Point(804, 420);
            this.label_valoare_left.Name = "label_valoare_left";
            this.label_valoare_left.Size = new System.Drawing.Size(33, 36);
            this.label_valoare_left.TabIndex = 15;
            this.label_valoare_left.Text = "0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.Controls.Add(this.label_valoare_height);
            this.groupBox_menu.Controls.Add(this.ScrollBar_height);
            this.groupBox_menu.Controls.Add(this.label7);
            this.groupBox_menu.Controls.Add(this.radioButton3);
            this.groupBox_menu.Controls.Add(this.control_scroll);
            this.groupBox_menu.Controls.Add(this.label4);
            this.groupBox_menu.Controls.Add(this.label_valoare_left);
            this.groupBox_menu.Controls.Add(this.textBox_send);
            this.groupBox_menu.Controls.Add(this.label_valoare_right);
            this.groupBox_menu.Controls.Add(this.groupBox1);
            this.groupBox_menu.Controls.Add(this.button_connect);
            this.groupBox_menu.Controls.Add(this.ScrollBar_left);
            this.groupBox_menu.Controls.Add(this.label5);
            this.groupBox_menu.Controls.Add(this.label1);
            this.groupBox_menu.Controls.Add(this.label3);
            this.groupBox_menu.Controls.Add(this.ScrollBar_right);
            this.groupBox_menu.Controls.Add(this.label2);
            this.groupBox_menu.Controls.Add(this.port_select);
            this.groupBox_menu.Controls.Add(this.button_send);
            this.groupBox_menu.Location = new System.Drawing.Point(12, 12);
            this.groupBox_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_menu.Size = new System.Drawing.Size(957, 633);
            this.groupBox_menu.TabIndex = 16;
            this.groupBox_menu.TabStop = false;
            this.groupBox_menu.Text = "Menu";
            // 
            // label_valoare_height
            // 
            this.label_valoare_height.AutoSize = true;
            this.label_valoare_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valoare_height.Location = new System.Drawing.Point(804, 578);
            this.label_valoare_height.Name = "label_valoare_height";
            this.label_valoare_height.Size = new System.Drawing.Size(33, 36);
            this.label_valoare_height.TabIndex = 20;
            this.label_valoare_height.Text = "0";
            // 
            // ScrollBar_height
            // 
            this.ScrollBar_height.Enabled = false;
            this.ScrollBar_height.Location = new System.Drawing.Point(189, 570);
            this.ScrollBar_height.Maximum = 900;
            this.ScrollBar_height.Minimum = 500;
            this.ScrollBar_height.Name = "ScrollBar_height";
            this.ScrollBar_height.Size = new System.Drawing.Size(549, 44);
            this.ScrollBar_height.TabIndex = 18;
            this.ScrollBar_height.Value = 600;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "HEIGHT:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(861, 62);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // control_scroll
            // 
            this.control_scroll.AutoSize = true;
            this.control_scroll.Location = new System.Drawing.Point(429, 366);
            this.control_scroll.Margin = new System.Windows.Forms.Padding(4);
            this.control_scroll.Name = "control_scroll";
            this.control_scroll.Size = new System.Drawing.Size(17, 16);
            this.control_scroll.TabIndex = 16;
            this.control_scroll.TabStop = true;
            this.control_scroll.UseVisualStyleBackColor = true;
            // 
            // istoric_comenzi
            // 
            this.istoric_comenzi.FormattingEnabled = true;
            this.istoric_comenzi.ItemHeight = 16;
            this.istoric_comenzi.Location = new System.Drawing.Point(1020, 22);
            this.istoric_comenzi.Margin = new System.Windows.Forms.Padding(4);
            this.istoric_comenzi.Name = "istoric_comenzi";
            this.istoric_comenzi.Size = new System.Drawing.Size(163, 244);
            this.istoric_comenzi.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 655);
            this.Controls.Add(this.istoric_comenzi);
            this.Controls.Add(this.groupBox_menu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ROBOT_CONTROL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_right;
        private System.Windows.Forms.RadioButton radioButton_left;
        private System.Windows.Forms.HScrollBar ScrollBar_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar ScrollBar_right;
        private System.Windows.Forms.Button button_send;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox port_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_valoare_right;
        private System.Windows.Forms.Label label_valoare_left;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox_menu;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton control_scroll;
        private System.Windows.Forms.ListBox istoric_comenzi;
        private System.Windows.Forms.RadioButton radioButton_height;
        private System.Windows.Forms.Label label_valoare_height;
        private System.Windows.Forms.HScrollBar ScrollBar_height;
        private System.Windows.Forms.Label label7;
    }
}

