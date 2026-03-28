// 这是一个ADOFAI（A Dance of Fire and Ice）游戏的初始mod框架喵
// 你可以在这个框架的基础上添加你想要的功能，比如修改游戏数据、添加新的关卡、改变游戏界面等等喵

// 很重要的一点，如果你是第一次生成mod的dll文件，一般方法是这样的喵
// 方法是点击Visual Studio上方的生成菜单，选择生成解决方案喵（快捷键是Ctrl+Shift+B）
// 生成成功后会在项目文件夹下的bin/Debug或者bin/Release文件夹里生成一个dll文件，这个dll文件就是你的mod了喵
// 最后你把这个mod的dll文件和Json文件打包成zip文件，拖进模组加载器里面即可使用喵

// 如果你是第一次写mod，这玩意语言是C# 你需要学习C#语言来开发mod喵

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// visual studio最开始写入的东西，我不知道有没有用，反正不影响喵

using UnityModManagerNet;
// 引用UnityModManagerNet命名空间，提供了mod开发所需的类和方法，比如ModEntry、ModLogger等等喵
// 我建议后面添加dll的时候放在lib文件夹里面，然后在项目属性里添加引用，这样比较清晰，也方便管理你的mod依赖的dll文件喵喵
// 第一次接触visual studio的话，引用方法是在解决方案资源管理器里右键点击引用，选择添加引用，然后在浏览选项卡里找到你的dll文件，添加进去就好了喵

namespace ADOFAImod //命名空间，建议起一个你的mod的名字，避免和其他mod吵架喵
                    // 不过visual studio会自动生成一个命名空间，名字和你的项目名字一样喵
{
    public class main // 主类，visual studio会检测你是否重命名了main.cs，然后自动重命名成对应的名字
                      // 对应的，如果修改了这个类名称，要在Info.json在修改参数"EntryMethod"
                      // 一般来说固定格式是"模组ID.你修改的类名称.Load"

    {
        public static UnityModManager.ModEntry.ModLogger Logger;
        // 定义一个名为Logger的日志容器，类型是UnityModManager.ModEntry.ModLogger喵
        // 在OnToggle方法中可以直接使用Logger.Log("我是梁志超他奶奶");喵

        static bool Load(UnityModManager.ModEntry modEntry)
        //mod加载时调用，返回true表示加载成功，返回false表示加载失败，失败会自动关闭mod喵
        {
            Logger = modEntry.Logger; //赋值日志记录器喵
            modEntry.OnToggle = OnToggle; //开关状态改变调用喵
            return true;//提示mod加载成功喵
        }

        static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        // 定义一个名为OnToggle的方法，参数modEntry是当前mod的入口对象喵
        // 在游戏的mod管理页面mod开关是控制这个参数value是开关状态，true表示开启，false表示关闭喵
        {
            if (value) //启动mod喵
            {
                Logger.Log("窝来啦喵"); 
            }
            else //关闭mod喵
            {
                Logger.Log("被关闭了呜"); 
            }
            return true; //返回true表示成功，返回false表示失败，失败则会自动关闭mod喵
        }
    }
}


// 很多废话，对吧喵
// 你可以删除这些注释，或者保留它们以供参考，反正不影响代码的运行呢喵