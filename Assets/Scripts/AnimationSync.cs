using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSync : MonoBehaviour
{

    [SerializeField]
    //Get a refrence to the main network object script
    private NetworkPlayer np;

    [SerializeField]
    private Animator animator;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //if we are the owner
        if (np.networkObject.IsOwner)
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            //set the "IsMoving" variable on the world & view model


                if (Input.GetButton("Fire2"))
                    np.networkObject.Attacking = true;
                else
                    np.networkObject.Attacking = false;
                if (Input.GetButton("Fire1"))
                    np.networkObject.Jumping = true;
                else
                    np.networkObject.Jumping = false;

                if (Input.GetButton("Sprint"))
                    np.networkObject.Sprinting = true;
                else
                    np.networkObject.Sprinting = false;
                np.networkObject.Forward = vertical;
                np.networkObject.Strafing = horizontal;
            animator.SetFloat("Forward", np.networkObject.Forward);
            animator.SetFloat("Strafing", np.networkObject.Strafing);
            animator.SetBool("Attack", np.networkObject.Attacking);
            animator.SetBool("Jumping", np.networkObject.Jumping);
            animator.SetBool("Sprinting", np.networkObject.Sprinting);

        }
        else //if we aren't the owner
        {
                //Use the values set by the owner
                animator.SetFloat("Forward", np.networkObject.Forward);
                animator.SetFloat("Strafing", np.networkObject.Strafing);
                animator.SetBool("Attack", np.networkObject.Attacking);
                animator.SetBool("Jumping", np.networkObject.Jumping);
                animator.SetBool("Sprinting", np.networkObject.Sprinting);

        }
    }
}
