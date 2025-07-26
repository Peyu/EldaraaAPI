using EldaraaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EldaraaApi.Data
{
    public class EldaraaDbContext : DbContext
    {
        public EldaraaDbContext(DbContextOptions<EldaraaDbContext> options)
        : base(options)
        {
        }

        public DbSet<Historia> Historias => Set<Historia>();
        public DbSet<Civilizacion> Civilizaciones { get; set; }
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Raza> Razas { get; set; }
        public DbSet<Subraza> Subrazas { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Trasfondo> Trasfondos { get; set; }
        public DbSet<PuntuacionHabilidades> PuntuacionesHabilidades { get; set; }
        public DbSet<Habilidad> Habilidades { get; set; }
        public DbSet<PersonajeHabilidad> PersonajesHabilidad { get; set; }
        public DbSet<EstadisticasCombate> EstadisticasCombate { get; set; }
        public DbSet<Hechizo> Hechizos { get; set; }
        public DbSet<PersonajeHechizo> PersonajesHechizo { get; set; }
        public DbSet<Equipamiento> Equipamientos { get; set; }
        public DbSet<PersonajeEquipamiento> PersonajesEquipamiento { get; set; }
        public DbSet<RasgosPersonalidad> RasgosPersonalidades { get; set; }
        public DbSet<AtributoPersonalizado> AtributosPersonalizados { get; set; }
        public DbSet<EntradaLibre> EntradasLibres { get; set; }
        public DbSet<TrasfondoHabilidad> TrasfondosHabilidad { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonajeHabilidad>().HasKey(ph => new { ph.PersonajeId, ph.HabilidadId });
            modelBuilder.Entity<PersonajeHechizo>().HasKey(ph => new { ph.PersonajeId, ph.HechizoId });
            modelBuilder.Entity<PersonajeEquipamiento>().HasKey(pe => new { pe.PersonajeId, pe.EquipamientoId });

            modelBuilder.Entity<TrasfondoHabilidad>().HasKey(th => new { th.TrasfondoId, th.HabilidadId });

            modelBuilder.Entity<TrasfondoHabilidad>()
                .HasOne(th => th.Trasfondo)
                .WithMany()
                .HasForeignKey(th => th.TrasfondoId);

            modelBuilder.Entity<TrasfondoHabilidad>()
                .HasOne(th => th.Habilidad)
                .WithMany()
                .HasForeignKey(th => th.HabilidadId);

            modelBuilder.Entity<Raza>().HasData(
                new Raza
                {
                    Id = 1,
                    Nombre = "Humano",
                    Descripcion = "Los humanos son una raza de ambición desbordante, versátiles como ninguna otra y siempre empujando los límites de lo posible. Carecen de la longevidad de otras especies, pero compensan con una intensidad vital que los impulsa a construir imperios, descubrir secretos arcanos y desafiar a los propios dioses si es necesario. Su diversidad cultural es abrumadora: hay humanos que veneran lo arcano, otros que viven por la espada, y algunos que se guían solo por el comercio o la fe. Son el reflejo de lo mejor y lo peor del mundo."
                },
                new Raza
                {
                    Id = 2,
                    Nombre = "Elfo",
                    Descripcion = "Los elfos son seres de belleza etérea y alma longeva, cuya existencia está profundamente entrelazada con la magia y el equilibrio natural. Habitan bosques antiguos, torres cristalinas o reinos ocultos más allá del velo del mundo material. Para ellos, la paciencia es virtud, y los siglos les otorgan una sabiduría que otras razas solo pueden soñar. Viven con elegancia, se expresan con poesía, y sus movimientos parecen coreografiados por la danza de los vientos. Sin embargo, su perspectiva distante a veces los vuelve fríos ante los problemas urgentes del presente."
                },
                new Raza
                {
                    Id = 3,
                    Nombre = "Enano",
                    Descripcion = "Nacidos de la roca y el fuego, los enanos son duros, tenaces y profundamente leales a su clan. Viven en fortalezas subterráneas forjadas en piedra y defendidas con acero, donde la historia de su linaje se graba en muros y crónicas. Su destreza en la herrería es legendaria, y sus armaduras y armas son codiciadas por reyes y aventureros. Son conocidos por su obstinación y su código de honor: una promesa enana es tan firme como la montaña. Sin embargo, su desconfianza hacia lo foráneo a veces los aísla, encerrándolos en sus propias fortalezas mentales y físicas."
                },
                new Raza
                {
                    Id = 4,
                    Nombre = "Mediano",
                    Descripcion = "Pequeños de estatura pero grandes de corazón, los medianos valoran la comodidad del hogar, las historias junto al fuego y la buena comida. Pero no se los debe subestimar: detrás de sus modales tranquilos hay una valentía inesperada y una suerte que raya lo sobrenatural. Suelen mantenerse alejados de las intrigas del mundo exterior, pero cuando uno de ellos deja su comarca, puede cambiar el destino del mundo. Su agilidad, discreción y naturaleza curiosa los vuelven compañeros ideales, y su inquebrantable optimismo es un faro en los tiempos oscuros."
                },
                new Raza
                {
                    Id = 5,
                    Nombre = "Gnomo",
                    Descripcion = "Los gnomos viven con una chispa inextinguible de entusiasmo. Son criaturas de mentes brillantes y corazones desbordantes de ideas. Amantes de los acertijos, la magia ilusoria y los dispositivos complejos, su vida es un constante experimento. Algunos gnomos se sumergen en la alquimia o la mecánica, mientras que otros encuentran gozo en el arte y la música. Son habladores, excéntricos y, a veces, exasperantes, pero nunca aburridos. Para un gnomo, el mundo es un lienzo por pintar o una máquina por desarmar... o ambas."
                },
                new Raza
                {
                    Id = 6,
                    Nombre = "Semielfo",
                    Descripcion = "Nacidos del cruce entre elfos y humanos, los semielfos caminan entre mundos, sin pertenecer completamente a ninguno. Tienen la gracia y los sentidos agudos de sus ancestros élficos, junto con la pasión y ambición humanas. Su vida es un constante equilibrio entre lo que son y lo que podrían ser. Esta dualidad los vuelve carismáticos, diplomáticos por naturaleza y a menudo solitarios. Rechazados por algunos, idealizados por otros, los semielfos aprenden desde jóvenes a ser sus propios aliados y a forjar su identidad más allá del linaje."
                },
                new Raza
                {
                    Id = 7,
                    Nombre = "Semiorco",
                    Descripcion = "Forjados en la violencia y la supervivencia, los semiorcos son descendientes de un legado feroz. Su fuerza física es impresionante, sus instintos combativos, agudos, y su presencia, imponente. Pero bajo esa fachada salvaje a menudo se esconde una lucha interna: una búsqueda de propósito, redención o simplemente aceptación. Muchos desafían el estigma que pesa sobre su sangre, demostrando que el honor, la compasión y el heroísmo no están limitados por el origen. Cuando un semiorco jura lealtad, su compromiso es absoluto y feroz como su furia ancestral."
                },
                new Raza
                {
                    Id = 8,
                    Nombre = "Dracónido",
                    Descripcion = "Imponentes y majestuosos, los dracónidos son el eco de los dragones en forma humanoide. Portan escamas relucientes, ojos ardientes y un aura de poder ancestral. Su herencia se manifiesta no solo en su aliento elemental, sino en su porte y sentido del honor. Criados en sociedades rígidas con fuertes ideales de jerarquía y deber, muchos dracónidos buscan gloria para sí mismos o para sus clanes. Otros vagan por el mundo buscando comprender su conexión con los dragones antiguos. Son nobles, intensos y a menudo, solitarios portadores de un legado que arde en su sangre."
                },
                new Raza
                {
                    Id = 9,
                    Nombre = "Tiefling",
                    Descripcion = "Marcados desde el nacimiento por pactos antiguos o linajes infernales, los tieflings portan la maldición de una sangre que no pidieron. Cuernos, ojos brillantes y colas serpenteantes los hacen blancos de prejuicio y temor, sin importar su carácter. Pero en la adversidad, los tieflings forjan voluntad de hierro. Muchos abrazan su herencia mágica y oscura, convirtiendo el rechazo en poder. Otros buscan redimirse o cambiar su destino. Bajo la piel infernal puede latir el corazón de un héroe, un villano... o algo mucho más complejo."
                }
            );

            modelBuilder.Entity<Subraza>().HasData(
                // ELFO (RazaId = 2)
                new Subraza
                {
                    Id = 1,
                    RazaId = 2,
                    Nombre = "Elfo de los bosques",
                    Descripcion = "Los elfos de los bosques son rápidos, sigilosos y profundamente conectados con la naturaleza viva. Se desplazan por los árboles como sombras, y sus sentidos perciben lo que otros pasarían por alto. Prefieren la libertad de los caminos ocultos a la rigidez de los salones élficos."
                },
                new Subraza
                {
                    Id = 2,
                    RazaId = 2,
                    Nombre = "Elfo alto",
                    Descripcion = "Orgullosos guardianes del saber mágico, los elfos altos veneran la tradición, el arte y la perfección arcana. Son los más cercanos a las antiguas cortes feéricas, y su dominio de la magia rivaliza con el de los magos humanos más renombrados."
                },
                new Subraza
                {
                    Id = 3,
                    RazaId = 2,
                    Nombre = "Elfo oscuro (Drow)",
                    Descripcion = "Criados en la oscuridad del inframundo, los drow son elfos marcados por una historia de traición, exilio y matriarcado implacable. Sus habilidades en combate, sigilo y magia oscura los hacen temibles, pero no todos siguen el camino de sus ancestros."
                },

                // ENANO (RazaId = 3)
                new Subraza
                {
                    Id = 4,
                    RazaId = 3,
                    Nombre = "Enano de las colinas",
                    Descripcion = "Fuertes de espíritu y resistentes al dolor, los enanos de las colinas valoran la tradición, la familia y los lazos ancestrales. Sus fortalezas están escondidas en valles protegidos, donde la sabiduría es tan preciada como el acero."
                },
                new Subraza
                {
                    Id = 5,
                    RazaId = 3,
                    Nombre = "Enano de las montañas",
                    Descripcion = "Más altos y robustos que sus parientes de las colinas, los enanos de las montañas son maestros de la guerra y la forja. Viven en fortalezas talladas en la piedra más dura, y sus clanes mantienen legados que se remontan a los albores del mundo."
                },

                // MEDIANO (RazaId = 4)
                new Subraza
                {
                    Id = 6,
                    RazaId = 4,
                    Nombre = "Mediano piesligeros",
                    Descripcion = "Ágiles y escurridizos, los piesligeros tienden a mezclarse con facilidad entre otras razas. Son curiosos, simpáticos y poseen una suerte natural que los salva de las situaciones más improbables."
                },
                new Subraza
                {
                    Id = 7,
                    RazaId = 4,
                    Nombre = "Mediano fornido",
                    Descripcion = "Más fuertes y robustos que otros medianos, los fornidos son sorprendentemente tenaces. Su resistencia física y voluntad férrea los hace ideales para las tareas más duras, a pesar de su pequeña estatura."
                },

                // GNOMO (RazaId = 5)
                new Subraza
                {
                    Id = 8,
                    RazaId = 5,
                    Nombre = "Gnomo del bosque",
                    Descripcion = "Reclusivos, tímidos y misteriosos, los gnomos del bosque habitan en armonía con la naturaleza. Su magia proviene de la tierra misma, y muchos tienen vínculos con criaturas feéricas o espíritus del bosque."
                },
                new Subraza
                {
                    Id = 9,
                    RazaId = 5,
                    Nombre = "Gnomo de las rocas",
                    Descripcion = "Inventores natos, los gnomos de las rocas son ingenieros, alquimistas y soñadores mecánicos. Sus madrigueras están repletas de artilugios chispeantes, libros de fórmulas y proyectos inacabados que podrían cambiar el mundo... o hacerlo explotar."
                }
            );

            modelBuilder.Entity<Clase>().HasData(
                new Clase
                {
                    Id = 1,
                    Nombre = "Bárbaro",
                    DadoGolpe = 12,
                    LanzadorConjuros = false,
                    Descripcion = "El bárbaro es una fuerza bruta de la naturaleza. Canaliza su furia en combate, desatando una rabia salvaje que lo hace casi imposible de detener. Su conexión con el instinto lo vuelve resistente al dolor y letal con armas contundentes. No pelea por gloria, sino por supervivencia y orgullo tribal."
                },
                new Clase
                {
                    Id = 2,
                    Nombre = "Bardo",
                    DadoGolpe = 8,
                    LanzadorConjuros = true,
                    Descripcion = "El bardo convierte la música, el arte y las palabras en magia pura. Domina una versatilidad asombrosa: puede inspirar a sus aliados, desatar hechizos o incluso engañar a la muerte con su carisma. Donde otros lanzan conjuros con libros o plegarias, el bardo lo hace con una canción."
                },
                new Clase
                {
                    Id = 3,
                    Nombre = "Clérigo",
                    DadoGolpe = 8,
                    LanzadorConjuros = true,
                    Descripcion = "Guerrero sagrado y servidor de lo divino, el clérigo canaliza el poder de su dios para sanar, proteger o castigar. Dependiendo de su dominio, puede ser un faro de vida, un martillo de guerra o un vengador implacable. Su fe es su arma más poderosa."
                },
                new Clase
                {
                    Id = 4,
                    Nombre = "Druida",
                    DadoGolpe = 8,
                    LanzadorConjuros = true,
                    Descripcion = "Los druidas son guardianes del equilibrio natural. Controlan las fuerzas elementales, se transforman en bestias y convocan la furia de la tormenta o la calma del bosque. Su conexión con la tierra es profunda, y su sabiduría, ancestral."
                },
                new Clase
                {
                    Id = 5,
                    Nombre = "Guerrero",
                    DadoGolpe = 10,
                    LanzadorConjuros = false,
                    Descripcion = "Maestro del combate marcial, el guerrero es versátil, disciplinado y peligroso con cualquier arma. Algunos luchan por honor, otros por oro, pero todos son fuerza pura en el campo de batalla. Su entrenamiento lo convierte en una máquina de guerra adaptable."
                },
                new Clase
                {
                    Id = 6,
                    Nombre = "Hechicero",
                    DadoGolpe = 6,
                    LanzadorConjuros = true,
                    Descripcion = "A diferencia de los magos, los hechiceros nacen con la magia en la sangre. Su poder es innato, salvaje y muchas veces impredecible. Canalizan energías caóticas con pura fuerza de voluntad, y su conexión mágica suele tener un origen misterioso o ancestral."
                },
                new Clase
                {
                    Id = 7,
                    Nombre = "Mago",
                    DadoGolpe = 6,
                    LanzadorConjuros = true,
                    Descripcion = "El mago es un erudito de lo arcano. A través de años de estudio y práctica rigurosa, domina una vasta variedad de conjuros. Aunque físicamente débil, su conocimiento mágico puede alterar la realidad misma, desatar tormentas de fuego o viajar entre planos."
                },
                new Clase
                {
                    Id = 8,
                    Nombre = "Monje",
                    DadoGolpe = 8,
                    LanzadorConjuros = false,
                    Descripcion = "El monje perfecciona su cuerpo y mente hasta convertirlos en armas. Con una disciplina inquebrantable, puede golpear con velocidad fulminante, caminar por paredes o canalizar su ki para defenderse del daño. Es la encarnación del equilibrio interior."
                },
                new Clase
                {
                    Id = 9,
                    Nombre = "Paladín",
                    DadoGolpe = 10,
                    LanzadorConjuros = true,
                    Descripcion = "Guardián de lo sagrado, el paladín jura votos que lo vinculan a una causa o deidad. Sus habilidades combinan fuerza marcial con poder divino: cura heridas, destruye el mal y resiste la corrupción con una voluntad inquebrantable. Su fe es su escudo."
                },
                new Clase
                {
                    Id = 10,
                    Nombre = "Pícaro",
                    DadoGolpe = 8,
                    LanzadorConjuros = false,
                    Descripcion = "Ágil, astuto y letal en la sombra, el pícaro domina el sigilo, el engaño y los golpes certeros. Es el primero en entrar y el último en ser visto. Ya sea un ladrón callejero o un espía refinado, el pícaro convierte cada oportunidad en ventaja."
                },
                new Clase
                {
                    Id = 11,
                    Nombre = "Explorador",
                    DadoGolpe = 10,
                    LanzadorConjuros = true,
                    Descripcion = "El explorador es un cazador del mundo salvaje. Domina terrenos inhóspitos, sigue rastros imposibles y combate con eficacia donde otros apenas sobreviven. Muchos tienen compañeros animales y lanzan conjuros naturales para proteger sus dominios."
                },
                new Clase
                {
                    Id = 12,
                    Nombre = "Brujo",
                    DadoGolpe = 8,
                    LanzadorConjuros = true,
                    Descripcion = "El brujo obtiene su poder mediante un pacto con una entidad poderosa: un demonio, un hada, un ente cósmico. Sus conjuros son limitados pero potentes, y sus habilidades oscuras lo convierten en un maestro del misterio y lo oculto. Su pacto es su fuerza... y su maldición."
                }
            );

            modelBuilder.Entity<Trasfondo>().HasData(
                // --- 16 trasfondos del PHB 2024 ---
                new Trasfondo
                {
                    Id = 1,
                    Nombre = "Acólito",
                    Caracteristica = "Refugio de la fe",
                    Descripcion = "Creciste en un templo, santuario o convento, consagrado al estudio y servicio de lo divino. Aprendiste rituales, escrituras y dogmas. Puedes refugiarte en cualquier templo de tu fe, y su gente suele ayudarte siempre que no contradigas tus votos."
                },
                new Trasfondo
                {
                    Id = 2,
                    Nombre = "Charlatán",
                    Caracteristica = "Identidad falsa",
                    Descripcion = "Eres un maestro del engaño, con una red de identidades falsas y documentos falsificados. Tenés habilidades para manipular, disfrazarte y evadir la ley. Tu ingenio te mantiene con vida más que tu espada."
                },
                new Trasfondo
                {
                    Id = 3,
                    Nombre = "Criminal",
                    Caracteristica = "Contacto criminal",
                    Descripcion = "Viviste al margen de la ley: ladrón, contrabandista, espía o asesino. Tenés una red de contactos en el mundo del crimen que puede ofrecerte información, refugio o favores... a cambio de algo."
                },
                new Trasfondo
                {
                    Id = 4,
                    Nombre = "Artista ambulante",
                    Caracteristica = "Acceso a la fama",
                    Descripcion = "Tu vida es escenario: música, danza, teatro o acrobacias. Soñaste y viajaste mucho, dejando una pequeña estela de admiradores. Donde actúas, la gente te abre puertas y recuerda tu nombre."
                },
                new Trasfondo
                {
                    Id = 5,
                    Nombre = "Héroe del pueblo",
                    Caracteristica = "Hospitalidad rústica",
                    Descripcion = "De origen humilde, te convertiste en un líder local tras una hazaña. La gente sencilla te considera protector, y siempre encontrarás ayuda y refugio donde otros se niegan."
                },
                new Trasfondo
                {
                    Id = 6,
                    Nombre = "Artesano del gremio",
                    Caracteristica = "Miembro del gremio",
                    Descripcion = "Fuiste formado en un oficio por un gremio reconocido. Esto te da privilegios legales, apoyo profesional y acceso a redes comerciales. Tu reputación te precede."
                },
                new Trasfondo
                {
                    Id = 7,
                    Nombre = "Ermitaño",
                    Caracteristica = "Revelación",
                    Descripcion = "Pasaste años en aislamiento buscando comprensión o redención. Encontraste una verdad secreta: un presagio, un arte arcano, una revelación espiritual. Ahora compartís tu sabiduría, pero te cuesta conectar con otros."
                },
                new Trasfondo
                {
                    Id = 8,
                    Nombre = "Marinero",
                    Caracteristica = "Pasaje marítimo",
                    Descripcion = "Has navegado mares, enfrentado tormentas y conocido puertos peligrosos. Sabés leer el cielo, escalar mástiles y sobrevivir en cubierta. La vida en alta mar te formó."
                },
                new Trasfondo
                {
                    Id = 9,
                    Nombre = "Sabio",
                    Caracteristica = "Investigador",
                    Descripcion = "Permaneciste entre libros, laboratorios o pergaminos, buscando respuestas. Tu mente es una biblioteca viviente. Las instituciones académicas te reconocen, aunque pueden verte como un excéntrico."
                },
                new Trasfondo
                {
                    Id = 10,
                    Nombre = "Soldado",
                    Caracteristica = "Rango militar",
                    Descripcion = "La guerra te formó: disciplina, estrategia y camaradería bajo fuego. Tenés un rango o reputación en tu ejército. Tu conocimiento táctico y conexiones militares son puertas abiertas."
                },
                new Trasfondo
                {
                    Id = 11,
                    Nombre = "Urchin (Huérfano urbano)",
                    Caracteristica = "Secretos de la ciudad",
                    Descripcion = "Naciste o creciste en calles, callejones o tejados. Pertenecés a bandas, conocés atajos urbanos y sabés el valor de permanecer invisible. La ciudad te acepta como uno de los suyos."
                },
                new Trasfondo
                {
                    Id = 12,
                    Nombre = "Entretenedor",
                    Caracteristica = "Actuación pública",
                    Descripcion = "Tus actos cautivan multitudes: canto, actuación, pantomima o música. Tenés presencia escénica, facilidad para atraer a la audiencia y dejar una impresión memorable."
                },
                new Trasfondo
                {
                    Id = 13,
                    Nombre = "Explorador forastero",
                    Caracteristica = "Amigo de la naturaleza",
                    Descripcion = "Creciste entre bosques, montañas o tierras alejadas. Sabés rastrear, encontrar comida y sobrevivir sin civilización. Te mueves con naturalidad en terrenos salvajes donde otros se pierden."
                },
                new Trasfondo
                {
                    Id = 14,
                    Nombre = "Granjero",
                    Caracteristica = "Resistencia rural",
                    Descripcion = "Labraste la tierra desde niño, y el trabajo duro te dio resistencia corporal y mental. Conocés vetas de agua, estaciones y ciclos naturales. Tu comunidad te respeta por saber mantenerla viva."
                },
                new Trasfondo
                {
                    Id = 15,
                    Nombre = "Guardia",
                    Caracteristica = "Alerta constante",
                    Descripcion = "Custodiás murallas, rutas o aldeas. Estás entrenado para detectar amenazas, señalarlas y actuar rápido. Pertenecés a un servicio comunitario y sabés mantener el orden."
                },
                new Trasfondo
                {
                    Id = 16,
                    Nombre = "Guía/cartógrafo",
                    Caracteristica = "Mapa y magia",
                    Descripcion = "Explorás lugares desconocidos con herramientas y magia elemental (druídica o arcana). Sabés orientarte, leer mapas y guiar a otros en rutas inexploradas con precisión y asombro."
                }
            );

            modelBuilder.Entity<Habilidad>().HasData(
                new Habilidad { Id = 1, Nombre = "Acrobacias", HabilidadBase = "DEX" },
                new Habilidad { Id = 2, Nombre = "Arcana", HabilidadBase = "INT" },
                new Habilidad { Id = 3, Nombre = "Atletismo", HabilidadBase = "STR" },
                new Habilidad { Id = 4, Nombre = "Engaño", HabilidadBase = "CHA" },
                new Habilidad { Id = 5, Nombre = "Historia", HabilidadBase = "INT" },
                new Habilidad { Id = 6, Nombre = "Intimidación", HabilidadBase = "CHA" },
                new Habilidad { Id = 7, Nombre = "Investigación", HabilidadBase = "INT" },
                new Habilidad { Id = 8, Nombre = "Juego de manos", HabilidadBase = "DEX" },
                new Habilidad { Id = 9, Nombre = "Medicina", HabilidadBase = "WIS" },
                new Habilidad { Id = 10, Nombre = "Naturaleza", HabilidadBase = "INT" },
                new Habilidad { Id = 11, Nombre = "Percepción", HabilidadBase = "WIS" },
                new Habilidad { Id = 12, Nombre = "Perspicacia", HabilidadBase = "WIS" },
                new Habilidad { Id = 13, Nombre = "Persuasión", HabilidadBase = "CHA" },
                new Habilidad { Id = 14, Nombre = "Religión", HabilidadBase = "INT" },
                new Habilidad { Id = 15, Nombre = "Sigilo", HabilidadBase = "DEX" },
                new Habilidad { Id = 16, Nombre = "Supervivencia", HabilidadBase = "WIS" },
                new Habilidad { Id = 17, Nombre = "Actuación", HabilidadBase = "CHA" }
            );

            modelBuilder.Entity<TrasfondoHabilidad>().HasData(
                // Acólito
                new TrasfondoHabilidad { TrasfondoId = 1, HabilidadId = 14 },
                new TrasfondoHabilidad { TrasfondoId = 1, HabilidadId = 12 },

                // Charlatán
                new TrasfondoHabilidad { TrasfondoId = 2, HabilidadId = 4 },
                new TrasfondoHabilidad { TrasfondoId = 2, HabilidadId = 8 },

                // Criminal
                new TrasfondoHabilidad { TrasfondoId = 3, HabilidadId = 15 },
                new TrasfondoHabilidad { TrasfondoId = 3, HabilidadId = 4 },

                // Artista ambulante
                new TrasfondoHabilidad { TrasfondoId = 4, HabilidadId = 17 },
                new TrasfondoHabilidad { TrasfondoId = 4, HabilidadId = 8 },

                // Héroe del pueblo
                new TrasfondoHabilidad { TrasfondoId = 5, HabilidadId = 3 },
                new TrasfondoHabilidad { TrasfondoId = 5, HabilidadId = 16 },

                // Artesano del gremio
                new TrasfondoHabilidad { TrasfondoId = 6, HabilidadId = 13 },
                new TrasfondoHabilidad { TrasfondoId = 6, HabilidadId = 12 },

                // Ermitaño
                new TrasfondoHabilidad { TrasfondoId = 7, HabilidadId = 9 },
                new TrasfondoHabilidad { TrasfondoId = 7, HabilidadId = 14 },

                // Marinero
                new TrasfondoHabilidad { TrasfondoId = 8, HabilidadId = 3 },
                new TrasfondoHabilidad { TrasfondoId = 8, HabilidadId = 11 },

                // Sabio
                new TrasfondoHabilidad { TrasfondoId = 9, HabilidadId = 2 },
                new TrasfondoHabilidad { TrasfondoId = 9, HabilidadId = 5 },

                // Soldado
                new TrasfondoHabilidad { TrasfondoId = 10, HabilidadId = 3 },
                new TrasfondoHabilidad { TrasfondoId = 10, HabilidadId = 6 },

                // Urchin (Huérfano urbano)
                new TrasfondoHabilidad { TrasfondoId = 11, HabilidadId = 15 },
                new TrasfondoHabilidad { TrasfondoId = 11, HabilidadId = 8 },

                // Entretenedor
                new TrasfondoHabilidad { TrasfondoId = 12, HabilidadId = 17 },
                new TrasfondoHabilidad { TrasfondoId = 12, HabilidadId = 1 },

                // Explorador forastero
                new TrasfondoHabilidad { TrasfondoId = 13, HabilidadId = 16 },
                new TrasfondoHabilidad { TrasfondoId = 13, HabilidadId = 3 },

                // Granjero
                new TrasfondoHabilidad { TrasfondoId = 14, HabilidadId = 10 },
                new TrasfondoHabilidad { TrasfondoId = 14, HabilidadId = 16 },

                // Guardia
                new TrasfondoHabilidad { TrasfondoId = 15, HabilidadId = 11 },
                new TrasfondoHabilidad { TrasfondoId = 15, HabilidadId = 3 },

                // Guía / Cartógrafo
                new TrasfondoHabilidad { TrasfondoId = 16, HabilidadId = 10 },
                new TrasfondoHabilidad { TrasfondoId = 16, HabilidadId = 16 }
            );
        }
    }
}
