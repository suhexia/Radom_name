# Radom_name
此项目制作是出于语文老师的要求（并且我本来也想做），所以做出来了这么个东西。  
挺有意思的，这可能是我第一次做出一个完整的软件，开源出来纪念纪念  
This programa made because of my chinese teacher(and i want to make this programa too), so here.  
I think it is too interesting, it may be my first to do a application.  

![这是一张主图片](https://github.com/suhexia/Radom_name/blob/main/Image_file/main_app.png)  

>+ 完全自定义，除了Form以外的文字均可自由修改  
>+ UI风格借鉴了某个JavaScript开发的点名器  
>+ 简单通俗易懂的文档  
  
1.名字目录：根目录/data/name.txt  
篇目目录：根目录/data/poem.txt  
本使用帮助文件位于根目录/readme.txt  
一行代表一条数据，如文件【不存在或文件为空】可能会导致程序闪退！  
（没有写异常处理，下个版本吧）  

2.此程序需要环境包.NET 3.1.0或以上的版本  
如缺少此环境请访问：https://dotnet.microsoft.com/download/dotnet/3.1/  下载此环境包。  
（一般来说，只需要在SDK的下载表格中找到os为Windows，installers为x64的安装包下载）  

3.左边的矩形为抽取的名字，右边为抽取的篇目（按钮同理），  
请勿修改窗口大小！否则可能会出现排版错误等问题！  

"""""""""""""""""""""""""""""""""""""  
相关UI的描述文字修改说明：  
（文件在根目录/ui_setting.txt）  
第一行————label1初始显示文字（左名字显示框）  
第二行————label2初始显示文字（右诗词显示框）  
第三行————button1显示文字（左触发按钮初始文字）  
第四行————button2显示文字（右触发按钮初始文字）  
第五行————button1过渡显示（在滚动时左按钮显示的文字）  
第六行————button2过渡显示（在滚动时右按钮显示的文字）  
第七行————button1末显示（滚动停止时左按钮显示）  
第八行————button2末显示（滚动停止时右按钮显示）  
"""""""""""""""""""""""""""""""""""""  
