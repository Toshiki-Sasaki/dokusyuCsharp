# 2章

## 用語
|用語|説明|
|:---:|:---:|
|識別子|変数などの名前のこと|
|予約語|あらかじめ意味が決められた単語のこと|
|コンテキストキーワード|特定の文脈でのみ意味を持ったキーワード、決められた場所を除いては識別子としても利用できる|
|逐語的識別子|@付きの識別子、主に異なるプログラミング言語との連携を想定している|
|静的型付け|宣言した型以外のものを代入できない性質のこと|


## 練習問題2.1
1. 構文的に間違っている変数の名前はどれか。またその理由。
① 1data: 変数名が数値から始まっている
② Hoge: camelCase記法が望ましい
③ 整数の箱: 正しい
④ for: 予約語なので使用不可
⑤ @if: 正しい
⑥ data-1: 正しい


## 暗黙的な型指定(var)と明示的な型のどちらを利用するべきか。
マイクロソフトのドキュメントによると、以下のような指針が示されている。
[1] 変数の型が右辺から明らかであるとき、または厳密な型が重要でない場合は、暗黙の型指定を使用します。
[2] 右辺から型が明らかでない場合は var を使用しないでください。
[3] 型を指定する際に変数名に頼らないでください。変数名が正しくな場合があります。
[4] dynamic(11.3節)の代わりに var を使用しないでください。
[5] for/foreach のカウンター変数では、暗黙の型指定をします。

## 練習問題2.2
1. C#で利用可能な組み込み型を、整数型(符号あり)、整数型(符号なし)、小数点型、それ以外からそれぞれ2個以上挙げてみましょう。
整数型(符号あり): int, long, sbyte, short
整数型(符号なし): uint, ulong, byte, ushort
小数点型): float, double, decimal
それ以外: string, bool, char, object

2. 値型と参照型の違いを、格納方法の観点から説明せよ。
値型の変数は、値そのものが格納される。
参照型は、値そのものは別に格納され、変数はその格納場所を表す情報だけが格納される。


## 数値セパレータ
C#7 では桁数の大きな数値の可読性を改善するために区切り文字(_)を指定できる。
123456789 = 123_456_789

## 指数表現
<仮数部> e <符号> <指数部> で表現可能。
1.4142e5 -> 1.4142*10^5 -> 141420
0.173205e-5 -> 0.173205*10^(-5) -> c0.00000173205

