namespace Taskss
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
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.Location = new System.Drawing.Point(305, 114);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(120, 95);
            this.taskListBox.TabIndex = 0;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(305, 216);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(305, 242);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(229, 114);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "добавит";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(229, 156);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "удалит";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.taskListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
    }
}

