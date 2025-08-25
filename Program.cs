//おみくじ
string[] omikuji = new string[5];

omikuji[0] = "0大吉";
omikuji[1] = "1中吉";
omikuji[2] = "2吉";
omikuji[3] = "3凶";
omikuji[4] = "4大凶";

//各おみくじを何回引いたかを格納する配列
int[] count = new int[5];


for (int i = 0; i < 100; i++)
{
    //Randomクラスを実体化して変数randが機能を参照できる
    Random rand = new Random();
    int result = rand.Next(0, 5); //0以上5未満のランダムを取得して変数resultに代入

    //result番目の値を配列からひっぱてきてコンソールに出す
    Console.WriteLine(i + "回目" + omikuji[result]);
    count[result]++; //resultで引いた結果の番号をカウント
}

//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine("今" + i + "回目の繰り返しです");
//}

for (int i =0; i<count.Length; i++)
{
    Console.WriteLine(omikuji[i] + "は" + count[i] + "回引きました");
}