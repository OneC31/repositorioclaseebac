using UnityEngine;


public class CubeOnDisable : MonoBehaviour

{
    public GameObject CUBIS;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
           
    }
    void OnEnable()
    {
        // crear cubo cuando se activa
        GameObject tempGameObject = Instantiate<GameObject>(gameObject);
        CUBIS = tempGameObject;
        tempGameObject.transform.position = transform.position;
        tempGameObject.transform.rotation = transform.rotation;

        tempGameObject.name = "CubeOnEnable";
        GetComponent<MeshRenderer>().material.color = Color.red;

    }
    void OnDisable()
    {
        // destruir cubo cuando se desactiva
        CUBIS.SetActive(false);
        Destroy(CUBIS);

        Debug.Log("Cube On Disable");
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
