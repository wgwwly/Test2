using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenManager : MonoBehaviour {

    public static TweenManager Instance = null;

    void Awake()
    {
        Instance = this;
    }
    public List<TweenBase> tweenList = new List<TweenBase>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0;i<tweenList.Count;i++)
        {
            tweenList[i].TweenUpdate();
        }
	}

    public void AddTween(TweenBase tween)
    {
        if(!tweenList.Contains(tween))
        {
            tweenList.Add(tween);
        }
    }

    public void RemoveTween(TweenBase tween)
    {
        tweenList.Remove(tween);
    }

    public void KillTween(TweenBase tween)
    {
        RemoveTween(tween);
    }
}
