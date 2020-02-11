using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPCFlip : IFlip
{
    public bool FlipSprite()
    {
        get => dir.x > 0 ? false : true;
    }
}
