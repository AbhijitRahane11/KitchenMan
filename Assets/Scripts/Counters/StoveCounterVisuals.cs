using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveCounterVisuals : MonoBehaviour
{
    [SerializeField] private StoveCounter stoveCounter;
    [SerializeField] private GameObject StoveOnGameObject;
    [SerializeField] private GameObject ParticlesGameObject;

    private void Start()
    {
        stoveCounter.OnStateChanged += StoveCounter_OnStateChanged;
    }

    private void StoveCounter_OnStateChanged(object sender, StoveCounter.OnStateChangeEventArgs e)
    {

        bool showVisual = e.state == StoveCounter.State.Frying || e.state == StoveCounter.State.Fried;
        StoveOnGameObject.SetActive(showVisual);
        ParticlesGameObject.SetActive(showVisual);
    }
}
