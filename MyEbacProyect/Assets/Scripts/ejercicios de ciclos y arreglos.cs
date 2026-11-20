using UnityEngine;

public class ejerciciosdeciclosyarreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                //ejercicio10
        int tamaño = 10;
        int[] arr1 = new int[tamaño];
        int[] arr2 = new int[tamaño];
        int[] arr3 = new int[tamaño];

        // llenar arr1 y arr2 con números aleatorios
        for (int i = 0; i < tamaño; i++)
        {
            arr1[i] = Random.Range(1, 10);   // de 1 a 100
            arr2[i] = Random.Range(1, 10);
        }

        // llenar arr3 con la suma posición por posición
        for (int i = 0; i < tamaño; i++)
        {
            arr3[i] = arr1[i] + arr2[i];
            Debug.Log("arr3[" + i + "] = " + arr1[i] + " + " + arr2[i] + " = " + arr3[i]);
        }
        //ejercicio2
        string[] palabras = { "Hola", "mundo", "desde", "Unity", "con", "C#" };
        string oracion = "";

        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }
            
            Debug.Log(palabras[0]);
            Debug.Log(oracion);     

            //ejercicio12
            int[,] A = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            int[] B = { 2, 1, 3 };

            int renglones = A.GetLength(0);   // 2
            int columnas  = A.GetLength(1);   // 3

            int[] resultado = new int[renglones];

            for (int i = 0; i < renglones; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i] += A[i, j] * B[j];
                }
                Debug.Log("resultado[" + i + "] = " + resultado[i]);
            }  

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
