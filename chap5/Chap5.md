# 標準ライブラリ

|クラス/構造体|概要|
|:---|:---|
|String|文字列の加工/整形、部分文字列の検索/取得|
|Regex|正規表現を利用した文字列の検索や置換、分割|
|DateTime|日付/時間を操作|
|TimeSpan|時間間隔を操作|
|StreamWriter/StreamReader|ファイルの読み書き|
|DirectoryInfo/FileInfo|フォルダー/ファイルの情報を管理/操作|
|Directory/File|フォルダー/ファイルの情報を管理/操作(静的メソッド)|
|Math|絶対値や平方根、四捨五入、三角関数などの演算機能|
|BigInteger|logs/ulong型の範囲を超える整数を扱う|
|Array|配列を操作|


## 文字列操作
### 文字列の長さの取得
```
var str1 = "WINGSプロジェクト";
Console.WriteLine( str1.Length ); //結果:11

var str2 = "叱る";
Console.WriteLine( str2.Length ); //結果:3
```

「叱」という文字がサロゲートペアであるために、3文字になってしまっている。

Unicodeは1文字を2バイトで表現する。しかし2バイトで表現できる文字数では不足する状況がではじめた。

そこで一部の文字を4バイトで表現することで、扱える文字を拡張することにした（サロゲートペア）。

また、Lengthプロパティではサロゲートペアを識別することはできないため、4バイト=2文字とみなす。

その対応として、StringInfoクラスのLengthTextElementsプロパティを利用する。

```
using System.Globalization;

var str = "叱る";
StringInfo strInfo = new StringInfo( str );
Console.WriteLine( strInfo.LengthTextElements ) ; //結果:2
```

## 文字列を大文字小文字、全角半角、ひらがなカタカナを区別せずに比較する

### 大文字小文字の区別
```
var str1 = "wings";
var str2 = "WINGS";

Console.WriteLine(str1.Equals(str2, StringComparison.OrdinalIgnoreCase)); //結果: true
Console.WriteLine(string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase)); //結果: 0
```

### 全角半角、ひらがなカタカナの区別
```
using System.Globalization;

var full = "ＷＩＮＧＳ";
var half = "WINGS";

var ci = CultureInfo.CurrentCulture.CompareInfo;
Console.WriteLine(ci.Compare(full, half)); // 結果:1 (異なる)
Console.WriteLine(ci.Compare(full, half, CompareOptions.IgnoreWidth)); //結果:0 (等しい)

var hiragana = "ぷろじぇくと";
var katakana = "プロジェクト";
Console.WriteLine(ci,.Compare(hiragana, katakana)); //結果:1 (異なる)
Console.WriteLine(ci.Compare(hiragana, katakana, CompareOptions.IgnoreKanaType)); //結果:0 (等しい)
```

## 文字列がnull/から文字であるかの判定

```
var str1 = "";
Console.WriteLine(String.IsNullOrEmpty(str1)); //結果: true
```

```
var str2 = "   ";
Console.WriteLine(String.IsNullOrWhiteSpace(str2)); //結果: true, 空白文字(半角スペース、タブ、改行、全角スペースなど)も検出可能
```

## 文字列の検索



