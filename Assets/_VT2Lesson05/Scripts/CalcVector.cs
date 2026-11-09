using UnityEngine;

public class CalcVector : MonoBehaviour
{
    public Vector3 A = new Vector3(2, 5, -4);
    public Vector3 B = new Vector3(5, 3, 6);

    public Vector3 Result = Vector3.zero;
    public float DotResult;

    private void Update()
    {
        Result = CrossMultiply(A, B);
        DotResult = DotMultiply(A, B);
    }

    /// <summary>
    /// ベクトル同士の足し算
    /// </summary>
    public Vector3 Additive(Vector3 a, Vector3 b)
    {
        var result = a + b;

        Debug.DrawRay(Vector3.zero, a, Color.red);
        Debug.DrawRay(Vector3.zero, b, Color.blue);
        Debug.DrawRay(a, b, Color.yellow);
        Debug.DrawRay(Vector3.zero, result, Color.green);

        return result;
    }

    /// <summary>
    /// ベクトル同士の引き算
    /// </summary>
    public Vector3 Subtract(Vector3 a, Vector3 b)
    {
        var result = a - b;

        Debug.DrawRay(Vector3.zero, a, Color.red);
        Debug.DrawRay(Vector3.zero, b, Color.blue);
        Debug.DrawRay(b, result, Color.green);

        return result;
    }

    /// <summary>
    /// ベクトル同士の内積
    /// </summary>
    public float DotMultiply(Vector3 a, Vector3 b)
    {
        var result = Vector3.Dot(a, b);

        Debug.DrawRay(Vector3.zero, a, Color.red);
        Debug.DrawRay(Vector3.zero, b, Color.blue);

        return result;
    }

    /// <summary>
    /// ベクトル同士の外積
    /// </summary>
    public Vector3 CrossMultiply(Vector3 a, Vector3 b)
    {
        var result = Vector3.Cross(a, b);

        Debug.DrawRay(Vector3.zero, a, Color.red);
        Debug.DrawRay(Vector3.zero, b, Color.blue);
        Debug.DrawRay(Vector3.zero, result, Color.green);

        return result;
    }

    /// <summary>
    /// ベクトルの各要素同士の乗算
    /// </summary>
    public Vector3 Multiply(Vector3 a, Vector3 b)
    {
        var result = Vector3.Scale(a, b);

        Debug.DrawRay(Vector3.zero, a, Color.red);
        Debug.DrawRay(Vector3.zero, b, Color.blue);
        Debug.DrawRay(Vector3.zero, result, Color.green);

        return result;
    }
}
