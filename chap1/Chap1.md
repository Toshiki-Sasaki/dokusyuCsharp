## 独習C#新版

# 1章
## 1.1 C#の特徴
### 共通言語ランタイム（CLR; Common Language Runtime）
.NETアプリが共通で利用する実行エンジン。
.NET FrameworkではC#をはじめ、VisualBasic、F#、C++/CLI といった言語を利用できるが、これらの言語で作成した全てのアプリはCLR上で動く。 
すなわち、開発者は上位の言語であれば選択に制限がなく、コンパイルした結果は共通中間言語に変換されるので同様の結果とパフォーマンスを得ることができる。

## 1.3 C#プログラミングの基本
### 新規プロジェクトの作成
|テンプレート名|用途|
|:---|:---|
|コンドールアプリ|コンソールから呼び出すアプリを作成|
|WPFアプリ/<br>Windwosフォームアプリケーション|デスクトップアプリを作成|
|ASP.NET Core Webアプリケーション<br>ASP.NET Webアプリケーション|webアプリを作成|
|クラスライブラリ|アプリから利用できるクラスライブラリを作成|
|Closs Platform App|Android, iOS, Windowsデバイス用のアプリを作成|
|単体テストアプリ|単体テストを含むプロジェクトを作成|
|Azureクラウドサービス|Azur上にクラウドサービスを作成|
|OpenGLゲーム|OpenGLでゲームアプリを作成|
|空白のアプリ|余分なものの入っていないアプリ作成用のシンプルなテンプレート|

### 用語
|用語|説明|
|:---|:---|
|プロジェクト|アプリをまとめるための器|
|ソリューション|プロジェクトを管理する大きな器|
|ビルド|全開のビルドからの差分だけを処理する|
|リビルド|全開のビルド結果を咲くよして一からビルドをやり直す|
|クリーン|全開のビルド結果を全て削除する|
|メンバー|classブロックに含まれる要素のこと（コンストラクター、メソッド、フィールド、プロパティなど）|
|メソッド|クラスの機能を表すためのメンバーで、アプリで実行すべき処理を表す|
|エントリーポイント|アプリを起動した時に始めに読むメソッドのこと|
|プレースホルダー|{0}のように値を置く場所|
|ブレークポイント|コードの実行を途中で中断し、その時の状況を確認する機能|
|名前空間|クラスを分類するための入れ物|

## 理解度チェック
### 1. C# の特徴を「マルチパラダイム」「マルチプラットフォーム」というキーワードを絡めて説明してみましょう。
C#は純粋なオブジェクト指向言語ではなく、宣言型プログラミング、関数型プログラミング、メタプログラミングなど様々なパラダイムを取り入れていることからマルチパラダイム言語と呼ばれている。
また、C#は.NETと呼ばれるプラットフォームごとの違いを吸収するマルチプラットフォームで動作する。

### 2. 空欄を埋めてください。
① 名前空間
② クラス
③ メソッド
④ コメント
⑤ 文

### 3. C#アプリはどのメソッドから実行されるか。また、そのようなメソッドのことをなんと呼ぶか。
Mainメソッドから呼ばれる。そのようなメソッドを「エントリーポイント」と呼ぶ。

### 4. 分の末尾を示す記号を答えよ。
; (セミコロン)

### 5. C#で使えるコメントの記法を全てあげよ。またそれらの違いを説明せよ。
|記法|説明|
|:---:|:---:| 
|// (...)| 単一行 |
|/* (...) */| 複数行 |
|/// (...)| ドキュメンテーションコメント（クラスやメソッドの情報を表す） | 




