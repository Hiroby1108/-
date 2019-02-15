using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField, Header("ゴミリスト"), Tooltip("Assets/Prefab/Trash01～03 :を使用\n\"Rigidbody\"を適用したものを使用")]
    List<Rigidbody> trash = new List<Rigidbody>();

    [SerializeField, Header("生物リスト"), Tooltip("まだ使用物を決めていない\n\"Rigidbody\"を適用したものを使用")]
    List<Rigidbody> living = new List<Rigidbody>();

    [SerializeField, Header("ゴミ生成個数")]
    int numOfEventTrash = 10;
    public int NumOfEventTrash{ get { return numOfEventTrash; } }
    [SerializeField, Header("生物生成個数")]
    int numOfEventLiving = 10;
    public int NumOfEventLiving { get { return numOfEventLiving; } }

    [SerializeField, Header("イベントx座標")]
    int X = 10;
    public int x { get { return X; } }
    [SerializeField, Header("イベントy座標")]
    int Y = 10;
    public int y { get { return Y; } }
    [SerializeField, Header("イベントz座標")]
    int Z = 10;
    public int z { get { return Z; } }
    [SerializeField, Header("イベントx範囲")]
    int Xs = 10;
    public int xs { get { return Xs; } }
    [SerializeField, Header("イベントy範囲")]
    int Ys = 10;
    public int ys { get { return Ys; } }
    [SerializeField, Header("イベントz範囲")]
    int Zs = 10;
    public int zs { get { return Zs; } }


    public GameObject rute;

    bool a = false;
    void Start()
    {
        rute.gameObject.SetActive(false);
    }

    void Update()
    {
        if (!a)
            if (rute.gameObject.activeSelf == true)
        {
            gameObject.transform.position = new Vector3(x, y, z);
            gameObject.transform.localScale = new Vector3(xs, ys, Zs);
            Appearance(numOfEventTrash, trash);//ゴミ生成
            Appearance(numOfEventLiving, living);//生き物生成
            a = true;
        }
    }
    private void Appearance(int i_num, List<Rigidbody> list)
    {
        if (list.Count <= 0) return;//未設定時
        for (int LP = 0; LP < i_num; LP++)
        {
            int x = (int)Random.Range(0, list.Count);
            if (list[x] == null) continue;
            Instantiate(list[x],//
                    new Vector3(Random.Range(-X - Xs, X + Xs), Random.Range(-Y - Ys, Y + Ys), Random.Range(-Z - Zs, Z - Zs)),//ここの値を変えれば乱数でゴミ出ますが電池の都合上できなかったのでだれかお願いします
                     Quaternion.Euler(0f, 0f, 0f));
            Debug.Log("unko");
        }
    }
}
