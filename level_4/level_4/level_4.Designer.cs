
namespace level_4
{
    partial class level_4
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
            this.button_check = new System.Windows.Forms.Button();
            this.textBox_answer1 = new System.Windows.Forms.TextBox();
            this.textBox_answer2 = new System.Windows.Forms.TextBox();
            this.textBox_answer3 = new System.Windows.Forms.TextBox();
            this.textBox_answer4 = new System.Windows.Forms.TextBox();
            this.textBox_answer5 = new System.Windows.Forms.TextBox();
            this.label_final = new System.Windows.Forms.Label();
            this.pictureBox_belka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_belka)).BeginInit();
            this.SuspendLayout();
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(865, 100);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(141, 31);
            this.button_check.TabIndex = 0;
            this.button_check.Text = "Проверить";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // textBox_answer1
            // 
            this.textBox_answer1.Location = new System.Drawing.Point(672, 50);
            this.textBox_answer1.Name = "textBox_answer1";
            this.textBox_answer1.Size = new System.Drawing.Size(141, 23);
            this.textBox_answer1.TabIndex = 1;
            // 
            // textBox_answer2
            // 
            this.textBox_answer2.Location = new System.Drawing.Point(672, 79);
            this.textBox_answer2.Name = "textBox_answer2";
            this.textBox_answer2.Size = new System.Drawing.Size(141, 23);
            this.textBox_answer2.TabIndex = 2;
            // 
            // textBox_answer3
            // 
            this.textBox_answer3.Location = new System.Drawing.Point(672, 108);
            this.textBox_answer3.Name = "textBox_answer3";
            this.textBox_answer3.Size = new System.Drawing.Size(141, 23);
            this.textBox_answer3.TabIndex = 3;
            // 
            // textBox_answer4
            // 
            this.textBox_answer4.Location = new System.Drawing.Point(672, 137);
            this.textBox_answer4.Name = "textBox_answer4";
            this.textBox_answer4.Size = new System.Drawing.Size(141, 23);
            this.textBox_answer4.TabIndex = 4;
            // 
            // textBox_answer5
            // 
            this.textBox_answer5.Location = new System.Drawing.Point(672, 166);
            this.textBox_answer5.Name = "textBox_answer5";
            this.textBox_answer5.Size = new System.Drawing.Size(141, 23);
            this.textBox_answer5.TabIndex = 5;
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_final.Location = new System.Drawing.Point(275, 294);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(0, 20);
            this.label_final.TabIndex = 6;
            // 
            // pictureBox_belka
            // 
            this.pictureBox_belka.Location = new System.Drawing.Point(779, 233);
            this.pictureBox_belka.Name = "pictureBox_belka";
            this.pictureBox_belka.Size = new System.Drawing.Size(280, 350);
            this.pictureBox_belka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_belka.TabIndex = 7;
            this.pictureBox_belka.TabStop = false;
            this.pictureBox_belka.Click += new System.EventHandler(this.pictureBox_belka_Click);
            // 
            // level_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1094, 627);
            this.Controls.Add(this.pictureBox_belka);
            this.Controls.Add(this.label_final);
            this.Controls.Add(this.textBox_answer5);
            this.Controls.Add(this.textBox_answer4);
            this.Controls.Add(this.textBox_answer3);
            this.Controls.Add(this.textBox_answer2);
            this.Controls.Add(this.textBox_answer1);
            this.Controls.Add(this.button_check);
            this.Name = "level_4";
            this.Text = "Уровень 4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_belka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.TextBox textBox_answer1;
        private System.Windows.Forms.TextBox textBox_answer2;
        private System.Windows.Forms.TextBox textBox_answer3;
        private System.Windows.Forms.TextBox textBox_answer4;
        //private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox_answer5;
        private System.Windows.Forms.Label label_final;
        private System.Windows.Forms.PictureBox pictureBox_belka;
    }
}

