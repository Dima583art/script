using UnityEngine;

public class Npc : MonoBehaviour
{
    // здоровье npc
    public int heath=5;
    // уровень npc
    public int level=1;
    // скорость npc
    public float speed=1.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       heath+=level;
       print("heath="+heath);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition=transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position=newPosition;
    } 
}