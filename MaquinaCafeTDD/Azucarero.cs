public class Azucarero
{
    private int cantidadAzucar;

    public Azucarero(int cantidadInicial)
    {
        cantidadAzucar = cantidadInicial;
    }

    public bool HayAzucar(int cantidad) => cantidadAzucar >= cantidad;

    public void UsarAzucar(int cantidad)
    {
        if (HayAzucar(cantidad))
            cantidadAzucar -= cantidad;
    }
}
