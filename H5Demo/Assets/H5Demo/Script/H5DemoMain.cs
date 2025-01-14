using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class H5DemoMain : MonoBehaviour
{
    public GameObject _cube;
    public float _rotateSpeed = 60;
    private int _rotateDirection = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        _rotateDirection = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (_cube == null) return;
        
        _cube.transform.Rotate(Vector3.up, _rotateDirection*_rotateSpeed * Time.deltaTime);
        
    }

    private void OnGUI()
    {
        string label = $"Set Rotation: {_rotateDirection}";
        if (GUILayout.Button(label, GUILayout.Width(300), GUILayout.Height(240)))
        {
            _rotateDirection *= -1;
        }
    }
}
