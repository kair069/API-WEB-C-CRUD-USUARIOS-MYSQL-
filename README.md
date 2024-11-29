# MyWebApi - CRUD de Usuarios con ASP.NET Web API y MySQL

Este proyecto es una API REST desarrollada en **C#** usando **ASP.NET Web API** para realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) de usuarios, conectada a una base de datos **MySQL**.

## Capturas de Pantalla

### Pantalla Principal de la API
### Captura 1
![Captura 1](https://github.com/kair069/API-WEB-C-CRUD-USUARIOS-MYSQL-/blob/main/Captura.PNG)

### Captura 2
![Captura 2](https://github.com/kair069/API-WEB-C-CRUD-USUARIOS-MYSQL-/blob/main/Captura1.PNG)

### Ejemplo de Respuesta de la API
![Captura 2](https://github.com/kair069/API-WEB-C-CRUD-USUARIOS-MYSQL-/blob/main/Captura2.PNG)

## Requisitos previos

Antes de ejecutar este proyecto, asegúrate de tener instalados los siguientes componentes:

- [Visual Studio](https://visualstudio.microsoft.com/) (con la carga de trabajo ASP.NET y desarrollo web).
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) y [MySQL Workbench](https://dev.mysql.com/downloads/workbench/).
- [MySQL Connector/NET](https://dev.mysql.com/downloads/connector/net/).
- .NET SDK 6.0 o superior.

## Configuración del proyecto

### 1. Clonar el repositorio
```bash
git clone <URL_DEL_REPOSITORIO>
cd MyWebApi


2. Configurar la conexión a MySQL
En el archivo appsettings.json, configura la cadena de conexión a tu base de datos:

json
Copiar código
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=NombreDeTuBaseDeDatos;User Id=tu_usuario;Password=tu_contraseña;"
  }
}
3. Migraciones (si estás usando Entity Framework)
Ejecuta los siguientes comandos en la consola de Package Manager para aplicar las migraciones:

bash
Copiar código
Add-Migration InitialCreate
Update-Database
4. Ejecutar la aplicación
En Visual Studio, selecciona MyWebApi como proyecto de inicio y presiona F5 para ejecutar.

Endpoints de la API
Método	Ruta	Descripción
GET	/api/usuarios	Obtener todos los usuarios
GET	/api/usuarios/{id}	Obtener un usuario por ID
POST	/api/usuarios	Crear un nuevo usuario
PUT	/api/usuarios/{id}	Actualizar un usuario existente
DELETE	/api/usuarios/{id}	Eliminar un usuario por ID
Tecnologías utilizadas
C#
ASP.NET Web API
MySQL
Entity Framework Core (opcional para ORM)
Contribuciones
Si deseas contribuir a este proyecto, puedes enviar un pull request o reportar problemas mediante la sección de issues.

Licencia
Este proyecto está licenciado bajo la MIT License.

markdown
Copiar código

### Pasos Finales:
1. Asegúrate de que las imágenes **`Captura.jpg`** y **`Captura1.jpg`** estén en la misma carpeta que el archivo **README.md**.
2. Sube el archivo **README.md** junto con las imágenes a tu repositorio de GitHub.

¿Necesitas más detalles o ajustes? 😊
