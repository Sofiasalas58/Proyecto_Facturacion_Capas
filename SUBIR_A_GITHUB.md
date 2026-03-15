# Cómo subir este proyecto a GitHub

Sigue estos pasos en tu PC (en **PowerShell**, **CMD** o **Git Bash**, donde tengas `git` instalado).

## 1. Abrir terminal en la carpeta del proyecto

```bash
cd C:\Users\USER\source\repos\Facturacion_Multicapas
```

## 2. Inicializar Git (si aún no es un repositorio)

```bash
git init
```

## 3. Añadir todos los archivos

```bash
git add .
```

## 4. Primer commit

```bash
git commit -m "Sistema facturacion multicapas - Login, Empleados, Seguridad"
```

## 5. Crear el repositorio en GitHub

1. Entra en https://github.com/new  
2. Nombre del repositorio: por ejemplo **Facturacion_Multicapas**  
3. No marques "Add a README" (ya tienes uno en el proyecto)  
4. Clic en **Create repository**

## 6. Enlazar y subir

En la misma carpeta del proyecto, ejecuta (sustituye **TU_USUARIO** por tu usuario de GitHub):

```bash
git remote add origin https://github.com/TU_USUARIO/Facturacion_Multicapas.git
git branch -M main
git push -u origin main
```

Si GitHub te pide usuario y contraseña, usa un **Personal Access Token** como contraseña (Configuración → Developer settings → Personal access tokens).

---

**Desde Visual Studio:**  
También puedes usar **Git** → **Crear repositorio Git** y luego **Git** → **Push** y enlazar con un repositorio nuevo en GitHub.
