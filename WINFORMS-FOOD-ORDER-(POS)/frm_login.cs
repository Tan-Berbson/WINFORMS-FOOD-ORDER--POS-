using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static WINFORMS_FOOD_ORDER__POS_.Class1;
namespace WINFORMS_FOOD_ORDER__POS_
{
    public partial class frm_login : Form
    {
        auth login = new auth();
        private int loginAttempts = 0; 
        private const int MaxLoginAttempts = 6; 
        private const int LockoutDuration = 60; 
        private System.Windows.Forms.Timer lockoutTimer;
        private DateTime lockoutEndTime; 

        public frm_login()
        {
            InitializeComponent();
            this.ControlBox = false;
            txt_password.UseSystemPasswordChar = true;
            lockoutTimer = new System.Windows.Forms.Timer();
            lockoutTimer.Interval = 1000; 
            lockoutTimer.Tick += LockoutTimer_Tick;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please enter username and password.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            }
            else if (lockoutTimer.Enabled)
            {
                TimeSpan remainingTime = lockoutEndTime - DateTime.Now;
                MessageBox.Show($"Account is locked. Please try again in {remainingTime.Seconds} seconds.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (login.loginadmin(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Log In Successfully Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_admindashboard f = new frm_admindashboard(txt_username.Text);
                f.Show();
                this.Hide();
                loginAttempts = 0;
            }
            else if (login.logincashier(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Log In Successfully Cashier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_cashierDashboard f = new frm_cashierDashboard(txt_username.Text);
                f.Show();
                this.Hide();
                loginAttempts = 0;

            }

            else
            {

                loginAttempts++;
                if (loginAttempts >= MaxLoginAttempts)
                {
                    // Lock the account for 60 seconds
                    lockoutEndTime = DateTime.Now.AddSeconds(LockoutDuration);
                    lockoutTimer.Start();
                    MessageBox.Show($"Too many failed attempts. Account is locked for {LockoutDuration} seconds.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Incorrect Username or Password. Attempts left: {MaxLoginAttempts - loginAttempts}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= lockoutEndTime)
            {
                lockoutTimer.Stop();
                loginAttempts = 0; 
                MessageBox.Show("You can now try logging in again.", "Lockout Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_signup_Click(object sender, EventArgs e)
        {
            frm_signup f = new frm_signup();
            f.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !checkBox1.Checked;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // This checks if the user is trying to close the app (like Alt+F4)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // This command CANCELS the closing process
                e.Cancel = true;

                MessageBox.Show("Access Denied: Please use the Logout button to exit.",
                                "Security Lock",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
            }
        }
    }
}
