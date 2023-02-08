using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTest : MonoBehaviour
{
    public GameObject testObj;
    Tween moveTween = null;
    Tween scaleTween = null;
    // Use this for initialization
    void Start()
    {
        //this.transform.DoMove(Vector3.zero,Vector3.one);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            //TweenManager.Instance.RemoveTween(moveTween);
            //moveTween.Clear();
            TweenManager.Instance.Clear();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (moveTween != null)
            {
                moveTween.TweenKill();
            }
            testObj.transform.localPosition = Vector3.zero;
            moveTween = testObj.transform.DoMove(new Vector3(300, 500, 0), 5);
            moveTween.ease = Ease.Linear;
            moveTween.OnComplete = () =>
            {
                Debug.Log("tween move complete");
            };
            moveTween.OnKill = () =>
            {
                Debug.Log("tween move kill");
            };
            moveTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (moveTween != null)
            {
                moveTween.TweenKill();
            }
            testObj.transform.localPosition = Vector3.zero;
            moveTween = testObj.transform.DoMove(new Vector3(300, 500, 0), 5);
            moveTween.ease = Ease.EaseInSine;
            moveTween.OnComplete = () =>
            {
                Debug.Log("tween move complete");
            };
            moveTween.OnKill = () =>
            {
                Debug.Log("tween move kill");
            };
            moveTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (moveTween != null)
            {
                moveTween.TweenKill();
            }
            testObj.transform.localPosition = Vector3.zero;
            moveTween = testObj.transform.DoMove(new Vector3(300, 500, 0), 5);
            moveTween.ease = Ease.EaseOutSine;
            moveTween.OnComplete = () =>
            {
                Debug.Log("tween move complete");
            };
            moveTween.OnKill = () =>
            {
                Debug.Log("tween move kill");
            };
            moveTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (moveTween != null)
            {
                moveTween.TweenKill();
            }
            testObj.transform.localPosition = Vector3.zero;
            moveTween = testObj.transform.DoMove(new Vector3(300, 500, 0), 5);
            moveTween.ease = Ease.EaseInOutSine;
            moveTween.OnComplete = () =>
            {
                Debug.Log("tween move complete");
            };
            moveTween.OnKill = () =>
            {
                Debug.Log("tween move kill");
            };
            moveTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            if (moveTween != null)
            {
                moveTween.TweenKill();
            }
            testObj.transform.localPosition = Vector3.zero;
            moveTween = testObj.transform.DoMove(new Vector3(300, 500, 0), 5);
            moveTween.ease = Ease.EaseInBack;
            moveTween.OnComplete = () =>
            {
                Debug.Log("tween move complete");
            };
            moveTween.OnKill = () =>
            {
                Debug.Log("tween move kill");
            };
            moveTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (moveTween != null)
            {
                moveTween.TweenKill();
            }
            testObj.transform.localPosition = Vector3.zero;
            moveTween = testObj.transform.DoMove(new Vector3(300, 500, 0), 5);
            moveTween.ease = Ease.EaseOutBack;
            moveTween.OnComplete = () =>
            {
                Debug.Log("tween move complete");
            };
            moveTween.OnKill = () =>
            {
                Debug.Log("tween move kill");
            };
            moveTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            if (moveTween != null)
            {
                moveTween.TweenKill();
            }
            testObj.transform.localPosition = Vector3.zero;
            moveTween = testObj.transform.DoMove(new Vector3(300, 500, 0), 5);
            moveTween.ease = Ease.EaseInOutBack;
            moveTween.OnComplete = () =>
            {
                Debug.Log("tween move complete");
            };
            moveTween.OnKill = () =>
            {
                Debug.Log("tween move kill");
            };
            moveTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (moveTween != null)
            {
                moveTween.TweenKill();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (scaleTween != null)
            {
                scaleTween.TweenKill();
            }
            testObj.transform.localScale = Vector3.one;
            scaleTween = testObj.transform.DoScale(new Vector3(2, 2, 2), 5);
            scaleTween.ease = Ease.Linear;
            scaleTween.OnComplete = () =>
            {
                Debug.Log("tween scale complete");
            };
            scaleTween.OnKill = () =>
            {
                Debug.Log("tween scale kill");
            };
            scaleTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (scaleTween != null)
            {
                scaleTween.TweenKill();
            }
            testObj.transform.localScale = Vector3.one;
            scaleTween = testObj.transform.DoScale(new Vector3(2, 2, 2), 5);
            scaleTween.ease = Ease.EaseInSine;
            scaleTween.OnComplete = () =>
            {
                Debug.Log("tween scale complete");
            };
            scaleTween.OnKill = () =>
            {
                Debug.Log("tween scale kill");
            };
            scaleTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (scaleTween != null)
            {
                scaleTween.TweenKill();
            }
            testObj.transform.localScale = Vector3.one;
            scaleTween = testObj.transform.DoScale(new Vector3(2, 2, 2), 5);
            scaleTween.ease = Ease.EaseOutSine;
            scaleTween.OnComplete = () =>
            {
                Debug.Log("tween scale complete");
            };
            scaleTween.OnKill = () =>
            {
                Debug.Log("tween scale kill");
            };
            scaleTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (scaleTween != null)
            {
                scaleTween.TweenKill();
            }
            testObj.transform.localScale = Vector3.one;
            scaleTween = testObj.transform.DoScale(new Vector3(2, 2, 2), 5);
            scaleTween.ease = Ease.EaseInOutSine;
            scaleTween.OnComplete = () =>
            {
                Debug.Log("tween scale complete");
            };
            scaleTween.OnKill = () =>
            {
                Debug.Log("tween scale kill");
            };
            scaleTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (scaleTween != null)
            {
                scaleTween.TweenKill();
            }
            testObj.transform.localScale = Vector3.one;
            scaleTween = testObj.transform.DoScale(new Vector3(2, 2, 2), 5);
            scaleTween.ease = Ease.EaseInBack;
            scaleTween.OnComplete = () =>
            {
                Debug.Log("tween scale complete");
            };
            scaleTween.OnKill = () =>
            {
                Debug.Log("tween scale kill");
            };
            scaleTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (scaleTween != null)
            {
                scaleTween.TweenKill();
            }
            testObj.transform.localScale = Vector3.one;
            scaleTween = testObj.transform.DoScale(new Vector3(2, 2, 2), 5);
            scaleTween.ease = Ease.EaseOutBack;
            scaleTween.OnComplete = () =>
            {
                Debug.Log("tween scale complete");
            };
            scaleTween.OnKill = () =>
            {
                Debug.Log("tween scale kill");
            };
            scaleTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            if (scaleTween != null)
            {
                scaleTween.TweenKill();
            }
            testObj.transform.localScale = Vector3.one;
            scaleTween = testObj.transform.DoScale(new Vector3(2, 2, 2), 5);
            scaleTween.ease = Ease.EaseInOutBack;
            scaleTween.OnComplete = () =>
            {
                Debug.Log("tween scale complete");
            };
            scaleTween.OnKill = () =>
            {
                Debug.Log("tween scale kill");
            };
            scaleTween.TweenStart();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (scaleTween != null)
            {
                scaleTween.TweenKill();
            }
        }
    }

    private void OnDestroy()
    {
        if (moveTween != null)
        {
            moveTween.Clear();
        }

        if(scaleTween != null)
        {
            scaleTween.Clear();
        }
    }

}
