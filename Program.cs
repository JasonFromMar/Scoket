using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Program
{
    class Program
    {
        // 设置连接端口        
        const int portNo = 500;
        static void Main(string[] args)
        {
            // 初始化服务器IP            
            System.Net.IPAddress localAdd = System.Net.IPAddress.Parse("127.0.0.1");            
            // 创建TCP侦听器            
            TcpListener listener = new TcpListener(localAdd, portNo);            
            listener.Start();            // 显示服务器启动信息            
            Console.WriteLine("Server is starting...\n");            
            // 循环接受客户端的连接请求            
            while (true)            
            {
                ChatClient user = new ChatClient(listener.AcceptTcpClient());
                // 显示连接客户端的IP与端口                
                Console.WriteLine(user._clientIP + " is joined...\n");            
            }   
        }
    }
}
