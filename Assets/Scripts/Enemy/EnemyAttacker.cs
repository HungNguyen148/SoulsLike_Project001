using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacker : MonoBehaviour
{
    private AnimatorHandler animatorHandler;
    public Transform model;
    private Animator animator;

    private int lastAttack;

    private void Awake()
    {
        animatorHandler = GetComponentInChildren<AnimatorHandler>();
        animator = model.GetComponent<Animator>();
    }

    public void Attack(int comboNum)
    {
        if (animatorHandler.GetIsInteracting())
        {
            return;
        }

        int rand = 0;
        do
        {
            if (!animator.GetBool("Phase2"))
                rand = Random.Range(0, 5);
            // Save space for phase 2

        } while (rand == lastAttack);
        lastAttack = rand;

        switch (rand)
        {
            case 0:
                animatorHandler.PlayAnimation("Attack01", true);
                break;
            case 1:
                animatorHandler.PlayAnimation("Attack02", true);
                break;
            case 2:
                animatorHandler.PlayAnimation("JumpingAttack", true);
                break;
            case 3:
                animatorHandler.PlayAnimation("SkyAttack01", true);
                break;
            case 4:
                animatorHandler.PlayAnimation("SkyAttack02", true);
                break;
            default:
                break;
                
        }       
    }
}
