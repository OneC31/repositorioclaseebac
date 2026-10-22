using UnityEngine;

public class getotherbolean : MonoBehaviour
{

    public GameObject CUBO;
    public GameObject Capsule;
    bool varR;
    public McolorFuncionAwake mcolorFuncionAwake ;
    public McolorFuncionAwake scriptsCUBO;
    public McolorFuncionAwake scriptsCapsule;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scriptsCUBO = CUBO.GetComponent<McolorFuncionAwake>();
        scriptsCapsule = Capsule.GetComponent<McolorFuncionAwake>();
       
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
         if  ( scriptsCUBO.var1 && scriptsCapsule.var1) 
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("both true");
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            Debug.Log("one false");
        }
        
    }
}
