-----------------------RegistroDragones Formulario---------------
La clase principal es RegistroDragon que hereda de Form y contiene los controles de la interfaz de usuario (TextBox, DataGridView, botones, etc.).
Se importan las clases Dragones y Conexion de los namespaces DragonesFORM.Data.Model y DragonesFORM.Data.Acces respectivamente. Estas clases probablemente representan el modelo de datos de un dragón y la lógica de acceso a datos (posiblemente a una base de datos).
La clase tiene un objeto SoundPlayer llamado Sonido y un Timer que se utiliza para detener el sonido después de un cierto tiempo.
En el constructor se inicializan algunos componentes y se configura el temporizador.
Hay varios métodos que manejan los eventos de los botones:

bttonInsert_Click: inserta un nuevo dragón en la base de datos utilizando los valores de los TextBox y reproduce un sonido.
bttonTabla_Click: carga los datos de la base de datos en el DataGridView y reproduce un sonido.
BuscarPorId: busca un dragón por su ID y rellena los TextBox con sus datos.
bttonDelete_Click_1: elimina un dragón de la base de datos y reproduce un sonido.
bttonLimpiar_Click: limpia los valores de los TextBox y reproduce un sonido.
bttonUpdate_Click_1: actualiza los datos de un dragón en la base de datos y reproduce un sonido.
bttonSiguiente_Click: llama al método BuscarPorId y reproduce un sonido.


El método Timer_Tick se ejecuta cada 2 segundos (según el intervalo configurado) y detiene el sonido que se está reproduciendo.
La aplicación utiliza una ruta de archivo local (C:\Users\mario\Downloads\libro.wav) para reproducir el sonido.

---------------------Conexion--------------------
Conexion(): Es el constructor de la clase y establece la cadena de conexión a la base de datos MySQL.
Insertar(Dragones especies): Este método inserta un nuevo registro en la tabla dragonario utilizando los valores proporcionados en el objeto especies de la clase Dragones.
Update(Dragones especies): Actualiza un registro existente en la tabla dragonario con los nuevos valores del objeto especies.
Delete(Dragones especies): Elimina un registro de la tabla dragonario basado en el número de dragón (numD) del objeto especies.
BuscarDragonPorId(int numD): Busca un dragón en la tabla dragonario por su número de identificación (numD) y devuelve un DataTable con los resultados.
ObtenerTodosLosDragones(): Devuelve una lista de objetos Dragones con todos los registros de la tabla dragonario.
LeerCatalogo(): Devuelve un DataTable con todos los registros de la tabla dragonario.

La clase utiliza la librería MySql.Data.MySqlClient para interactuar con la base de datos MySQL. Cada método establece una conexión con la base de datos utilizando la cadena de conexión proporcionada en el constructor, ejecuta una consulta SQL y maneja las excepciones en caso de errores.




-------------Base de Datos----------------

CREATE TABLE dragonario(
     numD INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    tipo VARCHAR(255) NOT NULL,
    habitat VARCHAR(255) NOT NULL,
    activo VARCHAR(10) NOT NULL,
    fuerza INT NOT NULL,
    agilidad INT NOT NULL,
    resistencia INT NOT NULL,
    velocidad INT NOT NULL,
    inteligencia INT NOT NULL,
    carisma INT NOT NULL,
    defensa INT NOT NULL,
    experiencia INT NOT NULL,
    descripcion TEXT NOT NULL);
   


