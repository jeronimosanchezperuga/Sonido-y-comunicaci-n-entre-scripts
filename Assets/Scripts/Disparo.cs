using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    public Transform apuntadorTR;
    Rigidbody rbBala;

    public float fuerzaDisparo; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(bala);
            rbBala = clon.GetComponent<Rigidbody>();
            clon.transform.rotation = apuntadorTR.rotation;
            rbBala.AddForce(clon.transform.up * fuerzaDisparo,ForceMode.Impulse);
            Destroy(clon,1);
        }
    }
}
