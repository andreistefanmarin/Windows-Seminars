namespace WinFormsApp11
{
    partial class editForm
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
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            dtpBirthDate = new DateTimePicker();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(370, 130);
            tbLastName.Margin = new Padding(4, 4, 4, 4);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(155, 31);
            tbLastName.TabIndex = 0;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(370, 202);
            tbFirstName.Margin = new Padding(4, 4, 4, 4);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(155, 31);
            tbFirstName.TabIndex = 1;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(266, 319);
            dtpBirthDate.Margin = new Padding(4, 4, 4, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(312, 31);
            dtpBirthDate.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(520, 420);
            btnOk.Margin = new Padding(4, 4, 4, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(118, 36);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(750, 420);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // editForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(dtpBirthDate);
            Controls.Add(tbFirstName);
            Controls.Add(tbLastName);
            Margin = new Padding(4, 4, 4, 4);
            Name = "editForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "editForm";
            Load += editForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLastName;
        private TextBox tbFirstName;
        private DateTimePicker dtpBirthDate;
        private Button btnOk;
        private Button btnCancel;
    }
}