using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }
        Student student = new Student();
        String cgpa;
        string path = @"F:\OneDrive - Higher Education Commission\Desktop\data.txt";
        static void ReadFile(ref List<Student> studentData)
        {
            using (StreamReader reader = new StreamReader(@"F:\OneDrive - Higher Education Commission\Desktop\data.txt"))
            {

                while (!reader.EndOfStream)
                {
                    Student obj = new Student();

                    obj.id = reader.ReadLine();
                    obj.name = reader.ReadLine();
                    obj.semester = reader.ReadLine();
                    obj.cgpa = Convert.ToDouble(reader.ReadLine());
                    obj.department = reader.ReadLine();
                    obj.university = reader.ReadLine();
                    obj.attendance = Convert.ToBoolean(reader.ReadLine());

                    studentData.Add(obj);


                }






            }









        }
        static List<Student> getTopThreeStudents(ref int firstIndex, ref int secondIndex, ref int thirdIndex, List<Student> list)
        {
            List<Student> resultList = new List<Student>(); //Onitialized for top 3 Students
            firstIndex = 0;
            secondIndex = 0;
            thirdIndex = 0;
            //Checking for top 3 Students
            for (int i = 1; i < list.Count; i++)
            {
                if (list[firstIndex].cgpa < list[i].cgpa)
                {
                    thirdIndex = secondIndex;
                    secondIndex = firstIndex;
                    firstIndex = i;
                }
                else if (list[secondIndex].cgpa < list[i].cgpa && list[secondIndex].cgpa < list[firstIndex].cgpa && list[firstIndex].cgpa != list[i].cgpa || list[secondIndex].cgpa == list[firstIndex].cgpa)
                {
                    secondIndex = i;
                }
                else if (list[thirdIndex].cgpa < list[i].cgpa && list[thirdIndex].cgpa < list[secondIndex].cgpa && list[secondIndex].cgpa != list[i].cgpa || list[thirdIndex].cgpa == list[secondIndex].cgpa)
                {
                    thirdIndex = i;
                }
            }
            resultList.Add(list[firstIndex]);
            resultList.Add(list[secondIndex]);
            resultList.Add(list[thirdIndex]);
            return resultList;
        }

        


        private void IDBox_TextChanged(object sender, EventArgs e)
        {

            student.id = IDBox.Text;

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

            student.name = NameBox.Text;

        }

        private void UniBox_TextChanged(object sender, EventArgs e)
        {

            student.university = UniBox.Text;

        }

        private void SemBox_TextChanged(object sender, EventArgs e)
        {

            student.semester = SemBox.Text;

        }

        private void DeptBox_TextChanged(object sender, EventArgs e)
        {
            student.department = DeptBox.Text;
        }

        private void CGPABox_TextChanged(object sender, EventArgs e)
        {
             cgpa = Convert.ToString(CGPABox.Text);
             student.attendance = false;
        }

        private void EnterRecButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(student.id) || string.IsNullOrEmpty(student.name) || string.IsNullOrEmpty(student.department) || string.IsNullOrEmpty(student.university))
            {


                MessageBox.Show("You left a field empty");


            }
            else
            {
                //Adding Student Record in File

                student.cgpa = Convert.ToDouble(cgpa);
                StreamWriter streamWriter = new StreamWriter(path, append: true);
                streamWriter.WriteLine(student.id);
                streamWriter.WriteLine(student.name);
                streamWriter.WriteLine(student.semester);
                streamWriter.WriteLine(student.cgpa);
                streamWriter.WriteLine(student.department);
                streamWriter.WriteLine(student.university);
                streamWriter.WriteLine(student.attendance);




                streamWriter.Close();
                MessageBox.Show("Record is saved for the student: " + student.name);
                List<Student> listForAll = new List<Student>();
                ReadFile(ref listForAll);

                dataGridView1.DataSource = listForAll;
                IDBox.Text = "";
                NameBox.Text = "";
                CGPABox.Text = "";
                SemBox.Clear();
                DeptBox.Text = "";
                UniBox.Text = "";


            }
        }

        private void ListAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            

            List<Student> listForAll = new List<Student>();
            ReadFile(ref listForAll);

            dataGridView1.DataSource = listForAll;
           
            
        }

        private void Top3RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            List<Student> listForTop = new List<Student>();
            //Taking data from file in list
            ReadFile(ref listForTop);
            int firstLargest = -1;
            int secondLargest = -1;
            int thirdLargest = -1;
            //calling function to return the list of top3 students
            List<Student> topThreeList = getTopThreeStudents(ref firstLargest, ref secondLargest, ref thirdLargest, listForTop);
            //adding list to grid for displaying
            dataGridView1.DataSource = topThreeList;




        }

        private void MarkAttButton_Click(object sender, EventArgs e)
        {


            





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            int indexAtten = e.RowIndex; //Taking index of which student's attandance is marked
            List<Student> listAttenMark = new List<Student>();
            //Getting data from file in List
            ReadFile(ref listAttenMark);
            if (listAttenMark[indexAtten].attendance == true)
            {
                listAttenMark[indexAtten].attendance = false;
            }
            else if (listAttenMark[indexAtten].attendance == false)
            {
                listAttenMark[indexAtten].attendance = true;
            }
            StreamWriter writer = new StreamWriter(path);
            writer.Write("");
            writer.Close();
            writer = File.AppendText(path);
            for (int i = 0; i < listAttenMark.Count; i++)
            {
                writer.WriteLine(listAttenMark[i].id);
                writer.WriteLine(listAttenMark[i].name);
                writer.WriteLine(listAttenMark[i].cgpa);
                writer.WriteLine(listAttenMark[i].semester);
                writer.WriteLine(listAttenMark[i].department);
                writer.WriteLine(listAttenMark[i].university);
                writer.WriteLine(listAttenMark[i].attendance);
            }
            writer.Close();


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = SearchBox.Text;

            List<Student> listDelete = new List<Student>();
            //getting data from file in list
            ReadFile(ref listDelete);

            for (int i = 0; i < listDelete.Count; i++)
            {
                if (listDelete[i].id == id)
                {
                   
                    listDelete.RemoveAt(i);
                }
            }

            StreamWriter stream = new StreamWriter(path);
            stream.Write("");
            stream.Close();
            stream = File.AppendText(path);
            for (int i = 0; i < listDelete.Count; i++)
            {
                // Writting updated list in text file
                stream.WriteLine(listDelete[i].id);
                stream.WriteLine(listDelete[i].name);
                stream.WriteLine(listDelete[i].cgpa);
                stream.WriteLine(listDelete[i].department);
                stream.WriteLine(listDelete[i].university);
                stream.WriteLine(listDelete[i].attendance);
            }
            stream.Close();
            MessageBox.Show("Record is Deleted Successfully");


            dataGridView1.DataSource = listDelete;



        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchById = SearchBox.Text;
            List<Student> listForId = new List<Student>();
            //getting data from file in list
            ReadFile(ref listForId);

            List<Student> listForId2 = new List<Student>();



            for (int i = 0; i < listForId.Count; i++)
            {
                if (listForId[i].id == searchById)
                {
                    MessageBox.Show("Name: " + listForId[i].name);

                   

                    listForId2.Add(listForId[i]);
                }
            }

            dataGridView1.DataSource = listForId2;
            SearchBox.Text = "";
        }
    }

    

}


