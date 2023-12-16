using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleShipRun
{
    public class Coin : MonoBehaviour
    {
        //private int coin = 3;

       
        void Update()
        {
            transform.Rotate(0f, 1f, 0f);
        }
    }

}

