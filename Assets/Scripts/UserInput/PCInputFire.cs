using System;
using UnityEngine;


public sealed class PCInputFire : IUserInputProxy
{
    public event Action<float> AxisOnChange = delegate (float f) { };

    public void GetAxis()
    {
        AxisOnChange.Invoke(Input.GetButtonDown(AxisManager.FIRE1) ? 1 : 0);
    }
}
