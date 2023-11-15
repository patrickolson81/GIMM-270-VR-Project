using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.XR;

public class ChangeVideo : MonoBehaviour
{
    public Material[] vidMat;
    
    private InputData _inputData;
    private int num = 0;
    private bool triggerPressed = false;

    void Start()
    {
        _inputData = GetComponent<InputData>();
        
    }

    private void FixedUpdate()
    {
        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool _triggerButtonPressed))
        {
            if (_triggerButtonPressed && !triggerPressed)
            {
                triggerPressed = true;
                Debug.Log(_triggerButtonPressed);

                if (num == 0)
                {
                    num = 1;
                    RenderSettings.skybox = vidMat[1];
                }
                else
                {
                    num = 0;
                    RenderSettings.skybox = vidMat[num];
                }
            }
            else if (!_triggerButtonPressed)
            {
                triggerPressed = false;
            }
        }
    }
}
