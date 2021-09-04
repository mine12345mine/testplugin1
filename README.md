# コイカツのプラグイン作成（入門）
## - VisualStudioの進め方 ～ [HelloWorld]と[キー設定]
<br>
[本家BepInExチュートリアル](https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/)<br>
[BepInExAPI](https://docs.bepinex.dev/api/index.html)

### 1. Visual Studio Installerから「.NETデスクトップ開発」をインストールしておく
<img src="./image/1.png" width="640px">

### 2.クラスライブラリ(.NET Framework)のプロジェクトを作成
<img src="./image/2.png" width="640px">

### 3.フレームワークは「.NET Framework3.5」を指定<br>
(3.5以外だとBepInExクラスの使用で問題があった、要注意)
<img src="./image/3.png" width="640px">

### 4.ソリューションエクスプローラーから参照の追加
<img src="./image/4.png" width="640px">

### 5.「0Harmony」「BepInEx」「UnityEngine」を追加
<img src="./image/5.png" width="640px">

### 6.ソースコード記述（Class1.cs）
<img src="./image/6.png" width="640px">

### 7.ビルドして出来たdllをplugins配下へ、そして実行
デバック画面のプラグインの名前の下に「Hello,world」のメッセージを確認
<img src="./image/7.png" width="640px">

F1からプラグイン設定画面を表示し、登録されていることを確認
<img src="./image/8.png" width="640px">

<br>
実際に実行して確認
<img src="./image/9.png" width="640px">

「補足」<br>
スタジオを実行したらBepInEx/config配下に設定ファイルが作成される。<br>
ボタン配置の変更のみだと更新されない？可能性あり。<br>


以上！
