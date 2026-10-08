using UnityEngine;

public class CubeOnOFF : MonoBehaviour
{
    public GameObject cuboONOFF;
    
    private GameObject copia;

    void OnEnable()
    {
        copia = Instantiate(
            cuboONOFF,
            transform.position,
            transform.rotation
        );

        copia.name = "CubeOnOFF";
        copia.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    void OnDisable()
    { 
        if (copia != null)
        {
            Debug.Log("se desactivo correctamente");
            Destroy(copia);
        }
    }
}