namespace week11
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.phoneNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.exitButton1 = new System.Windows.Forms.Button();
            this.enterFriendButton = new System.Windows.Forms.Button();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.allFriendsListBox = new System.Windows.Forms.ListBox();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.exitButton3 = new System.Windows.Forms.Button();
            this.reminderButton = new System.Windows.Forms.Button();
            this.searchMonthBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reminderListBox = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-1, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(514, 279);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.phoneNumberBox);
            this.tabPage1.Controls.Add(this.exitButton1);
            this.tabPage1.Controls.Add(this.enterFriendButton);
            this.tabPage1.Controls.Add(this.dayBox);
            this.tabPage1.Controls.Add(this.monthBox);
            this.tabPage1.Controls.Add(this.lastNameBox);
            this.tabPage1.Controls.Add(this.firstNameBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(165, 88);
            this.phoneNumberBox.Mask = "000-0000";
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(53, 20);
            this.phoneNumberBox.TabIndex = 3;
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(374, 136);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(90, 23);
            this.exitButton1.TabIndex = 8;
            this.exitButton1.Text = "Exit";
            this.exitButton1.UseVisualStyleBackColor = true;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // enterFriendButton
            // 
            this.enterFriendButton.Location = new System.Drawing.Point(374, 107);
            this.enterFriendButton.Name = "enterFriendButton";
            this.enterFriendButton.Size = new System.Drawing.Size(90, 23);
            this.enterFriendButton.TabIndex = 7;
            this.enterFriendButton.Text = "Enter Friend";
            this.enterFriendButton.UseVisualStyleBackColor = true;
            this.enterFriendButton.Click += new System.EventHandler(this.enterFriendButton_Click);
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(165, 159);
            this.dayBox.MaxLength = 2;
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(32, 20);
            this.dayBox.TabIndex = 5;
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(165, 123);
            this.monthBox.MaxLength = 2;
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(32, 20);
            this.monthBox.TabIndex = 4;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(165, 53);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 2;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(165, 17);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Birth Day (eg: 24)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Birth Month (eg: 10)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.allFriendsListBox);
            this.tabPage2.Controls.Add(this.exitButton2);
            this.tabPage2.Controls.Add(this.readButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // allFriendsListBox
            // 
            this.allFriendsListBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allFriendsListBox.FormattingEnabled = true;
            this.allFriendsListBox.ItemHeight = 11;
            this.allFriendsListBox.Location = new System.Drawing.Point(10, 12);
            this.allFriendsListBox.Name = "allFriendsListBox";
            this.allFriendsListBox.Size = new System.Drawing.Size(488, 191);
            this.allFriendsListBox.TabIndex = 4;
            // 
            // exitButton2
            // 
            this.exitButton2.Location = new System.Drawing.Point(255, 221);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(75, 23);
            this.exitButton2.TabIndex = 3;
            this.exitButton2.Text = "Exit";
            this.exitButton2.UseVisualStyleBackColor = true;
            this.exitButton2.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(155, 221);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 2;
            this.readButton.Tag = "button4";
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.exitButton3);
            this.tabPage3.Controls.Add(this.reminderButton);
            this.tabPage3.Controls.Add(this.searchMonthBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.reminderListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(506, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reminder";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // exitButton3
            // 
            this.exitButton3.Location = new System.Drawing.Point(249, 221);
            this.exitButton3.Name = "exitButton3";
            this.exitButton3.Size = new System.Drawing.Size(75, 23);
            this.exitButton3.TabIndex = 4;
            this.exitButton3.Text = "Exit";
            this.exitButton3.UseVisualStyleBackColor = true;
            this.exitButton3.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // reminderButton
            // 
            this.reminderButton.Location = new System.Drawing.Point(148, 221);
            this.reminderButton.Name = "reminderButton";
            this.reminderButton.Size = new System.Drawing.Size(75, 23);
            this.reminderButton.TabIndex = 3;
            this.reminderButton.Text = "Reminder";
            this.reminderButton.UseVisualStyleBackColor = true;
            this.reminderButton.Click += new System.EventHandler(this.reminderButton_Click);
            // 
            // searchMonthBox
            // 
            this.searchMonthBox.Location = new System.Drawing.Point(359, 193);
            this.searchMonthBox.MaxLength = 2;
            this.searchMonthBox.Name = "searchMonthBox";
            this.searchMonthBox.Size = new System.Drawing.Size(66, 20);
            this.searchMonthBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Which Month\'s Birthday Do You Want To Display? --->";
            // 
            // reminderListBox
            // 
            this.reminderListBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderListBox.FormattingEnabled = true;
            this.reminderListBox.ItemHeight = 11;
            this.reminderListBox.Location = new System.Drawing.Point(11, 11);
            this.reminderListBox.Name = "reminderListBox";
            this.reminderListBox.Size = new System.Drawing.Size(487, 169);
            this.reminderListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 277);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Friends";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Button exitButton1;
        private System.Windows.Forms.Button enterFriendButton;
        private System.Windows.Forms.MaskedTextBox phoneNumberBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button exitButton2;
        private System.Windows.Forms.ListBox allFriendsListBox;
        private System.Windows.Forms.Button exitButton3;
        private System.Windows.Forms.Button reminderButton;
        private System.Windows.Forms.TextBox searchMonthBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox reminderListBox;
    }
}

