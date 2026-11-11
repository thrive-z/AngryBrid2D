# 愤怒的小鸟 · Unity 2D 复刻练习

**[▶ 在线观看演示](https://thrive-z.github.io/AngryBrid2D/)　·　[⬇ 下载 Windows 试玩版](https://github.com/thrive-z/AngryBrid2D/releases/download/showcase-2026-11-11/AngryBrid2D-Windows.zip)**

用 Unity 2023.1.1f1 和 C# 制作的 2D 物理闯关项目。拖动弹弓发射小鸟，用碰撞和飞行技能击倒关卡里的猪，再查看分数和星级。

## 游戏演示

[在线观看愤怒的小鸟游戏演示](https://thrive-z.github.io/AngryBrid2D/)（约 1 分 43 秒） · [下载原版 MP4](https://github.com/thrive-z/AngryBrid2D/releases/download/showcase-2026-11-11/AngryBrid2D-Gameplay.mp4)

## 我实现的功能

- **弹弓和镜头**：鼠标拖动小鸟时限制拉伸范围，松手后按拉伸方向和距离发射。双侧皮筋跟随拖动，镜头跟拍小鸟。
- **飞行技能与碰撞**：黄鸟在空中加速，回旋鸟改变水平飞行方向，黑鸟爆炸时对附近目标造成伤害。障碍物按碰撞速度扣血，根据受损程度切换贴图。
- **关卡与结算**：实现地图选关、锁定状态、胜负结算、星级显示和重试。把关卡资源与场景加载流程接起来，新增关卡时可以从配置指定关卡内容。

## 用到的技术

- **Unity 2D 物理**：使用 Rigidbody2D 控制发射与飞行，从 Collision2D 读取碰撞速度，用 Physics2D 范围检测实现爆炸。
- **C# 继承和重写**：小鸟共用拖拽、发射和飞行流程，各鸟种重写自己的技能。
- **LineRenderer、ScriptableObject、uGUI / TextMesh Pro**：分别用于弹弓皮筋、地图和关卡配置，以及选关与结算界面。

## 下载与运行

| 文件 | 使用方式 |
| --- | --- |
| [Windows 试玩版 ZIP](https://github.com/thrive-z/AngryBrid2D/releases/download/showcase-2026-11-11/AngryBrid2D-Windows.zip) | 完整解压后双击 `AngryBrid2D.exe`。 |
| [Unity 资源包](https://github.com/thrive-z/AngryBrid2D/releases/download/showcase-2026-11-11/AngryBrid2D-Assets.unitypackage) | 用 Unity 2023.1.1f1 的 **Assets → Import Package → Custom Package** 导入。 |

按住鼠标左键向后拖动小鸟，松开发射。具备飞行技能的鸟发射后，可再点一次鼠标左键触发技能。

## Unity 工程

在 Unity Hub 添加仓库根目录，使用 Unity 2023.1.1f1 打开。从 `Assets/Scenes/1-StartScene.unity` 进入 Play Mode。
