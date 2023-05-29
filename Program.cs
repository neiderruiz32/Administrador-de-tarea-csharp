using Software_prueba_tecnica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// --- Modelo ---
public class TaskModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
}

// --- Vista ---
public class TaskView : Form
{
    private ListBox tasksListBox;
    private TextBox idTextBox;
    private TextBox titleTextBox;
    private TextBox descriptionTextBox;
    private Button addButton;
    private Button displayButton;
    private Button markCompletedButton;
    private Button editButton;
    private Button deleteButton;

    private TaskController controller;

    public TaskView(TaskController controller)
    {
        this.controller = controller;

        InitializeComponents();
    }

    public TaskView()
    {
    }

    private void InitializeComponents()
    {
        tasksListBox = new ListBox();
        tasksListBox.Dock = DockStyle.Fill;

        idTextBox = new TextBox();
        titleTextBox = new TextBox();
        descriptionTextBox = new TextBox();

        addButton = new Button();
        addButton.Text = "Agregar Tarea";
        addButton.Click += AddButton_Click;

        displayButton = new Button();
        displayButton.Text = "Mostrar Tareas";
        displayButton.Click += DisplayButton_Click;

        markCompletedButton = new Button();
        markCompletedButton.Text = "Marcar como Completada";

        editButton = new Button();
        editButton.Text = "Editar Tarea";
        editButton.Click += EditButton_Click;

        deleteButton = new Button();
        deleteButton.Text = "Eliminar Tarea";
        deleteButton.Click += DeleteButton_Click;

        TableLayoutPanel layoutPanel = new TableLayoutPanel();
        layoutPanel.Dock = DockStyle.Fill;
        layoutPanel.RowStyles.Clear();
        layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        layoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        layoutPanel.Controls.Add(tasksListBox, 0, 0);
        layoutPanel.Controls.Add(idTextBox, 0, 1);
        layoutPanel.Controls.Add(titleTextBox, 1, 1);
        layoutPanel.Controls.Add(descriptionTextBox, 2, 1);
        layoutPanel.Controls.Add(addButton, 3, 1);
        layoutPanel.Controls.Add(displayButton, 0, 2);
        layoutPanel.Controls.Add(markCompletedButton, 1, 2);
        layoutPanel.Controls.Add(editButton, 2, 2);
        layoutPanel.Controls.Add(deleteButton, 3, 2);

        Controls.Add(layoutPanel);
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        int id;
        if (int.TryParse(idTextBox.Text, out id))
        {
            TaskModel task = new TaskModel()
            {
                Id = id,
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                Completed = false
            };
            controller.AddTask(task);
        }
        else
        {
            MessageBox.Show("ID inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DisplayButton_Click(object sender, EventArgs e)
    {
        controller.DisplayTasks();
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
        int taskId;
        if (int.TryParse(idTextBox.Text, out taskId))
        {
            controller.EditTask(taskId);
        }
        else
        {
            MessageBox.Show("ID inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        int taskId;
        if (int.TryParse(idTextBox.Text, out taskId))
        {
            controller.DeleteTask(taskId);
        }
        else
        {
            MessageBox.Show("ID inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void DisplayTasks(List<TaskModel> tasks)
    {
        tasksListBox.Items.Clear();
        foreach (var task in tasks)
        {
            tasksListBox.Items.Add($"ID: {task.Id} | Título: {task.Title} | Descripción: {task.Description} | Completada: {task.Completed}");
        }
    }

    internal void SetController(TaskController controller)
    {
        this.controller = controller;
    }
}

// --- Controlador ---
public class TaskController
{
    private Dictionary<int, TaskModel> tasks;
    private TaskView view;

    public TaskController()
    {
        tasks = new Dictionary<int, TaskModel>();
    }

    public TaskController(TaskView view)
    {
        this.view = view;
    }

    public void AddTask(TaskModel task)
    {
        tasks[task.Id] = task;
    }

    public void DisplayTasks()
    {
        view.DisplayTasks(tasks.Values.ToList());
    }



    public void EditTask(int taskId)
    {
        if (tasks.TryGetValue(taskId, out TaskModel task))
        {
            // Aquí puedes mostrar un formulario de edición para modificar el título y la descripción de la tarea
            // y actualizar los valores en el objeto TaskModel.

            MessageBox.Show("Tarea actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Tarea no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void DeleteTask(int taskId)
    {
        if (tasks.Remove(taskId))
        {
            MessageBox.Show("Tarea eliminada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Tarea no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    internal List<TaskModel> GetAllTasks()
    {
        return tasks.Values.ToList();
    }

    internal TaskModel GetTaskById(int selectedTaskId)
    {
        if (tasks.TryGetValue(selectedTaskId, out TaskModel task))
        {
            return task;
        }
        else
        {
            return null;
        }
    }

    internal void DeleteTask(TaskModel selectedTask)
    {
        if (tasks.ContainsKey(selectedTask.Id))
        {
            tasks.Remove(selectedTask.Id);
        }
        else
        {
            MessageBox.Show("Seleccione tarea a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    internal TaskModel FindTaskById(int taskId)
    {
        if (tasks.TryGetValue(taskId, out TaskModel task))
        {
            return task;
        }
        else
        {
            return null;
        }
    }
}

// --- Programa Principal ---
class Program
{
    static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        TaskView view = new TaskView();
        TaskController controller = new TaskController(view);

        view.SetController(controller); // Agrega este método para establecer el controlador en la vista

        Application.Run(new AdministradorDeTareas());
    }
}

