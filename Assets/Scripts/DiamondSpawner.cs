using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _templete;

    private Transform[] _points;

    private void Start()
    {
        _points = GetComponentsInChildren<Transform>();

        foreach (var _point in _points)
        {
            Instantiate(_templete, _point.position, Quaternion.identity);
        }
    }
}
