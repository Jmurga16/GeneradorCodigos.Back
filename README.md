# PagoEfectivo_Back
1. Correr el Backend en Visual Studio, se habilitó la compatibilidad con Docker.
2. Compilar con Docker desde la Interfaz Visual Studio.
3. Al Crearse la imagen Docker Verificar en que puerto se encuentra
4. Abrir el Front End con Visual Studio Code e ir a la carpeta src/environments
5. En el archivo enviroment.ts se debe definir el puerto en que se corrió el backend
6. Guardar el archivo enviroment.ts
7. En la Consola digitar "docker build -t app-pago-efectivo-front:1.0.0 ."
8. Con la interfaz gráfica de Docker Desktop darle "Run" a la imagen creada.
9. Expandir a Optional Settings y Digitar en Ports LocalHost : 4200.
10. Darle a Run.
11. La aplicación inicio, y cuenta con los módulos : generación de códigos, canje de códigos y listado de email y codigos registrados.