INSERT INTO dragonario (nombre, tipo, habitat, activo, fuerza, agilidad, resistencia, velocidad, inteligencia, carisma, defensa, experiencia, descripcion)
VALUES
('Desdentao', 'Furia Nocturna', 'Islas', 'SI', 18, 20, 15, 22, 25, 10, 18, 30, 'Desdentao es el único Furia Nocturna conocido, es muy inteligente y tiene una gran capacidad para el vuelo y el combate.'),
('Arturde Espinas', 'Afilada', 'Bosques', 'SI', 10, 9, 11, 18, 15, 10, 5, 12, 'Los Aturde Espinas son color verde, con manchas marrones que recorren todo su cuello, lomo, cola y alas. Poseen una pequeña aleta espinosa sobre su lomo y su aleta timonera.'),
('Tormenta', 'Nadder Mortal', 'Bosques', 'SI', 14, 16, 12, 14, 12, 8, 10, 20, 'Tormenta es un Nadder Mortal conocido por sus escamas afiladas y su capacidad para lanzar espinas.'),
('Meatlug', 'Pesadilla Roca', 'Montañas', 'SI', 10, 8, 20, 5, 6, 6, 15, 15, 'Meatlug es un dragón amigable y leal, con una fuerza considerable y una gran resistencia.'),
('Furia de Sangre', 'Furia de Sangre', 'Volcanes', 'SI', 20, 20, 20, 20, 20, 20, 20, 20, 'El Furia de Sangre es un dragón extremadamente raro y poderoso, conocido por su ferocidad y fuerza.'),
('Gronckle', 'Gronckle', 'Cuevas', 'SI', 12, 7, 50, 10, 4, 0, 11, 1, 'Los Gronckles son dragones robustos con una alta resistencia y una capacidad única para moldear rocas.'),
('Pesadilla Monstruosa', 'Pesadilla Monstruosa', 'Bosques', 'SI', 18, 12, 18, 14, 16, 8, 16, 25, 'El Pesadilla Monstruosa es un dragón temible y grande, conocido por su capacidad para prenderse fuego.'),
('Muerte Susurrante', 'Muerte Susurrante', 'Subterráneo', 'SI', 17, 8, 18, 12, 10, 5, 15, 22, 'El Muerte Susurrante es un dragón peligroso que vive bajo tierra y es conocido por su habilidad para excavar túneles.'),
('Ala Tormentosa', 'Ala Tormentosa', 'Costas', 'SI', 18, 16, 14, 20, 19, 11, 18, 26, 'El Ala Tormentosa es conocido por su capacidad para controlar');
INSERT INTO dragonario (nombre, tipo, habitat, activo, fuerza, agilidad, resistencia, velocidad, inteligencia, carisma, defensa, experiencia, descripcion)
VALUES
('Chillón Mortal', 'Chillón Mortal', 'Montañas', 'SI', 15, 10, 12, 18, 14, 6, 12, 18, 'El Chillón Mortal es un dragón que puede lanzar un grito sónico devastador que puede desorientar a sus enemigos.'),
('Pesadilla Volcánica', 'Pesadilla Volcánica', 'Volcanes', 'SI', 19, 13, 16, 16, 15, 9, 17, 28, 'El Pesadilla Volcánica es un dragón que vive en áreas volcánicas y tiene una relación especial con el fuego y la lava.'),
('Furia del Mar', 'Marea', 'Océanos', 'SI', 14, 16, 12, 18, 17, 9, 15, 24, 'El Furia del Mar es un dragón que vive en los océanos y tiene la capacidad de manipular el agua.'),
('Cazador Silencioso', 'Cazador', 'Bosques', 'SI', 13, 20, 10, 22, 18, 12, 10, 21, 'El Cazador Silencioso es un dragón que se especializa en cazar sin ser detectado.'),
('Rompeolas', 'Marea', 'Costas', 'SI', 17, 15, 14, 16, 16, 8, 18, 27, 'El Rompeolas es conocido por su habilidad para crear grandes olas y tsunamis.'),
('Torbellino', 'Tornado', 'Cielos', 'SI', 18, 22, 13, 25, 19, 11, 14, 26, 'El Torbellino es un dragón que puede crear tornados y usar el viento para atacar.'),
('Aguijón Venenoso', 'Aguijón', 'Desiertos', 'SI', 16, 14, 11, 18, 15, 10, 12, 23, 'El Aguijón Venenoso es un dragón que tiene un veneno letal en su aguijón.'),
('Guardián del Bosque', 'Guardián', 'Bosques', 'SI', 15, 18, 13, 20, 17, 12, 16, 25, 'El Guardián del Bosque es un dragón que protege los bosques y tiene una conexión especial con la naturaleza.'),
('Incendiario', 'Incendiario', 'Volcanes', 'SI', 19, 12, 14, 17, 16, 9, 20, 28, 'El Incendiario es un dragón que puede lanzar fuego a grandes distancias y causar incendios masivos.');

INSERT INTO dragonario (nombre, tipo, habitat, activo, fuerza, agilidad, resistencia, velocidad, inteligencia, carisma, defensa, experiencia, descripcion)
VALUES
('Escama de Cristal', 'Cristal', 'Montañas', 'SI', 14, 15, 12, 19, 18, 10, 13, 24, 'El Escama de Cristal tiene escamas que pueden reflejar la luz y cegar a sus enemigos.'),
('Trueno Azul', 'Trueno', 'Costas', 'SI', 18, 17, 15, 21, 19, 11, 17, 26, 'El Trueno Azul es un dragón que puede generar fuertes descargas eléctricas y controlar el trueno.'),
('Viento de Hielo', 'Hielo', 'Montañas', 'SI', 17, 14, 13, 16, 15, 9, 18, 25, 'El Viento de Hielo es un dragón que puede lanzar ráfagas de viento helado y congelar a sus enemigos.'),
('Destructor de Rayo', 'Tronador', 'Costas', 'SI', 15, 14, 13, 16, 18, 10, 14, 25, 'El Destructor de Rayo es conocido por su habilidad para generar electricidad y lanzar rayos.'),
('Rompehuesos', 'Gigante', 'Montañas', 'SI', 22, 10, 20, 8, 10, 5, 25, 30, 'El Rompehuesos es un dragón grande y fuerte, famoso por su enorme fuerza física y resistencia.'),
('Chispa', 'Skrill', 'Tormentas', 'SI', 16, 18, 14, 20, 19, 12, 17, 28, 'El Skrill es un dragón que puede controlar los rayos y almacenarlos en su cuerpo para usarlos como arma.'),
('Aventurero', 'Cortador Rápido', 'Bosques', 'SI', 12, 18, 10, 22, 20, 15, 12, 24, 'El Cortador Rápido es un dragón ágil y veloz, especializado en ataques rápidos y precisos.'),
('Llamarada', 'Sombra Mortal', 'Desiertos', 'SI', 20, 14, 15, 18, 17, 9, 20, 27, 'El Sombra Mortal es un dragón que vive en desiertos y tiene la habilidad de lanzar llamas de gran intensidad.'),
('Destructor', 'Quebrantahuesos', 'Cuevas', 'SI', 19, 10, 17, 12, 11, 7, 16, 22, 'El Quebrantahuesos es conocido por su capacidad para aplastar huesos con su poderosa mandíbula.'),
('Ala de Muerte', 'Ala de Muerte', 'Subterráneo', 'SI', 21, 12, 18, 14, 15, 8, 22, 30, 'El Ala de Muerte es un dragón subterráneo que puede causar grandes terremotos y deslizamientos de tierra.');

