using System.Collections.Generic;
using UnityEngine;


public class SferaUpdate : MonoBehaviour
{
    public GameObject SPHEREM6;
    public List<GameObject> listaEsferas;
    public float FactorDeEscalamiento;
    public int numberofEsferas = 4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listaEsferas = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
     //creando esfera
    {
        numberofEsferas++;
        GameObject tempGameObject = Instantiate<GameObject>(SPHEREM6);
        tempGameObject.name = "Sphere";
        tempGameObject.transform.position = Random.insideUnitSphere;
        


        listaEsferas.Add(tempGameObject);
        List<GameObject> objetosparaeliminar = new List<GameObject>();
        foreach (GameObject go in listaEsferas)

        {
            float escala = go.transform.localScale.x;

            escala *= FactorDeEscalamiento;
            go.transform.localScale = Vector3.one * escala;
            
            if (escala <= 0.1)
            {
                objetosparaeliminar.Add(go);
            }
           
        }
        foreach (GameObject go in objetosparaeliminar)
        {
            listaEsferas.Remove(go);
            Destroy(go);
        }
        

    }
}
