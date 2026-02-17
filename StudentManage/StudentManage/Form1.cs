using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManager
{
    public partial class Form1 : Form
    {
        // Коллекция студентов
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик кнопки добавления
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (!string.IsNullOrEmpty(name))
            {
                students.Add(new Student { Name = name });
                UpdateStudentList();
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Введите имя студента.");
            }
        }

        // Обработчик кнопки удаления
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem is Student selectedStudent)
            {
                students.Remove(selectedStudent);
                UpdateStudentList();
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления.");
            }
        }

        // Метод обновления списка
        private void UpdateStudentList()
        {
            listBoxStudents.Items.Clear();
            listBoxStudents.Items.AddRange(students.ToArray());
        }
    }

    // Класс студента
    public class Student
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}