using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�I�u�W�F�N�g�ɑ��I�u�W�F�N�g���Ԃ�������
    private void OnCollisionEnter(Collision collision)
    {
        //���̃X�N���v�g���K�p����Ă���I�u�W�F�N�g������
        Destroy(this.gameObject);
    }
}
