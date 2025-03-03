# 📌 AUTOJAP SAN ANDRES (ASA)

## 🚀 Instalación y configuración

### 📦 Requisitos
- .NET 8 instalado
- PostgreSQL configurado y en ejecución
- Java 21 instalado
- Docker (opcional, pero recomendado)

### 🛠 Configuración del proyecto
1. **Clonar el repositorio**
   ```sh
   git clone https://github.com/LuisCalleLazo/SanAndres_Api.git
   o
   git clone git@github.com:LuisCalleLazo/SanAndres_Api.git
   cd tu-repositorio
   ```

2. **Configurar el archivo `appsettings.json`**
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Port=5432;Database=TuBase;Username=TuUsuario;Password=TuContraseña"
     }
   }
   ```

3. **Descargar `jasperreader.jar` y colocarlo en la carpeta `bin`**
   Descarga el archivo desde el siguiente enlace y colócalo en la carpeta `bin` dentro del proyecto:
   📥 [Descargar jasperreader.jar](https://drive.google.com/your-link)

4. **Restaurar paquetes y compilar**
   ```sh
   dotnet restore
   dotnet build
   ```

## 🗄️ Base de Datos

### 📌 Crear y actualizar la base de datos
Ejecuta el siguiente comando para aplicar las migraciones y poblar la base de datos con datos de prueba:
   ```sh
   dotnet ef database update
   ```
> 📢 **Nota:** Este comando ejecutará un *seeder* que insertará datos por defecto en la base de datos para facilitar el desarrollo.

## 🚀 Ejecutar el Proyecto

Para iniciar la aplicación en modo desarrollo:
   ```sh
   dotnet run
   ```
La API estará disponible en:
   - 🌐 **HTTP:** `http://localhost:5220`
   - 🔒 **HTTPS:** `https://localhost:7166`

## 📚 Endpoints y Documentación
Si Swagger está habilitado, puedes acceder a la documentación en:
   ```sh
   http://localhost:5220/swagger
   ```

## 🐳 Ejecutar con Docker (Opcional)
Si deseas correr PostgreSQL en un contenedor Docker:
   ```sh
   docker run --name postgres-dev -e POSTGRES_USER=TuUsuario -e POSTGRES_PASSWORD=TuContraseña -e POSTGRES_DB=TuBase -p 5432:5432 -d postgres:latest
   ```

---
**✨ Hecho con ❤️ por [Deynar Luis Calle Lazo](https://github.com/LuisCalleLazo)**

