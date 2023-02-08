using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void TweenCallback();

public enum TweenState
{
    Move,
    Scale
}

public enum Ease
{
    Linear,
    EaseInSine,
    EaseOutSine,
    EaseInOutSine,
    EaseInBack,
    EaseOutBack,
    EaseInOutBack
}
public abstract class TweenBase
{
    public Transform cacheTran;
    public float duration;
    public float curTime;
    public TweenState tweenState;
    public Ease ease = Ease.Linear;
    public Vector3 fromValue;
    public Vector3 endValue;
    public Vector3 curToValue;

    public float xMoveValue;
    public float yMoveValue;
    public float zMoveValue;
    /// <summary>
    /// 设想按自定义曲线移动
    /// </summary>
    public AnimationCurve curve;

    public TweenCallback OnComplete;
    public TweenCallback OnKill;

    public bool isStart;
    public bool isEnd;

    public abstract void TweenStart();
    public abstract void TweenUpdate();

    public abstract void TweenKill();

    #region Ease
    public float GetTime()
    {
        return curTime > duration ? duration : curTime;
    }

    public float Liner(float t, float baseValue, float fromValue)
    {
        //float t = GetTime();
        //curToValue = new Vector3(fromValue.x + t * xBaseValue, fromValue.y + t * yBaseValue, fromValue.z + t * zBaseValue);
        //return GetTime();

        return baseValue * t / duration + fromValue;
    }

    public void Liner()
    {
        float t = GetTime();
        //curToValue = new Vector3(fromValue.x + t * xBaseValue, fromValue.y + t * yBaseValue, fromValue.z + t * zBaseValue);
        curToValue = new Vector3(Liner(t, xMoveValue, fromValue.x), Liner(t, yMoveValue, fromValue.y), Liner(t, zMoveValue, fromValue.z));
    }

    float EaseInSine(float t, float baseValue, float fromValue)
    {
        //float t = GetTime();
        return -baseValue * Mathf.Cos(t / duration * (Mathf.PI / 2)) + baseValue + fromValue;
    }
    public void EaseInSine()
    {
        float t = GetTime();

        curToValue = new Vector3(EaseInSine(t, xMoveValue, fromValue.x), EaseInSine(t, yMoveValue, fromValue.y), EaseInSine(t, zMoveValue, fromValue.z));
    }

    float EaseOutSine(float t, float baseValue, float fromValue)
    {

        return baseValue * Mathf.Sin(t / duration * (Mathf.PI / 2)) + fromValue;
    }

    public void EaseOutSine()
    {
        float t = GetTime();
        curToValue = new Vector3(EaseOutSine(t, xMoveValue, fromValue.x), EaseOutSine(t, yMoveValue, fromValue.y), EaseOutSine(t, zMoveValue, fromValue.z));
    }


    float EaseInOutSine(float t, float baseValue, float fromValue)
    {
        return -baseValue / 2 * (Mathf.Cos(Mathf.PI * t / duration) - 1) + fromValue;
    }

    public void EaseInOutSine()
    {
        float t = GetTime();
        curToValue = new Vector3(EaseInOutSine(t, xMoveValue, fromValue.x), EaseInOutSine(t, yMoveValue, fromValue.y), EaseInOutSine(t, zMoveValue, fromValue.z));
    }

    float EaseInBack(float t, float baseValue, float fromValue, float s = 0)
    {
        if (s == 0)
        {
            s = 1.70158f;
        }
        t = t / duration;
        return baseValue * t * t * ((s + 1) * t - s) + fromValue;
    }

    public void EaseInBack()
    {
        float t = GetTime();
        curToValue = new Vector3(EaseInBack(t, xMoveValue, fromValue.x), EaseInBack(t, yMoveValue, fromValue.y), EaseInBack(t, zMoveValue, fromValue.z));
    }

    float EaseOutBack(float t, float baseValue, float fromValue, float s = 0)
    {
        if (s == 0)
        {
            s = 1.70158f;
        }
        t = t / duration - 1;
        return baseValue * (t * t * ((s + 1) * t + s) + 1) + fromValue;
    }

    public void EaseOutBack()
    {
        float t = GetTime();
        curToValue = new Vector3(EaseOutBack(t, xMoveValue, fromValue.x), EaseOutBack(t, yMoveValue, fromValue.y), EaseOutBack(t, zMoveValue, fromValue.z));
    }

    float EaseInOutBack(float t, float baseValue, float fromValue, float s = 0)
    {
        if (s == 0)
        {
            s = 1.70158f;
        }
        t = t / (duration / 2);
        if (t < 1)
        {
            return baseValue / 2 * (t * t * (((s *= 1.525f) + 1) * t - s)) + fromValue;
        }
        t -= 2;
        return baseValue / 2 * (t * t * (((s *= 1.525f) + 1) * t + s) + 2) + fromValue;
    }

    public void EaseInOutBack()
    {
        float t = GetTime();
        curToValue = new Vector3(EaseInOutBack(t, xMoveValue, fromValue.x), EaseInOutBack(t, yMoveValue, fromValue.y), EaseInOutBack(t, zMoveValue, fromValue.z));
    }

    public float GetEaseTime()
    {
        float easeTime = 0;
        //switch(ease)
        //{
        //    case Ease.Linear:
        //        easeTime = Liner(0,0);
        //        break;
        //    default:
        //        easeTime = Liner(0,0);
        //        break;
        //}
        return easeTime;
    }

    public void DoEase()
    {
        switch (ease)
        {
            case Ease.Linear:
                Liner();
                break;
            case Ease.EaseInSine:
                EaseInSine();
                break;
            case Ease.EaseOutSine:
                EaseOutSine();
                break;
            case Ease.EaseInOutSine:
                EaseInOutSine();
                break;
            case Ease.EaseInBack:
                EaseInBack();
                break;
            case Ease.EaseOutBack:
                EaseOutBack();
                break;
            case Ease.EaseInOutBack:
                EaseInOutBack();
                break;
            default:
                Liner();
                break;
        }
    }
    #endregion

    public void UpdateTweenValue()
    {
        switch (tweenState)
        {
            case TweenState.Move:
                cacheTran.localPosition = curToValue;
                break;
            case TweenState.Scale:
                cacheTran.localScale = curToValue;
                break;
        }
    }

    public bool IsTweenEnd()
    {
        if(!isStart && isEnd)
        {
            return true;
        }
        return false;
    }

    public void Clear(bool isRemove = true)
    {
        cacheTran = null;
        OnComplete = null;
        OnKill = null;
        curve = null;
        isStart = false;
        isEnd = false;
        if(isRemove)
        {
            TweenManager.Instance.RemoveTween(this);
        }
        
    }
}
