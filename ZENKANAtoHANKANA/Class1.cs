using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ZENKANAtoHANKANA
{
    class Class1
    {
        public static void Main(string[] args) 
        {
            foreach (string path in args)
            {
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        List<char> vs = new List<char>(lines[i].Length);

                        foreach (char pi in lines[i])
                        {
                            string str = new string(new char[] { pi });

                            for (int j = 0; j < from.Length; j++)
                            {
                                if (pi == from[j])
                                {
                                    str = to[j];
                                    break;
                                }
                            }

                            vs.AddRange(str);
                        }

                        lines[i] = new string(vs.ToArray()) ?? string.Empty;
                    }
                    File.WriteAllLines(path.Insert(path.LastIndexOf("."), "_C"), lines);
                }
            }
        }

        private static readonly char[] from = new char[]
        {
            'ア',
            'イ',
            'ウ',
            'エ',
            'オ',
            'カ',
            'キ',
            'ク',
            'ケ',
            'コ',
            'サ',
            'シ',
            'ス',
            'セ',
            'ソ',
            'タ',
            'チ',
            'ツ',
            'テ',
            'ト',
            'ナ',
            'ニ',
            'ヌ',
            'ネ',
            'ノ',
            'ハ',
            'ヒ',
            'フ',
            'ヘ',
            'ホ',
            'マ',
            'ミ',
            'ム',
            'メ',
            'モ',
            'ヤ',
            'ユ',
            'ヨ',
            'ラ',
            'リ',
            'ル',
            'レ',
            'ロ',
            'ワ',
            'ヲ',
            'ン',

            'ガ',
            'ギ',
            'グ',
            'ゲ',
            'ゴ',
            'ザ',
            'ジ',
            'ズ',
            'ゼ',
            'ゾ',
            'ダ',
            'ヂ',
            'ヅ',
            'デ',
            'ド',
            'バ',
            'ビ',
            'ブ',
            'ベ',
            'ボ',
            'パ',
            'ピ',
            'プ',
            'ペ',
            'ポ',

            'ァ',
            'ィ',
            'ゥ',
            'ェ',
            'ォ',
            'ヵ',
            'ヶ',
            'ャ',
            'ュ',
            'ョ',
        };

        private static readonly string[] to = new string[]
        {
            "ｱ",
            "ｲ",
            "ｳ",
            "ｴ",
            "ｵ",
            "ｶ",
            "ｷ",
            "ｸ",
            "ｹ",
            "ｺ",
            "ｻ",
            "ｼ",
            "ｽ",
            "ｾ",
            "ｿ",
            "ﾀ",
            "ﾁ",
            "ﾂ",
            "ﾃ",
            "ﾄ",
            "ﾅ",
            "ﾆ",
            "ﾇ",
            "ﾈ",
            "ﾉ",
            "ﾊ",
            "ﾋ",
            "ﾌ",
            "ﾍ",
            "ﾎ",
            "ﾏ",
            "ﾐ",
            "ﾑ",
            "ﾒ",
            "ﾓ",
            "ﾔ",
            "ﾕ",
            "ﾖ",
            "ﾗ",
            "ﾘ",
            "ﾙ",
            "ﾚ",
            "ﾛ",
            "ﾜ",
            "ｦ",
            "ﾝ",

            "ｶﾞ",
            "ｷﾞ",
            "ｸﾞ",
            "ｹﾞ",
            "ｺﾞ",
            "ｻﾞ",
            "ｼﾞ",
            "ｽﾞ",
            "ｾﾞ",
            "ｿﾞ",
            "ﾀﾞ",
            "ﾁﾞ",
            "ﾂﾞ",
            "ﾃﾞ",
            "ﾄﾞ",
            "ﾊﾞ",
            "ﾋﾞ",
            "ﾌﾞ",
            "ﾍﾞ",
            "ﾎﾞ",
            "ﾊﾟ",
            "ﾋﾟ",
            "ﾌﾟ",
            "ﾍﾟ",
            "ﾎﾟ",

            "ｧ",
            "ｨ",
            "ｩ",
            "ｪ",
            "ｫ",
            "ヵ",
            "ヶ",
            "ｬ",
            "ｭ",
            "ｮ",
        };
    }
}
