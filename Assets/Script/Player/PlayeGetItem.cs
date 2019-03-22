using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeGetItem : MonoBehaviour
{
    private static Dictionary<string, int> LivingList = new Dictionary<string, int>(){};//Livingタグのオブジェクト名と個数を取得,保存
    public static Dictionary<string, int> getLivingList() { return LivingList; }
    private static Dictionary<string, int> TrashList = new Dictionary<string, int>() {{ "tabako(Clone)", 0}, { "Petbotol(Clone)", 0 }, { "Gyomou(Clone)", 0 },
                                                                                      { "Taiya(Clone)", 0},{ "Terebi(Clone)", 0},{ "Uki(Clone)", 0},{ "Biniru(Clone)", 0},
                                                                                      { "Gyomou(masuugu)(Clone)", 0 }};
    public static Dictionary<string, int> getTrashList() { return TrashList; }

    /*
     * foreach (KeyValuePair<string, int> 変数 in PlayeGetItem.指定処置){処理を書く}
     * で読み込むことが出来る(指定処理は"getTrashList()"と"getLivingList()")
     * Dictionary<TKey,TValue>「* https://docs.microsoft.com/ja-jp/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.7.2」
     * KeyValuePair<TKey,TValue>「* https://docs.microsoft.com/ja-jp/dotnet/api/system.collections.generic.keyvaluepair-2?view=netframework-4.7.2」
     * 
     */

    // Start is called before the first frame update
    void Start()
    {
        getTrashList()[ "Petbotol(Clone)"]=0;
        getTrashList()["tabako(Clone)"]=0;
        getTrashList()["Gyomou(Clone)"]=0;
        getTrashList()["Biniru(Clone)"]=0;
        getTrashList()["Terebi(Clone)"]=0;
        getTrashList()["Taiya(Clone)"]=0;
        getTrashList()["Gyomou(masuugu)(Clone)"] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (KeyValuePair<string, int> DictKvp in TrashList)
            {
                Debug.Log(DictKvp);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        getObject(other,"Trash",TrashList);
        getObject(other, "Living", LivingList);
    }

    private void getObject(Collision other,string objtag, Dictionary<string, int> Dict_s_i)
    {
        if (other.gameObject.tag == objtag)
        {
            bool notFindDic = true;
            foreach (KeyValuePair<string, int> DictKvp in Dict_s_i)
            {
                if (other.gameObject.name == DictKvp.Key)
                {
                    Dict_s_i[other.gameObject.name]++;
                    notFindDic = false;
                    break;
                }
            }
            if (notFindDic) Dict_s_i.Add(other.gameObject.name, 1);
            Destroy(other.gameObject);
        }
    }
}
 
 
 
 
 
 
 
 
 
 