using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Univesity_Grade_Calculator
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int viva1, viva2, viva3, viva4;
            int inatt, mid, final, total, percentage, quizsum = 0;
            viva1 = int.Parse(tb_viva1.Text);
            viva2 = int.Parse(tb_viva2.Text);
            viva3 = int.Parse(tb_viva3.Text);
            viva4 = int.Parse(tb_viva4.Text);
            inatt = int.Parse(tb_attendance.Text);
            mid = int.Parse(tb_Mid.Text);
            final = int.Parse(tb_Final.Text);

            if (tb_attendance.Text == "" || tb_Final.Text == "" || tb_Mid.Text == "" || tb_viva1.Text == "" || tb_viva2.Text == "" || tb_viva3.Text == "" || tb_viva4.Text == "")
            {
                MessageBox.Show("Marking fields should not be left empty.");
            }
            else if (viva1 > 15 || viva2 > 15 || viva3 > 15 || viva4 > 15)
            {
                MessageBox.Show("Viva marks should not be greater than the maximum marks.");

            }
            else if (inatt > 15)
            {
                MessageBox.Show("Attendance should be within the range specified.");

            }
            else if (mid > 75)
            {
                MessageBox.Show("Mid marks should be within the range specified.");

            }
            else if (final > 150)
            {
                MessageBox.Show("Final marks should be within the range specified.");

            }
            else {
                
               
        
                lb_attendance.Text = inatt.ToString() + "/15";
                lb_attendance.Visible = true;
                
                lb_mid.Text = mid.ToString() + "/75";
                lb_mid.Visible = true;
                
                lb_Final.Text = final.ToString() + "/150";
                lb_Final.Visible = true;

                int[] array = { viva1, viva2, viva3, viva4 };

            for (int i = 0; i <= 3; i++)
            {
                Array.Sort(array);
                Array.Reverse(array);
                quizsum += array[i];
            }
            lb_quiz.Text = quizsum.ToString()+"/60";
            lb_quiz.Visible = true;

            total = inatt + mid + quizsum + final;
            lb_total.Text = total.ToString() + "/300";
            lb_total.Visible = true;
            percentage = (total * 100) / 300;

            if (percentage >= 91)
                lb_Grade.Text = "Ex";
            else if (percentage >= 81 && percentage <= 90)
                lb_Grade.Text = "A";
            else if (percentage >= 71 && percentage <= 80)
                lb_Grade.Text = "B";
            else if (percentage >= 61 && percentage <= 50)
                lb_Grade.Text = "C";
            else if (percentage >= 51 && percentage <= 40)
                lb_Grade.Text = "D";
            else if (percentage >= 41 && percentage <= 35)
                lb_Grade.Text = "P";
            else
                lb_Grade.Text = "F";

            lb_Grade.Visible = true;


            lb_displayresult.Text = tb_Name.Text +" with student id "+ tb_studentID.Text + " obtained " + percentage.ToString() + "% marks in " +tb_semester.Text+" Semester.";
            lb_displayresult.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_attendance.Text = "";
            tb_Final.Text = "";
            tb_Mid.Text = "";
            tb_Name.Text = "";
            tb_viva1.Text = "";
            tb_viva2.Text = "";
            tb_viva3.Text = "";
            tb_viva4.Text = "";
            tb_semester.Text = "";
            tb_studentID.Text = "";
            lb_attendance.Text = "";
            lb_displayresult.Text = "";
            lb_Final.Text = "";
            lb_Grade.Text = "";
            lb_mid.Text = "";
            lb_quiz.Text = "";
            lb_total.Text = "";
           
        }

      
    }
}
