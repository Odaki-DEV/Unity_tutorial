using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //動作速度
    public float speed = 1.0f;
    private Rigidbody myRigid;

    // Start is called before the first frame update
    void Start()
    {
        //ゲーム開始時に右上に移動

        //オブジェクトの物理情報を取得
        myRigid = this.GetComponent<Rigidbody>();

        //オブジェクトに力を加える
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
