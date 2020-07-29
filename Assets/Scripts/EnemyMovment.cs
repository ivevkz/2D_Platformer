using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;    

    private Transform[] _point;
    private int _currentPoint;

    private void Start()
    {
        _point = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _point[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _point[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (_currentPoint == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


        if (transform.position == target.position)
        {
            _currentPoint++;
            if (_currentPoint >= _point.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
