using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOunliner : MonoBehaviour
{
    private GameObject outLine;
    private Mesh outLineMesh;
    private MeshRenderer outLineMeshRenderer;
    [SerializeField, Header("縁取りの色用Materialの設定"), Tooltip("\"~/Material/OutLine\"を使って")]
    private Material outLineMaterual;
    // Start is called before the first frame update
    void Start()
    {
        outLine = Instantiate(this.gameObject);
        
        Destroy(outLine.GetComponent<AddOunliner>());
        Destroy(outLine.GetComponent<Collider>());
        outLine.transform.parent = this.gameObject.transform;
        outLine.name = this.name+".OutLine";
        outLine.transform.localScale *= 1.05f; 
        outLine.GetComponent<Renderer>().material = outLineMaterual;
    }
    
}
