using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

[XmlRoot("UserData")]
public class UserData
{
    [XmlArray("Timer")]
    [XmlArrayItem("Frame")]
    public List<float> Frames = new List<float>();

    [XmlArray("User Movement")]
    [XmlArrayItem("Movement")]
    public List<Vector3> Movements = new List<Vector3>();
    
    [XmlArray("Objects Interacted")]
    [XmlArrayItem("Object")]
    public List<string> Objects = new List<string>();

    [XmlArray("Objectives Completed")]
    [XmlArrayItem("Objective")]
    public List<string> Objectives = new List<string>();
}
