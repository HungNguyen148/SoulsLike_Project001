﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacker : MonoBehaviour
{
    private PlayerControls playerControls;
    private AnimatorHandler animatorHandler;

    private void Awake()
    {
        playerControls = GetComponent<PlayerControls>();
        animatorHandler = GetComponentInChildren<AnimatorHandler>();
    }

    public void HandleAttack()
    {
        if (playerControls.comboFlag)
        {
            animatorHandler.SetBool("DoCombo", true);
        }

        if (animatorHandler.GetIsInteracting() || animatorHandler.GetIsFalling())
        {
            return;
        }

        if (playerControls.attackFlag01)
        {
            animatorHandler.SetState(AnimatorHandler.IDLE);
            animatorHandler.PlayAnimation("Attack_01", true);
        }

        if (playerControls.attackFlag02)
        {
            animatorHandler.SetState(AnimatorHandler.IDLE);
            animatorHandler.PlayAnimation("DashAttack", true);
        }
    }
}
