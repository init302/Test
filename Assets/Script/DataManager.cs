using System.Collections;
using System.Collections.Generic;
public class DataManager
{
    private static DataManager instance;

    public static DataManager Instance
    {
        get
        {
            if (instance == null) instance = new();
            return instance;
        }
    }
}