namespace PassGen_8
{
    partial class FrmPassGen
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
            TxtPassword = new TextBox();
            BtnCopy = new Button();
            LblPassLen = new Label();
            nUDNumLen = new NumericUpDown();
            ChkUpper = new CheckBox();
            ChkLower = new CheckBox();
            ChkNum = new CheckBox();
            ChkOthers = new CheckBox();
            TxtOthers = new TextBox();
            BtnGen = new Button();
            BtnResetOth = new Button();
            ((System.ComponentModel.ISupportInitialize)nUDNumLen).BeginInit();
            SuspendLayout();
            // 
            // TxtPassword
            // 
            TxtPassword.Enabled = false;
            TxtPassword.Location = new Point(39, 22);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(722, 23);
            TxtPassword.TabIndex = 0;
            TxtPassword.TabStop = false;
            TxtPassword.Text = "PassWord";
            TxtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnCopy
            // 
            BtnCopy.Enabled = false;
            BtnCopy.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnCopy.Location = new Point(226, 125);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(349, 59);
            BtnCopy.TabIndex = 1;
            BtnCopy.Text = "复制密码(&P)";
            BtnCopy.UseVisualStyleBackColor = true;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // LblPassLen
            // 
            LblPassLen.AutoSize = true;
            LblPassLen.Location = new Point(301, 204);
            LblPassLen.Name = "LblPassLen";
            LblPassLen.Size = new Size(71, 17);
            LblPassLen.TabIndex = 2;
            LblPassLen.Text = "密码长度(&E)";
            // 
            // nUDNumLen
            // 
            nUDNumLen.Location = new Point(379, 198);
            nUDNumLen.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nUDNumLen.Name = "nUDNumLen";
            nUDNumLen.Size = new Size(120, 23);
            nUDNumLen.TabIndex = 3;
            nUDNumLen.TextAlign = HorizontalAlignment.Right;
            nUDNumLen.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // ChkUpper
            // 
            ChkUpper.AutoSize = true;
            ChkUpper.Checked = true;
            ChkUpper.CheckState = CheckState.Checked;
            ChkUpper.Location = new Point(349, 235);
            ChkUpper.Name = "ChkUpper";
            ChkUpper.Size = new Size(120, 21);
            ChkUpper.TabIndex = 4;
            ChkUpper.Text = "大写字母(A-Z)(&U)";
            ChkUpper.UseVisualStyleBackColor = true;
            ChkUpper.CheckedChanged += ChkUpper_CheckedChanged;
            // 
            // ChkLower
            // 
            ChkLower.AutoSize = true;
            ChkLower.Checked = true;
            ChkLower.CheckState = CheckState.Checked;
            ChkLower.Location = new Point(350, 270);
            ChkLower.Name = "ChkLower";
            ChkLower.Size = new Size(115, 21);
            ChkLower.TabIndex = 5;
            ChkLower.Text = "小写字母(a-z)(&L)";
            ChkLower.UseVisualStyleBackColor = true;
            ChkLower.CheckedChanged += ChkLower_CheckedChanged;
            // 
            // ChkNum
            // 
            ChkNum.AutoSize = true;
            ChkNum.Checked = true;
            ChkNum.CheckState = CheckState.Checked;
            ChkNum.Location = new Point(361, 305);
            ChkNum.Name = "ChkNum";
            ChkNum.Size = new Size(96, 21);
            ChkNum.TabIndex = 6;
            ChkNum.Text = "数字(0-9)(&N)";
            ChkNum.UseVisualStyleBackColor = true;
            ChkNum.CheckedChanged += ChkNum_CheckedChanged;
            // 
            // ChkOthers
            // 
            ChkOthers.AutoSize = true;
            ChkOthers.Checked = true;
            ChkOthers.CheckState = CheckState.Checked;
            ChkOthers.Location = new Point(100, 346);
            ChkOthers.Name = "ChkOthers";
            ChkOthers.Size = new Size(93, 21);
            ChkOthers.TabIndex = 5;
            ChkOthers.Text = "特殊字符(&O)";
            ChkOthers.UseVisualStyleBackColor = true;
            ChkOthers.CheckedChanged += ChkOthers_CheckedChanged;
            // 
            // TxtOthers
            // 
            TxtOthers.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            TxtOthers.Location = new Point(212, 342);
            TxtOthers.Name = "TxtOthers";
            TxtOthers.Size = new Size(310, 28);
            TxtOthers.TabIndex = 0;
            TxtOthers.TabStop = false;
            TxtOthers.Text = "~!@#$%^&*+-/.,\\{}[]();:";
            TxtOthers.TextChanged += TxtOthers_TextChanged;
            // 
            // BtnGen
            // 
            BtnGen.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnGen.Location = new Point(213, 377);
            BtnGen.Name = "BtnGen";
            BtnGen.Size = new Size(374, 59);
            BtnGen.TabIndex = 9;
            BtnGen.Text = "生成随机密码(&G)";
            BtnGen.UseVisualStyleBackColor = true;
            BtnGen.Click += BtnGen_Click;
            // 
            // BtnResetOth
            // 
            BtnResetOth.Enabled = false;
            BtnResetOth.Location = new Point(541, 345);
            BtnResetOth.Name = "BtnResetOth";
            BtnResetOth.Size = new Size(160, 23);
            BtnResetOth.TabIndex = 10;
            BtnResetOth.Text = "重置特殊字符(&R)";
            BtnResetOth.UseVisualStyleBackColor = true;
            BtnResetOth.Click += BtnResetOth_Click;
            // 
            // FrmPassGen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnResetOth);
            Controls.Add(BtnGen);
            Controls.Add(TxtOthers);
            Controls.Add(ChkOthers);
            Controls.Add(ChkNum);
            Controls.Add(ChkLower);
            Controls.Add(ChkUpper);
            Controls.Add(nUDNumLen);
            Controls.Add(LblPassLen);
            Controls.Add(BtnCopy);
            Controls.Add(TxtPassword);
            MaximizeBox = false;
            Name = "FrmPassGen";
            Text = "随机密码生成器";
            ((System.ComponentModel.ISupportInitialize)nUDNumLen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPassword;
        private Button BtnCopy;
        private Label LblPassLen;
        private NumericUpDown nUDNumLen;
        private CheckBox ChkUpper;
        private CheckBox ChkLower;
        private CheckBox ChkNum;
        private CheckBox ChkOthers;
        private TextBox TxtOthers;
        private Button BtnGen;
        private Button BtnResetOth;
    }
}
