using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVariableOnExit : StateMachineBehaviour

{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PlayerMovement player = GameObject.FindObjectOfType<PlayerMovement>();
        player.canMoveMultiplier = 0;
    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("isTouching", false);
        animator.SetBool("polkaCanMove", true);

        PlayerMovement player = GameObject.FindObjectOfType<PlayerMovement>();
        player.canMoveMultiplier = 1;
        Destroy(animator.gameObject);
        
    }
}