using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField, Header("ゴミリスト"), Tooltip("Assets/Prefab/Trash01～03 :を使用\n\"Rigidbody\"を適用したものを使用")]
    List<Rigidbody> trashRig = new List<Rigidbody>();

    [SerializeField, Header("生物リスト"), Tooltip("まだ使用物を決めていない\n\"Rigidbody\"を適用したものを使用")]
    List<Rigidbody> livingRig = new List<Rigidbody>();

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
        Invoke("call", 4.0f);
    }
    void call()
    {

        gameObject.transform.position = new Vector3(x, y, z);
        gameObject.transform.localScale = new Vector3(xs, ys, Zs);

    }
}
