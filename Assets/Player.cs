using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public�ɂ����Unity���GUI�Ńp�����[�^��ύX�ł���
    public float speed = 1.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //���L�[����������
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > -4)
            {
                this.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        //���L�[����������
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < 4)
            {
                    this.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}
