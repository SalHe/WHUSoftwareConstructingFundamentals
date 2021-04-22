# 软件构造基础（C#）

## 课程安排

- 授课12次
- 项目实践5次

## 成绩

- 考勤20%
- 平时作业20%  12次
- 项目实践30%  4~6人/组（最好考虑WinForm）
- 课程报告30%  3k字

## 教材

《C# 程序设计教程 第二版》唐大仕 清华大学出版社



## 作业

- 第1次：

  1. Hello，XXX

- 第2次：

  1. 编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。

  2. 编写程序，接收用户输入的两个数据为上下限，然后10个一行输出上下限之间的所有素数。

- 第3次：

  1. 每个形状类都能计算面积、判断形状是否合法。请尝试合理使用接口/抽象类、属性来实现。

  2. 随机创建10个形状对象，计算这些对象的面积之和。

- 第4次：

  1. 使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台/Winform界面上显示提示信息。

- 第5次：

  1. “哥德巴赫猜想”指出，每个大于6的偶数，都可以表示为两个素数的和。试用程序将6~100内的所有偶数都表示为两个素数的和。

  2. 随机生成100个0~1000间的整数，使用Linq语句对这些整数从大到小排序，并求和与平均数。

- 第6次：

  1. 编写一个Winform程序，从界面上选择两个文本文件，将两个文件的内容读取出来，合并写入到一个新创建的文件中，新文件存放于可执行程序目录中的Data子目录里.

- 第7次：

  1. 将课本中例5-31的Cayley树绘图代码进行修改。添加一组控件用以调节树的绘制参数。参数包括递归深度（n）、主干长度（leng）、右分支长度比（per1）、左分支长度比（per2）、右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）。

  2.  ~~编写程序实现一个计算器，包括十个数字（0~9）按钮和四个运算符（加、减、乘、除）按钮，以及等号和清空两个辅助按钮，还有一个显示输入输出的文本框，显示表达式及结果如：18+5=23。~~

- 第8次：

  1. 编写程序实现一个计算器，包括十个数字（0~9）按钮和四个运算符（加、减、乘、除）按钮，以及等号和清空两个辅助按钮，还有一个显示输入输出的文本框，显示表达式及结果如：18+5=23。

- 第9次:

  1. 对输入框中输入的身份证是否合法进行验证：
    1. 使用正则表达式对格式进行验证（共18位，前17位为数字，最后1位是数字或字母，其中年月日部分也可以进行验证；
    2. 对身份证的最后一位的有效性进行验证。