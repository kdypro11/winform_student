using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210404_ProJect2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }

            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Text == num.Value.ToString())
                {
                    MessageBox.Show("이미 등록된 학생의 번호 입니다.");
                    return;
                }
            }


            //리스트뷰에 입력
            ListViewItem lv = new ListViewItem();
      
            lv.Text = num.Value.ToString();
            lv.SubItems.Add(textBox1.Text); 
            string gender = "";
            if (rbM.Checked)
            {
                gender = "남";
            }
            else if (rbFm.Checked)
            {
                gender = "여";
            }

            lv.SubItems.Add(gender); 
            lv.SubItems.Add(subj1.Value.ToString());  
            lv.SubItems.Add(subj2.Value.ToString());  
            lv.SubItems.Add(subj3.Value.ToString());  
            lv.SubItems.Add(subj4.Value.ToString());  
            lv.SubItems.Add(subj5.Value.ToString());

            double subj01 = (double)subj1.Value;
            double subj02 = (double)subj2.Value;
            double subj03 = (double)subj3.Value;
            double subj04 = (double)subj4.Value;
            double subj05 = (double)subj5.Value;

            double ar = (subj01 + subj02 + subj03 + subj04 + subj05) / 5;
            lv.SubItems.Add(ar.ToString());

          


            //----------------------  마무리 라인 --------------
            listView.Items.Add(lv);

            num.Value++;

            textBox1.Text = "";
            subj1.Value = 0;
            subj2.Value = 0;
            subj3.Value = 0;
            subj4.Value = 0;
            subj5.Value = 0;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                num.Value = int.Parse(listView.SelectedItems[0].SubItems[0].Text);
                textBox1.Text = listView.SelectedItems[0].SubItems[1].Text;

                string gender = listView.SelectedItems[0].SubItems[2].Text;
                if (gender == "남")
                {
                    rbM.Checked = true;
                    rbFm.Checked = false;
                }
                else if (gender == "여")
                {
                    rbM.Checked = false;
                    rbFm.Checked = true;
                }
                subj1.Value = int.Parse(listView.SelectedItems[0].SubItems[3].Text);
                subj2.Value = int.Parse(listView.SelectedItems[0].SubItems[4].Text);
                subj3.Value = int.Parse(listView.SelectedItems[0].SubItems[5].Text);
                subj4.Value = int.Parse(listView.SelectedItems[0].SubItems[6].Text);
                subj5.Value = int.Parse(listView.SelectedItems[0].SubItems[7].Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("이름을 입력해주세요.");
                    return;
                }

                listView.SelectedItems[0].SubItems[0].Text = num.Value.ToString();
                listView.SelectedItems[0].SubItems[1].Text = textBox1.Text;

                string gender = "";
                if (rbM.Checked)
                {
                    gender = "남";
                }
                else if (rbFm.Checked)
                {
                    gender = "여";
                }

                listView.SelectedItems[0].SubItems[2].Text = gender;
                listView.SelectedItems[0].SubItems[3].Text = subj1.Value.ToString();
                listView.SelectedItems[0].SubItems[4].Text = subj2.Value.ToString();
                listView.SelectedItems[0].SubItems[5].Text = subj3.Value.ToString();
                listView.SelectedItems[0].SubItems[6].Text = subj4.Value.ToString();
                listView.SelectedItems[0].SubItems[7].Text = subj5.Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
