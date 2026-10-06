using UnityEngine;

public class Hola_Mundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
       Debug.LogWarning("funcion awake"); 
    }
    void Start()
    {
         
         Debug.LogError("funcion start");
         
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("funcion update");
    }
}
