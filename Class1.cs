using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace testplugin1
{
    [BepInProcess("CharaStudio")]
    [BepInPlugin("org.bepinex.plugins.exampleplugin", "Example Plug-In", "1.0.0.0")]
    public class Class1 : BaseUnityPlugin
    {
        private ConfigEntry<KeyboardShortcut> keyTest1 { get; set; }
        private bool _visible = false;      // GUIの表示非表示
        private bool _push = false;         // 連続キー押下防止用
        private void Awake()
        {
            UnityEngine.Debug.Log("Hello, world!");
            // キーメニュー
            keyTest1 = Config.Bind("Hotkeys", "Testkey", new KeyboardShortcut(KeyCode.J), new ConfigDescription("説明文"));
        }
        private void OnGUI()
        {
            if (keyTest1.Value.IsDown())
            {
                if (_push == false)
                {
                    _push = true;
                    _visible = !_visible;
                    UnityEngine.Debug.Log("KeyPush");
                }
            }
            else if(_push == true)
            {
                _push = false;
            }
            if (!_visible) return;
           
            GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100));
            GUI.Box(new Rect(0, 0, 100, 100), "グループGUI");
            GUI.Button(new Rect(10, 40, 80, 30), "ボタン");
            GUI.EndGroup();
        }
    }
}
