using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApproachState : BaseState
{
    private EnemyMotion enemyMotion;
    private PlayerDetector playerDetector;

    private float nextUpdateTime = 0;
    private Vector3 walkDirection;

    public ApproachState(EnemyMotion enemyMotion, PlayerDetector playerDetector)
    {
        this.enemyMotion = enemyMotion;
        this.playerDetector = playerDetector;
    }

    public override System.Type Tick()
    {
        if (Time.time > nextUpdateTime)
        {
            walkDirection = GetNewDirection();
            nextUpdateTime = GetNextUpdateTime();
        }
        else if (playerDetector.GetDistanceToPlayer() < 3.5f)
        {
            int nextDecision = Random.Range(0, 15);

            //if (nextDecision <= 1)
            //{
            //    return typeof(DodgeState);
            //}
            //if (nextDecision <= 3)
            //{
            //    return typeof(TauntState);
            //}
            if (nextDecision <= 0)
            {
                return typeof(IdleState);
            }
            else
            {
                return typeof(AttackState);
            }
        }
        else
        {
            Vector3 targetDirection = playerDetector.GetDirectionToPlayer();
            targetDirection.y = 0;
            enemyMotion.Walk(targetDirection);
            //enemyMotion.LockingWalk(walkDirection, playerDetector.player.position);
        }

        return null;
    }

    public Vector3 GetNewDirection()
    {
        return enemyMotion.myTransform.forward + enemyMotion.myTransform.right * Random.Range(-1f, 1f);
    }

    public float GetNextUpdateTime()
    {
        return Time.time + Random.Range(2f, 4f);
    }
}
