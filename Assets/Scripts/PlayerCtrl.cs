using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerCtrl : MonoBehaviour
{
    #region 基本參數
    public CharacterController charCtrl;
    public int HP;
    #endregion 基本參數

    #region 生命週期
    //初始化
    void Start()
    {
        HP = 100;
    }

    //更新:偵測操作
    void Update()
    {

    }

    public void Move(CallbackContext callback)
    {
        //角色控制器.移動(往前)
        charCtrl.SimpleMove(Vector3.forward);
    }
}