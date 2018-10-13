using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 机柜类
/// </summary>
public class Cabinet : AEntity {
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
        set {
            port = value;
        }
    }

    /// <summary>
    /// 缺少开关函数
    /// </summary>

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
