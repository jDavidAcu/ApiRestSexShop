# Proyecto de Backend para Tienda Web

Este proyecto es una implementación de un sistema de backend para una tienda web, con una arquitectura basada en capas y APIs RESTful para la gestión de datos. El sistema permite realizar transacciones y operaciones CRUD en una base de datos, aunque no se encuentra en un nivel profesional listo para producción. Su principal propósito es demostrar conocimientos en la creación de APIs REST y el manejo de bases de datos en un entorno web.

## Arquitectura

La arquitectura del proyecto está organizada en capas, donde se distribuyen las funcionalidades de la siguiente manera:

1. **Capa de Datos (Mapping)**: Se encarga de mapear las entidades del sistema con la distribución de las tablas en la base de datos.
2. **Capa de Acceso a Datos**: Maneja cómo acceder a los datos, realizando consultas y operaciones de manipulación sobre la base de datos.
3. **Capa de Lógica de Negocio**: Contiene la lógica de negocio y las reglas para interactuar con los datos y procesar la información.

## DTO (Data Transfer Object)

En este proyecto, se utiliza el patrón **DTO** (Data Transfer Object) para gestionar la transferencia de datos entre las capas del sistema. Este enfoque es útil especialmente para la implementación de una banca web, que fue parte de un proyecto conjunto con mis compañeros. Si bien este apartado es innecesario para este caso específico, recomiendo no eliminarlo, ya que podría generar incompatibilidades en futuras modificaciones o en la integración con otros sistemas.

## APIs REST

El sistema expone diversas APIs REST para interactuar con la base de datos. Para realizar las llamadas a las APIs, se recomienda utilizar herramientas como **SOAP UI** o **Postman**, que permiten testear las solicitudes y visualizar las respuestas.

## Conexión con la Base de Datos

La conexión con la base de datos se realiza a través de un servidor privado y gratuito en **Hostinger**. La cadena de conexión puede ser revisada en el archivo `web.config`. Si prefieres trabajar en un entorno local, he subido una copia de la base de datos en formato **.bak** para facilitar la restauración.

## Instalación Local

1. Descarga el archivo **.bak** de la base de datos.
2. Restaura el archivo **.bak** en tu servidor local de SQL Server.
3. Revisa y actualiza la cadena de conexión en el archivo `web.config` con los parámetros adecuados para tu entorno local.

## Recomendaciones

Este proyecto está diseñado para ser una demostración de conceptos y no debe considerarse como un modelo de producción profesional. Aunque funciona como un ejemplo funcional de una tienda web, aún se encuentra en desarrollo y falta mejorar en varios aspectos.

## Licencia

Este proyecto es de uso libre para fines educativos y de demostración. No debe ser utilizado en entornos de producción sin antes realizar las mejoras necesarias.

## Contacto

Si tienes preguntas o sugerencias, no dudes en contactarme a través de GitHub o por correo electrónico a **jose.david.acu@outlook.com**.

## Pruebas

Si se desea probar en producción se puede acceder a este enlace  **http://sexshop.runasp.net/Help** par apoder ver los endpoints de las API.

---

> *Este proyecto fue desarrollado como parte de un curso sobre integración de servicios y backend en desarrollo web.*
