using System;

/// <summary>
///  This class contains utility methods.
/// </summary>
public static class Utility {

    /// <summary>
    ///  This method throws an <see cref="ArgumentException"/>if the given condition is false.
    /// </summary>   
    public static void Require(bool condition, string msg) {
        if (!condition) throw new System.ArgumentException(msg);
    }
}
