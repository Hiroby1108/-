using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacuumer : MonoBehaviour
{
    private GameObject par;

    [SerializeField, Header("吸引力")]
    private float adForce;
    // Start is called before the first frame update
    void Start()
    {
        if (this.transform.parent.name == "Vacuum") par = this.transform.parent.gameObject;
        else Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Rigidbody>() == null) return;
        if (other.tag == "Living" || other.tag == "Trash") Vacuum(other);
    }


    private void Vacuum(Collider other)
    {
        Rigidbody one;
        if (other.GetComponent<Rigidbody>() == null) return;
        else
        {
            one = other.GetComponent<Rigidbody>();
            var vV = other.transform.position - par.transform.position;
            
            one.AddForce(-vV.normalized * adForce);
            
        }
        


    }
}
