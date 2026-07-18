using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{
    private Animator anim;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        // 关键改动1：初始化强制恢复Time.timeScale=1，避免启动卡死
        Time.timeScale = 1;

        // 新增：空值检查，方便调试Animator缺失问题
        if (anim == null)
        {
            Debug.LogError("PauseUI：未找到Animator组件！请检查挂载", this.gameObject);
        }
    }


    public void OnPauseButtonClick()
    {
        // 关键改动2：状态判断，避免重复暂停（已暂停则直接返回）
        if (isPaused || anim == null) return;

        // 1. 暂停游戏逻辑（小鸟、猪、木块的物理/更新）
        Time.timeScale = 0;
        // 2. 关键改动3：让Animator不受Time.timeScale影响，保证暂停菜单动画播放
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
        // 3. 触发暂停菜单显示
        anim.SetBool("IsShow", true);

        isPaused = true;
    }
    public void OnContinueButtonClick()
    {
        // 关键改动2：状态判断，避免重复继续
        if (!isPaused || anim == null) return;

        // 1. 恢复游戏逻辑运行
        Time.timeScale = 1;
        // 2. 恢复Animator默认更新模式
        anim.updateMode = AnimatorUpdateMode.Normal;
        // 3. 隐藏暂停菜单
        anim.SetBool("IsShow", false);

        isPaused = false;
    }
    public void OnRestartButtonClick()
    {
        GameManager.Instance.RestartLevel();
    }
    public void OnLevelListButtonClick()
    {
        GameManager.Instance.LevelList();
    }

}