## 文字リテラル
シングルクォート(')で囲む。
|エスケープシーケンス|概要|
|:---:|:---:|
|¥0|null|
|¥b|バックスペース|
|¥r|復帰(キャリッジリターン)
|¥f|フォームフィード|
|¥t|水平タブ|
|¥v|垂直タブ|
|¥unnnn|unicode文字|
|¥xnnnn|unicode文字(可変長)|
|¥unnnnnnnn|unicode文字(サロゲートペア)|

## 文字列リテラル
ダブルクォート(")で囲む。

### 逐語的文字列リテラル
「¥xx」をエスケープシーケンスではなく表記のまま解釈する。
標準的な文字列リテラルの先頭に「@」をつけて表記する。
Windowsのパスを「¥¥」で表現するのは面倒。
"C:¥¥Windows¥¥AppPatch¥¥en-US" -> @"C:¥Windows¥AppPatch¥en-US"

逐語的文字列リテラルで「"」はそのまま表すことができない。またエスケープシーケンスの「¥"」も使えないので、代わりに「""」を使う。

### 文字列への変数展開
$"..."で文字列リテラルを表現することもできる。この場合、文字列内の{...}が式として解釈され、その結果が文字列に埋め込まれる。
```
string name = "山田";
Console.Write( $"こんにちは、{name} さん！" );
```

$@"..." も可能。
```
string name = "山田";
Console.Write( $@"おはよう、{name} さん！
こんにちは、{name} さん！
さようなら、{name} さん！" );
```

## 練習問題2.3
1. 以下の記法を利用して、リテラル表現をしてみましょう。

## 暗黙的な型変換
値範囲の狭い型から広い型には無条件に変換できる（拡大変換）。
広い型から狭い型への変換（縮小変換）は内容に関わらずエラー

## 明示的な変換（キャスト）
実際の値が範囲内にあることが明らかな場合で、型キャスト構文を利用して明示的に変換の意思を表明した場合に限って、縮小変換を認めている。
これを明示的変換と呼ぶ。

## 文字列⇄数値の変換
文字列から数値への変換では、数値型のクラスからParseメソッドを呼び出す。
数値を文字列に変換するには、数値型のToStringメソッドを呼び出す。

## 練習問題2.4
1. 正しいコードへ返還せよ
Before:
```
long m = 10;
int i = m;
```

After:
```
long m = 10;
int i = (int)m;
```
longからintへの変換は縮小変換なので、明示的変換が必要。

2. 文字列型の値"15"をint型に変換するためのコードを書け。
```
string s = "15";
int i = Int32.Parse(s);
```

## クラス型
クラスをインスタンス化するにはnewというキーワードを使用する。
```
クラス名 変数名 = new クラス名(引数, ...)
```

## null条件演算子
「オブジェクトが非nullの時だけそのメンバーにアクセスしたい」という状況はよくある。このような処理を「?.」を使って簡単に表すことができる。
```
// こちらはエラー
string str = null;
string unspace = str.Trim();

// こちらはエラーにならない
string str = null;
string unspace = str?.Trim();
```

値型の本来の型名に「?」を付与することで、null許容型の変数を宣言できる。
```
int? num1 = 108;
int? num2 = null;

// 値型のみなので参照型のstring?などはできない。
```

null許容型と本来の値型とは相互変換が可能。
値型から対応するnull許容型への変換は、拡大変換となるので暗黙的に変換が可能。
```
int i = 108;
int? num = i;
```

一方でnull許容型から値型への変換は、明示的なキャストが必要。
```
int? num = 108;
int i = (int)num;

// nullのように値型に変換できない場合はエラー。
int? num = null;
int i = (int)num;
```

## 配列の宣言
### 1次元配列
1. 配列のサイズだけを宣言
```
データ型[] 配列名 = new データ型[要素数];
int[] data = new int[5];
```

2. 初期値を指定した宣言
```
データ型[] 配列名 = {要素1, 要素2, ...}
int[] data = { 1, 2, 3, 4, 5 }; 
```

3. var による配列宣言
```
var 変数名 = new[] {要素1, 要素2, ...}
var data = new[] { 1, 2, 3, 4, 5 }
```

### 多次元配列
```
データ型[,] 変数名 = new データ型[要素数1, 要素数2]
// 例
int[,] data = new int[3, 3];
// 3次元なら
int[,,] data = new int[3, 3, 3];
```

### ジャグ配列
```
データ型[][] 変数名 = new データ型[要素数][]
変数名[インデックス] = new データ型[要素数]
// 例
int[][] data = new int[3][];
data[0] = new int[2];
data[1] = new int[4];
data[2] = new int[3];
```

## 章の理解度チェック
1. コードで間違っているポイントを3つ挙げよ。
 - import ではなく、using 。
 - 文字列型はダブルクォート(") で囲む。
 - Console.WriteLine(data); セミコロンが必要。

2. 空欄を埋めよ
①  完全修飾名
②  単純名
③  using
④  解決

3. 空欄を埋めよ
①  const
②  0.9
③  $
④  sum

4. 正しいものには○、間違っているものは×
小数点型は符号なし型と符号あり型とに分類できる ... ×
文字列リテラルはダブルクォート、またはシングルクォートでくくる ... ×
short 型の型サフィックスは「~s」である ... ×
暗黙的な変換は常に安全なので、桁落ちなどの情報の欠落は発生しない ... ×
メソッド/フィールドなどにアクセスするには、必ずnew演算子でクラスをインスタンス化しなけばならない ... ×

5. 次のコードを作成せよ
2章理解度.sln
