using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryMethodInWinForms
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
            var studentList = students.Where(s => s.Age < 20);

            // DataGriview 欄位對應
            this.dataGridView1.DataSource = students;
            this.dataGridView1.Columns["StudentId"].HeaderText = "學號";
            this.dataGridView1.Columns["StudentName"].HeaderText = "姓名";
            this.dataGridView1.Columns["Age"].HeaderText = "年齡";
            this.dataGridView1.Columns["Region"].HeaderText = "國家";
            this.dataGridView1.Columns["City"].HeaderText = "城市";
        }

        private List<Student> GetStudents() => new List<Student>
            {
                new Student { StudentId = "B11002555", StudentName = "Peter", Age = 20, Region="臺灣", City = "台北市" },
                new Student { StudentId = "B11002556", StudentName = "Mary", Age = 21, Region="臺灣", City = "台北市"},
                new Student { StudentId = "B11002557", StudentName = "James", Age = 20, Region="臺灣", City = "新北市"},
                new Student { StudentId = "B11002558", StudentName = "Tommy", Age = 21, Region = "臺灣", City = "台中市"},
                new Student { StudentId = "B11002559", StudentName = "Sam", Age = 20, Region = "臺灣", City = "台南市"},
                new Student { StudentId = "B11002560", StudentName = "David", Age = 21, Region = "臺灣", City = "高雄市"},
                new Student { StudentId = "B11002561", StudentName = "Andy", Age = 20, Region = "臺灣", City = "台北市"},
                new Student { StudentId = "B11002562", StudentName = "Satoshi", Age = 21, Region = "日本", City = "東京都"},
                new Student { StudentId = "B11002563", StudentName = "Yoshiko", Age = 20, Region = "日本", City = "青森縣"},
                new Student { StudentId = "B11002564", StudentName = "kageyama", Age = 15, Region = "日本", City = "宮城縣"},
                new Student { StudentId = "B11002565", StudentName = "hinata", Age = 15, Region = "日本", City = "宮城縣"},
                new Student { StudentId = "B11002566", StudentName = "asahi", Age = 18, Region = "日本", City = "宮城縣"},
                new Student { StudentId = "B11002567", StudentName = "kioko", Age = 18, Region = "日本", City = "宮城縣"},
            };
    }
}
