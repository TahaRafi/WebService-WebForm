using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeServicesCourseGradingWeb
{
    
    public partial class Form1 : Form
    {
        public static int count1 = 1;
      static public  List<int> ListStudent = new List<int>();
        static public List<string> ListStudentAssess= new List<string>();
        Tmp.Service service = new Tmp.Service();
        List<TextBox> listA = new List<TextBox>();
        List<TextBox> listB = new List<TextBox>();
        List<TextBox> listC = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            try
            {
                int txtno = int.Parse(textBox1.Text);
                Console.WriteLine(txtno);
                int pointX = 0;
                int pointY = 5;
                
                panel2.Controls.Clear();
                int count = 11;
                for (int i = 0; i < txtno; i++)
                {
                    TextBox a = new TextBox();
                    TextBox b = new TextBox();
                    TextBox c = new TextBox();
                    ////a
                  
                    a.Location = new Point(pointX, pointY);
                    a.Name = "textbox" + count;
                    panel2.Controls.Add(a);
                    pointX += 100;
                    listA.Add(a);
                  
                    /////b
                    
                    b.Location = new Point(pointX, pointY);
                    b.Name = "textbox" + count;
                    panel2.Controls.Add(b);
                    pointX += 100;
                    listB.Add(b);
                    /////c
                   
                    c.Location = new Point(pointX, pointY);
                    c.Name = "textbox" + count;
                    panel2.Controls.Add(c);
                    listC.Add(c);


                    panel2.Show();
                    pointY += 20;
                    pointX = 0;
                    count++;
                }

               



            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listA.Count; i++)
            {
                String a1 = listA[i].Text;
                int a = int.Parse(a1); 
               if(!ListStudent.Contains(a))
                {
                    ListStudent.Add(a);
                }
                service.InsertStudent(a, listB[i].Text, listC[i].Text);

            }
            listA.Clear();
            listB.Clear();
            listC.Clear();
            label9.Text = "Data Successfully Submitted";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        ////////////////////////////INSERTASSESSMENT///////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        List<TextBox> Date = new List<TextBox>();
        List<TextBox> Mark = new List<TextBox>();
        List<TextBox> TotalMarks = new List<TextBox>();
        List<TextBox>  TotalGrades= new List<TextBox>();
        List<String> mylist = new List<string>();
        
        private void Add_Assessment_Click(object sender, EventArgs e)
        {

           
            mylist.Add("Assignment");
            mylist.Add("Midterm");
            mylist.Add("Final");

            


            try
            {
               
                int pointX = 0;
                int pointY = 5;

                panel3.Controls.Clear();
                int intmylist = 0;
                
                int count = 21;
                
                for (int i = 0; i <ListStudent.Count; i++)
                {


                 

                        TextBox a = new TextBox();
                        TextBox b = new TextBox();
                        TextBox c = new TextBox();
                        TextBox d = new TextBox();
                        TextBox E = new TextBox();
                         TextBox f = new TextBox();
                    a.Location = new Point(pointX, pointY);
                       // a.Text =;
                        a.Name = "textbox" + count;
                        a.Text = a.Text + ListStudent[i];
                        panel3.Controls.Add(a);
                        pointX += 100;
                       
                        /////b

                        b.Location = new Point(pointX, pointY);
                        b.Text = "Quiz";
                        b.Name = "textbox" + count;
                        panel3.Controls.Add(b);
                        pointX += 100;

                    /////c
                    DateTime time = DateTime.Now;             // Use current time.
                    string format = "dd-mm-yyyy";
                    c.Location = new Point(pointX, pointY);
                        c.Name = "textbox" + count;
                    c.Text = DateTime.Now.ToLongTimeString();
                    Date.Add(c);
                        panel3.Controls.Add(c);
                        pointX += 100;

                        ///////////d
                        d.Location = new Point(pointX, pointY);
                        d.Name = "textbox" + count;
                        Mark.Add(d);
                        panel3.Controls.Add(d);
                        pointX += 100;
                    ////////E
                    E.Location = new Point(pointX, pointY);
                    E.Name = "textbox" + count;
                    TotalMarks.Add(E);
                    panel3.Controls.Add(E);
                    pointX += 100;

                    ////////F
                    f.Location = new Point(pointX, pointY);
                        f.Name = "textbox" + count;
                        TotalGrades.Add(f);
                        panel3.Controls.Add(f);


                    panel3.Show();
                        pointY += 20;
                        pointX = 0;
                      
                        
                    
                   
                    
                        intmylist = 0;
                        while(intmylist<3)
                        {
                            TextBox a1 = new TextBox();
                            TextBox b1 = new TextBox();
                            TextBox c1 = new TextBox();
                            TextBox d1 = new TextBox();
                            a1.Location = new Point(pointX, pointY);
                            // a.Text =;
                            a1.Name = "textbox" + count;
                            a1.Text = a1.Text + ListStudent[i];
                           // panel3.Controls.Add(a1);
                            pointX += 100;

                            /////b

                            b1.Location = new Point(pointX, pointY);
                            b1.Text = mylist[intmylist];
                            b1.Name = "textbox" + count;
                            panel3.Controls.Add(b1);
                            pointX += 100;

                            /////c

                            c1.Location = new Point(pointX, pointY);
                            c1.Name = "textbox" + count;
                            c1.Text = DateTime.Now.ToLongTimeString();
                        Date.Add(c1);
                              panel3.Controls.Add(c1);
                            pointX += 100;

                            ///////////d
                            d1.Location = new Point(pointX, pointY);
                            d1.Name = "textbox" + count;
                        Mark.Add(d1);
                        panel3.Controls.Add(d1);


                            panel3.Show();
                            pointY += 20;
                            pointX = 0;
                            intmylist++;
                        }

                        
                    
                    pointY += 20;
                    pointX = 0;
                   
                     count++;
                }





            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }

        }

        List<int> TotalMark = new List<int>();
        private void button2_Click(object sender, EventArgs e)
        {

            int count = 1;
            int k = 0;
           for(int i=0;i<ListStudent.Count;i++)
           {
                int sum = 0;
                int intmylist = 0;
                int AID = count;
                int SID = ListStudent[i];
                string AssessType = "Quiz";
                string date = Date[k].Text;
                string mark = Mark[k].Text;
                int a = int.Parse(mark);
                sum = a;
                service.InsertAssessments(AID,SID,AssessType,date,a);
                k++;count++;
               while(intmylist<3)
                {
                    AID = count;
                    SID = ListStudent[i];
                    AssessType = mylist[intmylist];
                    date = Date[k].Text;
                    mark = Mark[k].Text;
                    a = int.Parse(mark);
                    sum = sum + a;
                    service.InsertAssessments(AID, SID, AssessType, date, a);
                   k++; count++; intmylist++;
                }
                TotalMark.Add(sum);
                string marks = "";
                marks = marks + sum;
                TotalMarks[i].Text = marks;

            }//fori
        }


        List<char> TotalGradeShow = new List<char>();
        private void button3_Click(object sender, EventArgs e)
        {


           
            for(int i=0; i < TotalMark.Count;i++)
            {
                if(TotalMark[i]>=50 &&TotalMark[i]<62)
                {
                    TotalGrades[i].Text = "D";
                    TotalGradeShow.Add('D');

                }
                if (TotalMark[i] >= 62 && TotalMark[i] < 74)
                {
                    TotalGrades[i].Text = "C";
                    TotalGradeShow.Add('C');
                }
                if (TotalMark[i]>= 74 && TotalMark[i] < 86)
                {
                    TotalGrades[i].Text = "B";
                    TotalGradeShow.Add('B');
                }
                if (TotalMark[i] >= 86 && TotalMark[i] <=100)
                {
                    TotalGrades[i].Text = "A";
                    TotalGradeShow.Add('A');
                }
                if (TotalMark[i]<50)
                {
                    TotalGrades[i].Text = "F";
                    TotalGradeShow.Add('F');
                }

            }//for
            ////////////////////////////////////////////PRINT GRADE SHEET///////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////
            int pointX = 0;
            int pointY = 5;
            panel4.Controls.Clear();
 
            for (int i = 0; i <ListStudent.Count; i++)
            {
                string aa = "";
                aa = aa + TotalGradeShow[i];
                int SID = ListStudent[i];
                int Mark = TotalMark[i];

                service.InsertGrade(SID,Mark, aa);
                TextBox a = new TextBox();
                TextBox b = new TextBox();
                TextBox c = new TextBox();
                TextBox d = new TextBox();
                ////a

                a.Location = new Point(pointX, pointY);
                a.Text = a.Text+ListStudent[i];
                panel4.Controls.Add(a);
                pointX += 100;


                /////b

                b.Location = new Point(pointX, pointY);
                b.Text = b.Text +TotalMark[i];
                panel4.Controls.Add(b);
                pointX += 100;

                /////c

                c.Location = new Point(pointX, pointY);
                c.Text = c.Text+"100";
                panel4.Controls.Add(c);
                pointX += 100;

                //d
                d.Location = new Point(pointX, pointY);
                d.Text = d.Text + TotalGradeShow[i];
                panel4.Controls.Add(d);
                panel2.Show();

                pointY += 20;
                pointX = 0;
               
               
                
            }
            label16.Text = "Grade Sheet";
            label17.Text = "SID";
            label18.Text = "Marks";
            label19.Text = "Total Marks";
            label20.Text = "Grade";

            
        }////func end
        ///func





        //////////////////////////////////////////////////////InsertAssessmentLogic///////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
