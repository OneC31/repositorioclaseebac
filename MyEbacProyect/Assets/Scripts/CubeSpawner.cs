using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab; // Prefab del cubo a instanciar
    public List<GameObject> listaCubes;
    public float FactorDeEscalamiento;
    public int numberofCubes = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listaCubes = new List<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        numberofCubes++;
        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);
        tempGameObject.name = "Cube" + numberofCubes;
        Color c =new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listaCubes.Add(tempGameObject);
        List<GameObject> objetosparaeliminar = new List<GameObject>();
       foreach (GameObject go in listaCubes)
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
            listaCubes.Remove(go);
            Destroy(go);
        }
    }
}
