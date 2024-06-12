using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attendence atend = new Attendence();
            atend.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addassesment ass = new Addassesment();
            ass.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveAssessment remass = new RemoveAssessment();
            remass.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Addclo clo = new Addclo();
            clo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateClo upclo = new UpdateClo();
            upclo.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewAssessment vass = new ViewAssessment();
            vass.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Viewclo clo = new Viewclo();
            clo.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Addrubric rub = new Addrubric();
            rub.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RemoveRubric remrub = new RemoveRubric();
            remrub.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddAssComp ass = new AddAssComp();
            ass.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            UpdAssCom ass = new UpdAssCom();
            ass.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Studentresult res = new Studentresult();
            res.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddRubricsLevel ass = new AddRubricsLevel();
            ass.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ClassAttendence ass = new ClassAttendence();
            ass.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            StudentAttendance ass = new StudentAttendance();
            ass.Show();
            this.Hide();
        }
    }
}
