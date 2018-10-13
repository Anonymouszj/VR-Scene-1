using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : AEntity {
    public override void Init()
    {
        throw new System.NotImplementedException();
    }

    private NextScene nextScene;
    public NextScene NextScene
    {
        get
        {
            return nextScene;
        }
        set
        {
            nextScene = value;
        }
    }


    public void ChangeScene()
    {

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
