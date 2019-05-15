using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


[XmlRoot("Analytics")]
public class Analytics : MonoBehaviour
{
    private string path = @"";

    void Save()
    {
        var serializer = new XmlSerializer(typeof(UserData));
        using (var stream = new FileStream(path, FileMode.Create))
        {
            serializer.Serialize(stream, this);
            stream.Close();
        }
    }
}
