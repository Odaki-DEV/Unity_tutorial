using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //���쑬�x
    public float speed = 1.0f;
    private Rigidbody myRigid;

    // Start is called before the first frame update
    void Start()
    {
        //�Q�[���J�n���ɉE��Ɉړ�

        //�I�u�W�F�N�g�̕��������擾
        myRigid = this.GetComponent<Rigidbody>();

        //�I�u�W�F�N�g�ɗ͂�������
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
