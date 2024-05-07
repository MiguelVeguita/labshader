using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class npc1 : MonoBehaviour
{
    private Rigidbody npc1rig;
    public GameObject cartel1;
    public float x, y, z,pla;
    public bool interactuar,pcp;
   
    // Start is called before the first frame update
    void Start()
    {
        npc1rig = GetComponent<Rigidbody>();
        pla = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        float yy = npc1rig.velocity.y;

        npc1rig.velocity = new Vector3(x*3*pla, yy, z*3*pla);
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "p1")
        {
            x = 0;
            z = -1;
        }
        if (collision.transform.tag == "p2")
        {
            x = 1;
            z = 0;
        }
        if (collision.transform.tag == "p3")
        {
            x = 0;
            z = 1;
        }
        if (collision.transform.tag == "p4")
        {
            x = -1;
            z = 0;
        }
        if (collision.transform.tag == "Player")
        {
            pla = 0;
            interactuar = true;
            
                cartel1.SetActive(true);
            

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            pla = 1;
            interactuar = false;
            
                cartel1.SetActive(false);
            
           
        }
    }
    public bool iii()
    {

        return interactuar;
    }
   
    
}
