﻿
namespace WinFormsApp1
{
    partial class level_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level_1));
            this.text_box_answer = new System.Windows.Forms.TextBox();
            this.label_riddle = new System.Windows.Forms.Label();
            this.label_bool_answer = new System.Windows.Forms.Label();
            this.btn_result = new System.Windows.Forms.Button();
            this.Xback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_help = new System.Windows.Forms.Label();
            this.pictureBox_belka = new System.Windows.Forms.PictureBox();
            this.pictureBox_nut = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.sver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_belka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nut)).BeginInit();
            this.SuspendLayout();
            // 
            // text_box_answer
            // 
            this.text_box_answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.text_box_answer.Location = new System.Drawing.Point(613, 80);
            this.text_box_answer.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_answer.Name = "text_box_answer";
            this.text_box_answer.Size = new System.Drawing.Size(221, 23);
            this.text_box_answer.TabIndex = 0;
            // 
            // label_riddle
            // 
            this.label_riddle.AutoSize = true;
            this.label_riddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_riddle.Location = new System.Drawing.Point(41, 32);
            this.label_riddle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_riddle.Name = "label_riddle";
            this.label_riddle.Size = new System.Drawing.Size(49, 18);
            this.label_riddle.TabIndex = 1;
            this.label_riddle.Text = "Riddle";
            // 
            // label_bool_answer
            // 
            this.label_bool_answer.AutoSize = true;
            this.label_bool_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_bool_answer.Location = new System.Drawing.Point(361, 51);
            this.label_bool_answer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_bool_answer.Name = "label_bool_answer";
            this.label_bool_answer.Size = new System.Drawing.Size(0, 18);
            this.label_bool_answer.TabIndex = 2;
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_result.Location = new System.Drawing.Point(843, 60);
            this.btn_result.Margin = new System.Windows.Forms.Padding(4);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(165, 56);
            this.btn_result.TabIndex = 3;
            this.btn_result.Text = "Проверить";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // Xback
            // 
            this.Xback.FlatAppearance.BorderSize = 2;
            this.Xback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Xback.ForeColor = System.Drawing.Color.Black;
            this.Xback.Location = new System.Drawing.Point(1060, 14);
            this.Xback.Margin = new System.Windows.Forms.Padding(4);
            this.Xback.Name = "Xback";
            this.Xback.Size = new System.Drawing.Size(35, 34);
            this.Xback.TabIndex = 4;
            this.Xback.Text = "X";
            this.Xback.UseVisualStyleBackColor = true;
            this.Xback.Click += new System.EventHandler(this.Xback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label_help);
            this.panel1.Controls.Add(this.pictureBox_belka);
            this.panel1.Controls.Add(this.btn_result);
            this.panel1.Controls.Add(this.label_bool_answer);
            this.panel1.Controls.Add(this.label_riddle);
            this.panel1.Controls.Add(this.text_box_answer);
            this.panel1.Location = new System.Drawing.Point(14, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 540);
            this.panel1.TabIndex = 5;
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_help.Location = new System.Drawing.Point(563, 191);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(0, 18);
            this.label_help.TabIndex = 5;
            // 
            // pictureBox_belka
            // 
            this.pictureBox_belka.Location = new System.Drawing.Point(768, 143);
            this.pictureBox_belka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_belka.Name = "pictureBox_belka";
            this.pictureBox_belka.Size = new System.Drawing.Size(291, 368);
            this.pictureBox_belka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_belka.TabIndex = 4;
            this.pictureBox_belka.TabStop = false;
            this.pictureBox_belka.Click += new System.EventHandler(this.pictureBox_belka_Click);
            // 
            // pictureBox_nut
            // 
            this.pictureBox_nut.Location = new System.Drawing.Point(31, 14);
            this.pictureBox_nut.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_nut.Name = "pictureBox_nut";
            this.pictureBox_nut.Size = new System.Drawing.Size(73, 69);
            this.pictureBox_nut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_nut.TabIndex = 7;
            this.pictureBox_nut.TabStop = false;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(435, 32);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(204, 37);
            this.email.TabIndex = 8;
            this.email.Text = "УРОВЕНЬ 1";
            // 
            // menu
            // 
            this.menu.FlatAppearance.BorderSize = 2;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu.ForeColor = System.Drawing.Color.Black;
            this.menu.Location = new System.Drawing.Point(910, 14);
            this.menu.Margin = new System.Windows.Forms.Padding(4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(102, 34);
            this.menu.TabIndex = 9;
            this.menu.Text = "МЕНЮ";
            this.menu.UseVisualStyleBackColor = true;
            // 
            // sver
            // 
            this.sver.FlatAppearance.BorderSize = 2;
            this.sver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sver.ForeColor = System.Drawing.Color.Black;
            this.sver.Location = new System.Drawing.Point(1018, 14);
            this.sver.Margin = new System.Windows.Forms.Padding(4);
            this.sver.Name = "sver";
            this.sver.Size = new System.Drawing.Size(35, 34);
            this.sver.TabIndex = 16;
            this.sver.Text = "-";
            this.sver.UseVisualStyleBackColor = true;
            this.sver.Click += new System.EventHandler(this.sver_Click);
            // 
            // level_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1110, 666);
            this.Controls.Add(this.sver);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pictureBox_nut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Xback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1110, 666);
            this.Name = "level_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уровень 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_belka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_box_answer;
        private System.Windows.Forms.Label label_riddle;
        private System.Windows.Forms.Label label_bool_answer;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button Xback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_nut;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button sver;
        private System.Windows.Forms.PictureBox pictureBox_belka;
        private System.Windows.Forms.Label label_help;
    }
}

