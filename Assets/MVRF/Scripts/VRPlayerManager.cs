using HTC.UnityPlugin.Vive;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRPlayerManager : MonoBehaviour
{

    public bool dontDestroyOnLoad = false;

    public GameObject vivePointers;
    public GameObject Teleporting;
    [SerializeField]
    private SteamVR_Behaviour steamVR_Behaviour;


    private void Awake()
    {
        ViveInput.AddPressDown(HandRole.RightHand, ControllerButton.Pad, OnPadPressDown);
        ViveInput.AddPressUp(HandRole.RightHand, ControllerButton.Pad, OnPadPressUp);
        steamVR_Behaviour.doNotDestroy = dontDestroyOnLoad;
    }

    private void OnPadPressDown()
    {
        vivePointers.SetActive(false);
    }

    private void OnPadPressUp()
    {
        vivePointers.SetActive(true);
    }
}
