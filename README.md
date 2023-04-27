# UnityCarGame
My university pocket project


List of scripts /assets/scripts/:
1.NewControls.cs :
Файл с описанием функций управления

    float LaunchSpeed //скорость при нажатии
    float RotSpeed //скорость поворота
    
    void Start()    // запускающая функция, в которой определяется путь к объекту которым мы управляем
    void Update()   // функция запускающаяся при нажатии кнопки
                    // определяет текущую скорость машины и вызывает функции поворота и движения
    void Rotation() // функция поворота, вызываемая при нажатии кнопок left & right
    void Launch()   // функция придающая ускорение машине посредством функции addForce с указанием вектора движения и скорости

2.Road.cs :
Файл с описанием функций генерации объектов окружения

    public List<GameObject> blocks; //Коллекция всех дорожных блоков
    public GameObject player; //Игрок
    public GameObject roadBlock; //Префаб дорожного блока
    public GameObject car; //Префаб машины NPC
    public GameObject coinPrefab; //Префаб монеты
    
    void Update()   // функция вызывающаяся при взаимодействии с картой
                    // определяет местоположение объекта
                    // и генерирует продолжение дороги на заданном расстоянии от него
                    // параллельно удаляя пройденные участки дороги через работу с массивом blocks
3.RoadBlock.cs :
    public bool Fetch(float x) //Проверка, проехала ли машина игрока этот блок на достаточное расстояние
    public void Delete() //Удаление блока
