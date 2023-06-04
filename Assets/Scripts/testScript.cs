using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using System;

public class testScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        // {
        //     NewLine = Environment.NewLine,
        // };
        var rec = new List<CsvDataClass> {new CsvDataClass()};
        rec[0].death = "no";
        rec[0].lifetime = 1;
        rec[0].coins = 2;
        rec[0].damage_dealt = 3;
        rec[0].damage_taken = 4;
        rec[0].health = 5;
        rec[0].enemies_killed = 6;
        rec[0].level = 7;
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            // Don't write the header again.
            HasHeaderRecord = false,
            NewLine = Environment.NewLine,
        };
        using (var stream = File.Open(Application.streamingAssetsPath + @"/Data/data.csv", FileMode.Append))
        using (var writer = new StreamWriter(stream))
        {
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(rec);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
