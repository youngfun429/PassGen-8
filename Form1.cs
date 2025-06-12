namespace PassGen_8
{
    public partial class FrmPassGen : Form
    {
        private bool bolUpper = true, bolLower = true, bolNum = true, bolOth = true;

        public FrmPassGen()
        {
            InitializeComponent();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtPassword.Text);
        }

        private void ChkUpper_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkUpper.Checked)
            {
                bolUpper = true;
                BtnGen.Enabled = true;
                BtnGen.Text = "重新生成随机密码(&G)";
                EnableChkBox();
            }
            else
            {
                bolUpper = false;
                DisableChkBox(bolUpper, bolLower, bolNum, bolOth);
            }
        }

        private void DisableChkBox(bool bolUpper, bool bolLower, bool bolNum, bool bolOth)
        {
            if (!bolOth & !bolLower & !bolNum)
                ChkUpper.Enabled = false;
            if (!bolUpper & !bolOth & !bolNum)
                ChkLower.Enabled = false;
            if (!bolUpper & !bolLower & !bolOth)
                ChkNum.Enabled = false;
            if (!bolUpper & !bolLower & !bolNum)
                ChkOthers.Enabled = false;
        }

        private void EnableChkBox()
        {
            ChkUpper.Enabled = true;
            ChkLower.Enabled = true;
            ChkNum.Enabled = true;
            ChkOthers.Enabled = true;
        }

        private void ChkLower_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkLower.Checked)
            {
                bolLower = true;
                BtnGen.Enabled = true;
                BtnGen.Text = "重新生成随机密码(&G)";
                EnableChkBox();
            }
            else
            {
                bolLower = false;
                DisableChkBox(bolUpper, bolLower, bolNum, bolOth);
            }
        }

        private void ChkNum_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkNum.Checked)
            {
                bolNum = true;
                BtnGen.Enabled = true;
                BtnGen.Text = "重新生成随机密码(&G)";
                EnableChkBox();
            }
            else
            {
                bolNum = false;
                DisableChkBox(bolUpper, bolLower, bolNum, bolOth);
            }
        }

        private void ChkOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOthers.Checked)
            {
                bolOth = true;
                TxtOthers.Enabled = true;
                BtnGen.Enabled = true;
                BtnGen.Text = "重新生成随机密码(&G)";
                EnableChkBox();
            }
            else
            {
                bolOth = false;
                TxtOthers.Enabled = false;
                BtnResetOth.Enabled = false;
                DisableChkBox(bolUpper, bolLower, bolNum, bolOth);
            }
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            bool bolInclNonOthers = false;
            char[] chars =
                {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                '1','2','3','4','5','6','7','8','9','0',' '
                };
            for (int j = 0; j < TxtOthers.Text.Length; j++)
            {
                if (((int)TxtOthers.Text[j] > 127) | (TxtOthers.Text.IndexOfAny(chars) >= 0))
                {
                    MessageBox.Show("特殊字符框中不能包含 大小写、数字、空格、汉字、全角 字符");
                    bolInclNonOthers = true;
                    break;
                }
            }
            if (!bolInclNonOthers)
            {
                string strString = "", strPassword = "";
                string subStrStringUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", //大写
                    subStrStringLower = "abcdefghijklmnopqrstuvwxyz", //小写
                    subStrStringNum = "0123456789", //数字
                    subStrStringOthers = TxtOthers.Text;//其他字符

                Random randUpper = new();
                Random randLower = new();
                Random randNum = new();
                Random randOthers = new();
                Random randString = new();

                int nUpper, nLower, nNum, nOthers;//随机生成的整数
                string subCharUpper, subCharLower, subCharNum, subCharOthers;

                nUpper = randUpper.Next(subStrStringUpper.Length);
                subCharUpper = subStrStringUpper.Substring(nUpper, 1);
                nLower = randLower.Next(subStrStringLower.Length);
                subCharLower = subStrStringLower.Substring(nLower, 1);
                nNum = randNum.Next(subStrStringNum.Length);
                subCharNum = subStrStringNum.Substring(nNum, 1);
                nOthers = randOthers.Next(subStrStringOthers.Length);
                subCharOthers = subStrStringOthers.Substring(nOthers, 1);//分别从大写、小写、数字、其他字符中随机取出的一个字符

                nUpper = randUpper.Next(Decimal.ToInt32(nUDNumLen.Value));
                nLower = randLower.Next(Decimal.ToInt32(nUDNumLen.Value));
                nNum = randNum.Next(Decimal.ToInt32(nUDNumLen.Value));
                nOthers = randOthers.Next(Decimal.ToInt32(nUDNumLen.Value));//随机生成的不大于密码长度整数

                BtnCopy.Enabled = true;

                if (ChkUpper.Checked)
                {
                    strString += subStrStringUpper;
                    while ((nUpper == nLower) | (nUpper == nNum) | (nUpper == nOthers))
                        nUpper = randUpper.Next(Decimal.ToInt32(nUDNumLen.Value));
                }
                else
                    nUpper = 0;

                if (ChkLower.Checked)
                {
                    strString += subStrStringLower;
                    while ((nLower == nUpper) | (nLower == nNum) | (nLower == nOthers))
                        nLower = randLower.Next(Decimal.ToInt32(nUDNumLen.Value));
                }
                else
                    nLower = 0;

                if (ChkNum.Checked)
                {
                    strString += subStrStringNum;
                    while ((nNum == nUpper) | (nNum == nLower) | (nNum == nOthers))
                        nNum = randNum.Next(Decimal.ToInt32(nUDNumLen.Value));
                }
                else
                    nNum = 0;

                if (ChkOthers.Checked)
                {
                    strString += subStrStringOthers;
                    while ((nOthers == nUpper) | (nOthers == nLower) | (nOthers == nNum))
                        nOthers = randOthers.Next(Decimal.ToInt32(nUDNumLen.Value));
                }
                else
                    nOthers = 0;
                //生成包括随机密码可用的所有字符串strString，并确保随机生成的整数不相等

                for (int i = 1; i <= Decimal.ToInt32(nUDNumLen.Value); i++)//按照用户选择的密码长度生成随机密码循环
                {
                    int n = randString.Next(strString.Length);//随机生成不大于strString长度的一个整数
                    if (i == nUpper)
                        strPassword += subCharUpper;
                    else if (i == nLower)
                        strPassword += subCharLower;
                    else if (i == nNum)
                        strPassword += subCharNum;
                    else if (i == nOthers)
                        strPassword += subCharOthers;
                    else
                        strPassword += strString.Substring(n, 1);//从strString中随机取出一个字符
                }

                TxtPassword.Text = strPassword;
                BtnGen.Text = "重新生成随机密码(&G)";
            }
        }

        private void TxtOthers_TextChanged(object sender, EventArgs e)
        {
            BtnResetOth.Enabled = true;
        }

        private void BtnResetOth_Click(object sender, EventArgs e)
        {
            TxtOthers.Text = "~!@#$%^&*+-/.,\\{}[]();:";
            BtnResetOth.Enabled = false;
        }
    }
}
