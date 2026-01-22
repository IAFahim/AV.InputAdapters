using UnityEngine;

namespace AV.InputAdapters.Runtime
{
    /// <summary>
    /// Receives a Vector2 position value.
    /// Interface follows naming guidelines: descriptive type name + descriptive property.
    /// </summary>
    public interface IPositionReceiver
    {
        Vector2 Position { set; }
    }
}
