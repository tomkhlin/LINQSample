using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryExpressionInWinForms
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

            // Query expression，取得所有學生
            var studentList = from student in students
                              select student;

            // 顯示學生資料            
            string display = "";
            foreach (var student in studentList)
            {
                display += $"學號: {student.StudentID}  名字: {student.StudentName}    國家及縣市: {student.Region}-{student.City}\n";
            }
            this.label1.Text = display;
        }

        private List<Student> GetStudents() => new List<Student>
            {
                new Student { StudentID = "B11002555", StudentName = "Peter", Age = 20, City = "台北市", Region="臺灣"},
                new Student { StudentID = "B11002556", StudentName = "Mary", Age = 21, City = "台北市", Region="臺灣"},
                new Student { StudentID = "B11002557", StudentName = "James", Age = 20, City = "新北市", Region="臺灣"},
                new Student { StudentID = "B11002558", StudentName = "Tommy", Age = 21, City = "台中市", Region="臺灣"},
                new Student { StudentID = "B11002559", StudentName = "Sam", Age = 20, City = "台南市", Region="臺灣"},
                new Student { StudentID = "B11002560", StudentName = "David", Age = 21, City = "高雄市", Region="臺灣"},
                new Student { StudentID = "B11002561", StudentName = "Andy", Age = 20, City = "台北市", Region="臺灣"},
                new Student { StudentID = "B11002562", StudentName = "Satoshi", Age = 21, City = "東京都", Region = "日本"},
                new Student { StudentID = "B11002563", StudentName = "Yoshiko", Age = 20, City = "青森縣", Region = "日本"},
                new Student { StudentID = "B11002564", StudentName = "kageyama", Age = 15, City = "宮城縣", Region = "日本"},
                new Student { StudentID = "B11002565", StudentName = "hinata", Age = 15, City = "宮城縣", Region = "日本"},
                new Student { StudentID = "B11002566", StudentName = "asahi", Age = 18, City = "宮城縣", Region = "日本"},
                new Student { StudentID = "B11002567", StudentName = "kioko", Age = 18, City = "宮城縣", Region = "日本"},
            };
    }
}
