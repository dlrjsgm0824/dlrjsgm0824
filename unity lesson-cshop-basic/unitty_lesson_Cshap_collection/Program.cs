using System;
using System.Collections.Generic;
// collection 
//동적배열이라고도 함.
// Array 와 다르게 크기르 정해놓고 collection 이란 단어뜻대로 수집하듯이 더하거나 뺄수있으며 그에따라 데이터가 유동적으로 변함
namespace unitty_lesson_Cshap_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //=====================================================
            //List
            //=====================================================
            List<int> _list = new List<int>();
            _list.Add(3);
            _list.Add(2);
            _list.Add(1);
            _list.Add(0);
            _list.Add(3);

            //remove
            //0번째 인덱스부터 탐색하고 , 첫번째로 인자와 같은 요소를 발견하면 삭제
            //삭제 성공시 true 반환 , 인자와 같은 요소를 찾지 못하면 false 반환

            _list.Remove(3);

            int length =  _list.Count;
            for (int i = 0; i < length; i++)
            {
                int tmpNumber = _list[i];
                Console.WriteLine(tmpNumber);

            }

            // foreach : collection 이 가지고있는 타입의 아이템만큼 반복문을 실행하면서 각 아이템을 반환.
            foreach (int num in _list)
            {

            }
            {
                Console.WriteLine(num);
                // foreach 가 처음돌때 num에 _list[0] 반환 
                // 두번쨰 돌때는 num에 _list[1] 반환
            }




            //==============================================================
            //Dictionary
            //===============================================================
            Dictionary<string, string> _dic = new Dictionary<string, string>();
            _dic.Add("검사", "양손대검을 사용하여 물리공격을하는 클래스");
            _dic.Add("마법사", " 지팡이를 사용하여 마법공격을 하는클래스");
            _dic.Add("수호자", "방패를 사용하여 물리공격 및 바어위주의 클래스");

               _dic.Remove("검사");
              bool isSwordMaster = _dic.ContainsKey("검사");
            if (isSwordMaster)
            {
                string tmpValue = _dic["검사"];
                Console.WriteLine($"검사 : {tmpValue}");
            }

            else
            {
                Console.WriteLine("검사를 찾을 수 없습니다");

            }

            foreach  ( string sub in _dic.Keys)
            {
                string tmpvalue = _dic[sub];
                Console.WriteLine($"{sub} : {tmpvalue}");
            }

            foreach  (string sub in _dic.Values)
            {
                Console.WriteLine(sub);
            }

            foreach (KeyValuePair<string,string> sub in _dic)
            {
                string tmpKey = sub.Key;
                string tmpValue = sub.Value;
                Console.WriteLine($"{tmpKey}:{tmpValue}"); 
            }
            //dictionary 도 forach 구문가능하다
            //dictionary 도 collection이고
            //dictionart

            //Stack
            //Queue

        }
    }
}
