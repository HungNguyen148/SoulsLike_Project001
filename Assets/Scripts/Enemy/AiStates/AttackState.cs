using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : BaseState
{
    private AnimatorHandler animatorHandler;
    private EnemyAttacker enemyAttacker;
    private PlayerDetector playerDetector;
    private EnemyMotion enemyMotion;

    private bool isAnimationPlayed = false;

    public AttackState(AnimatorHandler animatorHandler, EnemyAttacker enemyAttacker, PlayerDetector playerDetector, EnemyMotion enemyMotion)
    {
        this.animatorHandler = animatorHandler;
        this.enemyAttacker = enemyAttacker;
        this.playerDetector = playerDetector;
        this.enemyMotion = enemyMotion;
    }

    public override System.Type Tick()
    {
        if (animatorHandler.GetIsInteracting())
        {
            return null;
        }

        if (!isAnimationPlayed)
        {
            int comboNum = Random.Range(0, 3);
            enemyAttacker.Attack(comboNum);
            isAnimationPlayed = true;
        }
        else
        {
            isAnimationPlayed = false;

            //int nextDecision = Random.Range(0, 11);

            return typeof(ApproachState);

            //if (nextDecision <= 3)
            //{
            //    return typeof(RetreatState);
            //}
            //else if (nextDecision <= 6)
            //{
            //    return typeof(DodgeState);
            //}
            //else
            //{
            //    return typeof(IdleState);
            //}
        }

        return null;
    }
}
