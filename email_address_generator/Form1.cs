using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace email_address_generator
{
    public partial class frm1 : Form
    {

        frm2 f2 = new frm2();
        public int flag = 0;

        public frm1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.tb1.Text = "";
            this.tb2.Text = "";
            this.tb3.Text = "";
            this.tb4.Text = "";






        }

        private void btn2_Click(object sender, EventArgs e)
        {

            int flag = 0;

            string firstname = this.tb1.Text;
            string lastname = this.tb2.Text;
            string email = this.tb4.Text;

            string firstnameini = this.tb1.Text.Substring(0, 1);
            string lastnameini = this.tb2.Text.Substring(0, 1);
            string firstnameiniall = firstnameini;
            string lastnameiniall = lastnameini;
            if (firstname.Contains("ä"))
            {
                if (firstname.IndexOf("ä") == 0)
                {
                    firstnameini = "a";
                    firstnameiniall = "ae";
                    firstname = firstname.Replace("ä", "ae");
                }
                else
                {
                    firstname = firstname.Replace("ä", "ae");
                }
                flag = 1;

            }
            if (firstname.Contains("ö"))
            {
                if (firstname.IndexOf("ö") == 0)
                {
                    firstnameini = "o";
                    firstnameiniall = "oe";
                    firstname = firstname.Replace("ö", "oe");
                }
                else
                {
                    firstname = firstname.Replace("ö", "oe");
                }
                flag = 1;

            }
            if (firstname.Contains("ü"))
            {
                if (firstname.IndexOf("ü") == 0)
                {
                    firstnameini = "u";
                    firstnameiniall = "ue";
                    firstname = firstname.Replace("ü", "ue");
                }
                else
                {
                    firstname = firstname.Replace("ü", "ue");
                }
                flag = 1;

            }
            if (lastname.Contains("ä"))
            {
                if (lastname.IndexOf("ä") == 0)
                {
                    lastnameini = "a";
                    lastnameiniall = "ae";
                    lastname = lastname.Replace("ä", "ae");
                }
                else
                {
                    lastname = lastname.Replace("ä", "ae");
                }
                flag = 1;

            }
            if (lastname.Contains("ö"))
            {
                if (lastname.IndexOf("ö") == 0)
                {
                    lastnameini = "o";
                    lastnameiniall = "oe";
                    lastname = lastname.Replace("ö", "oe");
                }
                else
                {
                    lastname = lastname.Replace("ö", "oe");
                }
                flag = 1;
            }
            if (lastname.Contains("ü"))
            {
                if (lastname.IndexOf("ü") == 0)
                {
                    lastnameini = "u";
                    lastnameiniall = "ue";
                    lastname = lastname.Replace("ü", "ue");
                }
                else
                {
                    lastname = lastname.Replace("ü", "ue");
                }
                flag = 1;
            }





            string emailsuffix;
            string ctyemailsuffix;

            if (firstname == "")
            {
                MessageBox.Show("First name cannot be empty!", "Warning");
            }
            else if (lastname == "")
            {
                MessageBox.Show("Last name cannot be empty!", "Warning");
            }
            else if (email == "")
            {
                MessageBox.Show("Email suffix cannot be empty!", "Warning");
            }
            else
            {
                emailsuffix = "@" + this.tb4.Text + ".com";
                if (this.cb2.SelectedItem == null)
                {
                    tbr2.Visible = false;
                    ctyemailsuffix = "@" + this.tb4.Text + this.cb2.SelectedItem;
                }
                else
                {
                    tbr2.Visible = true;
                    ctyemailsuffix = "@" + this.tb4.Text + this.cb2.SelectedItem;
                }



                string middlename = this.tb3.Text;
                string middlenameini;
                string middlenameiniall;
                if (middlename != "")
                {
                    middlenameini = this.tb3.Text.Substring(0, 1);
                    middlenameiniall = middlenameini;
                    if (middlenameini.Contains("ä"))
                    {
                        middlenameiniall = "ae";
                        middlenameini = "a";

                        flag = 1;

                    }
                    if (middlenameini.Contains("ö"))
                    {
                        middlenameiniall = "oe";
                        middlenameini = "o";
                        flag = 1;
                    }
                    if (middlenameini.Contains("ü"))
                    {
                        middlenameiniall = "ue";
                        middlenameini = "u";
                        flag = 1;
                    }

                    this.tbr1.Text = System.Environment.NewLine + firstname + "." + lastname + emailsuffix +
                   System.Environment.NewLine + firstname + "_" + lastname + emailsuffix +
                   System.Environment.NewLine + firstname + "-" + lastname + emailsuffix +
                   System.Environment.NewLine + firstname + lastname + emailsuffix +
                   System.Environment.NewLine + lastname + "." + firstname + emailsuffix +
                   System.Environment.NewLine + lastname + "_" + firstname + emailsuffix +
                   System.Environment.NewLine + lastname + "-" + firstname + emailsuffix +
                   System.Environment.NewLine + lastname + firstname + emailsuffix +
                   System.Environment.NewLine + firstnameini + "." + lastname + emailsuffix +
                   System.Environment.NewLine + firstnameini + "_" + lastname + emailsuffix +
                   System.Environment.NewLine + firstnameini + "-" + lastname + emailsuffix +
                   System.Environment.NewLine + firstnameini + lastname + emailsuffix +
                   System.Environment.NewLine + lastname + "." + firstnameini + emailsuffix +
                   System.Environment.NewLine + lastname + "_" + firstnameini + emailsuffix +
                   System.Environment.NewLine + lastname + "-" + firstnameini + emailsuffix +
                   System.Environment.NewLine + lastname + firstnameini + emailsuffix +
                   System.Environment.NewLine + firstname + "." + lastnameini + emailsuffix +
                   System.Environment.NewLine + firstname + "_" + lastnameini + emailsuffix +
                   System.Environment.NewLine + firstname + "-" + lastnameini + emailsuffix +
                   System.Environment.NewLine + firstname + lastnameini + emailsuffix +
                   System.Environment.NewLine + lastnameini + "." + firstname + emailsuffix +
                   System.Environment.NewLine + lastnameini + "_" + firstname + emailsuffix +
                   System.Environment.NewLine + lastnameini + "-" + firstname + emailsuffix +
                   System.Environment.NewLine + lastnameini + firstname + emailsuffix +
                   System.Environment.NewLine + firstname + emailsuffix +
                   System.Environment.NewLine + lastname + emailsuffix +
                   System.Environment.NewLine + firstnameini + middlenameini + lastname + emailsuffix;
                    if (flag == 1)
                    {

                        this.tbr1.Text += 
                        System.Environment.NewLine + firstnameiniall + "." + lastname + emailsuffix +
                        System.Environment.NewLine + firstnameiniall + "_" + lastname + emailsuffix +
                        System.Environment.NewLine + firstnameiniall + "-" + lastname + emailsuffix +
                        System.Environment.NewLine + firstnameiniall + lastname + emailsuffix +
                        System.Environment.NewLine + lastname + "." + firstnameiniall + emailsuffix +
                        System.Environment.NewLine + lastname + "_" + firstnameiniall + emailsuffix +
                        System.Environment.NewLine + lastname + "-" + firstnameiniall + emailsuffix +
                        System.Environment.NewLine + lastname + firstnameiniall + emailsuffix +
                        System.Environment.NewLine + firstname + "." + lastnameiniall + emailsuffix +
                        System.Environment.NewLine + firstname + "_" + lastnameiniall + emailsuffix +
                        System.Environment.NewLine + firstname + "-" + lastnameiniall + emailsuffix +
                        System.Environment.NewLine + firstname + lastnameiniall + emailsuffix +
                        System.Environment.NewLine + lastnameiniall + "." + firstname + emailsuffix +
                        System.Environment.NewLine + lastnameiniall + "_" + firstname + emailsuffix +
                        System.Environment.NewLine + lastnameiniall + "-" + firstname + emailsuffix +
                        System.Environment.NewLine + lastnameiniall + firstname + emailsuffix +
                        System.Environment.NewLine + firstnameiniall + middlenameiniall + lastname + emailsuffix;
                    }

                    this.tbr2.Text = System.Environment.NewLine + firstname + "." + lastname + ctyemailsuffix +
                                          System.Environment.NewLine + firstname + "_" + lastname + ctyemailsuffix +
                                          System.Environment.NewLine + firstname + "-" + lastname + ctyemailsuffix +
                                          System.Environment.NewLine + firstname + lastname + ctyemailsuffix +
                                          System.Environment.NewLine + lastname + "." + firstname + ctyemailsuffix +
                                          System.Environment.NewLine + lastname + "_" + firstname + ctyemailsuffix +
                                          System.Environment.NewLine + lastname + "-" + firstname + ctyemailsuffix +
                                          System.Environment.NewLine + lastname + firstname + ctyemailsuffix +
                                          System.Environment.NewLine + firstnameini + "." + lastname + ctyemailsuffix +
                                          System.Environment.NewLine + firstnameini + "_" + lastname + ctyemailsuffix +
                                          System.Environment.NewLine + firstnameini + "-" + lastname + ctyemailsuffix +
                                          System.Environment.NewLine + firstnameini + lastname + ctyemailsuffix +
                                          System.Environment.NewLine + lastname + "." + firstnameini + ctyemailsuffix +
                                          System.Environment.NewLine + lastname + "_" + firstnameini + ctyemailsuffix +
                                          System.Environment.NewLine + lastname + "-" + firstnameini + ctyemailsuffix +
                                          System.Environment.NewLine + lastname + firstnameini + ctyemailsuffix +
                                          System.Environment.NewLine + firstname + "." + lastnameini + ctyemailsuffix +
                                          System.Environment.NewLine + firstname + "_" + lastnameini + ctyemailsuffix +
                                          System.Environment.NewLine + firstname + "-" + lastnameini + ctyemailsuffix +
                                          System.Environment.NewLine + firstname + lastnameini + ctyemailsuffix +
                                          System.Environment.NewLine + lastnameini + "." + firstname + ctyemailsuffix +
                                          System.Environment.NewLine + lastnameini + "_" + firstname + ctyemailsuffix +
                                          System.Environment.NewLine + lastnameini + "-" + firstname + ctyemailsuffix +
                                          System.Environment.NewLine + lastnameini + firstname + ctyemailsuffix +
                                          System.Environment.NewLine + firstname + ctyemailsuffix +
                                          System.Environment.NewLine + lastname + ctyemailsuffix +
                                            System.Environment.NewLine + firstnameini + middlenameini + lastname + ctyemailsuffix;
                    if (flag == 1)
                    {

                        this.tbr2.Text += 
                        System.Environment.NewLine + firstnameiniall + "." + lastname + ctyemailsuffix +
                        System.Environment.NewLine + firstnameiniall + "_" + lastname + ctyemailsuffix +
                        System.Environment.NewLine + firstnameiniall + "-" + lastname + ctyemailsuffix +
                        System.Environment.NewLine + firstnameiniall + lastname + ctyemailsuffix +
                        System.Environment.NewLine + lastname + "." + firstnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + lastname + "_" + firstnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + lastname + "-" + firstnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + lastname + firstnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + firstname + "." + lastnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + firstname + "_" + lastnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + firstname + "-" + lastnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + firstname + lastnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + lastnameiniall + "." + firstname + ctyemailsuffix +
                        System.Environment.NewLine + lastnameiniall + "_" + firstname + ctyemailsuffix +
                        System.Environment.NewLine + lastnameiniall + "-" + firstname + ctyemailsuffix +
                        System.Environment.NewLine + lastnameiniall + firstname + ctyemailsuffix +
                        System.Environment.NewLine + firstnameiniall + middlenameiniall + lastname + ctyemailsuffix;
                    }


                }
                else
                {
                    this.tbr1.Text = System.Environment.NewLine + firstname + "." + lastname + emailsuffix +
                   System.Environment.NewLine + firstname + "_" + lastname + emailsuffix +
                   System.Environment.NewLine + firstname + "-" + lastname + emailsuffix +
                   System.Environment.NewLine + firstname + lastname + emailsuffix +
                   System.Environment.NewLine + lastname + "." + firstname + emailsuffix +
                   System.Environment.NewLine + lastname + "_" + firstname + emailsuffix +
                   System.Environment.NewLine + lastname + "-" + firstname + emailsuffix +
                   System.Environment.NewLine + lastname + firstname + emailsuffix +
                   System.Environment.NewLine + firstnameini + "." + lastname + emailsuffix +
                   System.Environment.NewLine + firstnameini + "_" + lastname + emailsuffix +
                   System.Environment.NewLine + firstnameini + "-" + lastname + emailsuffix +
                   System.Environment.NewLine + firstnameini + lastname + emailsuffix +
                   System.Environment.NewLine + lastname + "." + firstnameini + emailsuffix +
                   System.Environment.NewLine + lastname + "_" + firstnameini + emailsuffix +
                   System.Environment.NewLine + lastname + "-" + firstnameini + emailsuffix +
                   System.Environment.NewLine + lastname + firstnameini + emailsuffix +
                   System.Environment.NewLine + firstname + "." + lastnameini + emailsuffix +
                   System.Environment.NewLine + firstname + "_" + lastnameini + emailsuffix +
                   System.Environment.NewLine + firstname + "-" + lastnameini + emailsuffix +
                   System.Environment.NewLine + firstname + lastnameini + emailsuffix +
                   System.Environment.NewLine + lastnameini + "." + firstname + emailsuffix +
                   System.Environment.NewLine + lastnameini + "_" + firstname + emailsuffix +
                   System.Environment.NewLine + lastnameini + "-" + firstname + emailsuffix +
                   System.Environment.NewLine + lastnameini + firstname + emailsuffix +
                   System.Environment.NewLine + firstname + emailsuffix +
                   System.Environment.NewLine + lastname + emailsuffix;
                    if (flag == 1)
                    {

                        this.tbr1.Text += 
                        System.Environment.NewLine + firstnameiniall + "." + lastname + emailsuffix +
                        System.Environment.NewLine + firstnameiniall + "_" + lastname + emailsuffix +
                        System.Environment.NewLine + firstnameiniall + "-" + lastname + emailsuffix +
                        System.Environment.NewLine + firstnameiniall + lastname + emailsuffix +
                        System.Environment.NewLine + lastname + "." + firstnameiniall + emailsuffix +
                        System.Environment.NewLine + lastname + "_" + firstnameiniall + emailsuffix +
                        System.Environment.NewLine + lastname + "-" + firstnameiniall + emailsuffix +
                        System.Environment.NewLine + lastname + firstnameiniall + emailsuffix +
                        System.Environment.NewLine + firstname + "." + lastnameiniall + emailsuffix +
                        System.Environment.NewLine + firstname + "_" + lastnameiniall + emailsuffix +
                        System.Environment.NewLine + firstname + "-" + lastnameiniall + emailsuffix +
                        System.Environment.NewLine + firstname + lastnameiniall + emailsuffix +
                        System.Environment.NewLine + lastnameiniall + "." + firstname + emailsuffix +
                        System.Environment.NewLine + lastnameiniall + "_" + firstname + emailsuffix +
                        System.Environment.NewLine + lastnameiniall + "-" + firstname + emailsuffix +
                        System.Environment.NewLine + lastnameiniall + firstname + emailsuffix;
                      
                    }

                    this.tbr2.Text = System.Environment.NewLine + firstname + "." + lastname + ctyemailsuffix +
                                         System.Environment.NewLine + firstname + "_" + lastname + ctyemailsuffix +
                                         System.Environment.NewLine + firstname + "-" + lastname + ctyemailsuffix +
                                         System.Environment.NewLine + firstname + lastname + ctyemailsuffix +
                                         System.Environment.NewLine + lastname + "." + firstname + ctyemailsuffix +
                                         System.Environment.NewLine + lastname + "_" + firstname + ctyemailsuffix +
                                         System.Environment.NewLine + lastname + "-" + firstname + ctyemailsuffix +
                                         System.Environment.NewLine + lastname + firstname + ctyemailsuffix +
                                         System.Environment.NewLine + firstnameini + "." + lastname + ctyemailsuffix +
                                         System.Environment.NewLine + firstnameini + "_" + lastname + ctyemailsuffix +
                                         System.Environment.NewLine + firstnameini + "-" + lastname + ctyemailsuffix +
                                         System.Environment.NewLine + firstnameini + lastname + ctyemailsuffix +
                                         System.Environment.NewLine + lastname + "." + firstnameini + ctyemailsuffix +
                                         System.Environment.NewLine + lastname + "_" + firstnameini + ctyemailsuffix +
                                         System.Environment.NewLine + lastname + "-" + firstnameini + ctyemailsuffix +
                                         System.Environment.NewLine + lastname + firstnameini + ctyemailsuffix +
                                         System.Environment.NewLine + firstname + "." + lastnameini + ctyemailsuffix +
                                         System.Environment.NewLine + firstname + "_" + lastnameini + ctyemailsuffix +
                                         System.Environment.NewLine + firstname + "-" + lastnameini + ctyemailsuffix +
                                         System.Environment.NewLine + firstname + lastnameini + ctyemailsuffix +
                                         System.Environment.NewLine + lastnameini + "." + firstname + ctyemailsuffix +
                                         System.Environment.NewLine + lastnameini + "_" + firstname + ctyemailsuffix +
                                         System.Environment.NewLine + lastnameini + "-" + firstname + ctyemailsuffix +
                                         System.Environment.NewLine + lastnameini + firstname + ctyemailsuffix +
                                         System.Environment.NewLine + firstname + ctyemailsuffix +
                                         System.Environment.NewLine + lastname + ctyemailsuffix;
                    if (flag == 1)
                    {

                        this.tbr2.Text +=
                        System.Environment.NewLine + firstnameiniall + "." + lastname + ctyemailsuffix +
                        System.Environment.NewLine + firstnameiniall + "_" + lastname + ctyemailsuffix +
                        System.Environment.NewLine + firstnameiniall + "-" + lastname + ctyemailsuffix +
                        System.Environment.NewLine + firstnameiniall + lastname + ctyemailsuffix +
                        System.Environment.NewLine + lastname + "." + firstnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + lastname + "_" + firstnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + lastname + "-" + firstnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + lastname + firstnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + firstname + "." + lastnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + firstname + "_" + lastnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + firstname + "-" + lastnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + firstname + lastnameiniall + ctyemailsuffix +
                        System.Environment.NewLine + lastnameiniall + "." + firstname + ctyemailsuffix +
                        System.Environment.NewLine + lastnameiniall + "_" + firstname + ctyemailsuffix +
                        System.Environment.NewLine + lastnameiniall + "-" + firstname + ctyemailsuffix +
                        System.Environment.NewLine + lastnameiniall + firstname + ctyemailsuffix;
                       
                    }

                }
            }




        }







        private void btn3_Click(object sender, EventArgs e)
        {


            if (this.cb1.SelectedIndex == 0)
            {
                f2.Text = "About me";
                f2.lblintro.Text = "This is an Email Address Generator. \n\nWe give you all the possible combinations of someone's Email Address. \n\n                        By: Michael Pan\n                            Bruce Qu  ";
                f2.btnclose.Text = "Close";
            }
            else if (this.cb1.SelectedIndex == 1)
            {
                f2.Text = "关于";
                f2.lblintro.Text = "    这是一个Email地址生成器。\n\n    我们给你某人所有可能的Email地址。\n\n                         By: 潘宇腾\n                             瞿鹿鸣 ";
                f2.btnclose.Text = "关闭";
            }
            f2.ShowDialog();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb1.SelectedIndex == 0)
            {
                this.Text = "Email Address Generator";
                this.gb1.Text = "Parameters";
                this.lblang.Text = "Choose Language";
                this.lbfirst.Text = "Example: Bruce";
                this.lblast.Text = "Example: Qu";
                this.lbemail.Text = "Example: deloitte";
                this.lbmiddle.Text = "Example: Michael";

                this.lbl1.Text = "First Name";
                this.lbl2.Text = "Last Name";
                this.lbl3.Text = "Middle Name";
                this.lbl4.Text = "Company Email" + "\n" + "Suffix";
                this.cty_lb.Text = "Country" + "\n" + "Suffix";

                this.btn1.Text = "Retry";
                this.btn2.Text = "Generate";
                this.btn3.Text = "About me";
                this.btn4.Text = "Exit";




            }
            else if (this.cb1.SelectedIndex == 1)
            {
                this.Text = "Email地址生成器";
                this.gb1.Text = "设置参数";
                this.lblang.Text = " 选择语言：";
                this.lbfirst.Text = "例如：Bruce";
                this.lblast.Text = "例如：Qu";
                this.lbemail.Text = "例如:deloitte";
                this.lbmiddle.Text = "例如：Michael";

                this.lbl1.Text = "       名：";
                this.lbl2.Text = "       姓：";
                this.lbl3.Text = "   中间名：";
                this.lbl4.Text = "Email后缀：";
                this.cty_lb.Text = "国家后缀：";


                this.btn1.Text = "重试";
                this.btn2.Text = "生成";
                this.btn3.Text = "关于";
                this.btn4.Text = "退出";


            }
        }











    }
    
}
