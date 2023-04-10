using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAni : MonoBehaviour
{
    private Player player;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        OnMove();
        OnRun();
    }

    #region Movement
    private void OnMove()
    {
        if(player._direction.sqrMagnitude > 0)
        {
            if(player._isRolling)
            {
                anim.SetTrigger("isRoll");
            }
            else
            {
                anim.SetInteger("Transition", 1);
            }
            
        }
        else
        {
            anim.SetInteger("Transition", 0);
        }
        if (player._direction.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);

        }
        if (player._direction.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        
    }

    void OnRun()
    {
        if(player._isRunning)
        {
            anim.SetInteger("Transition", 2);
        }

    }
    #endregion
}

