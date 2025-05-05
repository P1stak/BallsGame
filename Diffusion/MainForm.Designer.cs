namespace Diffusion
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
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.label_BlueLeft = new System.Windows.Forms.Label();
            this.label_BlueRight = new System.Windows.Forms.Label();
            this.label_PinkLeft = new System.Windows.Forms.Label();
            this.label_PinkRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(12, 12);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Старт";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(713, 12);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 1;
            this.button_Stop.Text = "Стоп";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // label_BlueLeft
            // 
            this.label_BlueLeft.Location = new System.Drawing.Point(734, 334);
            this.label_BlueLeft.Name = "label_BlueLeft";
            this.label_BlueLeft.Size = new System.Drawing.Size(100, 23);
            this.label_BlueLeft.TabIndex = 2;
            this.label_BlueLeft.Text = "0";
            // 
            // label_BlueRight
            // 
            this.label_BlueRight.AutoSize = true;
            this.label_BlueRight.Location = new System.Drawing.Point(734, 361);
            this.label_BlueRight.Name = "label_BlueRight";
            this.label_BlueRight.Size = new System.Drawing.Size(13, 13);
            this.label_BlueRight.TabIndex = 3;
            this.label_BlueRight.Text = "0";
            // 
            // label_PinkLeft
            // 
            this.label_PinkLeft.AutoSize = true;
            this.label_PinkLeft.Location = new System.Drawing.Point(734, 389);
            this.label_PinkLeft.Name = "label_PinkLeft";
            this.label_PinkLeft.Size = new System.Drawing.Size(13, 13);
            this.label_PinkLeft.TabIndex = 4;
            this.label_PinkLeft.Text = "0";
            // 
            // label_PinkRight
            // 
            this.label_PinkRight.AutoSize = true;
            this.label_PinkRight.Location = new System.Drawing.Point(734, 415);
            this.label_PinkRight.Name = "label_PinkRight";
            this.label_PinkRight.Size = new System.Drawing.Size(13, 13);
            this.label_PinkRight.TabIndex = 5;
            this.label_PinkRight.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_PinkRight);
            this.Controls.Add(this.label_PinkLeft);
            this.Controls.Add(this.label_BlueRight);
            this.Controls.Add(this.label_BlueLeft);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label_BlueLeft;
        private System.Windows.Forms.Label label_BlueRight;
        private System.Windows.Forms.Label label_PinkLeft;
        private System.Windows.Forms.Label label_PinkRight;
    }
}

