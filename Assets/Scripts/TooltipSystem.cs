using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
    [SerializeField] private Tooltip tooltip;
    private static TooltipSystem _current;

    void Awake()
    {
        _current = this;
    }

    public static void Show(string contentText, string headerText = "")
    {
        _current.tooltip.SetText(contentText, headerText);
        _current.tooltip.gameObject.SetActive(true);
    }
    
    public static void Hide()
    {
        _current.tooltip.gameObject.SetActive(false);
    }
}
