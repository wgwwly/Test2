using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TweenUtil {

    public static Tween DoMove(this Transform target, Vector3 endValue, float duration)
    {
        Tween tween = new Tween();
        tween.DoMove(target,endValue, duration);
        return tween;
    }

    public static Tween DoScale(this Transform target, Vector3 endValue, float duration)
    {
        Tween tween = new Tween();
        tween.DoScale(target, endValue, duration);
        return tween;
    }
}
