using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Software_prueba_tecnica
{
    public partial class AdministradorDeTareas : Form
    {
        private TaskController controller;
        private TaskView taskView;

        public AdministradorDeTareas()
        {
            // Crea una instancia del controlador y la vista
            InitializeComponent();
            controller = new TaskController();
            taskView = new TaskView(controller);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        private void buttonAddTask_Click_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBoxId.Text, out id))
            {
                // Crea un nuevo objeto TaskModel con los datos ingresados
                TaskModel task = new TaskModel
                {
                    Id = id,
                    Title = textBoxTitle.Text,
                    Description = textBoxDescription.Text,
                    Completed = false
                };
                // Agrega la tarea al controlador
                controller.AddTask(task);
                RefreshTaskList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("ID inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            // Limpia los campos de entrada de texto
            textBoxId.Text = string.Empty;
            textBoxTitle.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
        }

        private void RefreshTaskList()
        {
            // Obtiene todas las tareas del controlador
            List<TaskModel> tasks = controller.GetAllTasks();
            // Limpia la lista de tareas en el ListBox
            listBoxTasks.Items.Clear();
            // Agrega las tareas al ListBox
            listBoxTasks.Items.AddRange(tasks.Select(task => $"{task.Id} - {task.Title}").ToArray());
        }

        private void buttonEditTask_Click_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxId.Text, out int selectedTaskId))
            {
                // Obtiene la tarea seleccionada por su ID
                TaskModel selectedTask = controller.GetTaskById(selectedTaskId);
                if (selectedTask != null)
                {
                    // Actualiza los campos de la tarea con los valores ingresados
                    selectedTask.Title = textBoxTitle.Text;
                    selectedTask.Description = textBoxDescription.Text;
                    RefreshTaskList();
                    ClearInputFields();
                    MessageBox.Show("Tarea actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ID inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteTask_Click_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxId.Text, out int selectedTaskId))
            {
                // Obtiene la tarea seleccionada por su ID
                TaskModel selectedTask = controller.GetTaskById(selectedTaskId);
                if (selectedTask != null)
                {
                    // Elimina la tarea del controlador
                    controller.DeleteTask(selectedTask);
                    RefreshTaskList();
                    ClearInputFields();
                    MessageBox.Show("Tarea eliminada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione la tarea a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                // Obtiene el ID de la tarea seleccionada en el ListBox
                int selectedTaskId = int.Parse(listBoxTasks.SelectedItem.ToString().Split('-')[0].Trim());
                // Obtiene la tarea seleccionada por su ID
                TaskModel selectedTask = controller.GetTaskById(selectedTaskId);
                if (selectedTask != null)
                {
                    // Muestra los detalles de la tarea en los campos de texto
                    textBoxId.Text = selectedTask.Id.ToString();
                    textBoxDescription.Text = selectedTask.Description;
                    textBoxTitle.Text = selectedTask.Title;
                }
            }
        }

        private void buttonSearchTask_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxId.Text, out int taskId))
            {
                // Busca una tarea por su ID
                TaskModel foundTask = controller.FindTaskById(taskId);
                if (foundTask != null)
                {
                    // La tarea se encontró, actualiza los campos de texto con los detalles de la tarea encontrada
                    textBoxTitle.Text = foundTask.Title;
                    textBoxDescription.Text = foundTask.Description;
                    // También puedes realizar cualquier otra acción necesaria aquí
                    MessageBox.Show("Tarea encontrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // No se encontró ninguna tarea con el ID especificado
                    MessageBox.Show("Tarea no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // El valor del ID no es un número válido
                MessageBox.Show("ID inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearTask_Click(object sender, EventArgs e)
        {
            // Limpia los campos de entrada de texto
            ClearInputFields();
        }

    }
}
