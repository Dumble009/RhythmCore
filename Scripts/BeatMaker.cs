using UnityEngine;

public delegate void BeatHandler();

/// <summary>
/// 拍動を元にテンポの計算、イベントの発行を行うクラス
/// </summary>
public class BeatMaker : MonoBehaviour
{
    /// <summary>
    /// 外部のオブジェクトが拍動事象発生時に呼び出す関数
    /// </summary>
    public void Beat()
    {

    }

    /// <summary>
    /// 拍動時のイベントの登録
    /// </summary>
    /// <param name="handler">登録されるイベントハンドラ</param>
    public void RegisterOnBeat(BeatHandler handler)
    {

    }

    /// <summary>
    /// 拍動時のイベントの登録解除
    /// </summary>
    /// <param name="handler">登録解除されるイベントハンドラ</param>
    public void UnregisterOnBeat(BeatHandler handler)
    {

    }

    /// <summary>
    /// テンポ(拍動間の秒数)の計算
    /// </summary>
    /// <returns></returns>
    virtual protected float CalcTempo()
    {
        return 0.0f;
    }
}