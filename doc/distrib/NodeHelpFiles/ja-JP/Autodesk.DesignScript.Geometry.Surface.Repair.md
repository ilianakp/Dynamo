## 詳細
Repair は、無効なジオメトリを持つサーフェスまたはポリサーフェスの修復を試みます。最適化を実行する可能性もあります。この修復のノードは新しいサーフェス オブジェクトを返します。
このノードは、読み込まれたジオメトリまたは変換されたジオメトリの操作でエラーが発生した場合に役に立ちます。

たとえば、**Revit** などのホスト コンテキストや **.SAT** ファイルからデータを読み込み、ブール演算やトリムが予期せずに失敗した場合に、修復操作によってエラーの原因となっている *無効なジオメトリ* がクリーンアップされる場合があります。

一般的に、この機能は外部ソースから読み込んだジオメトリに対してのみ使用し、Dynamo で作成したジオメトリに使用する必要はありません。Dynamo で作成したジオメトリでエラーが発生した場合は、Dynamo チームの GitHub にバグをレポートしてください。
___


