using UnityEngine;

public class getotherbolean5to : MonoBehaviour
{
    //public GameObject Sphere22;
    //ublic GameObject Capsule22;

    public getotherbolean getotherbolean;
    public getotherbolean2 getotherbolean2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (getotherbolean.varR && getotherbolean2.varR2)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }
}
