# PruebaForm
					Proyecto Ingeniería de Software

					    Implementación Continua.

**IDE**

        .NET
        
	El código que queremos en controlar esta Elaborado en Microsoft Visual Studio,lenguaje .NET
	
**Configurar GitHub con Visual Studio Community**

	Al momento de instalar Microsoft Visual Studio, debemos darle instalación personalizada, seleccionamos todos los componentes de Git.
	
**GitHub**
	Vamos a la siguiente dirección https://github.com/ y allí nos registraremos, ingresaremos y creamos un repositorio de código fuente. 
	
	Volvemos a nuestro IDE y en la sección de  “Team Explorer” del Visual Studio Community. Ahí veremos que hay un menú llamado “Manage Connections”, en el cual se nos ofrecerá conectarnos a nuestro repositorio de GitHub, En ese punto nos pedirá que iniciemos sesión con nuestra cuenta de GitHub para poder acceder a la misma.
	
	Una vez completados estos pasos realizaremos cambios a nuestro código fuente, y en el lado Superior Derecho en la sección de “Changes” nos aparecerá un cuadro amarillo en donde podremos colocar un mensaje acerca de los cambios que fueron realizados, para luego presionar el botón “Commit and Push” esperaremos unos segundos y veremos estos cambios en nuestro repositorio de GitHub.
	
**Crear cuenta en DreamSpark**

	Entrar a www.dreamspark.com creamos una cuenta gratuita, damos la opción que somos estudiantes y enviamos una fotografía con nuestro Carné de identificación de la Universidad, esperar respuesta de activación de 3 a 5 días hábiles.
	
 **Registrarse en Microsoft Azure**

	Entrar al https://portal.azure.com/ Nos registramos en Microsoft Azure con el mismo correo que creamos en DreamSpark, debemos tener una tarjeta de débito o crédito para poder crear la Máquina virtual.

**Descargar e Instalar Jenkins en la Máquina Virtual**

	Entrar en la Página de Jenkins https://jenkins.io/ y descargar la versión Weekly Release mas reciente.
	
**Configurar Jenkins en máquina virtual**

•	Descargar e Instalar MSBuildTools

	Ir a la página 
		https://www.microsoft.com/en-us/download/details.aspx?id=40760

•	Crear Variable de Entorno Path

Ir a:

•	Computer
•	Propierties
•	Advanced System Setting
•	Envioronment Varibles
•	Sistem Variables
•	New Sistem Variables
•	Varibale Name: Path
•	Variable Value: C:\Program Files (x86)\MSBuild\14.0\Bin

Para ir a la dirección de Variable Value debemos.

Ir a:

•	Computer
•	Local Disk (C:)
•	Program Files (x86)
•	MSBuild
•	Seleccionar la versión que tiene instalada en mi caso es la versión 14.0
•	Bin
•	Copiamos la dirección y la colocamos en Variable Value

•	Descargar e Instalar Git en la máquina virtual.
		
		Ir a la página https://git-scm.com/downloads
		
**Configuración de Jenkins con Git para poder crear una Nueva Tarea**

•	Instalar los Plugins de Git en Jenkins
Vamos a:

•	Manage Jenkins.
•	Manage Plugins.
•	Buscar todos los plugins de Git, en la opción Avaible Buscar, seleccionar e instalar, cuando hemos seleccionado todos los Plugins         dar clic en Download now and install after restart.
•	Ahora vamos de nuevo a Manage Jenkins. 
•	Seleccionamos la opción Global Tools Configuration.
•	Configuramos en el apartado de Git.
		Name: Git
		Path to Git Executable: C:\Program Files\Git\bin.git.exe

Pasos para crear Path to Git Executable

Ir a:

•	Computer
•	Local Disk (C:)
•	Program Files
•	Git
•	Bin
•	Agregar Git.exe al final de la dirección, dar clic en Save para guardar cambios.

•	Instalar Plugins de MSBuild en Jenkins

Vamos a:

•	Manage Jenkins.
•	Manage Plugins.
•	Buscar todos los plugins de MSBuild, en la opción Avaible Buscar, seleccionar e instalar, cuando hemos seleccionado todos los             Plugins dar clic en Download now and install after restart.
•	Ahora vamos de nuevo a Manage Jenkins. 
•	Seleccionamos la opción Global Tools Configuration.
•	Configuramos el apartado MSBuild
•	Dar clic en MSBuild Installations…
		Name: MSBuild
		Path to MSBuild: MSBuild
		Solo escribimos MSBuild en Path to MSBuild, porque por eso creamos la Variable de Entorno al principio.

**Creación de la Nueva Tarea en Jenkins**

Ir a: 

•	**New Item (Nueva Tarea)**
•	Escribimos el nombre de la tarea.
•	Seleccionar FreeStyle Project (Crear un Proyecto de Estilo Libre).
•	Clic en Ok para crear la Tarea.


        **General**

        Seleccionamos GitHub Project, aquí es donde agregamos el link de donde se encuentra nuestro repositorio en GitHub

•	Source Code Managment (Configurar el Origen del Código Fuente).

•	Seleccionamos Git
•	Seleccionamos GitHub Project, aquí es donde agregamos el link de donde se encuentra nuestro repositorio en GitHub, agregando al           final del link .GIT
•	Agregar Credenciales
•	Podemos crear una Credencial
        **Ir a Add Credentials (Agregar Credenciales)**
•	Seleccionar Jenkins
•	Domain: Global Credential (Unrestricted)
•	Kind: User Name with Password, llenar los campos que se le solicitan.
•	Hacer clic en Add (Agregar) para poder guardar la credencial que acabamos de crear.

        **Build Triggers (Disparadores de Ejecución)**
        
•	Seleccionar la opción Build when a change is pushed to GitHub (Construir un cambio cuando se empuja a GitHub).
•	Seleccionar Poll SCM (Consultar Repositorio SCM, en el espacio en blanco del programador se colocara el tiempo de cada cuanto se          revisen si hay cambios.

	**Build** 
	
•	Seleccionamos Add Build Step (Añadir un nuevo paso)
•	Seleccionamos la opción Build a Visual Studio Project or Solution using MSBuil (Construir un proyecto de Visual Studio o solución         utilizando MSBuil)
•	Configurar MSBuild
•	MSBuild Version: Default
•	MSBuild File: ${WORKSPACE}\NombreDelProyecto\ NombreDelProyecto.sln.
•	Clic en Save para guardar las configuraciones de la tarea.
			
**Crear Servicio de Aplicaciones**

•	Ir a la página https://portal.azure.com/  debemos crear un servicio de aplicaciones, en la parte izquierda aparecerá el servicio          de aplicaciones debemos crear uno, llenar los campos requeridos, al momento que ya este creado nuestro servicio de aplicaciones           debemos proceder con la configuración de dicho servicio.
•	Nos vamos al bloque de publicación de nuestro servicio de aplicaciones, nos vamos a Origen de Implementación y seleccionamos Git.
•	Configurar Credenciales de Implementación en este apartado debemos crear un usuario y contraseña las cuales utilizaremos en                https://buddy.works/
•	Siempre dentro de la configuración de nuestro servicio de aplicaciones nos vamos a al bloque General y seleccionamos Propiedades y         luego copiamos en la URL de Git, también este paso nos servirá para hacer una nuevo Proyecto  en Buddy.

 **Registrarnos en Buddy**
 
•	Podemos acceder con la cuenta que iniciamos sesión en GitHub
