namespace EldaraaApi.Data;

public static class HistoriaStore
{
    public static List<object> GetHistorias()
    {
        return new List<object>
        {
            new {
                titulo = "El Emperador sin Nombre",
                resumen = "Hace generaciones, cuando Eldara estaba desgarrada por guerras interminables, surgió un hombre...",
                texto = """Hace generaciones, cuando Eldara estaba desgarrada por guerras interminables, surgió un hombre. Su nombre fue prohibido ... y otros, en susurros, lo esperan."""
            },
            new {
                titulo = "La Llama y la Ruina – Crónica del Fin del Imperio",
                resumen = "Tras su misteriosa desaparición, las naciones recuperaron su libertad...",
                texto = """El imperio era vasto. Inquebrantable. ... Y no todos se despiertan."""
            },
            new {
                titulo = "La Torre que Solo los Dignos Ven – Crónica de la Escuela de Magia",
                resumen = "En tierras neutrales, las Hechiceras de Vareth fundaron una torre donde se enseña magia...",
                texto = """En el corazón de la tierra de nadie ... nadie la disputará."""
            },
            new {
                titulo = "Las Diez Llamas Silenciosas – El Juramento de las Hechiceras de Vareth",
                resumen = "Las hechiceras de Vareth no gritan, no conquistan, no marchan. Pero cuando hablan… el mundo escucha",
                texto = """Cuando cayó el Imperio del Tirano sin Nombre ... Caerán todas."""
            }
        };
    }
}