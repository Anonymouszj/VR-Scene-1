using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : AEntity {
    public override void Init()
    {
        throw new System.NotImplementedException();
    }
    public GameObject Image;
    public bool on;
    private void OnTriggerEnter(Collider other)

    {
        //if (on == false)
        print("ooooooooooooo");
        on = true;
        //if() on = false;
    }
    private Transform screen;
    private Transform Screen
    {
        get { return screen; }
        set { screen = value; }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PointSceen();
	}
    /// <summary>
    /// 点击电脑报警
    /// </summary>
    public void PointSceen()
    {
        
        if (on == true)
        {
            print("true");
            Image.SetActive(true);
        }

        else
        {
            print("false");
            Image.SetActive(false);
        }
            
    }
}
