using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBlock : MonoBehaviour
{
    public bool Fetch(float x) //Проверка, проехала ли машина игрока этот блок на достаточное расстояние
    {
        bool result = false;
    
        if(x > transform.position.x + 94f)
        {
            result = true; //Если машина проехала на 100f от блока, то возвращается true
        }
    
        return result;
    }
    
    public void Delete() 
    {
        if (gameObject != null)
        { 
            Destroy(gameObject); //Удаление блока
        }
    }
}
