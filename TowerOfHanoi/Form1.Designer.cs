
namespace TowerOfHanoi
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.takeButton1 = new System.Windows.Forms.Button();
            this.takeButton2 = new System.Windows.Forms.Button();
            this.takeButton3 = new System.Windows.Forms.Button();
            this.putButton1 = new System.Windows.Forms.Button();
            this.putButton2 = new System.Windows.Forms.Button();
            this.putButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // takeButton1
            // 
            this.takeButton1.Location = new System.Drawing.Point(35, 360);
            this.takeButton1.Name = "takeButton1";
            this.takeButton1.Size = new System.Drawing.Size(100, 50);
            this.takeButton1.TabIndex = 4;
            this.takeButton1.Text = "Take";
            this.takeButton1.UseVisualStyleBackColor = true;
            this.takeButton1.Visible = false;
            this.takeButton1.Click += new System.EventHandler(this.takeButtons_Click);
            // 
            // takeButton2
            // 
            this.takeButton2.Location = new System.Drawing.Point(205, 360);
            this.takeButton2.Name = "takeButton2";
            this.takeButton2.Size = new System.Drawing.Size(100, 50);
            this.takeButton2.TabIndex = 5;
            this.takeButton2.Text = "Take";
            this.takeButton2.UseVisualStyleBackColor = true;
            this.takeButton2.Visible = false;
            this.takeButton2.Click += new System.EventHandler(this.takeButtons_Click);
            // 
            // takeButton3
            // 
            this.takeButton3.Location = new System.Drawing.Point(375, 360);
            this.takeButton3.Name = "takeButton3";
            this.takeButton3.Size = new System.Drawing.Size(100, 50);
            this.takeButton3.TabIndex = 6;
            this.takeButton3.Text = "Take";
            this.takeButton3.UseVisualStyleBackColor = true;
            this.takeButton3.Visible = false;
            this.takeButton3.Click += new System.EventHandler(this.takeButtons_Click);
            // 
            // putButton1
            // 
            this.putButton1.Location = new System.Drawing.Point(35, 360);
            this.putButton1.Name = "putButton1";
            this.putButton1.Size = new System.Drawing.Size(100, 50);
            this.putButton1.TabIndex = 7;
            this.putButton1.Text = "Put";
            this.putButton1.UseVisualStyleBackColor = true;
            this.putButton1.Visible = false;
            this.putButton1.Click += new System.EventHandler(this.putButtons_Click);
            // 
            // putButton2
            // 
            this.putButton2.Location = new System.Drawing.Point(205, 360);
            this.putButton2.Name = "putButton2";
            this.putButton2.Size = new System.Drawing.Size(100, 50);
            this.putButton2.TabIndex = 8;
            this.putButton2.Text = "Put";
            this.putButton2.UseVisualStyleBackColor = true;
            this.putButton2.Visible = false;
            this.putButton2.Click += new System.EventHandler(this.putButtons_Click);
            // 
            // putButton3
            // 
            this.putButton3.Location = new System.Drawing.Point(375, 360);
            this.putButton3.Name = "putButton3";
            this.putButton3.Size = new System.Drawing.Size(100, 50);
            this.putButton3.TabIndex = 9;
            this.putButton3.Text = "Put";
            this.putButton3.UseVisualStyleBackColor = true;
            this.putButton3.Visible = false;
            this.putButton3.Click += new System.EventHandler(this.putButtons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(175, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Шагов: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.putButton3);
            this.Controls.Add(this.putButton2);
            this.Controls.Add(this.putButton1);
            this.Controls.Add(this.takeButton3);
            this.Controls.Add(this.takeButton2);
            this.Controls.Add(this.takeButton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ханойские башни";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button takeButton1;
        private System.Windows.Forms.Button takeButton2;
        private System.Windows.Forms.Button takeButton3;
        private System.Windows.Forms.Button putButton1;
        private System.Windows.Forms.Button putButton2;
        private System.Windows.Forms.Button putButton3;
        private System.Windows.Forms.Label label1;
    }
}

