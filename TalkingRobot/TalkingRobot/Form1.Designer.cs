using System;
namespace TalkingRobot
{
    partial class Display
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.learn_abcd_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.color_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.image_type = new System.Windows.Forms.Panel();
            this.information_number = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.flags_Button = new System.Windows.Forms.Button();
            this.animal_button = new System.Windows.Forms.Button();
            this.repeat_button = new System.Windows.Forms.Button();
            this.repeat_texboxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.date_time = new System.Windows.Forms.Label();
            this.random_button = new System.Windows.Forms.Button();
            this.jump_comboox = new System.Windows.Forms.ComboBox();
            this.image_type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // learn_abcd_button
            // 
            this.learn_abcd_button.BackColor = System.Drawing.Color.Transparent;
            this.learn_abcd_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.learn_abcd_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.learn_abcd_button.Location = new System.Drawing.Point(470, 82);
            this.learn_abcd_button.Name = "learn_abcd_button";
            this.learn_abcd_button.Size = new System.Drawing.Size(99, 23);
            this.learn_abcd_button.TabIndex = 2;
            this.learn_abcd_button.Text = "LEARN ABCD";
            this.learn_abcd_button.UseVisualStyleBackColor = false;
            this.learn_abcd_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(470, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "LEARN 1234";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // color_button
            // 
            this.color_button.BackColor = System.Drawing.Color.Transparent;
            this.color_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_button.Location = new System.Drawing.Point(470, 140);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(99, 23);
            this.color_button.TabIndex = 4;
            this.color_button.Text = "COLORS";
            this.color_button.UseVisualStyleBackColor = false;
            this.color_button.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(470, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "EXIT CLASS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(768, 382);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "READ BLACKBOARD";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(470, 341);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "PAUSE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(928, 382);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "CLEAR";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(236, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "contact : suryawanshi.praveen007@gmail.com";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(575, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(586, 297);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "blackboard";
            this.richTextBox1.ZoomFactor = 3F;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // image_type
            // 
            this.image_type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.image_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image_type.Controls.Add(this.information_number);
            this.image_type.Location = new System.Drawing.Point(575, 79);
            this.image_type.Name = "image_type";
            this.image_type.Size = new System.Drawing.Size(586, 431);
            this.image_type.TabIndex = 14;
            this.image_type.Visible = false;
            this.image_type.Paint += new System.Windows.Forms.PaintEventHandler(this.image_type_Paint);
            // 
            // information_number
            // 
            this.information_number.AutoSize = true;
            this.information_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_number.ForeColor = System.Drawing.Color.Red;
            this.information_number.Location = new System.Drawing.Point(206, 71);
            this.information_number.Name = "information_number";
            this.information_number.Size = new System.Drawing.Size(99, 108);
            this.information_number.TabIndex = 0;
            this.information_number.Text = "1";
            this.information_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information.ForeColor = System.Drawing.Color.Red;
            this.information.Location = new System.Drawing.Point(568, 37);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(309, 39);
            this.information.TabIndex = 15;
            this.information.Text = "TALKING ROBOT";
            // 
            // flags_Button
            // 
            this.flags_Button.BackColor = System.Drawing.Color.White;
            this.flags_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flags_Button.Location = new System.Drawing.Point(470, 169);
            this.flags_Button.Name = "flags_Button";
            this.flags_Button.Size = new System.Drawing.Size(99, 23);
            this.flags_Button.TabIndex = 18;
            this.flags_Button.Text = "FLAGS";
            this.flags_Button.UseVisualStyleBackColor = false;
            this.flags_Button.Click += new System.EventHandler(this.flags_Button_Click);
            // 
            // animal_button
            // 
            this.animal_button.BackColor = System.Drawing.Color.White;
            this.animal_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animal_button.Location = new System.Drawing.Point(470, 198);
            this.animal_button.Name = "animal_button";
            this.animal_button.Size = new System.Drawing.Size(99, 23);
            this.animal_button.TabIndex = 19;
            this.animal_button.Text = "ANIMALS";
            this.animal_button.UseVisualStyleBackColor = false;
            this.animal_button.Click += new System.EventHandler(this.animal_button_Click);
            // 
            // repeat_button
            // 
            this.repeat_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeat_button.Location = new System.Drawing.Point(470, 284);
            this.repeat_button.Name = "repeat_button";
            this.repeat_button.Size = new System.Drawing.Size(99, 23);
            this.repeat_button.TabIndex = 20;
            this.repeat_button.Text = "REPEAT";
            this.repeat_button.UseVisualStyleBackColor = true;
            this.repeat_button.Click += new System.EventHandler(this.repeat_button_Click);
            // 
            // repeat_texboxt
            // 
            this.repeat_texboxt.Location = new System.Drawing.Point(470, 258);
            this.repeat_texboxt.Name = "repeat_texboxt";
            this.repeat_texboxt.Size = new System.Drawing.Size(99, 20);
            this.repeat_texboxt.TabIndex = 21;
            this.repeat_texboxt.Text = "1";
            this.repeat_texboxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TalkingRobot.Properties.Resources.Iron_Man4_Avengers;
            this.pictureBox1.Location = new System.Drawing.Point(2, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 512);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TalkingRobot.Properties.Resources.iron_man_clip_art_184084;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(462, 500);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.Color.Red;
            this.user_name.Location = new System.Drawing.Point(575, 14);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(149, 22);
            this.user_name.TabIndex = 24;
            this.user_name.Text = "enter your name";
            // 
            // date_time
            // 
            this.date_time.AutoSize = true;
            this.date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time.ForeColor = System.Drawing.Color.Red;
            this.date_time.Location = new System.Drawing.Point(730, 17);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(89, 16);
            this.date_time.TabIndex = 25;
            this.date_time.Text = "DATE TIME";
            this.date_time.Click += new System.EventHandler(this.date_time_Click);
            // 
            // random_button
            // 
            this.random_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.random_button.Location = new System.Drawing.Point(470, 229);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(99, 23);
            this.random_button.TabIndex = 26;
            this.random_button.Text = "ALL";
            this.random_button.UseVisualStyleBackColor = true;
            this.random_button.Click += new System.EventHandler(this.random_button_Click);
            // 
            // jump_comboox
            // 
            this.jump_comboox.ForeColor = System.Drawing.Color.Red;
            this.jump_comboox.FormattingEnabled = true;
            this.jump_comboox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E ",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.jump_comboox.Location = new System.Drawing.Point(471, 314);
            this.jump_comboox.Name = "jump_comboox";
            this.jump_comboox.Size = new System.Drawing.Size(98, 21);
            this.jump_comboox.TabIndex = 27;
            this.jump_comboox.Text = "JUMP";
            this.jump_comboox.SelectedIndexChanged += new System.EventHandler(this.jump_comboox_SelectedIndexChanged);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 522);
            this.Controls.Add(this.jump_comboox);
            this.Controls.Add(this.random_button);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.repeat_texboxt);
            this.Controls.Add(this.repeat_button);
            this.Controls.Add(this.animal_button);
            this.Controls.Add(this.flags_Button);
            this.Controls.Add(this.information);
            this.Controls.Add(this.image_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.color_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.learn_abcd_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAKING ROBOT";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Display_Load);
            this.image_type.ResumeLayout(false);
            this.image_type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click_2(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void richTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

       private void image_type_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button learn_abcd_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel image_type;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Button flags_Button;
        private System.Windows.Forms.Button animal_button;
        private System.Windows.Forms.Button repeat_button;
        private System.Windows.Forms.TextBox repeat_texboxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label information_number;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label date_time;
        private System.Windows.Forms.Button random_button;
        private System.Windows.Forms.ComboBox jump_comboox;
    }
}

