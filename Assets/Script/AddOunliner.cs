using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOunliner : MonoBehaviour
{
    /*Unityの処理のせいか、正常に稼働しない
     * 使うな*/
    private GameObject outLine;
    private Mesh outLineMesh;
    private MeshRenderer outLineMeshRenderer;
    [SerializeField, Header("縁取りの色用Materialの設定"), Tooltip("\"~/Material/OutLine\"を使って")]
    private Material outLineMaterual;
    // Start is called before the first frame update
    void Start()
    {
        outLine = Instantiate(this.gameObject);
        outLine.SetActive(false);
        foreach (var con in outLine.GetComponents<Component>())
        {
            foreach (Transform n in outLine.transform)
            {
                GameObject.Destroy(n.gameObject);
            }
            if (!(con.GetType().Name == "MeshFilter"
                || con.GetType().Name== "MeshRenderer"
                || con.GetType().Name == "Transform"))
            {
                Debug.Log(con.GetType().Name);
                Destroy(outLine.GetComponent(con.GetType().Name));
            }
        }
        
        outLine.transform.parent = this.gameObject.transform;
        outLine.name = this.name+".OutLine";
        outLine.transform.localScale *= 1.05f; 
        outLine.GetComponent<Renderer>().material = outLineMaterual;
        outLine.SetActive(true);
    }
    
}
