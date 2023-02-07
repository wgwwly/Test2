using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween: TweenBase
{

    public void DoMove(Transform target, Vector3 endValue, float duration)
    {
        cacheTran = target;
        base.fromValue = target.localPosition;
        base.endValue = endValue;
        base.curToValue = base.fromValue;
        base.duration = duration;
        //base.xBaseValue = (endValue.x - base.fromValue.x) / duration;
        //base.yBaseValue = (endValue.y - base.fromValue.y) / duration;
        //base.zBaseValue = (endValue.z - base.fromValue.z) / duration;

        base.xBaseValue = endValue.x;
        base.yBaseValue = endValue.y;
        base.zBaseValue = endValue.z;
        base.tweenState = TweenState.Move;
    }

    public void DoScale(Transform target, Vector3 endValue, float duration)
    {
        cacheTran = target;
        base.fromValue = target.localScale;
        base.endValue = endValue;
        base.curToValue = base.fromValue;
        base.duration = duration;
        //base.xBaseValue = (endValue.x - base.fromValue.x) / duration;
        //base.yBaseValue = (endValue.y - base.fromValue.y) / duration;
        //base.zBaseValue = (endValue.z - base.fromValue.z) / duration;

        base.xBaseValue = endValue.x;
        base.yBaseValue = endValue.y;
        base.zBaseValue = endValue.z;
        base.tweenState = TweenState.Scale;
    }

    public override void TweenStart()
    {
        base.isStart = true;
        base.isEnd = false;
        base.curTime = 0;
        TweenManager.Instance.AddTween(this);
    }

    public override void TweenUpdate()
    {
        if (isStart)
        {
            //float mTime = Liner();
            //float mTime = GetEaseTime();
            DoEase();
            if (base.curTime >= base.duration)
            {
                isStart = false;
                isEnd = true;
                if(OnComplete != null)
                {
                    OnComplete();
                }
                TweenManager.Instance.RemoveTween(this);
            }
            else
            {
                base.curTime += Time.deltaTime;
            }
            //curToValue = new Vector3(fromValue.x + mTime * xBaseValue, fromValue.y + mTime * yBaseValue, fromValue.z + mTime * zBaseValue);

            UpdateTweenValue();
            //cacheTran.localPosition = curToValue;
        }
    }

    //public void UpdateTweenValue()
    //{
    //    switch (tweenState)
    //    {
    //        case TweenState.Move:
    //            cacheTran.localPosition = curToValue;
    //            break;
    //        case TweenState.Scale:
    //            cacheTran.localScale = curToValue;
    //            break;
    //    }
    //}

    public override void TweenKill()
    {
        //结束后禁止直行onkill
        if (OnKill != null && !isEnd)
        {
            OnKill();
        }
        TweenManager.Instance.KillTween(this);
    }
}
