using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger :  MonoBehaviour {
   
    

    private void Awake()
    {
        
        /*zkong kong = new zkong();
        kong.SetManager(k);
        Transform t = GameObject.Find("Scene").GetComponent<Transform>();
        k.Creat(t);*/

    }
    // Use this for initialization
    void Start () {
        EntityManager k = new EntityManager(Resources.Load<AEntity>("kongtiao1"));//管理器实例化
        Transform t = GameObject.Find("Scene").GetComponent<Transform>();//父节点
        k.Creat(t);

        EntityManager a = new EntityManager(Resources.Load<AEntity>("rongjiejihe1"));//管理器实例化
        Transform b = GameObject.Find("Scene").GetComponent<Transform>();//父节点
        a.Creat(b);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
