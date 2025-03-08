using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stats : MonoBehaviour
{
    public abstract void TakeDamage(int amount, string hitAnimation, bool isBack);
}
