using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;



namespace BattleShipRun 
{
    [RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
    public class MovePlayerForward : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private DynamicJoystick _joystick;
        //[SerializeField] private Animation _animator;
        [SerializeField] public float move_speed;  // Скорость движения     

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();            
        }

        void Player_move()
        {
            if (Input.GetMouseButton(0))
            {
                _rigidbody.AddForce(Vector3.forward * move_speed,ForceMode.Acceleration); //Применяем силу ускорения к кораблю по нажатию кнопки
                
            }
            else
            {
                _rigidbody.velocity = Vector3.forward * 0f; //Отжали кнопку всё остановилось
            }                
        }
        
        void FixedUpdate()
        {   
            Player_move();  
        }

    }
}


