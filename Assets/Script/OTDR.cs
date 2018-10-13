using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class OTDR : AEntity {
    public override void Init()
    {
        throw new System.NotImplementedException();
    }
    private Port port;

    public Port Port
    {
        get
        {
            return port;
        }

        set
        {
            port = value;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public void Test()
    {

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
