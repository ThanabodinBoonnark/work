---?color=linear-gradient(to top left, #bdc3c7, #2c3e50)
# @color[orange](Markdown)

---?color=linear-gradient(180deg, #003366 33.33%, white 33.33%)
## Markdown

@color[black](Mark down คือ
ภาษาคอมพิวเตอร์ ที่มนุษย์สามารถอ่านเข้าใจได้ง่าย
และด้วยความง่ายนี้มันก็สามารถแปลงกลับมาเป็นภาษาอื่นๆ
ได้ง่ายด้วยกันเช่น HTML, XHTML และด้วยความง่ายเช่นนี้จึงมีเจ้าอื่นนำไป Customize ให้เป็นของตัวเอง
เช่น github ก็อาจจะเพิ่มพวก feature
เข้าไปเช่น task list, mention และอื่น ๆ)

---?color=linear-gradient(to top left, #bdc3c7, #2c3e50)

# เริ่มเขียนMarkdown

---?color=linear-gradient(100deg, #003366 50%, #E8E8E8 50%)

@snap[west span-40 text-center]

## @color[white](หัวเรื่อง)
@color[white](@fa[quote-left quote-graphql](การเขียนหัวเรื่องในขนาดต่างๆ))
![GRAPHQL](https://sv1.picz.in.th/images/2019/12/06/igbSyS.png)
@snapend

@snap[north-east span-60 text-08]
# @color[black](หัวเรื่อง 1)
## @color[black](หัวเรื่อง 2)
### @color[black](หัวเรื่อง 3)
#### @color[black](หัวเรื่อง 4)
##### @color[black](หัวเรื่อง 5)
###### @color[black](หัวเรื่อง 6)
@snapend

---

@snap[west span-50]

#### รูปแบบอักษรประกอบไปด้วย

```
        หัวเรื่องแรก  หัวเรื่องที่สอง 
        --------  -----------  
         ตัวเอียง     _ตัวเอียง_     
         ตัวหน้า     **ตัวหน้า**    
         ขีดฆ่า      ~~ขีดฆ่า~~
```
@snapend      

@snap[east span-50]

แสดงผล
_สวัสดี_
**สวัสดี**
~~สวัสดี~~
@snapend

---

@snap[north span-50]
ลิสต์แบบเรียงลำดับ (Ordered List)
![](https://sv1.picz.in.th/images/2019/12/05/iZFSgv.jpg)
@snapend

@snap[east span-50]

1. สวัสดี
2. ฉัน
3. ชื่อ
4. อะไร
   @snapend

---

@snap[north span-50]
ลิสต์แบบไม่เรียงลำดับ (Unordered List)
@snapend
![](https://sv1.picz.in.th/images/2019/12/05/iZFYCE.jpg)
@snap[east span-50]

- สวัสดี
- สวัสดี
- สวัสดี

* สวัสดี
* สวัสดี
* สวัสดี
  @snapend

---

@snap[north span-50]
หรือ list ซ้อน list (Nested List)
@snapend
![](https://sv1.picz.in.th/images/2019/12/05/iZyXqq.jpg)
@snap[east span-50]

1. สวัสดี
   - ฉันชื่อ - อะไร 1. ไม่รู้ 2. สินะ
     @snapend

---

## การใส่ link ใน Markdown

โค้ต

    [](https://sv1.picz.in.th/images/2019/12/05/iZyv78.jpg)

เเสดงผล

## [Links](http://www.google.com)

## ใส่รูปภาพใน Markdown

โค้ต

    ![Google ](https://sv1.picz.in.th/images/2019/12/05/iZyaHz.jpg)

เเสดงผล

## ![Google ](https://www.google.co.th/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png)

@snap[north span-120]

## การใส่ตาราง (Tables)

@snapend

@snap[east span-50]
| หัวเรื่องแรก | หัวเรื่องที่สอง | หัวเรื่องสาม |
| :-------- | :--------: | ---------: |
| ซ็าย | กึ่งกลาง | ขวา |
| ซ็าย | กึ่งกลาง | ขวา |
@snapend

---
