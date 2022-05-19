using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CombatActionButton : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    private CombatAction combatAction;
    private CombatActionsUI ui;

    private void Awake()
    {
        ui = FindObjectOfType<CombatActionsUI>();
    }
}
