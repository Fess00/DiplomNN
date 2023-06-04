using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;


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
        rec[0].coins = 1;
        rec[0].damage_dealt = 1;
        rec[0].damage_taken = 1;
        rec[0].health = 1;
        rec[0].level = 1;
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            // Don't write the header again.
            HasHeaderRecord = false,
        };
        using (var stream = File.Open(Application.streamingAssetsPath + @"/Data/data.csv", FileMode.Append))
        using (var writer = new StreamWriter(stream))
        using (var csv = new CsvWriter(writer, config))
        {
            csv.WriteRecords(rec);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
