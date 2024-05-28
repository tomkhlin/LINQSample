using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinSampleInWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var students = GetStudents();
            var courses = GetCourses();

            ShowData(students, courses);
        }

        private void ShowData(List<Student> students, List<Course> courses)
        {
            this.dataGridView1.DataSource = courses;
            this.dataGridView1.Columns["CourseId"].HeaderText = "課程編號";
            this.dataGridView1.Columns["CourseName"].HeaderText = "課程名稱";
            this.dataGridView1.Columns["TeacherName"].HeaderText = "授課教師";
            this.dataGridView1.Columns["Credit"].HeaderText = "學分數";
            this.dataGridView1.Columns["IsRequired"].HeaderText = "是否為必修";

            this.dataGridView2.DataSource = students;
            this.dataGridView2.Columns["StudentId"].HeaderText = "學號";
            this.dataGridView2.Columns["StudentName"].HeaderText = "姓名";
            this.dataGridView2.Columns["Age"].HeaderText = "年齡";
            this.dataGridView2.Columns["Region"].HeaderText = "國家";
            this.dataGridView2.Columns["City"].HeaderText = "城市";
            this.dataGridView2.Columns["CourseId"].HeaderText = "課程編號";
            this.dataGridView2.Columns["Score"].HeaderText = "總分";

            this.panel1.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.dataGridView2);
        }

        private void ShowInnerJoinData(List<Student> students, List<Course> courses)
        {
            var result = from student in students
                         join course in courses on student.CourseId equals course.CourseId
                         where student.Score >= 60
                         select new
                         {
                             student.StudentId,
                             student.StudentName,
                             student.Age,
                             student.Region,
                             student.City,
                             student.CourseId,                             
                             course.CourseName,
                             course.TeacherName,
                             course.Credit,
                             course.IsRequired,
                             student.Score,
                         };
            this.dataGridView3.DataSource = result.ToList();
            this.dataGridView3.Columns["StudentId"].HeaderText = "學號";
            this.dataGridView3.Columns["StudentName"].HeaderText = "姓名";
            this.dataGridView3.Columns["Age"].HeaderText = "年齡";
            this.dataGridView3.Columns["Region"].HeaderText = "國家";
            this.dataGridView3.Columns["City"].HeaderText = "城市";
            this.dataGridView3.Columns["CourseId"].HeaderText = "課程編號";            
            this.dataGridView3.Columns["CourseName"].HeaderText = "課程名稱";
            this.dataGridView3.Columns["TeacherName"].HeaderText = "授課教師";
            this.dataGridView3.Columns["Credit"].HeaderText = "學分數";
            this.dataGridView3.Columns["IsRequired"].HeaderText = "是否為必修";
            this.dataGridView3.Columns["Score"].HeaderText = "總分";
        }

        //取得課程資料
        private List<Course> GetCourses() => new List<Course>
        {
            new Course { CourseId = "C11001", CourseName = "C#", TeacherName = "Dr.John", Credit = 3, IsRequired = false },
            new Course { CourseId = "C11002", CourseName = "Java", TeacherName = "Dr.Allen", Credit = 3, IsRequired = false },
            new Course { CourseId = "C11003", CourseName = "Python", TeacherName = "Dr.Tom", Credit = 3, IsRequired = true },
            new Course { CourseId = "C11004", CourseName = "C++", TeacherName = "Dr.David", Credit = 3, IsRequired = true },
            new Course { CourseId = "C11005", CourseName = "DataStructure", TeacherName = "Dr.James", Credit = 3, IsRequired = true },
            new Course { CourseId = "C11006", CourseName = "Algorithm", TeacherName = "Dr.Sam", Credit = 3, IsRequired = true },
        };

        //取得學生資料
        private List<Student> GetStudents() => new List<Student>
            {
                new Student { StudentId = "B11002555", StudentName = "Peter", Age = 20, Region="臺灣", City = "台北市", CourseId = "C11001", Score = 70},
                new Student { StudentId = "B11002556", StudentName = "Mary", Age = 21, Region="臺灣", City = "台北市", CourseId = "C11001", Score = 65},
                new Student { StudentId = "B11002557", StudentName = "James", Age = 20, Region="臺灣", City = "新北市", CourseId = "C11005", Score = 40},
                new Student { StudentId = "B11002558", StudentName = "Tommy", Age = 21, Region = "臺灣", City = "台中市", CourseId = "C11006", Score = 90},
                new Student { StudentId = "B11002559", StudentName = "Sam", Age = 20, Region = "臺灣", City = "台南市", CourseId = "C11005", Score = 50},
                new Student { StudentId = "B11002560", StudentName = "David", Age = 21, Region = "臺灣", City = "高雄市", CourseId = "C11006", Score = 75},
                new Student { StudentId = "B11002561", StudentName = "Andy", Age = 20, Region = "臺灣", City = "台北市", CourseId = "C11001", Score = 85},
                new Student { StudentId = "B11002562", StudentName = "Satoshi", Age = 21, Region = "日本", City = "東京都", CourseId = "C11003", Score = 30},
                new Student { StudentId = "B11002563", StudentName = "Yoshiko", Age = 20, Region = "日本", City = "青森縣", CourseId = "C11005", Score = 20},
                new Student { StudentId = "B11002564", StudentName = "Jenny", Age = 21, Region = "美國", City = "紐約市", CourseId = "C11003", Score = 95},
                new Student { StudentId = "B11002565", StudentName = "John", Age = 20, Region = "美國", City = "洛杉磯", CourseId = "C11005", Score = 70},
            };

        private void button1_Click(object sender, EventArgs e)
        {
            var students = GetStudents();
            var courses = GetCourses();
            ShowInnerJoinData(students, courses);
        }
    }
}
