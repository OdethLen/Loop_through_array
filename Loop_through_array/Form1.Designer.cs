namespace Loop_through_array
{
    partial class Form1
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
            label1 = new Label();
            txtNumber = new TextBox();
            btnShowArray = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 88);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(141, 85);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 1;
            // 
            // btnShowArray
            // 
            btnShowArray.Location = new Point(141, 155);
            btnShowArray.Name = "btnShowArray";
            btnShowArray.Size = new Size(75, 23);
            btnShowArray.TabIndex = 2;
            btnShowArray.Text = "Show";
            btnShowArray.UseVisualStyleBackColor = true;
            btnShowArray.Click += btnShowArray_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(141, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 245);
            Controls.Add(btnAdd);
            Controls.Add(btnShowArray);
            Controls.Add(txtNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber;
        private Button btnShowArray;
        private Button btnAdd;
    }
}
