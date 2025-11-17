public class MaquinaDeCafe
{
    private Cafetera cafetera;
    private Azucarero azucarero;
    private Vasos vasos;

    public MaquinaDeCafe(Cafetera cafetera, Azucarero azucarero, Vasos vasos)
    {
        this.cafetera = cafetera;
        this.azucarero = azucarero;
        this.vasos = vasos;
    }

    public string ServirCafe(string tamano, int cucharadasAzucar)
    {
        int cantidadCafe = tamano.ToLower() switch
        {
            "pequeño" => 3,
            "mediano" => 5,
            "grande" => 7,
            _ => 0
        };

        if (!vasos.HayVasos(tamano))
            return "No hay vasos disponibles.";

        if (!cafetera.HayCafe(cantidadCafe))
            return "No hay café suficiente.";

        if (!azucarero.HayAzucar(cucharadasAzucar))
            return "No hay azúcar suficiente.";

        vasos.UsarVaso(tamano);
        cafetera.UsarCafe(cantidadCafe);
        azucarero.UsarAzucar(cucharadasAzucar);

        return $"Aquí tienes tu café {tamano} con {cucharadasAzucar} cucharadas de azúcar ";
    }
}
