
/// <summary>
/// テスト用のITimerオブジェクトのモック
/// </summary>
internal class MockTimer : ITimer
{
    float currentTime;

    /// <summary>
    /// 現在時間
    /// </summary>
    public float CurrentTime
    {
        set
        {
            currentTime = value;
        }
    }

    public MockTimer()
    {
        currentTime = 0.0f;
    }

    /// <summary>
    /// 設定されたcurrentTimeをそのまま返す
    /// </summary>
    /// <returns>ダミーの現在時間</returns>
    float ITimer.GetCurrentTime()
    {
        return currentTime;
    }
}