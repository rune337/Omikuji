//おみくじ
using System.Numerics;

string[] omikuji = new string[5];

omikuji[0] = "0大吉";
omikuji[1] = "1中吉";
omikuji[2] = "2吉";
omikuji[3] = "3凶";
omikuji[4] = "4大凶";

//各おみくじを何回引いたかを格納する配列
int[] count = new int[5];

//Randomクラスを実体化して変数randが機能を参照できる
Random rand = new Random();

//for (int i = 0; i < 100; i++)
//{
//    int result = rand.Next(0, 5); //0以上5未満のランダムを取得して変数resultに代入

//    //result番目の値を配列からひっぱてきてコンソールに出す
//    Console.WriteLine(i + "回目" + omikuji[result]);
//    count[result]++; //resultで引いた結果の番号をカウント
//}

//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine("今" + i + "回目の繰り返しです");
//}

//大吉を引くまで繰り返すループ
bool end = false;
while (end == false)
{
    int result = rand.Next(0, 5);//0以上5未満のランダムを取得して変数resultに代入
    //result番目の値を配列から引っ張てきてコンソールに出す
    Console.WriteLine(omikuji[result]);
    count[result]++;//resultで引いた結果の番号をカウント

    //もし大吉を引いていたら変数endはtrue
    if (result == 0)
    {
        end = true;
    }
}

for (int i = 0; i < count.Length; i++)
{
    Console.WriteLine(omikuji[i] + "は" + count[i] + "回引きました");
}

//論理型
//bool end = false; //終わりフラグ
////いつ終わりが来るかわからないループ
//while (end == false)//終わりのフラグが来ない間は繰り返す
//{
//    int dice = rand.Next(1, 7); //1～6のランダム
//    if (dice == 1)
//    {
//        end = true;

//    }
//    Console.WriteLine("つづく");
//}