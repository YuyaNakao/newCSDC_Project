using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
    public float speed;
    Rigidbody rid;
    public GameObject obj;
    ScoreManager manager;
    public int playerNo;
    int count;
    bool enemyflag;

    // Use this for initialization
    void Start () {
        rid = GetComponent<Rigidbody>();
        rid.AddForce((transform.forward) * speed, ForceMode.VelocityChange);
        manager = GameObject.Find("Score").GetComponent<ScoreManager>();
        count = 0;
        Destroy(obj, 5);
    }
	
	// Update is called once per frame
	void Update () {
        if (enemyflag)
        {
            enemyflag = false;
        }
    }

    private void OnTriggerEnter(Collider hit)
    {

       if (hit.CompareTag("izimekko"))
        {
            count++;
        }
    }

    private void OnDestroy()
    {
        enemyflag = true;
    }


}
