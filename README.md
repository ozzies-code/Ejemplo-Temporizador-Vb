# Ejemplo-Temporizador-Vb
 Este proyecto se basa en el uso de un control Timer para mostrar la hora actual
 Se emplea una etiqueta o control Label para contener en su propiedad Text la Hora asociada 
 al equipo que proporcionara el control Timer

 # Actualizacion: 30/12/2024
 # Hora: 10:08

 Se agrego una actualizacion en la rama master para contar con dos 
 versiones del proyecto.

Detalles Tecnicos del Proyecto:
Lenguaje: Visual Basic.NET
Version del Framawork: 4.7.2

# Example-Timer-VB
This project is based on the use of a Timer control to display the current time
A Label control is used to contain in its Text property the Time associated
with the equipment that will provide the Timer control

# Update: 12/30/2024
# Time: 10:08

An update was added to the master branch to have two versions
of the project.

Technical Details of the Project:
Language: Visual Basic.NET
Framework Version: 4.7.2

![imagen](https://github.com/user-attachments/assets/980d8cd9-7ce5-45fe-b3c7-dff653e511a1)

Code of the Project:

    Public Class frmEjemploTemporizador
    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        lblReloj.Text = TimeOfDay
    End Sub
End Class

