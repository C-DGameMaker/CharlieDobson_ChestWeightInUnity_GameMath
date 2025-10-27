using Mono.Cecil;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Search;
using UnityEngine;

public class ChestWeight : MonoBehaviour
{
    [Header("CHEST TYPES")]
    [SerializeField] int woodChest;
    [SerializeField] int bronzeChest;
    [SerializeField] int silverChest;
    [SerializeField] int goldChest;
    [SerializeField] int platinumChest;
    static int totalChest;
    

    [Header("WOOD CHEST DROPS")]
    [SerializeField] int woodCommon;
    [SerializeField] int woodUnCommon;
    [SerializeField] int woodRare;
    [SerializeField] int woodEpic;
    [SerializeField] int woodLegandary;
    static int woodChance;

    [Header("BRONZE CHEST DROPS")]
    [SerializeField] int bronzeCommon;
    [SerializeField] int bronzeUnCommon;
    [SerializeField] int bronzeRare;
    [SerializeField] int bronzeEpic;
    [SerializeField] int bronzeLegandary;
    static int bronzeChance;

    [Header("SILVER CHEST DROPS")]
    [SerializeField] int silverCommon;
    [SerializeField] int silverUnCommon;
    [SerializeField] int silverRare;
    [SerializeField] int silverEpic;
    [SerializeField] int silverLegandary;
    static int silverChance;

    [Header("GOLD CHEST DROPS")]
    [SerializeField] int goldCommon;
    [SerializeField] int goldUnCommon;
    [SerializeField] int goldRare;
    [SerializeField] int goldEpic;
    [SerializeField] int goldLegandary;
    static int goldChance;

    [Header("PLATINUM CHEST DROPS")]
    [SerializeField] int platinumCommon;
    [SerializeField] int platinumUnCommon;
    [SerializeField] int platinumRare;
    [SerializeField] int platinumEpic;
    [SerializeField] int platinumLegandary;
    static int platChance;

    static List<int> chests = new List<int> { };
    static List<int> wood = new List<int> { };
    static List<int> bronze = new List<int> { };
    static List<int> silver = new List<int> { };
    static List<int> gold = new List<int> { };
    static List<int> platinum = new List<int> { };

    void Update()
    {
        totalChest = woodChest + bronzeChest + silverChest + goldChest + platinumChest;
        if (Input.GetKey(KeyCode.Space))
        {
            int chest = Random.Range(0,(totalChest + 1));

            for (int i = 0; i < chest; i++)
            {

            }

        }
    }

    void WoodChest()
    {
        woodChance = woodCommon + woodUnCommon + woodRare + woodEpic + woodLegandary;

        int chest = Random.Range(0, (woodChance + 1));
    }

    void BronzeChest()
    {

    }

    void SilverChest()
    {

    }

    void GoldChest()
    {

    }

    void PlatinumChest()
    {

    }



}
