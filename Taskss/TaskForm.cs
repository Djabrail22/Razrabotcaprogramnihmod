using System;
using System.Windows.Forms;

public class TaskForm : Form
{
    private TaskManager taskManager = new TaskManager();
    private ListBox taskListBox;
    private TextBox titleTextBox;
    private TextBox descriptionTextBox;
    private Button addButton;
    private Button removeButton;

    public TaskForm()
    {
        // Инициализация элементов управления и их размещение
        // Добавить обработчики событий для кнопок
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        var task = new Task
        {
            Title = titleTextBox.Text,
            Description = descriptionTextBox.Text,
            IsCompleted = false
        };
        taskManager.AddTask(task);
        UpdateTaskList();
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
        if (taskListBox.SelectedItem is Task selectedTask)
        {
            taskManager.RemoveTask(selectedTask.Id);
            UpdateTaskList();
        }
    }

    private void UpdateTaskList()
    {
        taskListBox.Items.Clear();
        foreach (var task in taskManager.GetTasks())
        {
            taskListBox.Items.Add(task);
        }
    }
}

