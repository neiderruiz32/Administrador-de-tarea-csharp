# Administrador de Tareas

Este es un programa de administración de tareas simple que permite al usuario agregar, editar, eliminar y buscar tareas. Está desarrollado en C# y utiliza el patrón de diseño Modelo-Vista-Controlador (MVC) para separar la lógica de la aplicación, la representación de los datos y la interfaz de usuario.

## Características

- Agregar una tarea: El usuario puede ingresar el ID, título y descripción de una tarea y agregarla al sistema.
- Mostrar lista de tareas: Se muestra una lista de todas las tareas existentes en un ListBox.
- Editar una tarea: El usuario puede seleccionar una tarea de la lista, modificar su título y descripción y guardar los cambios.
- Eliminar una tarea: El usuario puede seleccionar una tarea de la lista y eliminarla del sistema.
- Buscar una tarea: El usuario puede buscar una tarea por su ID y ver sus detalles.
- Limpiar campos: El usuario puede limpiar los campos de entrada de texto para agregar una nueva tarea.

## Estructura del Código

El código está organizado en tres clases principales:

### AdministradorDeTareas

Esta clase representa el formulario principal de la aplicación. Contiene los eventos y métodos relacionados con la interfaz de usuario, como agregar, editar, eliminar y buscar tareas. También se encarga de comunicarse con el controlador y la vista para realizar las operaciones necesarias.

### TaskController

Esta clase es el controlador de la aplicación. Mantiene una colección de tareas y proporciona métodos para agregar, editar, eliminar y buscar tareas. Además, se encarga de comunicarse con la vista para mostrar la lista de tareas y recibir las interacciones del usuario.

### TaskView

Esta clase representa la vista de la aplicación. Contiene los controles de la interfaz de usuario, como el ListBox y los campos de entrada de texto, y se encarga de mostrar los datos y eventos relevantes. Recibe actualizaciones del controlador y muestra la lista de tareas en el ListBox.

## Uso

1. Ejecute el programa y verá una ventana con una lista de tareas vacía.
2. Para agregar una tarea, ingrese un ID válido, título y descripción en los campos de entrada de texto. Luego, haga clic en el botón "Agregar tarea".
3. La tarea se agregará a la lista y se mostrará en el ListBox.
4. Para editar una tarea, seleccione una tarea de la lista haciendo clic en ella. Los campos de entrada de texto se llenarán automáticamente con los detalles de la tarea seleccionada. Modifique el título y la descripción según sea necesario y haga clic en el botón "Editar tarea".
5. La tarea se actualizará en la lista y se mostrará el mensaje "Tarea actualizada exitosamente".
6. Para eliminar una tarea, seleccione una tarea de la lista y haga clic en el botón "Eliminar tarea".
7. La tarea se eliminará de la lista y se mostrará el mensaje "Tarea eliminada exitosamente".
8. Para buscar una tarea por su ID, ingrese el ID en el campo de entrada de texto y haga clic en el botón "Buscar tarea".
9. Si se encuentra una tarea con el ID especificado, se mostrarán los detalles de la tarea en los campos de entrada de texto y se mostrará el mensaje "Tarea encontrada".
10. Para limpiar los campos de entrada de texto, haga clic en el botón "Limpiar campos".

¡Administra tus tareas con esta aplicación simple pero efectiva!
