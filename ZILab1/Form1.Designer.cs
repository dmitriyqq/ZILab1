
namespace ZILab1
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
            this.encodeTextBox = new System.Windows.Forms.TextBox();
            this.decodeTextBox = new System.Windows.Forms.TextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.encodeComboBox = new System.Windows.Forms.ComboBox();
            this.decodeComboBox = new System.Windows.Forms.ComboBox();
            this.bytesTextBox = new System.Windows.Forms.TextBox();
            this.UpdateBytesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encodeTextBox
            // 
            this.encodeTextBox.Location = new System.Drawing.Point(12, 93);
            this.encodeTextBox.Multiline = true;
            this.encodeTextBox.Name = "encodeTextBox";
            this.encodeTextBox.Size = new System.Drawing.Size(391, 141);
            this.encodeTextBox.TabIndex = 0;
            // 
            // decodeTextBox
            // 
            this.decodeTextBox.Location = new System.Drawing.Point(409, 93);
            this.decodeTextBox.Multiline = true;
            this.decodeTextBox.Name = "decodeTextBox";
            this.decodeTextBox.Size = new System.Drawing.Size(379, 141);
            this.decodeTextBox.TabIndex = 1;
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(328, 52);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(75, 23);
            this.encodeButton.TabIndex = 2;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(409, 52);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 3;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // encodeComboBox
            // 
            this.encodeComboBox.FormattingEnabled = true;
            this.encodeComboBox.Location = new System.Drawing.Point(12, 52);
            this.encodeComboBox.Name = "encodeComboBox";
            this.encodeComboBox.Size = new System.Drawing.Size(121, 21);
            this.encodeComboBox.TabIndex = 4;
            // 
            // decodeComboBox
            // 
            this.decodeComboBox.FormattingEnabled = true;
            this.decodeComboBox.Location = new System.Drawing.Point(667, 54);
            this.decodeComboBox.Name = "decodeComboBox";
            this.decodeComboBox.Size = new System.Drawing.Size(121, 21);
            this.decodeComboBox.TabIndex = 5;
            // 
            // bytesTextBox
            // 
            this.bytesTextBox.Location = new System.Drawing.Point(12, 277);
            this.bytesTextBox.Multiline = true;
            this.bytesTextBox.Name = "bytesTextBox";
            this.bytesTextBox.Size = new System.Drawing.Size(776, 161);
            this.bytesTextBox.TabIndex = 6;
            // 
            // UpdateBytesButton
            // 
            this.UpdateBytesButton.Location = new System.Drawing.Point(368, 240);
            this.UpdateBytesButton.Name = "UpdateBytesButton";
            this.UpdateBytesButton.Size = new System.Drawing.Size(75, 31);
            this.UpdateBytesButton.TabIndex = 7;
            this.UpdateBytesButton.Text = "Update";
            this.UpdateBytesButton.UseVisualStyleBackColor = true;
            this.UpdateBytesButton.Click += new System.EventHandler(this.UpdateBytesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateBytesButton);
            this.Controls.Add(this.bytesTextBox);
            this.Controls.Add(this.decodeComboBox);
            this.Controls.Add(this.encodeComboBox);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.decodeTextBox);
            this.Controls.Add(this.encodeTextBox);
            this.Name = "Form1";
            this.Text = "ZILab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encodeTextBox;
        private System.Windows.Forms.TextBox decodeTextBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.ComboBox encodeComboBox;
        private System.Windows.Forms.ComboBox decodeComboBox;
        private System.Windows.Forms.TextBox bytesTextBox;
        private System.Windows.Forms.Button UpdateBytesButton;
    }
}

