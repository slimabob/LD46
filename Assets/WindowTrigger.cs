﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowTrigger : MonoBehaviour
{
    private QuestManager questManager;
    public Vector3Reference DirectionMarkerDestination;

    private void Awake()
    {
        questManager = GetComponentInParent<QuestManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponentInParent<PizzaBox>())
        {
            Debug.Log("Pizza entered window trigger!");
            if(questManager.CurrentMission.IsInDeliveryZone)
            {
                questManager.CurrentMission.CompleteQuest();
                Debug.Log("Delivered the pizza!");
                questManager.SpawnMarkerAtVec3(questManager.CurrentMission.ReturnLocation);
                DirectionMarkerDestination.Value = questManager.CurrentMission.ReturnLocation;
            }
        }
    }
}