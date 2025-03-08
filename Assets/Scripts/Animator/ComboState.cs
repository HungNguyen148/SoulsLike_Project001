using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboState : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("DoCombo", false);
        animator.SetBool("CanCombo", false);
    }
}
