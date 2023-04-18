using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook._31_Algorithm
{
    class Record
    {
        // 상품명
        public string Name { get; set; }

        //수량
        public int Quantity { get; set; }
    }
    class GroupAlgorithm
    {
        static void Main(string[] args)
        {   

            //[0] 테스트용 데이터 채우기용 로컬 하뭇
            List<Record> GetAll()
            {
                return new List<Record>
                {
                    new Record { Name = "RADIO", Quantity = 3 },
                    new Record { Name = "TV", Quantity = 1 },
                    new Record { Name = "RADIO", Quantity = 2 },
                    new Record { Name = "DVD", Quantity = 4 }
                };
            }
            //[0][2] 컬렉션 데이터 출력용 로컬 함수
            void PrintData(string message, List<Record> data)
            {
                Console.WriteLine(message);
                foreach (var item in data)
                {
                    Console.WriteLine($"{item.Name, 5} = { item.Quantity }");
                }
            }

            //[1] Input

            List<Record> records = GetAll(); // 입력 데이터
            List<Record> groups = new List<Record>(); // 출력 데이터
            int N = records.Count(); // 의사코드

            //[2] Process: Group 알고리즘(SORT -> SUM -> GROUP)
            //[A] 정렬: SORT
            for (int i = 0; i < N-1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (String.Compare(records[i].Name, records[j].Name) > 0)
                    {
                        var t = records[i];
                        records[i] = records[j]; 
                        records[j] = t; //SWAP
                    }
                }
            }
            //[B] 그룹 소계: GROUP
            int subtotal = 0; // 소계를 담을 그릇
            for (int i = 0; i < N; i++)
            {
                subtotal += records[i].Quantity; // SUM
                // 다음 레코드가 없거나, 현재 레코드와 다음 레코드가 다른 Name 이면
                if ((i + 1) == N || (records[i].Name != records[i+1].Name))
                {
                    groups.Add(new Record { Name = records[i].Name, Quantity = subtotal });
                    subtotal = 0;
                }
            }


            //[3] Output
            PrintData("[1] 정렬된 데이터", records);
            PrintData("[2] 이름으로 그룹화된 데이터", groups);
            PrintData("[3] LINQ", records.GroupBy(r => r.Name).Select(g => new Record { Name = g.Key, Quantity = g.Sum(n => n.Quantity)}).ToList());
        }
    }
}
