using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerat : MonoBehaviour
{
    
    [SerializeField,Header("ゴミリスト"),Tooltip("Assets/Prefab/Trash01～03 :を使用\n\"Rigidbody\"を適用したものを使用")]
    List<Rigidbody> trashRig = new List<Rigidbody>();

    [SerializeField,Header("生物リスト"), Tooltip("まだ使用物を決めていない\n\"Rigidbody\"を適用したものを使用")]
    List<Rigidbody> livingRig = new List<Rigidbody>();

    [SerializeField, Header("拡散範囲(プレイエリアの大きさ)"), Tooltip("拡散範囲を囲うようにプレイエリアを設定")]
    float range = 50;

    [SerializeField, Header("ゴミ生成個数")]
    int numOfTrash = 10;

    [SerializeField, Header("生物生成個数")]
    int numOfLiving = 10;

    [SerializeField, Header("活動中心//デフォルトは0,0,0")]
    Vector3 center = new Vector3(0f,0f,0f);

    [System.NonSerialized]
    public float rangeOut;

    
    private bool generatEnd;
    private GameObject PlayArea;
    private GameObject SafetyArea;

    // Start is called before the first frame update
    void Start()
    {
        generatEnd = false;
        PlayArea = this.transform.GetChild(0).gameObject;
        SafetyArea = this.transform.GetChild(0).GetChild(0).gameObject;
        this.transform.position = center;
        rangeOut = range;
        
        Generate(numOfTrash, trashRig);//ゴミ生成
        Generate(numOfLiving, livingRig);//生き物生成
        
        if (PlayArea != null) PlayArea.transform.localScale = new Vector3(range, range, range) * 5f;
        if (SafetyArea != null) SafetyArea.transform.localScale = new Vector3(1f, 1f, 1f)*3.5f /5f;

        generatEnd = true;
        Debug.Log("Generated Complete");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Generate(int i_num, List<Rigidbody> listRig)
    {
        if (listRig.Count <= 0) return;//未設定時
        for (int LP = 0; LP < i_num; LP++)
        {
            int x = (int)Random.Range(0, listRig.Count);
            if (listRig[x] == null) continue;
            Instantiate(listRig[x],//
                new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range)),//
                 Quaternion.Euler(0f, 0f, 0f));
        }
    }
    public bool getGeneratEnd()
    {
        return generatEnd;
    }
}
