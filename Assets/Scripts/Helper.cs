using UnityEngine;
using System.Collections;

public static class Helper
{
    // a static helper class for common methods and shortcuts
    public static GameObject GetParent(GameObject obj)
    {
        Transform parentTransform = obj.transform.parent;
        if (parentTransform == null)
            return null;

        return parentTransform.gameObject;
    }




    /// <summary>
    ///get the position (center or pivot) of a collider in world space (considering offset).
    /// ONLY WORKS WITH BOX OR CIRCLE COLLIDERS
    /// </summary>
    
    public static Vector2 GetRealPos(Collider2D coll)
    {
        // if passed a Collider2D - check whether it's a circle or a box and call appropriate overload
        if (coll.GetType() == typeof(BoxCollider2D))
            return GetRealPos((BoxCollider2D)coll);

        else if (coll.GetType() == typeof(CircleCollider2D))
            return GetRealPos((CircleCollider2D)coll);

        else // if it's not a circle or box collider, throw an exception
            throw new System.ArgumentException("GetRealPos(Collider2D) only accepts box or circle colliders!");
    }
    public static Vector2 GetRealPos(BoxCollider2D boxCollider)
    { 
        Vector2 initialPos = boxCollider.transform.position;
        return initialPos + boxCollider.offset;
    }
    public static Vector2 GetRealPos(CircleCollider2D circleCollider)
    {
        Vector2 initialCenter = circleCollider.transform.position;
        return initialCenter + circleCollider.offset;
    }

    public static void Main (string[] args)
    {
        CircleCollider2D c = new CircleCollider2D();
        System.Console.WriteLine(c.GetType().IsInstanceOfType(new CircleCollider2D()));
    }
}