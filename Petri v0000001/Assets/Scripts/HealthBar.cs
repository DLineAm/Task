using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;

    private Player targetPlayer;

    private void Awake()
    {
        targetPlayer = transform.root.GetComponent<Player>();

        targetPlayer.OnHealthChange.AddListener(() =>
        {
            slider.value = targetPlayer.CurrentHealth;
        });

        targetPlayer.OnMaxHealthChange.AddListener(() =>
        {
            slider.maxValue = targetPlayer.MaxHealth;
        });

    }

    private void Start()
    {
        
    }

}
