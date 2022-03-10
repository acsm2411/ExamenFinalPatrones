using ExamenFinalPatrones;

var navegador = new Navegador();
navegador.TipoDeRuta = "A"; //Dato que vendria de la aplicacion cliente, solo por temas practicos

var trazadoRuta = navegador.generar_ruta(new object(), new object());

