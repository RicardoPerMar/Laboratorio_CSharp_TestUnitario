# Laboratorio_CSharp_TestUnitario
1 - Vamos a crear una aplicación de consola que tiene como funcionalidad solicitar al usuario un correo electrónico y comprobará si es válido. La aplicación seguirá solicitando correos al usuario hasta que se escriba como correo electrónico el comando "quit".

El objetivo de este ejercicio es crear los tests necesarios para verificar que la función que válida los correos electrónicos funciona correctamente.

2 - Modificamos el ejercicio anterior para ir almacenando los correos electrónicos en memoria y en el caso de que el usuario introduzca un correo repetido mostrar el seiguiente mensaje:

"Ya se ha validado el correo electrónico".

¿Cómo afecta esta modificación a los tests? Utiliza Moq para aislar la funcionalidad de comprobar si el usuario ya ha introducido el correo.