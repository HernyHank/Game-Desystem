using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVariableOnExit : StateMachineBehaviour

{
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("isTouching", false);
        animator.SetBool("polkaCanMove", true);
        IdolOfSholka idol = GameObject.FindObjectOfType<IdolOfSholka>();
        Destroy(idol.gameObject);

        // Or toggle it:
        // bool current = animator.GetBool("isTouching");
        // animator.SetBool("isTouching", !current);
    }
}