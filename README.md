En este documento se apuntan todas las referencias a lo requerido para esta practica.
Los requisitos se referenciaran de la siguienteforma ("fichero1.extensión:NºPrimeraLinea-NºUltimaLinea//NombreElemento")("fichero2.extensión:NºPrimeraLinea-NºUltimaLinea//NombreElemento").
En algunos requisitos solo se referenciará a un solo fichero ("fichero.extensión:NºPrimeraLinea-NºUltimaLinea//NombreElemento").
________________________________________________________________________________________________________________

-Creamos 2 constructores para una misma clase 
(Usuarios.cs:25-37)

-Usamos los getter y setter básicos y otros personalizados 
(Usuarios.cs:10-22)

-Realizamos la sobrecarga de algún método 
(UserList.cs:23-30)

-Manejamos componentes básicos 
(Todos los xaml tienen elementos basicos, por ejemplo:) (Login.xaml:usernameTextBox,PassPasswordBox)

-Manejamos componentes avanzados 
(tienen configuraciones que modificar) (MainWindow.xaml:imgIndex)

-Usamos distintos tipos de listas de objetos dependiendo de su uso (List, ObservableCollection...) x2 
(listaCanciones.cs:10)(UserList.cs:09)

-Usamos eventos diferentes del básico del componente x2 
(MainWindow.xaml:32)(musikEstilos.xaml)

-Realizamos algún Binding entre 2 componentes gráficos 
(dialogoAlta.xaml:13-15)

-Indicamos que archivo es el origen de datos de nuestra ventana 
(altas.xaml.cs:23-25)

-Realizamos Binding entre un componente y un objeto 
(altas.xaml:18)

-Usamos DataGrid para mostrar información. Sin personalizar la salida. 
(altas.xaml)

-Ídem pero configurándolo con DataGrid.Columns x3 
(altas.xaml:18)

-Somos capaces de conseguir que el DataGrid (o el componente que sea) se actualice, no solo con la inclusión/eliminación de nuevos elementos, 
sino también al cambiar alguna propiedad de alguno de ellos. (INotifyPropertyChanged) x4 
(Cancion.cs)

-Usamos una 2ª ventana 
(Login.xaml)(Register.xaml)(MenuPrincipal.xaml)(UserConfiguracion.xaml)

-Utilizamos correctamente distintos espacios de nombres, separamos las clases según su propósito (gui, datos, lógica...) 
(raiz:MainWindow.xaml)(dto:UserList.cs/Usuarios.cs) (gui:Login.xaml/Register.xaml/MenuPrincipal.xaml/UserConfiguracion.xaml)

-Accedemos a las posiciones de un Array con la sintaxis objetoArray[posicion] x3 
(listaCanciones.cs:25-28)

-Utilizamos el interfaz ICloneable para manejar información temporal (no tocamos el objeto que hemos clonado) x3
(Cancion.cs)

-Usamos IDataErrorInfo para validar campos incluyendo NotifyOnValidationError y ValidatesOnDataErrors x4
(dialogoAlta.xaml:13-14)

-Asociamos una función a la validación de algún campo. x4
(dialogoAlta.xaml.cs:67-86)
