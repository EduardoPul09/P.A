import tkinter as tk
from tkinter import messagebox
import re
import mysql.connector as mysqlConn


def InsertaRe(nombres, apellidos, edad, estatura, telefono, genero):
    try:
        connection = mysqlConn.connect(
            host = "localhost", port = "3306", user = "root", password = "PswrdSQL091204", database = "tabla")
        cursor = connection.cursor()
        query = "insert into tabla (nombres, apellidos, edad, estatura, telefono, genero) valores (%s,%s,%s,%s,%s,%s)"
        valores = (nombres, apellidos, edad, estatura, telefono, genero)
        cursor.execute(query, valores)
        connection.commit()
        cursor.close()
        connection.close()
        messagebox.showinfo("informacion", "valores guardados en la base de datos")
    except mysqlConn.Error as error:
        messagebox.showerror("error", f"Error al guardar los datos: {error}")
        
        
    def limpiar_campos():
        tbNombres.delete(0,tk.END)
        tbApellidos.delete(0,tk.END)
        tbEdad.delete(0,tk.END)
        tbEstatura.delete(0,tk.END)
        tbTelefono.delete(0,tk.END)
        var_genero.set(0)
        
    def isValidInt(valo):
        try:
            int(valo)
            return True
        except ValueError:
            return False
    def isValidFloat(valo):
        try:
            float(valo)
            return True
        except ValueError:
            return False
        
        
    def isValidTel(valo):
        return valo.isdigit() and len(valo) == 10
    
    def isValidText(valo):
        return bool(re.match("^[a-zA-Z\s]+$", valo))
    
    def borrar_fun():
        limpiar_campos()
        
    def guardar():
        nombres = tbNombres.get()
        apellidos = tbApellidos.get()
        edad = tbEdad.get()
        estatura = tbEstatura.get()
        telefono = tbTelefono.get()
        genero = ""
        if var_genero.get() == 1:
            genero = "Hombre"
        elif var_genero.get() == 2: 
            genero = "Mujer"
            
        if (isValidInt(edad) and isValidFloat(estatura) and isValidTel(telefono) and isValidText(nombres) and isValidText(apellidos)):
            datos = "nombre"+nombres +"\nApellidos: " + apellidos + "\nEdad: " + edad + "\nEstatura: " + estatura + "\nTelefono: " + telefono + "\nGenero: " + genero
            with open("datosP.txt","a") as file:
                file.write(datos +"\n\n")
            messagebox.show("Datos"+"Datos guardados: \n\n", datos)
            
        else:
            messagebox.showerror("Error"+"No se pudieron guardar los datos")
        borrar_fun()
        
        
    ventana = tk.Tk()
    ventana.geometry("620x580")
    ventana.title("Formulario Python")
    
    var_genero = tk.IntVar()
    lbNombres = tk.Label(ventana, text = "Nombres: ")
    lbNombres.pack()
    tbNombres = tk.Entry()
    tbNombres.pack()
    lbApellidos = tk.Label(ventana, text = "Apellidos: ")
    lbApellidos.pack()
    tbApellidos = tk.Entry()
    tbApellidos.pack()
    lbTelefono = tk.Label(ventana, text = "Telefono: ")
    lbTelefono.pack()
    tbTelefono = tk.Entry()
    tbTelefono.pack()
    lbEdad = tk.Label(ventana, text = "Edad: ")
    lbEdad.pack()
    tbEdad = tk.Entry()
    tbEdad.pack()
    lbEstatura = tk.Label(ventana, text = "Estatura: ")
    lbEstatura.pack()
    tbEstatura = tk.Entry()
    tbEstatura.pack()
    lbGenero = tk.Label(ventana, text = "Genero ")
    lbGenero.pack()
    rbHombre = tk.Radiobutton(ventana, text = "Hombre", variable=var_genero, value=1)
    rbHombre.pack()
    rbMujer = tk.Radiobutton(ventana, text = "Mujer", variable=var_genero, value=2)
    rbMujer.pack()

    bBorrar = tk.Button(ventana, text = "Borrar", command=borrar_fun)
    bBorrar.pack()
    bGuardar = tk.Button(ventana, text = "Guardar", command=guardar)
    bGuardar.pack()
    
    
    ventana.mainloop()