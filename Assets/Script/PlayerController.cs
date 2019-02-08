using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public enum STEP
    {   // 状況STEP.
        NONE = -1,
        SET,
        PLAY,
        BACK,
    }
    
    private STEP step;          // 今のSTEP.
    private STEP next_step;     // 次のSTEP.
    private float step_timer;   // 経過時間.
    private float break_timer;   // 特定経過時間.
    

    private Rigidbody playerRig;

    private Vector3 Defrot;
    private Vector3 Atrot;

    [SerializeField, Header("デフォルト速度"), Tooltip("Playerが進む速度")]
    private float speed;
    [SerializeField, Header("デフォルト角速度"), Tooltip("Playerが回る回転率")]
    private float speedRot;
    [SerializeField,Header("ペナルティタイム(秒)"), Tooltip("コースアウト時の操作不能時間")]
    private float penaltyTime;

    void Start()
    {
        next_step = STEP.SET;    // 最初はSETから.
        playerRig = this.GetComponent<Rigidbody>();
        this.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        OutCompass();
    }

    void Update()
    {
        step_timer += Time.deltaTime;    // 経過時間を取得.

        // （１）ステップ変化時のみ.
        if (next_step != STEP.NONE)
        {
            step = next_step;       // 現状に反映.
            next_step = STEP.NONE;  // 変化待ち.
            step_timer = 0.0f;      // 経過時間リセット.

            switch (step)
            {
                case STEP.SET:
                    next_step = STEP.PLAY;  // 次はPLAYステップに.
                    break;
            }
        }

        // （２）繰り返し実行.
        switch (step)
        {
            case STEP.PLAY://Player操作
                Vector3 pos = transform.position;
                Vector3 rot = transform.eulerAngles;
                pos += transform.forward * Time.deltaTime * speed;
                rot.y += Input.GetAxis("Horizontal") * Time.deltaTime * speedRot;
                rot.x -= Input.GetAxis("Vertical") * Time.deltaTime * speedRot;
                if (rot.x > 180f) rot.x -= 360f;
                if (-180f < rot.x && rot.x < -89f)  rot.x = -89f;
                else if (180f > rot.x && rot.x > 89f) rot.x = 89f;
                
                this.transform.position = pos;
                this.transform.eulerAngles = rot;
                break;

            case STEP.BACK://場外からの復帰処理
                pos = transform.position;
                rot = transform.eulerAngles;
                float breaker = step_timer - break_timer;
                pos += transform.forward * Time.deltaTime *speed;

                if (breaker < penaltyTime/5f)
                {
                    Defrot = transform.eulerAngles;
                    Atrot = CallCompass();
                }
                else if (penaltyTime/5f < breaker&& breaker< penaltyTime /5f * 4f)
                 {
                    rot.x = Mathf.LerpAngle(Defrot.x, Atrot.x, (breaker - penaltyTime / 5f) / (penaltyTime / 5f * 3f));
                    rot.y = Mathf.LerpAngle(Defrot.y, Atrot.y, (breaker - penaltyTime / 5f) / (penaltyTime / 5f * 3f));
                }else if (penaltyTime<breaker)//念のための復帰処理をリロード
                {
                    break_timer = step_timer;
                }
                Debug.Log(breaker+":" +break_timer);
                this.transform.position = pos;
                this.transform.eulerAngles = rot;
                break;
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Trash")
        {
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Area")
        {
            if (other.gameObject.name == "SafetyArea")
            {
                break_timer = step_timer;
                step = STEP.PLAY;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Area")
        {
            if (other.gameObject.name == "PlayArea")
            {
                break_timer = step_timer;
                step = STEP.BACK;
            }
        }
    }

    private void OutCompass()
    {
        GameObject Compass= GameObject.CreatePrimitive(PrimitiveType.Cube);
        Compass.GetComponent < BoxCollider >().enabled = false;
        Compass.GetComponent<MeshRenderer>().enabled = false;
        Compass.name = "Compass";
    }
    
    private Vector3 CallCompass()
    {
        GameObject Compass = GameObject.Find("Compass");
        Compass.transform.LookAt(this.gameObject.transform);
        float X = Compass.transform.eulerAngles.x;
        float Y = Compass.transform.eulerAngles.y;
        
        if (X > 180f) X -= 360f;
        if (Y > 180f) Y -= 360f;
        if (Y > 0) Y -= 180f;
        else Y += 180;
        return new Vector3(-X, Y, 0);
    }
    
}
