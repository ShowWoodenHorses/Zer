using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatePanel : MonoBehaviour
{
    public GameObject Panel;
    private bool _isActive;

    private void Update()
    {
        if (_isActive)
            Panel.SetActive(true);
        else
            Panel.SetActive(false);
    }

    public void SetState()
    {
        _isActive = !_isActive;
    }
}
