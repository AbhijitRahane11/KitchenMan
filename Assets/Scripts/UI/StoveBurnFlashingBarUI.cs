using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveBurnFlashingBarUI : MonoBehaviour
{

    private const string IS_FLASHING = "IsFlashing";

    [SerializeField] private StoveCounter stoveCounter;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        stoveCounter.OnPregressChanged += StoveCounter_OnPregressChanged;
        animator.SetBool(IS_FLASHING, false );
    }

    private void StoveCounter_OnPregressChanged(object sender, IHasProgress.OnProgressChangedEventArgs e)
    {
        float burnShowProgeaaAmount = .5f;
        bool show = stoveCounter.IsFried() && e.progressNormalized >= burnShowProgeaaAmount;

        
        animator.SetBool(IS_FLASHING, show);    
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
