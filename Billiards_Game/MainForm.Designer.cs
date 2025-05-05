namespace Billiards_Game
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
            this.label_Top = new System.Windows.Forms.Label();
            this.label_Right = new System.Windows.Forms.Label();
            this.label_Down = new System.Windows.Forms.Label();
            this.label_Left = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Top
            // 
            this.label_Top.AutoSize = true;
            this.label_Top.Location = new System.Drawing.Point(386, 13);
            this.label_Top.Name = "label_Top";
            this.label_Top.Size = new System.Drawing.Size(13, 13);
            this.label_Top.TabIndex = 0;
            this.label_Top.Text = "0";
            // 
            // label_Right
            // 
            this.label_Right.AutoSize = true;
            this.label_Right.Location = new System.Drawing.Point(753, 219);
            this.label_Right.Name = "label_Right";
            this.label_Right.Size = new System.Drawing.Size(13, 13);
            this.label_Right.TabIndex = 1;
            this.label_Right.Text = "0";
            // 
            // label_Down
            // 
            this.label_Down.AutoSize = true;
            this.label_Down.Location = new System.Drawing.Point(386, 428);
            this.label_Down.Name = "label_Down";
            this.label_Down.Size = new System.Drawing.Size(13, 13);
            this.label_Down.TabIndex = 2;
            this.label_Down.Text = "0";
            // 
            // label_Left
            // 
            this.label_Left.AutoSize = true;
            this.label_Left.Location = new System.Drawing.Point(12, 219);
            this.label_Left.Name = "label_Left";
            this.label_Left.Size = new System.Drawing.Size(13, 13);
            this.label_Left.TabIndex = 3;
            this.label_Left.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Left);
            this.Controls.Add(this.label_Down);
            this.Controls.Add(this.label_Right);
            this.Controls.Add(this.label_Top);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Top;
        private System.Windows.Forms.Label label_Right;
        private System.Windows.Forms.Label label_Down;
        private System.Windows.Forms.Label label_Left;
    }
}

