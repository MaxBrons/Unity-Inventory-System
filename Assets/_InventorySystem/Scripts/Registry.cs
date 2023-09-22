using System.Collections.Generic;
using System.Linq;

// Service locator class to retreive and store objects/services
public static class Registry
{
    private static Dictionary<string, object> objects = new();

    // Adds an object if it does not already exist in the Registry
    public static void Register(string key, object obj)
    {
        if(!objects.TryAdd(key, obj)) {
            objects[key] = obj;
        }
    }

    // Removes an object if it can be found in the Registry
    public static bool Unregister(object obj)
    {
        if (!objects.ContainsValue(obj))
            return false;

        foreach (var item in objects.Keys) {
            if (objects[item] == obj) {
                objects[item] = null;
                return true;
            }
        }
        return false;
    }

    // Return an object with the given Registry Key
    public static object Get(string key)
    {
        if (!objects.ContainsKey(key))
            return null;
        return objects[key];
    }
}
