using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BattleShipRun
{
    [RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
    public class SwipeDetector : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private DynamicJoystick _joystick;
        [SerializeField] public float move_speed;  // Скорость движения
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();  
        }
        void Update()
        {
            _rigidbody.velocity = new Vector3(_joystick.Horizontal * -move_speed, 0f, 0f); //Взаимодействие со стиком по оси Х, на остальных заглушка. 
        }
    }
}
    
