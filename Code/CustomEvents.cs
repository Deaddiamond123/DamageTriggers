using System;
using System.Collections;
using System.Collections.Generic;
using BrokeProtocol.API;
using BrokeProtocol.API.Types;
using BrokeProtocol.Entities;
using BrokeProtocol.Managers;
using BrokeProtocol.Required;
using UnityEngine;

namespace uwu
{
    public class CustomEvents : IScript
    {
        public List<ShPlayer> PlayersInTheTriggerBox { get; set; } = new List<ShPlayer>();
        [CustomTarget]
        public void EnterHypothermia(ShPhysical physical, string triggerid) //The enter event, "Enter", can be modified. More info on Readme (Github).
        {
            if (physical is ShPlayer player)
            {
                PlayersInTheTriggerBox.Add(player);
            }
        }

        [CustomTarget]
        public void ExitHypothermia(ShPhysical physical, string triggerid) //The exit event, "Exit", can be modified. More info on Readme (Github). 
        {
            if (physical is ShPlayer player)
            {
                PlayersInTheTriggerBox.Remove(player);
            }
        }

        [Target(GameSourceEvent.ManagerStart, ExecutionMode.Override)]
        public void OnStart(SvManager svManager) 
        {
            svManager.StartCoroutine(Whatever());
        }
        public IEnumerator Whatever()
        {
            while (true)
            {
                foreach (var player in PlayersInTheTriggerBox)
                {
                    player.svPlayer.Damage(DamageIndex.Null, 10, null, null); //The parameter "10" can be modified, remember that the health of a player is 100
                }
                yield return new WaitForSeconds(2); //Can be modified, change the number inside of the parenthesis. 
            }
        }

    }
}