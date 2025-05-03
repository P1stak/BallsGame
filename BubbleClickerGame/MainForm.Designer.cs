namespace BubbleClickerGame
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
            this.label_Rules = new System.Windows.Forms.Label();
            this.label_Show_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(367, 310);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Старт";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Rules
            // 
            this.label_Rules.AutoSize = true;
            this.label_Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Rules.Location = new System.Drawing.Point(216, 187);
            this.label_Rules.Name = "label_Rules";
            this.label_Rules.Size = new System.Drawing.Size(0, 16);
            this.label_Rules.TabIndex = 1;
            this.label_Rules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Show_Count
            // 
            this.label_Show_Count.AutoSize = true;
            this.label_Show_Count.Location = new System.Drawing.Point(691, 9);
            this.label_Show_Count.Name = "label_Show_Count";
            this.label_Show_Count.Size = new System.Drawing.Size(0, 13);
            this.label_Show_Count.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Show_Count);
            this.Controls.Add(this.label_Rules);
            this.Controls.Add(this.button_Start);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Rules;
        private System.Windows.Forms.Label label_Show_Count;
    }
}

