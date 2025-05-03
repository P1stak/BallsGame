namespace BallsGame
{
    partial class MainForm
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
            this.button_Create_Balls = new System.Windows.Forms.Button();
            this.button_Stop_Balls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Create_Balls
            // 
            this.button_Create_Balls.Location = new System.Drawing.Point(643, 13);
            this.button_Create_Balls.Name = "button_Create_Balls";
            this.button_Create_Balls.Size = new System.Drawing.Size(62, 23);
            this.button_Create_Balls.TabIndex = 3;
            this.button_Create_Balls.Text = "Создать";
            this.button_Create_Balls.UseVisualStyleBackColor = true;
            this.button_Create_Balls.Click += new System.EventHandler(this.button_Create_Balls_Click);
            // 
            // button_Stop_Balls
            // 
            this.button_Stop_Balls.Location = new System.Drawing.Point(711, 12);
            this.button_Stop_Balls.Name = "button_Stop_Balls";
            this.button_Stop_Balls.Size = new System.Drawing.Size(77, 24);
            this.button_Stop_Balls.TabIndex = 5;
            this.button_Stop_Balls.Text = "Остановить";
            this.button_Stop_Balls.UseVisualStyleBackColor = true;
            this.button_Stop_Balls.Click += new System.EventHandler(this.button_Stop_Balls_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Stop_Balls);
            this.Controls.Add(this.button_Create_Balls);
            this.Name = "MainForm";
            this.Text = "Мячики";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Create_Balls;
        private System.Windows.Forms.Button button_Stop_Balls;
    }
}

