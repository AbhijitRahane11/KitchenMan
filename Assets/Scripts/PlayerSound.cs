using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{

    private Player player;
    private float footStepTimer;
    private float footStepTimerMax = .1f;

    private void Awake()
    {
        player = GetComponent<Player>();
    }
    public void Update()
    {
        footStepTimer -= Time.deltaTime;
        if (footStepTimer < 0)
        {
            footStepTimer = footStepTimerMax;

            if (player.IsWalk())
            {
                float volume = 1f;
                SoundManager.Instance.PlayFootstepSound(player.transform.position, volume);
            }
        }
    }
}