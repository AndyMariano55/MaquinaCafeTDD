public class Vasos
{
    private int pequenos;
    private int medianos;
    private int grandes;

    public Vasos(int p, int m, int g)
    {
        pequenos = p;
        medianos = m;
        grandes = g;
    }

    public bool HayVasos(string tamano)
    {
        return tamano.ToLower() switch
        {
            "pequeño" => pequenos > 0,
            "mediano" => medianos > 0,
            "grande" => grandes > 0,
            _ => false
        };
    }

    public void UsarVaso(string tamano)
    {
        switch (tamano.ToLower())
        {
            case "pequeño": if (pequenos > 0) pequenos--; break;
            case "mediano": if (medianos > 0) medianos--; break;
            case "grande": if (grandes > 0) grandes--; break;
        }
    }
}
