using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine.TestTools.Utils;

public class SimpleBeatMakerTest
{
    BeatMaker b;
    MockTimer timer;
    const float allowedRelativeError = 10e-6f; // float値を比較する際に許容できる相対誤差の上限

    [SetUp]
    public void Init()
    {
        timer = new MockTimer();
        b = new SimpleBeatMaker(timer);
    }

    [Test]
    public void ConstantTempoTest1()
    {
        var packet = new BeatPacket(); // 拍動イベントの引数をコピーしておく入れ物

        b.RegisterOnBeat((p) => { packet = p; }); // 拍動イベントの登録

        // 時刻0秒に1回目の拍動が発生
        timer.CurrentTime = 0.0f;
        b.Beat();

        // 時刻1秒に2回目の拍動が発生
        timer.CurrentTime = 1.0f;
        b.Beat();

        // この時点でのpacketの情報が、拍動の回数が2回、予想テンポが1.0秒になっているはず
        Assert.That(packet.BeatCount == 2);
        Assert.That(Utils.AreFloatsEqual(1.0f, packet.Tempo, allowedRelativeError));
    }
}