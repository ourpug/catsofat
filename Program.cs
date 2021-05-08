using System;

namespace 對照擺放
{
    class Magic //響導class
    {
        public string name;
        public string favoriteSpell; // public叫做訪問修飾符,public就是再class外部訪問他,意味著可以更改變量,用點對方法進行編碼,就是 magic.XXXXX 之後選屬性
        private int spellSlots; // private代表我們只能訪問,class本身內部的變量或方法,所以無法在Magic這class之外看到spellSlot.
        public float experience; //如果前面沒有public 或 private都會默認私有
        //static keyboard 當我們添加static這意味著變量屬於類型本身,而不是針對特別實立.就是分享此class所有實例
        public static int Count;//公共靜態整數,保持大寫是靜態整數的標準
        public Magic(string _name,string _favoriteSpell)//之後新增的 constructor 構造函數 建構子
        {
            name =_name;
            favoriteSpell = _favoriteSpell; 
            spellSlots = 2;
            experience = 100f;
            Count++;
        }
        public void CastSpell() // CastSpell 是方法
        {
            if(spellSlots > 0)
            {
            Console.WriteLine(name + " 施放 " + favoriteSpell); //施放
            spellSlots--;
            experience += 0.3f; // 放2次0.6
            }else
            {
             Console.WriteLine(name + " 魔法插槽不足.智商不足");
            }
        }
        public void Meditate()
        {
            Console.WriteLine(name +" 降低別人智商以在魔法插槽中");
            spellSlots = 2;
        }


        
    }
     
           

    class Program // 其實這裡就有class了
    {
        static void Main(string[] args)
        {
             Magic 魔法1 = new Magic("非洲紅小胖","變聰明");//之後有改            //對應上面的class
            //魔法1.name = " 非洲紅小胖 ";                     // 以下是初始數值
            //魔法1.favoriteSpell = " 變聰明 ";
            //魔法1.spellSlots = 2;
            //魔法1.experience = 3f;                        // 給你一開始的數值

            魔法1.CastSpell();
            魔法1.CastSpell(); 
            魔法1.CastSpell(); 
            魔法1.Meditate();
            魔法1.CastSpell();
            魔法1.CastSpell();
            //創建類建構函數,實立化類   
            Magic 魔法2 = new Magic("豹氣a紅小胖","變胖");
            魔法2.CastSpell();
            Console.WriteLine(Magic.Count);//只要是黃字的都是方法


            Console.WriteLine("經驗: " +魔法1.experience);             
 //.................................................................................................................................

            MeetAlien();
            Console.WriteLine("----------");
             MeetAlien(); // 對應樓下的staitc void 的MeetAlien 所以上下有2個外星人顯示
             Multiply(3,8);  //multiply是對應3參考值
             Multiply(7,13); // 後面的數字是參數
             Multiply(11,5);
             int 結果1 = Evento(3, 8); // 為甚麼底下要加static , 因為無法似別底下的
             Console.WriteLine("結果是"+結果1);
             if(結果1 % 2 ==0)//餘數等於0
             {
               Console.WriteLine(結果1 + "是一個偶數");
             }else
             {
                Console.WriteLine(結果1 + "是一個非偶數");
             }
             
            Console.ReadKey();
            
        }
// references 的意思是參考值
        static void MeetAlien(){          //方法就是函數,脫離了void Main //再來static void是在無效之前轉到我們方法頂部,並添加static關鍵字
            Random 計算 = new Random(); // 新隨機賦予隨機計算

            string 名子 = "X-" + 計算.Next(10, 9999); // X 破折號 +隨機計算 賦予 名子
            int 年齡 = 計算.Next(10,500);

            Console.WriteLine("早,我是"+ 名子);
            Console.WriteLine("我有"+ 年齡 + "年壽命");
            Console.WriteLine("哈,其實我是外星人");           
        }  // { } < 這是花括號
// references 的意思是參考值        
        static void Multiply(int 號碼01, int 號碼02) //int 號碼02是參數
        {
          int 結果 = 號碼01*號碼02;
          Console.WriteLine("結果是" + 結果);
        }
 //.................................................................
        static int Evento(int 號碼03,int 號碼04)
        {
            int 結果1 = 號碼03 * 號碼04 ;
            return 結果1;
        }
    }
}
