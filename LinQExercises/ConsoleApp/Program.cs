using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static IEnumerable<int> numbers = new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 10 };
        
        static void Main(string[] args)
        {
            // CollectionOperators();
            // FinalOperators();
            // ConversionOperators();
        }

        static void CollectionOperators()
        {
            var qry = Enumerable.Empty<int>();
            // TODO: Number > 5
            // TODO: Range 3~8
            // TODO: Unique numbers
            // TODO: แสดงเฉพาะ 3 ตัวแรก
            // TODO: ไม่เอา 3 ตัวแรก
            // TODO: เรียงลำดับ น้อย-มาก
            // TODO: เรียงลำดับ มาก-น้อย
            // TODO: กลับด้านลำดับ
            // TODO: รวม 2 collection ไว้ด้วยกัน
            // TODO: เอาเฉพาะตัวที่ซ้ำกันใน 2 collection
            // TODO: ตัดตัวที่ซ้ำกับ collection อื่น
            foreach (var item in qry)
            {
                System.Console.WriteLine(item);
            }
        }

        static void FinalOperators()
        {
            // TODO: นับว่ามีเลข 1 กี่ตัว
            // TODO: หาผลรวม
            // TODO: หาค่าต่ำสุด
            // TODO: หาค่ามากสุด
            // TODO: หาค่าเฉลี่ย
            // TODO: ขอข้อมูลตัวแรก
            // TODO: มีเลขที่มากกว่า 8 ใน collection ไหม
            // TODO: ข้อมูลใน collection ทุกตัวมากกว่า 0 ใช่ไหม
            // TODO: ข้อมูลใน collection ทุกตัวมากกว่า 5 ใช่ไหม
            // TODO: มีเลข 3 ไหม
            // TODO: มีเลข 99 ไหม
        }

        static void ConversionOperators()
        {
            // TODO: แปลง collection เป็น array
            int[] arrayCollection = new int[0];

            // TODO: แปลง collection เป็น list
            List<int> listCollection = new List<int>();
        }
    }
}
