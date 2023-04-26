using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; 

public class Road : MonoBehaviour
{
    public List<GameObject> blocks; //Коллекция всех дорожных блоков
    public GameObject player; //Игрок
    public GameObject roadBlock; //Префаб дорожного блока
    public GameObject car; //Префаб машины NPC
    //public GameObject coinPrefab; //Префаб монеты
    
    private System.Random rand = new System.Random(); //Генератор случайных чисел
    
    void Update()
    {
        float x = player.GetComponent<NewControls>().RigidBody.position.x; //Получение положения игрока
    
        var last = blocks[blocks.Count - 1]; //Номер дорожного блока, который дальше всех от игрока
    
        if(x > last.transform.position.x - 96.0f) //Если игрок подъехал к последнему блоку ближе, чем на 10 блоков
        {
            //Инстанцирование нового блока
            var block = Instantiate(blocks[blocks.Count - 1], new Vector3(last.transform.position.x + 96.0f, last.transform.position.y, last.transform.position.z), Quaternion.identity); 
            block.transform.SetParent(gameObject.transform); //Перемещение блока в объект Road
            blocks.Add(block); //Добавление блока в коллекцию
    
        }
    
        foreach (GameObject block in blocks.ToList()) 
        {
            if (block != null)
            { 
                bool fetched = block.GetComponent<RoadBlock>().Fetch(x); //Проверка, проехал ли игрок этот блок
        
                if(fetched) //Если проехал blocks.Array.data[0]
                {
                    blocks.Remove(block); //Удаление блока из коллекции
                    block.GetComponent<RoadBlock>().Delete(); //Удаление блока со сцены
                }
            }
        }
    }
}


//Проблема в том что удаляется только первый блок, а дальше структура массива нарушается и скрипт его неправильно считывает.