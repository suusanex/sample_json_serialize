# sample_json_serialize
Code experimenting with several cases of serialization deserialization using JSON.NET.

バージョンアップでクラスに変更が入った場合、古いバージョンの文字列を新しいバージョンのクラスへデシリアライズできるかどうかの実験。.NET 4.5.2 + Newtonsoft.Json 12.0.2 を使用。

変数の追加：デシリアライズ成功。追加された変数は、new時のデフォルト値となった

変数の削除：デシリアライズ成功。削除された変数は、無視された。

注意点：Listにデフォルト値がある場合、デシリアライズ時に上書きではなく追加される（直観と反する動き）

