using UnityEngine;

public class claseNormal
{
    int numero1;
    int numero2;

    public claseNormal(int param1, int param2)
    {
        numero1 = param1;
        numero2 = param2;
    }
    public claseNormal(float param1, float param2)
    {
        numero1 = (int)param1;
        numero2 = (int)param2;
    }
    public int SumaEnteros(int a, int b)
    {
        return a + b;
    }
    

    public float SumaFlotantes(float a, float b)
    {
        return a + b;
    }

    public float SumaEnteros(float a, float b)
    {
        return a + b;
    }
    
    public void VuelveCeroAlNumero(out float numero)
    {
        numero = 0;
    }
}   

