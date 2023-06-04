using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

public class CsvDataClass
{
    [Name("death")]
    public string death {get; set;}
    [Name("lifetime")]
    public int lifetime {get; set;}
    [Name("coins")]
    public int coins {get; set;}
    [Name("damage_dealt")]
    public int damage_dealt {get; set;}
    [Name("damage_taken")]
    public int damage_taken {get; set;}
    [Name("health")]
    public int health {get; set;}
    [Name("level")]
    public int level {get; set;}

    private static CsvDataClass instance;

    // Static singleton property
    public static CsvDataClass getInstance()
    {
        if (instance == null)
            instance = new CsvDataClass();
        return instance;
    }
}
