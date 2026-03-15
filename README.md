# Facturacion Multicapas

Sistema de facturación en arquitectura de 3 capas (Presentación, Lógica de Negocios, Acceso a Datos) con conexión a SQL Server.

## Estructura del proyecto

- **Capa_Presentacion** (PRACTICA_AEAE 2_Sofia): formularios WinForms (Login, Empleados, Seguridad, etc.).
- **Capa_LogicaDeNegocios**: reglas de negocio (Validar_Usuario, Cls_Empleados, Cls_Seguridad).
- **Capa_AccesoDatos**: conexión y consultas a la base de datos (Cls_Acceso_Datos).

## Requisitos

- Visual Studio 2017 o superior
- .NET Framework 4.7.2
- SQL Server (base de datos `Facturacion_Cliente_Servidor`)

## Configuración

Ajustar la cadena de conexión en `Capa_AccesoDatos\Cls_Acceso_Datos.cs` y en `Capa_LogicaDeNegocios\Validar_usuario.cs` según tu servidor y base de datos.

## Solución

Abrir `Proyecto_Facturacion_Capas.slnx` en Visual Studio.
