using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EldaraaApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrasfondosHabilidad",
                columns: table => new
                {
                    TrasfondoId = table.Column<int>(type: "INTEGER", nullable: false),
                    HabilidadId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrasfondosHabilidad", x => new { x.TrasfondoId, x.HabilidadId });
                    table.ForeignKey(
                        name: "FK_TrasfondosHabilidad_Habilidades_HabilidadId",
                        column: x => x.HabilidadId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrasfondosHabilidad_Trasfondos_TrasfondoId",
                        column: x => x.TrasfondoId,
                        principalTable: "Trasfondos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clases",
                columns: new[] { "Id", "DadoGolpe", "Descripcion", "LanzadorConjuros", "Nombre" },
                values: new object[,]
                {
                    { 1, 12, "El bárbaro es una fuerza bruta de la naturaleza. Canaliza su furia en combate, desatando una rabia salvaje que lo hace casi imposible de detener. Su conexión con el instinto lo vuelve resistente al dolor y letal con armas contundentes. No pelea por gloria, sino por supervivencia y orgullo tribal.", false, "Bárbaro" },
                    { 2, 8, "El bardo convierte la música, el arte y las palabras en magia pura. Domina una versatilidad asombrosa: puede inspirar a sus aliados, desatar hechizos o incluso engañar a la muerte con su carisma. Donde otros lanzan conjuros con libros o plegarias, el bardo lo hace con una canción.", true, "Bardo" },
                    { 3, 8, "Guerrero sagrado y servidor de lo divino, el clérigo canaliza el poder de su dios para sanar, proteger o castigar. Dependiendo de su dominio, puede ser un faro de vida, un martillo de guerra o un vengador implacable. Su fe es su arma más poderosa.", true, "Clérigo" },
                    { 4, 8, "Los druidas son guardianes del equilibrio natural. Controlan las fuerzas elementales, se transforman en bestias y convocan la furia de la tormenta o la calma del bosque. Su conexión con la tierra es profunda, y su sabiduría, ancestral.", true, "Druida" },
                    { 5, 10, "Maestro del combate marcial, el guerrero es versátil, disciplinado y peligroso con cualquier arma. Algunos luchan por honor, otros por oro, pero todos son fuerza pura en el campo de batalla. Su entrenamiento lo convierte en una máquina de guerra adaptable.", false, "Guerrero" },
                    { 6, 6, "A diferencia de los magos, los hechiceros nacen con la magia en la sangre. Su poder es innato, salvaje y muchas veces impredecible. Canalizan energías caóticas con pura fuerza de voluntad, y su conexión mágica suele tener un origen misterioso o ancestral.", true, "Hechicero" },
                    { 7, 6, "El mago es un erudito de lo arcano. A través de años de estudio y práctica rigurosa, domina una vasta variedad de conjuros. Aunque físicamente débil, su conocimiento mágico puede alterar la realidad misma, desatar tormentas de fuego o viajar entre planos.", true, "Mago" },
                    { 8, 8, "El monje perfecciona su cuerpo y mente hasta convertirlos en armas. Con una disciplina inquebrantable, puede golpear con velocidad fulminante, caminar por paredes o canalizar su ki para defenderse del daño. Es la encarnación del equilibrio interior.", false, "Monje" },
                    { 9, 10, "Guardián de lo sagrado, el paladín jura votos que lo vinculan a una causa o deidad. Sus habilidades combinan fuerza marcial con poder divino: cura heridas, destruye el mal y resiste la corrupción con una voluntad inquebrantable. Su fe es su escudo.", true, "Paladín" },
                    { 10, 8, "Ágil, astuto y letal en la sombra, el pícaro domina el sigilo, el engaño y los golpes certeros. Es el primero en entrar y el último en ser visto. Ya sea un ladrón callejero o un espía refinado, el pícaro convierte cada oportunidad en ventaja.", false, "Pícaro" },
                    { 11, 10, "El explorador es un cazador del mundo salvaje. Domina terrenos inhóspitos, sigue rastros imposibles y combate con eficacia donde otros apenas sobreviven. Muchos tienen compañeros animales y lanzan conjuros naturales para proteger sus dominios.", true, "Explorador" },
                    { 12, 8, "El brujo obtiene su poder mediante un pacto con una entidad poderosa: un demonio, un hada, un ente cósmico. Sus conjuros son limitados pero potentes, y sus habilidades oscuras lo convierten en un maestro del misterio y lo oculto. Su pacto es su fuerza... y su maldición.", true, "Brujo" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "HabilidadBase", "Nombre" },
                values: new object[,]
                {
                    { 1, "DEX", "Acrobacias" },
                    { 2, "INT", "Arcana" },
                    { 3, "STR", "Atletismo" },
                    { 4, "CHA", "Engaño" },
                    { 5, "INT", "Historia" },
                    { 6, "CHA", "Intimidación" },
                    { 7, "INT", "Investigación" },
                    { 8, "DEX", "Juego de manos" },
                    { 9, "WIS", "Medicina" },
                    { 10, "INT", "Naturaleza" },
                    { 11, "WIS", "Percepción" },
                    { 12, "WIS", "Perspicacia" },
                    { 13, "CHA", "Persuasión" },
                    { 14, "INT", "Religión" },
                    { 15, "DEX", "Sigilo" },
                    { 16, "WIS", "Supervivencia" },
                    { 17, "CHA", "Actuación" }
                });

            migrationBuilder.InsertData(
                table: "Razas",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Los humanos son una raza de ambición desbordante, versátiles como ninguna otra y siempre empujando los límites de lo posible. Carecen de la longevidad de otras especies, pero compensan con una intensidad vital que los impulsa a construir imperios, descubrir secretos arcanos y desafiar a los propios dioses si es necesario. Su diversidad cultural es abrumadora: hay humanos que veneran lo arcano, otros que viven por la espada, y algunos que se guían solo por el comercio o la fe. Son el reflejo de lo mejor y lo peor del mundo.", "Humano" },
                    { 2, "Los elfos son seres de belleza etérea y alma longeva, cuya existencia está profundamente entrelazada con la magia y el equilibrio natural. Habitan bosques antiguos, torres cristalinas o reinos ocultos más allá del velo del mundo material. Para ellos, la paciencia es virtud, y los siglos les otorgan una sabiduría que otras razas solo pueden soñar. Viven con elegancia, se expresan con poesía, y sus movimientos parecen coreografiados por la danza de los vientos. Sin embargo, su perspectiva distante a veces los vuelve fríos ante los problemas urgentes del presente.", "Elfo" },
                    { 3, "Nacidos de la roca y el fuego, los enanos son duros, tenaces y profundamente leales a su clan. Viven en fortalezas subterráneas forjadas en piedra y defendidas con acero, donde la historia de su linaje se graba en muros y crónicas. Su destreza en la herrería es legendaria, y sus armaduras y armas son codiciadas por reyes y aventureros. Son conocidos por su obstinación y su código de honor: una promesa enana es tan firme como la montaña. Sin embargo, su desconfianza hacia lo foráneo a veces los aísla, encerrándolos en sus propias fortalezas mentales y físicas.", "Enano" },
                    { 4, "Pequeños de estatura pero grandes de corazón, los medianos valoran la comodidad del hogar, las historias junto al fuego y la buena comida. Pero no se los debe subestimar: detrás de sus modales tranquilos hay una valentía inesperada y una suerte que raya lo sobrenatural. Suelen mantenerse alejados de las intrigas del mundo exterior, pero cuando uno de ellos deja su comarca, puede cambiar el destino del mundo. Su agilidad, discreción y naturaleza curiosa los vuelven compañeros ideales, y su inquebrantable optimismo es un faro en los tiempos oscuros.", "Mediano" },
                    { 5, "Los gnomos viven con una chispa inextinguible de entusiasmo. Son criaturas de mentes brillantes y corazones desbordantes de ideas. Amantes de los acertijos, la magia ilusoria y los dispositivos complejos, su vida es un constante experimento. Algunos gnomos se sumergen en la alquimia o la mecánica, mientras que otros encuentran gozo en el arte y la música. Son habladores, excéntricos y, a veces, exasperantes, pero nunca aburridos. Para un gnomo, el mundo es un lienzo por pintar o una máquina por desarmar... o ambas.", "Gnomo" },
                    { 6, "Nacidos del cruce entre elfos y humanos, los semielfos caminan entre mundos, sin pertenecer completamente a ninguno. Tienen la gracia y los sentidos agudos de sus ancestros élficos, junto con la pasión y ambición humanas. Su vida es un constante equilibrio entre lo que son y lo que podrían ser. Esta dualidad los vuelve carismáticos, diplomáticos por naturaleza y a menudo solitarios. Rechazados por algunos, idealizados por otros, los semielfos aprenden desde jóvenes a ser sus propios aliados y a forjar su identidad más allá del linaje.", "Semielfo" },
                    { 7, "Forjados en la violencia y la supervivencia, los semiorcos son descendientes de un legado feroz. Su fuerza física es impresionante, sus instintos combativos, agudos, y su presencia, imponente. Pero bajo esa fachada salvaje a menudo se esconde una lucha interna: una búsqueda de propósito, redención o simplemente aceptación. Muchos desafían el estigma que pesa sobre su sangre, demostrando que el honor, la compasión y el heroísmo no están limitados por el origen. Cuando un semiorco jura lealtad, su compromiso es absoluto y feroz como su furia ancestral.", "Semiorco" },
                    { 8, "Imponentes y majestuosos, los dracónidos son el eco de los dragones en forma humanoide. Portan escamas relucientes, ojos ardientes y un aura de poder ancestral. Su herencia se manifiesta no solo en su aliento elemental, sino en su porte y sentido del honor. Criados en sociedades rígidas con fuertes ideales de jerarquía y deber, muchos dracónidos buscan gloria para sí mismos o para sus clanes. Otros vagan por el mundo buscando comprender su conexión con los dragones antiguos. Son nobles, intensos y a menudo, solitarios portadores de un legado que arde en su sangre.", "Dracónido" },
                    { 9, "Marcados desde el nacimiento por pactos antiguos o linajes infernales, los tieflings portan la maldición de una sangre que no pidieron. Cuernos, ojos brillantes y colas serpenteantes los hacen blancos de prejuicio y temor, sin importar su carácter. Pero en la adversidad, los tieflings forjan voluntad de hierro. Muchos abrazan su herencia mágica y oscura, convirtiendo el rechazo en poder. Otros buscan redimirse o cambiar su destino. Bajo la piel infernal puede latir el corazón de un héroe, un villano... o algo mucho más complejo.", "Tiefling" }
                });

            migrationBuilder.InsertData(
                table: "Trasfondos",
                columns: new[] { "Id", "Caracteristica", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Refugio de la fe", "Creciste en un templo, santuario o convento, consagrado al estudio y servicio de lo divino. Aprendiste rituales, escrituras y dogmas. Puedes refugiarte en cualquier templo de tu fe, y su gente suele ayudarte siempre que no contradigas tus votos.", "Acólito" },
                    { 2, "Identidad falsa", "Eres un maestro del engaño, con una red de identidades falsas y documentos falsificados. Tenés habilidades para manipular, disfrazarte y evadir la ley. Tu ingenio te mantiene con vida más que tu espada.", "Charlatán" },
                    { 3, "Contacto criminal", "Viviste al margen de la ley: ladrón, contrabandista, espía o asesino. Tenés una red de contactos en el mundo del crimen que puede ofrecerte información, refugio o favores... a cambio de algo.", "Criminal" },
                    { 4, "Acceso a la fama", "Tu vida es escenario: música, danza, teatro o acrobacias. Soñaste y viajaste mucho, dejando una pequeña estela de admiradores. Donde actúas, la gente te abre puertas y recuerda tu nombre.", "Artista ambulante" },
                    { 5, "Hospitalidad rústica", "De origen humilde, te convertiste en un líder local tras una hazaña. La gente sencilla te considera protector, y siempre encontrarás ayuda y refugio donde otros se niegan.", "Héroe del pueblo" },
                    { 6, "Miembro del gremio", "Fuiste formado en un oficio por un gremio reconocido. Esto te da privilegios legales, apoyo profesional y acceso a redes comerciales. Tu reputación te precede.", "Artesano del gremio" },
                    { 7, "Revelación", "Pasaste años en aislamiento buscando comprensión o redención. Encontraste una verdad secreta: un presagio, un arte arcano, una revelación espiritual. Ahora compartís tu sabiduría, pero te cuesta conectar con otros.", "Ermitaño" },
                    { 8, "Pasaje marítimo", "Has navegado mares, enfrentado tormentas y conocido puertos peligrosos. Sabés leer el cielo, escalar mástiles y sobrevivir en cubierta. La vida en alta mar te formó.", "Marinero" },
                    { 9, "Investigador", "Permaneciste entre libros, laboratorios o pergaminos, buscando respuestas. Tu mente es una biblioteca viviente. Las instituciones académicas te reconocen, aunque pueden verte como un excéntrico.", "Sabio" },
                    { 10, "Rango militar", "La guerra te formó: disciplina, estrategia y camaradería bajo fuego. Tenés un rango o reputación en tu ejército. Tu conocimiento táctico y conexiones militares son puertas abiertas.", "Soldado" },
                    { 11, "Secretos de la ciudad", "Naciste o creciste en calles, callejones o tejados. Pertenecés a bandas, conocés atajos urbanos y sabés el valor de permanecer invisible. La ciudad te acepta como uno de los suyos.", "Urchin (Huérfano urbano)" },
                    { 12, "Actuación pública", "Tus actos cautivan multitudes: canto, actuación, pantomima o música. Tenés presencia escénica, facilidad para atraer a la audiencia y dejar una impresión memorable.", "Entretenedor" },
                    { 13, "Amigo de la naturaleza", "Creciste entre bosques, montañas o tierras alejadas. Sabés rastrear, encontrar comida y sobrevivir sin civilización. Te mueves con naturalidad en terrenos salvajes donde otros se pierden.", "Explorador forastero" },
                    { 14, "Resistencia rural", "Labraste la tierra desde niño, y el trabajo duro te dio resistencia corporal y mental. Conocés vetas de agua, estaciones y ciclos naturales. Tu comunidad te respeta por saber mantenerla viva.", "Granjero" },
                    { 15, "Alerta constante", "Custodiás murallas, rutas o aldeas. Estás entrenado para detectar amenazas, señalarlas y actuar rápido. Pertenecés a un servicio comunitario y sabés mantener el orden.", "Guardia" },
                    { 16, "Mapa y magia", "Explorás lugares desconocidos con herramientas y magia elemental (druídica o arcana). Sabés orientarte, leer mapas y guiar a otros en rutas inexploradas con precisión y asombro.", "Guía/cartógrafo" }
                });

            migrationBuilder.InsertData(
                table: "Subrazas",
                columns: new[] { "Id", "Descripcion", "Nombre", "RazaId" },
                values: new object[,]
                {
                    { 1, "Los elfos de los bosques son rápidos, sigilosos y profundamente conectados con la naturaleza viva. Se desplazan por los árboles como sombras, y sus sentidos perciben lo que otros pasarían por alto. Prefieren la libertad de los caminos ocultos a la rigidez de los salones élficos.", "Elfo de los bosques", 2 },
                    { 2, "Orgullosos guardianes del saber mágico, los elfos altos veneran la tradición, el arte y la perfección arcana. Son los más cercanos a las antiguas cortes feéricas, y su dominio de la magia rivaliza con el de los magos humanos más renombrados.", "Elfo alto", 2 },
                    { 3, "Criados en la oscuridad del inframundo, los drow son elfos marcados por una historia de traición, exilio y matriarcado implacable. Sus habilidades en combate, sigilo y magia oscura los hacen temibles, pero no todos siguen el camino de sus ancestros.", "Elfo oscuro (Drow)", 2 },
                    { 4, "Fuertes de espíritu y resistentes al dolor, los enanos de las colinas valoran la tradición, la familia y los lazos ancestrales. Sus fortalezas están escondidas en valles protegidos, donde la sabiduría es tan preciada como el acero.", "Enano de las colinas", 3 },
                    { 5, "Más altos y robustos que sus parientes de las colinas, los enanos de las montañas son maestros de la guerra y la forja. Viven en fortalezas talladas en la piedra más dura, y sus clanes mantienen legados que se remontan a los albores del mundo.", "Enano de las montañas", 3 },
                    { 6, "Ágiles y escurridizos, los piesligeros tienden a mezclarse con facilidad entre otras razas. Son curiosos, simpáticos y poseen una suerte natural que los salva de las situaciones más improbables.", "Mediano piesligeros", 4 },
                    { 7, "Más fuertes y robustos que otros medianos, los fornidos son sorprendentemente tenaces. Su resistencia física y voluntad férrea los hace ideales para las tareas más duras, a pesar de su pequeña estatura.", "Mediano fornido", 4 },
                    { 8, "Reclusivos, tímidos y misteriosos, los gnomos del bosque habitan en armonía con la naturaleza. Su magia proviene de la tierra misma, y muchos tienen vínculos con criaturas feéricas o espíritus del bosque.", "Gnomo del bosque", 5 },
                    { 9, "Inventores natos, los gnomos de las rocas son ingenieros, alquimistas y soñadores mecánicos. Sus madrigueras están repletas de artilugios chispeantes, libros de fórmulas y proyectos inacabados que podrían cambiar el mundo... o hacerlo explotar.", "Gnomo de las rocas", 5 }
                });

            migrationBuilder.InsertData(
                table: "TrasfondosHabilidad",
                columns: new[] { "HabilidadId", "TrasfondoId" },
                values: new object[,]
                {
                    { 12, 1 },
                    { 14, 1 },
                    { 4, 2 },
                    { 8, 2 },
                    { 4, 3 },
                    { 15, 3 },
                    { 8, 4 },
                    { 17, 4 },
                    { 3, 5 },
                    { 16, 5 },
                    { 12, 6 },
                    { 13, 6 },
                    { 9, 7 },
                    { 14, 7 },
                    { 3, 8 },
                    { 11, 8 },
                    { 2, 9 },
                    { 5, 9 },
                    { 3, 10 },
                    { 6, 10 },
                    { 8, 11 },
                    { 15, 11 },
                    { 1, 12 },
                    { 17, 12 },
                    { 3, 13 },
                    { 16, 13 },
                    { 10, 14 },
                    { 16, 14 },
                    { 3, 15 },
                    { 11, 15 },
                    { 10, 16 },
                    { 16, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrasfondosHabilidad_HabilidadId",
                table: "TrasfondosHabilidad",
                column: "HabilidadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrasfondosHabilidad");

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Razas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Razas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Razas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Razas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Razas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subrazas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subrazas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subrazas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subrazas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subrazas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subrazas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subrazas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subrazas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subrazas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trasfondos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Razas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Razas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Razas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Razas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
