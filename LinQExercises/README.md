# LinQ exercises, สนามฝึก LinQ

[Original source](http://linq101.nilzorblog.com/linq101-lambda.php)

## Collection
|คำสั่ง|ใช้สำหรับ|ผลลัพท์|
|--|--|--|
|Where|กรองข้อมูล|Collection|
|Select|เลือก|Collection|
|Distinct|ตัดตัวซ้ำ|Collection|
|Take|เอา|Collection|
|Skip|ข้าม|Collection|
|SkipWhile|ข้ามจนกว่า|Collection|
|TakeWhile|เอาจนกว่า|Collection|
|OrderBy|เรียงลำดับ น้อย-มาก|Collection|
|OrderByDescending|เรียงลำดับ มาก-น้อย|Collection|
|Reverse|เรียงลำดับกลับด้าน|Collection|
|Union|รวม 2 collection เข้าด้วยกัน|Collection|
|Intersect|เอาเฉพาะตัวที่ซ้ำกันใน 2 collection|Collection|
|Except|ตัดตัวที่ซ้ำกับ collection อื่น|Collection|

## Final
|คำสั่ง|ใช้สำหรับ|ผลลัพท์|
|--|--|--|
|Count|นับว่ามีกี่ตัว|number|
|Sum|หาผลรวม|number|
|Min|หาค่าน้อยสุด|number|
|Max|หาค่ามากสุด|number|
|Average|หาค่าเฉลี่ย|number|
|First|เอาข้อมูลตัวแรก|T|
|FirstOrDefault|เอาข้อมูลตัวแรก ถ้าไม่เจอขอ default|T หรือ default|
|Any|ดูว่ามีซักตัวไหมที่ตรงเงื่อนไข|bool|
|All|ทุกตัวตรงเงื่อนไขหรือไม่|bool|
|Contains|ใน collection มีตัวนี้หรือเปล่า|bool|

## Conversion operators
|คำสั่ง|ใช้สำหรับ|ผลลัพท์|
|--|--|--|
|ToArray|แปลงเป็น array|Array<T>|
|ToList|แปลงเป็น list|List<T>|