using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTobubble : MonoBehaviour {

    float speed = 0.1f;
    float timer = 0;
    GameObject obj;
	// Use this for initialization
	void Start () {
        obj = GameObject.FindGameObjectWithTag("tree");
	}


    void Update()
    {
        if (obj != null)
        {
            float step = speed * Time.deltaTime;
      
            this.gameObject.SetActive(true);
            this.gameObject.transform.localPosition = new Vector3(Mathf.Lerp(this.gameObject.transform.localPosition.x, obj.transform.localPosition.x, step), Mathf.Lerp(this.gameObject.transform.localPosition.y, obj.transform.localPosition.y, step), Mathf.Lerp(this.gameObject.transform.localPosition.z, obj.transform.localPosition.z, step));//插值算法也可以
 
        }
    }


}
