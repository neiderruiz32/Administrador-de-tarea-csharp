namespace Software_prueba_tecnica
{
    partial class AdministradorDeTareas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorDeTareas));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonClearTask = new System.Windows.Forms.Button();
            this.buttonSearchTask = new System.Windows.Forms.Button();
            this.buttonDeleteTask_Click = new System.Windows.Forms.Button();
            this.buttonEditTask_Click = new System.Windows.Forms.Button();
            this.buttonAddTask_Click = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo de tarea";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxTitle.Location = new System.Drawing.Point(409, 170);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(204, 22);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(409, 231);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(204, 199);
            this.textBoxDescription.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description de tarea";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(409, 112);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(204, 22);
            this.textBoxId.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID";
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTasks.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 20;
            this.listBoxTasks.Location = new System.Drawing.Point(762, 193);
            this.listBoxTasks.MultiColumn = true;
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(312, 284);
            this.listBoxTasks.TabIndex = 13;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            // 
            // buttonClearTask
            // 
            this.buttonClearTask.BackgroundImage = global::Software_prueba_tecnica.Properties.Resources.actualizar;
            this.buttonClearTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClearTask.Location = new System.Drawing.Point(619, 400);
            this.buttonClearTask.Name = "buttonClearTask";
            this.buttonClearTask.Size = new System.Drawing.Size(33, 30);
            this.buttonClearTask.TabIndex = 15;
            this.buttonClearTask.UseVisualStyleBackColor = true;
            this.buttonClearTask.Click += new System.EventHandler(this.buttonClearTask_Click);
            // 
            // buttonSearchTask
            // 
            this.buttonSearchTask.BackgroundImage = global::Software_prueba_tecnica.Properties.Resources.lupa;
            this.buttonSearchTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearchTask.Location = new System.Drawing.Point(619, 108);
            this.buttonSearchTask.Name = "buttonSearchTask";
            this.buttonSearchTask.Size = new System.Drawing.Size(33, 30);
            this.buttonSearchTask.TabIndex = 14;
            this.buttonSearchTask.UseVisualStyleBackColor = true;
            this.buttonSearchTask.Click += new System.EventHandler(this.buttonSearchTask_Click);
            // 
            // buttonDeleteTask_Click
            // 
            this.buttonDeleteTask_Click.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDeleteTask_Click.BackgroundImage = global::Software_prueba_tecnica.Properties.Resources.boton_x;
            this.buttonDeleteTask_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteTask_Click.Location = new System.Drawing.Point(1045, 94);
            this.buttonDeleteTask_Click.Name = "buttonDeleteTask_Click";
            this.buttonDeleteTask_Click.Size = new System.Drawing.Size(127, 72);
            this.buttonDeleteTask_Click.TabIndex = 10;
            this.buttonDeleteTask_Click.UseVisualStyleBackColor = false;
            this.buttonDeleteTask_Click.Click += new System.EventHandler(this.buttonDeleteTask_Click_Click);
            // 
            // buttonEditTask_Click
            // 
            this.buttonEditTask_Click.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonEditTask_Click.BackgroundImage = global::Software_prueba_tecnica.Properties.Resources.editar;
            this.buttonEditTask_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditTask_Click.Location = new System.Drawing.Point(855, 94);
            this.buttonEditTask_Click.Name = "buttonEditTask_Click";
            this.buttonEditTask_Click.Size = new System.Drawing.Size(127, 72);
            this.buttonEditTask_Click.TabIndex = 9;
            this.buttonEditTask_Click.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditTask_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEditTask_Click.UseVisualStyleBackColor = false;
            this.buttonEditTask_Click.Click += new System.EventHandler(this.buttonEditTask_Click_Click);
            // 
            // buttonAddTask_Click
            // 
            this.buttonAddTask_Click.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAddTask_Click.BackgroundImage = global::Software_prueba_tecnica.Properties.Resources.guardar_el_archivo;
            this.buttonAddTask_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddTask_Click.Location = new System.Drawing.Point(683, 94);
            this.buttonAddTask_Click.Name = "buttonAddTask_Click";
            this.buttonAddTask_Click.Size = new System.Drawing.Size(118, 72);
            this.buttonAddTask_Click.TabIndex = 2;
            this.buttonAddTask_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddTask_Click.UseVisualStyleBackColor = false;
            this.buttonAddTask_Click.Click += new System.EventHandler(this.buttonAddTask_Click_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Software_prueba_tecnica.Properties.Resources._1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(20, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 365);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "ADMINISTRADOR DE TAREAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdministradorDeTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1213, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClearTask);
            this.Controls.Add(this.buttonSearchTask);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeleteTask_Click);
            this.Controls.Add(this.buttonEditTask_Click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonAddTask_Click);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministradorDeTareas";
            this.Text = "Administrador de tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEditTask_Click;
        private System.Windows.Forms.Button buttonDeleteTask_Click;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button buttonSearchTask;
        private System.Windows.Forms.Button buttonClearTask;
        private System.Windows.Forms.Button buttonAddTask_Click;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

