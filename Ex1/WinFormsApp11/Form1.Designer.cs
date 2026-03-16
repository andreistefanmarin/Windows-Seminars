namespace WinFormsApp11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


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
            components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("");
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            errorProvider = new ErrorProvider(components);
            dtpBirthDate = new DateTimePicker();
            button1 = new Button();
            lvParticipants = new ListView();
            LastName = new ColumnHeader();
            FirstName = new ColumnHeader();
            BirthDate = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            serializationToolStripMenuItem = new ToolStripMenuItem();
            serializeToolStripMenuItem = new ToolStripMenuItem();
            deserializeToolStripMenuItem = new ToolStripMenuItem();
            xMLSerializationToolStripMenuItem1 = new ToolStripMenuItem();
            serializationToolStripMenuItem1 = new ToolStripMenuItem();
            deserializationToolStripMenuItem = new ToolStripMenuItem();
            jSONSerializationlegacyToolStripMenuItem = new ToolStripMenuItem();
            textFileToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Birth Date";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(198, 52);
            tbLastName.Margin = new Padding(4);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(155, 31);
            tbLastName.TabIndex = 5;
            tbLastName.Validating += tbLastName_Validating;
            tbLastName.Validated += tbLastName_Validated;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(198, 115);
            tbFirstName.Margin = new Padding(4);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(155, 31);
            tbFirstName.TabIndex = 6;
            tbFirstName.Validating += tbFirstName_Validating;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(186, 196);
            dtpBirthDate.Margin = new Padding(4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(312, 31);
            dtpBirthDate.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(605, 241);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(291, 36);
            button1.TabIndex = 11;
            button1.Text = "Add Participants";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lvParticipants
            // 
            lvParticipants.Columns.AddRange(new ColumnHeader[] { LastName, FirstName, BirthDate });
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            lvParticipants.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            lvParticipants.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvParticipants.Location = new Point(34, 334);
            lvParticipants.Margin = new Padding(4);
            lvParticipants.Name = "lvParticipants";
            lvParticipants.Size = new Size(673, 145);
            lvParticipants.TabIndex = 12;
            lvParticipants.UseCompatibleStateImageBehavior = false;
            lvParticipants.View = View.Details;
            lvParticipants.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // LastName
            // 
            LastName.Text = "LastName";
            // 
            // FirstName
            // 
            FirstName.Text = "FirstName";
            // 
            // BirthDate
            // 
            BirthDate.Text = "BirthDate";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { serializationToolStripMenuItem, xMLSerializationToolStripMenuItem1, jSONSerializationlegacyToolStripMenuItem, textFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 33);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // serializationToolStripMenuItem
            // 
            serializationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serializeToolStripMenuItem, deserializeToolStripMenuItem });
            serializationToolStripMenuItem.Name = "serializationToolStripMenuItem";
            serializationToolStripMenuItem.Size = new Size(170, 29);
            serializationToolStripMenuItem.Text = "JSON Serialization";
            serializationToolStripMenuItem.Click += serializationToolStripMenuItem_Click;
            // 
            // serializeToolStripMenuItem
            // 
            serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            serializeToolStripMenuItem.Size = new Size(197, 34);
            serializeToolStripMenuItem.Text = "Serialize";
            // 
            // deserializeToolStripMenuItem
            // 
            deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            deserializeToolStripMenuItem.Size = new Size(197, 34);
            deserializeToolStripMenuItem.Text = "Deserialize";
            deserializeToolStripMenuItem.Click += deserializeToolStripMenuItem_Click;
            // 
            // xMLSerializationToolStripMenuItem1
            // 
            xMLSerializationToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { serializationToolStripMenuItem1, deserializationToolStripMenuItem });
            xMLSerializationToolStripMenuItem1.Name = "xMLSerializationToolStripMenuItem1";
            xMLSerializationToolStripMenuItem1.Size = new Size(162, 29);
            xMLSerializationToolStripMenuItem1.Text = "XML Serialization";
            // 
            // serializationToolStripMenuItem1
            // 
            serializationToolStripMenuItem1.Name = "serializationToolStripMenuItem1";
            serializationToolStripMenuItem1.Size = new Size(270, 34);
            serializationToolStripMenuItem1.Text = "Serialization";
            serializationToolStripMenuItem1.Click += serializationToolStripMenuItem1_Click;
            // 
            // deserializationToolStripMenuItem
            // 
            deserializationToolStripMenuItem.Name = "deserializationToolStripMenuItem";
            deserializationToolStripMenuItem.Size = new Size(270, 34);
            deserializationToolStripMenuItem.Text = "Deserialization";
            deserializationToolStripMenuItem.Click += deserializationToolStripMenuItem_Click;
            // 
            // jSONSerializationlegacyToolStripMenuItem
            // 
            jSONSerializationlegacyToolStripMenuItem.Name = "jSONSerializationlegacyToolStripMenuItem";
            jSONSerializationlegacyToolStripMenuItem.Size = new Size(235, 29);
            jSONSerializationlegacyToolStripMenuItem.Text = "JSON Serialization (legacy)";
            // 
            // textFileToolStripMenuItem
            // 
            textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            textFileToolStripMenuItem.Size = new Size(84, 29);
            textFileToolStripMenuItem.Text = "TextFile";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1000, 562);
            Controls.Add(lvParticipants);
            Controls.Add(button1);
            Controls.Add(dtpBirthDate);
            Controls.Add(tbFirstName);
            Controls.Add(tbLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private ErrorProvider errorProvider;
        private DateTimePicker dtpBirthDate;
        private Button button1;
        private ListView lvParticipants;
        private ColumnHeader LastName;
        private ColumnHeader FirstName;
        private ColumnHeader BirthDate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem serializationToolStripMenuItem;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem deserializeToolStripMenuItem;
        private ToolStripMenuItem xMLSerializationToolStripMenuItem1;
        private ToolStripMenuItem jSONSerializationlegacyToolStripMenuItem;
        private ToolStripMenuItem textFileToolStripMenuItem;
        private ToolStripMenuItem serializationToolStripMenuItem1;
        private ToolStripMenuItem deserializationToolStripMenuItem;
    }
}
