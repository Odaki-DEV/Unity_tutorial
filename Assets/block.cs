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

    //オブジェクトに他オブジェクトがぶつかった時
    private void OnCollisionEnter(Collision collision)
    {
        //このスクリプトが適用されているオブジェクトを消す
        Destroy(this.gameObject);
    }
}
