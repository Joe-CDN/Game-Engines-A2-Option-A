using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileManager : MonoBehaviour
{
    public static bool WriteToFile(string a_Filename, string a_FileContents)
    {
        var fullPath = Path.Combine(Application.persistentDataPath, a_Filename);

        try
        {
             File.WriteAllText(fullPath, a_FileContents);
             return true;
        }
        catch (Exception e)
        {
           Debug.LogError($"Failed to write to {fullPath} with exception {e}");
        }
        return false;
    }

    public static bool LoadFromFile(string a_Filename, out string result)
    {
        var fullPath = Path.Combine(Application.persistentDataPath, a_Filename);

        try
        {
             result = File.ReadAllText(fullPath);
             return true;
        }
        catch (Exception e)
        {
            Debug.LogError($"Failed to read from {fullPath} with exception {e}");
            result = "";
            return false;
        }
    }
}