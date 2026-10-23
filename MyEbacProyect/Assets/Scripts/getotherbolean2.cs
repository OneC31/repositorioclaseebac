using UnityEngine;

public class getotherbolean2 : MonoBehaviour
{
    public GameObject CUBO;
    public GameObject Capsule;
    public bool varR2;
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
         if  ( scriptsCUBO.var1 || scriptsCapsule.var1) 
        {   
            varR2 = true;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("or true");
        }
        else
        {
            varR2 = false;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            Debug.Log(scriptsCUBO.var1);
            Debug.Log(scriptsCapsule.var1);
            Debug.Log("both false");
        }
        
    }
}
