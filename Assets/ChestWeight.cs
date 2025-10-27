using Mono.Cecil;
using Unity.VisualScripting;
using UnityEngine;

public class ChestWeight : MonoBehaviour
{
    [Header("CHEST TYPES")]
    public int wood = 1;

    [Header("WOOD CHEST DROPS")]
    public int woodCommon = 1;

    [Header("BRONZE CHEST DROPS")]
    public int bronzeCommon = 1;

    [Header("STONE CHEST DROPS")]
    public int stoneCommon = 1;

    [Header("GOLD CHEST DROPS")]
    public int goldCommon = 1;

    [Header("PLATIUM CHEST DROPS")]
    public int platiumCommon = 1;


    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("You pressed the spaceBar");
        }
    
    }
    
}
