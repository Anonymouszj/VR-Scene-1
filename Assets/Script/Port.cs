using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 机器接口类
/// </summary>
public class Port : AEntity {
    public override void Init()
    {
        throw new System.NotImplementedException();
    }
    private Optical_Fiber optical;

    public Optical_Fiber Optical
    {
        get
        {
            return optical;
        }

        set
        {
            optical = value;
        }
    }
    /// <summary>
    /// 接口和光纤的连接
    /// </summary>
    public void Connect()
    {
        
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
