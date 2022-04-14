namespace tictactoe
{
    partial class titactoe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label0 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.X_Wins_Count = new System.Windows.Forms.Label();
            this.O_Wins_Count = new System.Windows.Forms.Label();
            this.Draw_Count = new System.Windows.Forms.Label();
            this.Player_One_Name = new System.Windows.Forms.Label();
            this.Display_Player_Name = new System.Windows.Forms.TextBox();
            this.Display_Player_Name_2 = new System.Windows.Forms.TextBox();
            this.Player_Two_Name = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitGameToolStripMenuItem,
            this.resetScoreToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // resetScoreToolStripMenuItem
            // 
            this.resetScoreToolStripMenuItem.Name = "resetScoreToolStripMenuItem";
            this.resetScoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetScoreToolStripMenuItem.Text = "Reset Score";
            this.resetScoreToolStripMenuItem.Click += new System.EventHandler(this.resetScoreToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.MediumPurple;
            this.A1.FlatAppearance.BorderSize = 0;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Pink Blue", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.Location = new System.Drawing.Point(12, 43);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 1;
            this.A1.TabStop = false;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.Button_Click);
            this.A1.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.A1.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.C3.FlatAppearance.BorderSize = 0;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Pink Blue", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.Location = new System.Drawing.Point(224, 255);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 4;
            this.C3.TabStop = false;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.Button_Click);
            this.C3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.C3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.C2.FlatAppearance.BorderSize = 0;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Pink Blue", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.Location = new System.Drawing.Point(118, 255);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 5;
            this.C2.TabStop = false;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.Button_Click);
            this.C2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.C2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.C1.FlatAppearance.BorderSize = 0;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Pink Blue", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.Location = new System.Drawing.Point(12, 255);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 6;
            this.C1.TabStop = false;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.Button_Click);
            this.C1.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.C1.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Salmon;
            this.B3.FlatAppearance.BorderSize = 0;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Pink Blue", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.Location = new System.Drawing.Point(224, 149);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 7;
            this.B3.TabStop = false;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            this.B3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Salmon;
            this.B2.FlatAppearance.BorderSize = 0;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Pink Blue", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.Location = new System.Drawing.Point(118, 149);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 8;
            this.B2.TabStop = false;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            this.B2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Salmon;
            this.B1.FlatAppearance.BorderSize = 0;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Pink Blue", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.Location = new System.Drawing.Point(12, 149);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 9;
            this.B1.TabStop = false;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            this.B1.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B1.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.MediumPurple;
            this.A3.FlatAppearance.BorderSize = 0;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Pink Blue", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.Location = new System.Drawing.Point(224, 43);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 10;
            this.A3.TabStop = false;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.Button_Click);
            this.A3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.A3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.MediumPurple;
            this.A2.FlatAppearance.BorderSize = 0;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Pink Blue", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.Location = new System.Drawing.Point(118, 43);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 11;
            this.A2.TabStop = false;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.Button_Click);
            this.A2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.A2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pink Blue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(365, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Wins count";
            // 
            // Label0
            // 
            this.Label0.AutoSize = true;
            this.Label0.Font = new System.Drawing.Font("Pink Blue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label0.Location = new System.Drawing.Point(365, 213);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(77, 17);
            this.Label0.TabIndex = 13;
            this.Label0.Text = "Wins count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pink Blue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Draw count";
            // 
            // X_Wins_Count
            // 
            this.X_Wins_Count.AutoSize = true;
            this.X_Wins_Count.Font = new System.Drawing.Font("Pink Blue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X_Wins_Count.Location = new System.Drawing.Point(448, 95);
            this.X_Wins_Count.Name = "X_Wins_Count";
            this.X_Wins_Count.Size = new System.Drawing.Size(16, 17);
            this.X_Wins_Count.TabIndex = 15;
            this.X_Wins_Count.Text = "0";
            // 
            // O_Wins_Count
            // 
            this.O_Wins_Count.AutoSize = true;
            this.O_Wins_Count.Font = new System.Drawing.Font("Pink Blue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.O_Wins_Count.Location = new System.Drawing.Point(448, 213);
            this.O_Wins_Count.Name = "O_Wins_Count";
            this.O_Wins_Count.Size = new System.Drawing.Size(16, 17);
            this.O_Wins_Count.TabIndex = 16;
            this.O_Wins_Count.Text = "0";
            // 
            // Draw_Count
            // 
            this.Draw_Count.AutoSize = true;
            this.Draw_Count.Font = new System.Drawing.Font("Pink Blue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Draw_Count.Location = new System.Drawing.Point(457, 313);
            this.Draw_Count.Name = "Draw_Count";
            this.Draw_Count.Size = new System.Drawing.Size(16, 17);
            this.Draw_Count.TabIndex = 17;
            this.Draw_Count.Text = "0";
            // 
            // Player_One_Name
            // 
            this.Player_One_Name.AutoSize = true;
            this.Player_One_Name.Font = new System.Drawing.Font("Pink Blue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player_One_Name.Location = new System.Drawing.Point(365, 43);
            this.Player_One_Name.Name = "Player_One_Name";
            this.Player_One_Name.Size = new System.Drawing.Size(121, 20);
            this.Player_One_Name.TabIndex = 18;
            this.Player_One_Name.Text = "Player One (X)";
            // 
            // Display_Player_Name
            // 
            this.Display_Player_Name.BackColor = System.Drawing.Color.Salmon;
            this.Display_Player_Name.Font = new System.Drawing.Font("Pink Blue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display_Player_Name.ForeColor = System.Drawing.Color.Beige;
            this.Display_Player_Name.Location = new System.Drawing.Point(365, 66);
            this.Display_Player_Name.Name = "Display_Player_Name";
            this.Display_Player_Name.Size = new System.Drawing.Size(133, 26);
            this.Display_Player_Name.TabIndex = 19;
            this.Display_Player_Name.TabStop = false;
            this.Display_Player_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Display_Player_Name.Click += new System.EventHandler(this.Display_Player_One_Name_Click);
            // 
            // Display_Player_Name_2
            // 
            this.Display_Player_Name_2.BackColor = System.Drawing.Color.Salmon;
            this.Display_Player_Name_2.Font = new System.Drawing.Font("Pink Blue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display_Player_Name_2.ForeColor = System.Drawing.Color.LightBlue;
            this.Display_Player_Name_2.Location = new System.Drawing.Point(365, 184);
            this.Display_Player_Name_2.Name = "Display_Player_Name_2";
            this.Display_Player_Name_2.Size = new System.Drawing.Size(133, 26);
            this.Display_Player_Name_2.TabIndex = 21;
            this.Display_Player_Name_2.TabStop = false;
            this.Display_Player_Name_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Display_Player_Name_2.Click += new System.EventHandler(this.Display_Player_One_Name_Click);
            // 
            // Player_Two_Name
            // 
            this.Player_Two_Name.AutoSize = true;
            this.Player_Two_Name.Font = new System.Drawing.Font("Pink Blue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player_Two_Name.Location = new System.Drawing.Point(365, 161);
            this.Player_Two_Name.Name = "Player_Two_Name";
            this.Player_Two_Name.Size = new System.Drawing.Size(121, 20);
            this.Player_Two_Name.TabIndex = 20;
            this.Player_Two_Name.Text = "Player Two (O)";
            // 
            // titactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(544, 370);
            this.Controls.Add(this.Display_Player_Name_2);
            this.Controls.Add(this.Player_Two_Name);
            this.Controls.Add(this.Display_Player_Name);
            this.Controls.Add(this.Player_One_Name);
            this.Controls.Add(this.Draw_Count);
            this.Controls.Add(this.O_Wins_Count);
            this.Controls.Add(this.X_Wins_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 409);
            this.MinimumSize = new System.Drawing.Size(560, 409);
            this.Name = "titactoe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe !";
            this.Load += new System.EventHandler(this.titactoe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button A1;
        private Button C3;
        private Button C2;
        private Button C1;
        private Button B3;
        private Button B2;
        private Button B1;
        private Button A3;
        private Button A2;
        private Label label1;
        private Label Label0;
        private Label label3;
        private Label X_Wins_Count;
        private Label O_Wins_Count;
        private Label Draw_Count;
        private ToolStripMenuItem resetScoreToolStripMenuItem;
        private Label Player_One_Name;
        private TextBox Display_Player_Name;
        private TextBox Display_Player_Name_2;
        private Label Player_Two_Name;
    }
}