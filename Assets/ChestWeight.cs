using Mono.Cecil;
using Unity.VisualScripting;
using UnityEngine;

public class ChestWeight : MonoBehaviour
{
    [Header("CHEST TYPES")]
    public int wood = 1;
    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("You pressed the spaceBar");
        }
    
    }
    
}
