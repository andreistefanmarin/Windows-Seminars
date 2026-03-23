namespace WinFormsApp11
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Minecraft", 11F);
            label1.Location = new Point(27, 42);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 0;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Minecraft", 11F);
            label2.Location = new Point(27, 97);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Minecraft", 11F);
            label3.Location = new Point(27, 149);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 2;
            label3.Text = "Birth Date";
            // 
            // tbFirstName
            // 
            tbFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbFirstName.Location = new Point(220, 44);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(343, 31);
            tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            tbLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbLastName.Location = new Point(220, 99);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(343, 31);
            tbLastName.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(220, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(343, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(348, 275);
            button1.Name = "button1";
            button1.Size = new Size(121, 42);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            button2.Location = new Point(475, 275);
            button2.Name = "button2";
            button2.Size = new Size(121, 42);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 329);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditForm";
            Text = "WinAppProgramming Run";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}