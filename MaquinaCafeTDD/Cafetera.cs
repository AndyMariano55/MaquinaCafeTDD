public class Cafetera
{
    private int cantidadCafe;

    public Cafetera(int cantidadInicial)
    {
        cantidadCafe = cantidadInicial;
    }

    public bool HayCafe(int cantidad) => cantidadCafe >= cantidad;

    public void UsarCafe(int cantidad)
    {
        if (HayCafe(cantidad))
            cantidadCafe -= cantidad;
    }
}
