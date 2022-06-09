using UnityEngine;

/// <summary>
/// 前の拍からの経過秒数をそのままテンポとするBeatMaker
/// </summary>
public class SimpleBeatMaker : BeatMaker
{
    /// <summary>
    /// 実行開始時から最後の拍動が打たれた時までの経過秒数
    /// </summary>
    float lastBeatTime;
    public SimpleBeatMaker() : base()
    {
        lastBeatTime = 0.0f;
    }
    protected override float CalcTempo()
    {
        float tempo = Time.realtimeSinceStartup - lastBeatTime;
        lastBeatTime = Time.realtimeSinceStartup;

        return tempo;
    }
}
