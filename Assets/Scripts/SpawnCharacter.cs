using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _character;

    private Transform _transformSpawn;
    private void Start()
    {
        _transformSpawn = GetComponent<Transform>();
        Instantiate(_character, _transformSpawn.position, Quaternion.identity);
    }

}
