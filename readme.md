# Sistema de Gestión para Trabajo Final

> Proyecto desarrollado en .NET C# con almacenamiento XML

## 📋 Descripción

Este proyecto implementa una arquitectura en capas utilizando .NET Framework y XML como base de datos. La solución está estructurada en múltiples proyectos que separan las diferentes responsabilidades del sistema.

## 🏗️ Estructura del Proyecto

- **Abstraccion**: Contiene las interfaces y clases abstractas del sistema
- **BE (Business Entities)**: Entidades de negocio y modelos de datos
- **BLL (Business Logic Layer)**: Capa de lógica de negocio
- **MPP (Mapping)**: Capa de mapeo entre objetos y XML
- **Servicio**: Servicios compartidos del sistema
- **UI**: Interfaz de usuario

## 🔧 Requisitos

- Visual Studio 2017 o superior
- .NET Framework 4.7.2 o superior
- Permisos de lectura/escritura en el directorio de la aplicación para el almacenamiento XML

## ⚙️ Configuración

1. Clonar el repositorio
2. Abrir la solución `TrabajoFinal.sln` en Visual Studio
3. Restaurar los paquetes NuGet si es necesario
4. Compilar la solución

## 📁 Almacenamiento

El sistema utiliza archivos XML como base de datos. Los archivos se crearán automáticamente en la primera ejecución en el directorio configurado de la aplicación.

## 🚀 Ejecución

1. Establecer el proyecto UI como proyecto de inicio
2. Ejecutar la aplicación en Visual Studio (F5)

## 🏛️ Arquitectura

- Arquitectura en capas
- Patrón Repository para el acceso a datos
- Mapeo objeto-XML personalizado
- Interfaz de usuario Windows Forms
