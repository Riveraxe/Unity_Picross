using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayToAction : MonoBehaviour
{
    public static IEnumerable DelayToInvokeDo(Action action, float delaySeconds)
    {
        yield return new WaitForSeconds(delaySeconds);
        action();
    }
}
