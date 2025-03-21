using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveBurnWarningUI : MonoBehaviour
{
    [SerializeField] private StoveCounter stoveCounter;


    private void Start()
    {
        stoveCounter.OnPregressChanged += StoveCounter_OnPregressChanged;
        Hide();
    }

    private void StoveCounter_OnPregressChanged(object sender, IHasProgress.OnProgressChangedEventArgs e)
    {
        float burnShowProgeaaAmount = .5f;
        bool show= stoveCounter.IsFried() &&  e.progressNormalized >=burnShowProgeaaAmount;

        if ((show))
        {
            Show();
        }
        else 
        {
            Hide();
        }
    }


    private void Show()
    {
        gameObject.SetActive(true);
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
