﻿using UnityEngine;
using System.Collections;

public class SpeedUpType : GameType
{
    TrailRenderer trail;
    protected override void UsePowerup(PlayerType player)
	{
        StartCoroutine(GottaGoFast(player));
		//Sound sound = new Sound(transform.root.gameObject.audio, "Sounds/speed sfx");
        player.uninfectedSpeed = 15;
        
    }

    IEnumerator GottaGoFast(PlayerType player)
    {
        trail = player.GetComponent<TrailRenderer>();
        trail.enabled = true;
        yield return new WaitForSeconds(player.duration);
        trail.enabled = false;
    }
}
