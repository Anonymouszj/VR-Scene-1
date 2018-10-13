using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zkong : AEntity {
    public Transform p;
    public override void Init()
    {
       
    }
    // Use this for initialization
    private void Awake()
    {
        p = this.transform;
    }
    void Start () {
        this.transform.position = p.position;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
